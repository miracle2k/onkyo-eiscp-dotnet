using System;
using System.IO;
using System.Net;
using System.Net.Sockets;
using System.Diagnostics;
using System.Linq;
using System.Collections.Generic;
using System.Collections.Concurrent;
using System.Text;
using System.Text.RegularExpressions;
using System.Threading;
using System.Collections;

namespace Eiscp.Core
{
    /// <summary>
    /// Deals with formatting and parsing data wrapped in an ISCP
    /// containers.
    /// </summary>
    /// The docs say:
    /// 
    ///    "ISCP (Integra Serial Control Protocol) consists of three
    ///    command characters and parameter character(s) of variable
    ///    length."
    ///
    /// It seems this was the original protocol used for communicating
    /// via a serial cable.
    public class IscpMessage
    {      
        public IscpMessage(byte[] data)
        {
            // ! = start character
            // 1 = destination unit type, 1 means receiver
            // End character may be CR, LF or CR+LF, according to doc
            Bytes = new byte[data.Length + 3];
            Bytes[0] = (byte)'!';
            Bytes[1] = (byte)'1';
            data.CopyTo(Bytes, 2);
            Bytes[Bytes.Length - 1] = (byte)'\r';
        }

        public IscpMessage(string data):
            this(Encoding.ASCII.GetBytes(data))
        {
        }

        public byte[] Bytes
        {
            get;
            private set;
        }

        public static byte[] Parse(byte[] data)
        {
            const char EOF = '\x1a';

            Debug.Assert(data[0] == (byte)'!' && data[1] == (byte)'1');

            byte last = data[data.Length - 1];
            Debug.Assert(last == (byte)EOF || last == (byte)'\n' || last == (byte)'\r');

            // drop first 2 and last 3 characters
            byte[] unpacked = new byte[data.Length - 5];
            Array.Copy(data, 2, unpacked, 0, unpacked.Length);
            return unpacked;
        }
    }

    public class Header
    {
        public byte[] magic;
        public int headerSize;
        public int messageSize;
        public byte version;
        public byte[] reserved;
    }

    /// <summary>
    /// For communicating over Ethernet, traditional ISCP messages are
    /// wrapped inside an eISCP package.
    /// </summary>
    public class EiscpPacket
    {
        public EiscpPacket(byte[] iscpMessage)
        {
            // Header format is:
            // - magic: 4 bytes of ASCII characters 'ISCP';
            // - header size: unsigned integer 16;
            // - message size: unsigned integer;
            // - version: byte 1;
            // - reserved: 3 bytes 0.
            // Integers are 32 bit big-endian. There's no padding.
            byte[] magic = Encoding.ASCII.GetBytes("ISCP");
            byte[] headerSize = BitConverter.GetBytes(IPAddress.HostToNetworkOrder(16));
            byte[] messageSize = BitConverter.GetBytes(IPAddress.HostToNetworkOrder(iscpMessage.Length));
            byte[] versionAndReserved = { 1, 0, 0, 0 };

            Bytes = new byte[16 + iscpMessage.Length];

            magic.CopyTo(Bytes, 0);
            headerSize.CopyTo(Bytes, 4);
            messageSize.CopyTo(Bytes, 8);
            versionAndReserved.CopyTo(Bytes, 12);

            iscpMessage.CopyTo(Bytes, 16);
        }

        public EiscpPacket(string message):
            this(Encoding.ASCII.GetBytes(message))
        {
        }

        public EiscpPacket(IscpMessage iscpMessage) :
            this(iscpMessage.Bytes)
        {
        }

        public byte[] Bytes
        {
            get;
            private set;
        }

        /// <summary>
        /// Parse the eISCP package given by <paramref name="bytes"/>
        /// </summary>       
        public static byte[] Parse(byte[] bytes)
        {
            byte[] headerBytes = new byte[16];
            Array.Copy(bytes, headerBytes, 16);

            Header h = ParseHeader(headerBytes);

            byte[] data = new byte[h.messageSize];
            Array.Copy(bytes, h.headerSize, data, 0, h.messageSize);

            Debug.Assert(data.Length == h.messageSize);

            return data;
        }

        /// <summary>
        /// Parse the header of an eISCP package.
        /// </summary>
        /// This is useful when reading data in a streaming fashion,
        /// because you can subsequently know the number of bytes to
        /// expect in the packet.        
        public static Header ParseHeader(byte[] bytes)
        {
            // A header is always 16 bytes in length
            Debug.Assert(bytes.Length == 16);

            // Parse the header. Its format is described in the constructor's body.
            var header = new Header()
            {
                magic = new byte[4],
                headerSize = IPAddress.NetworkToHostOrder(BitConverter.ToInt32(bytes, 4)),
                messageSize = IPAddress.NetworkToHostOrder(BitConverter.ToInt32(bytes, 8)),
                version = bytes[12],
                reserved = new byte[3]
            };
            Array.Copy(bytes, 0, header.magic, 0, 4);
            Array.Copy(bytes, 13, header.reserved, 0, 3);

            // Strangely, the header contains a header size field.
            Debug.Assert(Encoding.ASCII.GetString(header.magic) == "ISCP");
            Debug.Assert(header.headerSize == 16);

            return header;
        }
    }

    public static class Utils
    {
        /// <summary>
        /// Convert an ascii command like (PVR00) to the binary data we
        /// need to send to the receiver.
        /// </summary>        
        public static EiscpPacket CommandToPacket(string command)
        {
            return new EiscpPacket(new IscpMessage(command));
        }

        /// <summary>
        /// Ensures that various ways to refer to a command can be used.
        /// </summary>
        public static string NormalizeCommand(string command)
        {
            return command.ToLower().Replace('_', ' ').Replace('-', ' ');
        }


        /// <summary>
        /// Navigate a dictionary tree.
        /// </summary>
        /// This function saves the tedium of repeated casts when someone wants to
        /// retrieve an object located in a deeply nested dictionary.
        /// <param name="dict">Root of a dictionary tree.</param>
        /// <param name="keys">Path to the object in the tree.</param>
        /// <returns>Node pointed by the path. It may be itself a dictionary.</returns>
        public static object Nav(object dict, params object[] keys)
        {
            foreach (object key in keys)
            {
                dict = (dict as IDictionary)[key];
            }

            return dict;
        }

        /// <summary>
        /// Transform the given given high-level command to a
        /// low-level ISCP message.
        /// </summary>
        ///
        /// <exception cref="ArgumentException">
        /// Raises <c>ArgumentException</c> if <paramref name="command"/> is not valid.
        /// </exception>
        /// 
        /// This exposes a system of human-readable, "pretty"
        /// commands, which is organized into three parts: the zone, the
        /// command, and arguments. For example:    
        /// 
        /// <example>
        /// <code>
        ///     Command("power", "on");
        ///     Command("power", "on", zone: "main");
        ///     Command("volume", "66", zone: "zone2");
        /// </code>
        /// </example>
        /// 
        /// As you can see, if no zone is given, the main zone is assumed.
        ///
        /// Instead of passing three different parameters, you may put the
        /// whole thing in a single string, which is helpful when taking
        /// input from users:
        ///
        /// <example>
        /// <code>
        ///    Command("power on:);
        ///    Command("zone2 volume 66");
        /// </code>
        /// </example>
        /// To further simplify things, for example when taking user input
        /// from a command line, where whitespace needs escaping, the
        /// following is also supported:
        ///
        /// <example>
        /// <code>
        ///     Command("power=on");
        ///     Command("zone2.volume=66");
        /// </code>
        /// </example>
        public static string CommandToIscp(string command, string arguments = null, string zone = null)
        {
            List<string> argumentsList = null;
            string defaultZone = "main";
            char[] commandSep = new char[] { '.', ' ' };
            Func<string, string> norm = s => s.Trim().ToLower();

            // If parts are not explicitly given, parse the command
            if (arguments == null && zone == null)
            {
                // Separating command and args with colon allows multiple args
                if (command.Contains(":") || command.Contains("="))
                {
                    char[] separators = new char[] { ':', '=' };
                    string[] baseAndArguments = command.Split(separators, 2); // in Python counterpart it's "max 1 split", here - it's "max 2 parts"
                    string commandBase = baseAndArguments[0];
                    string commandArguments = baseAndArguments[1];
                     
                    var parts = new List<string>(
                        from c in commandBase.Split(commandSep)
                        select norm(c)
                    );

                    if (parts.Count == 2)
                    {
                        zone = parts[0];
                        command = parts[1];
                    }
                    else
                    {
                        zone = defaultZone;
                        command = parts[0];
                    }

                    // Split arguments by comma or space
                    argumentsList = new List<string>(
                        from a in commandArguments.Split(',', ' ')
                        select norm(a)
                    );
                }
                else
                {
                    // Split command part by space or dot
                    var parts = new List<string>(
                        from c in command.Split(commandSep)
                        select norm(c)
                    );

                    if (parts.Count >= 3)
                    {
                        zone = parts[0];
                        command = parts[1];
                        argumentsList = parts.GetRange(2, parts.Count - 2);
                    }
                    else if (parts.Count == 2)
                    {
                        zone = defaultZone;
                        command = parts[0];
                        argumentsList = parts.GetRange(1, 1);
                    }
                    else
                    {
                        throw new ArgumentException("Need at least command and argument");
                    }
                }
            }

            //zone = zone ?? "";

            // Find the command in our database, resolve to internal eISCP command
            object group = EiscpCommands.ZoneMappings[zone] ?? zone;
            if (!EiscpCommands.Commands.Contains(group))
            {
                throw new ArgumentException(String.Format("\"{0}\" is not a valid zone", group));
            }

            object prefix = Nav(EiscpCommands.CommandMappings, group, command) ?? command;
            if (Nav(EiscpCommands.Commands, group, prefix) == null) 
            {
                throw new ArgumentException(String.Format("\"{0}\" is not a valid command in zone \"{1}\"", command, zone));
            }

            // TODO: For now, only support one; though some rare commands would
            // need multiple.
            string argument = argumentsList[0];

            object value = Nav(EiscpCommands.ValueMappings, group, prefix, argument) ?? argument;            
            if (Nav(EiscpCommands.Commands, group, prefix, "values", value) == null)
            {
                throw new ArgumentException(String.Format("\"{0}\" is not a valid argument " +
                    "for command \"{1}\" in zone \"{2}\"", argument, command, zone));
            }

            return (string)prefix + (string)value;
        }

        public static Tuple<string, string> IscpToCommand(string iscpMessage)
        {
            foreach (DictionaryEntry item in EiscpCommands.Commands)
            {
                string zone = (string)item.Key;
                IDictionary zoneCmds = (IDictionary)item.Value;

                // For now, ISCP commands are always three characters, which
                // makes this easy.
                string command = iscpMessage.Substring(0, 3);
                string args = iscpMessage.Substring(3);
                if (zoneCmds.Contains(command))
                {                   
                    if (Nav(zoneCmds, command, "values", args) != null)
                    {
                        return new Tuple<string, string>(
                            (string)Nav(zoneCmds, command, "name"),
                            (string)Nav(zoneCmds, command, "values", args, "name")
                        );
                    }
                }
            }

            throw new ArgumentException("Cannot convert ISCP message to command: " + iscpMessage);
        }

        /// <summary>
        /// Helper that calls <paramref name="getterFunc"/> until a matching message
        /// is found, or the timeout occurs. 
        /// </summary>
        /// Matching means the same commands
        /// group, i.e. for sent message MVLUP we would accept MVL13
        /// in response.
        public static byte[] FilterForMessage(Func<double, byte[]> getterFunc, string msg)
        {
            long start = DateTime.Now.Ticks; // 10 000 ticks makes a millisecond

            while (true)
            {
                byte[] candidate = getterFunc(0.05);
                if (candidate != null)
                {
                    string str = Encoding.ASCII.GetString(candidate);
                    // It seems ISCP commands are always three characters.
                    if (str.Substring(0, 3) == msg.Substring(0, 3))
                    {
                        return candidate;
                    }
                }

                // The protocol docs claim that a response  should arrive
                // within *50ms or the communication as failed*. In my tests,
                // however, the interval needed to be at least 200ms before
                // I managed to see any response, aand only after 300ms
                // reproducably, so use a generous timeout.
                if (DateTime.Now.Ticks - start > 7000000) // 700ms
                {
                    throw new ArgumentException("Not received a response");
                }
            }
        }
    }

    public interface IReceiver: IDisposable
    {
        void Send(string iscpMessage);
        byte[] Get(double timeout);
        byte[] Raw(string message);
        string Model { get; }
        IPAddress Host { get; }
        int Port { get; }
    }

    /// <summary>
    /// Implements the eISCP interface to Onkyo receivers.
    /// </summary>
    ///
    /// This uses a blocking interface. The remote end will regularily
    /// send unsolicited status updates. You need to manually call
    /// <see cref="Get"/> to query those.
    /// 
    /// You may want to look at the <see cref="Receiver"/> class instead, which
    /// uses a background thread.
	public class EiscpClient : IReceiver {
        private Socket commandSocket;

        public int Port
        {
            get;
            protected set;
        }

        public IPAddress Host
        {
            get;
            protected set;
        }

        public string Model
        {
            get;
            protected set;
        }

        /// <summary>
        /// Try to find ISCP devices on network.
        /// </summary>
        /// Waits for <paramref name="timeout"/> seconds, then returns all devices found,
        /// in form of a list of <see cref="IReceiver"/>s.        
        public static List<IReceiver> Discover(double timeout, Func<IPAddress, int, string, IReceiver> constructor)
        {
            int onkyoPort = 60128;
            byte[] onkyoMagic = (new EiscpPacket("!xECNQSTN")).Bytes;

            var foundReceivers = new List<IReceiver>();


            // Broadcast magic
            Socket socket = new Socket(AddressFamily.InterNetwork, SocketType.Dgram, ProtocolType.Udp);
            using(socket)
            {
                socket.Blocking = false; // So we can use Poll
                socket.EnableBroadcast = true;
                socket.Bind(new IPEndPoint(IPAddress.Any, 0));
                socket.SendTo(onkyoMagic, new IPEndPoint(IPAddress.Broadcast, onkyoPort));
               
                EndPoint addr = new IPEndPoint(IPAddress.Broadcast, onkyoPort);
                byte[] data = new byte[1024];
                int read = 0;
                while (true)
                {
                    int microsecondTimeout = (int)(timeout * 1000000);
                    if (!socket.Poll(microsecondTimeout, SelectMode.SelectRead))
                    {
                        break;
                    }
                    read = socket.ReceiveFrom(data, ref addr);

                    string response = Encoding.ASCII.GetString(EiscpPacket.Parse(data));
                    // Return string looks something like this:
                    // !1ECNTX-NR609/60128/DX
                    GroupCollection info = Regex.Match(response.Trim(),
                        @"!" +
                        @"(?<device_category>\d)" +
                        @"ECN" +
                        @"(?<model_name>[^/]*)/" +
                        @"(?<iscp_port>\d{5})/" +
                        @"(?<area_code>\w{2})/" +
                        @"(?<identifier>.*)"
                    ).Groups;

                    int port = Int32.Parse(info["iscp_port"].Value);
                    string model = info["model_name"].Value;

                    // Give the user a ready-made receiver instance. It will only
                    // connect on demand, when actually used.
                    IReceiver receiver = constructor((addr as IPEndPoint).Address, port, model);
                    foundReceivers.Add(receiver);
                }
            }

            return foundReceivers;
        }

		public static List<IReceiver> Discover(double timeout = 5) {
			return Discover(timeout, EiscpClient.Create);
        }

		public static EiscpClient Create(IPAddress address, int port, string model) {
			return new EiscpClient(address, port, model);
        }

		public EiscpClient(IPAddress host, int port = 60128, string model = null) {
            Host = host;
            Port = port;
            Model = model;

            commandSocket = null;
        }

		~EiscpClient() {
            Dispose();
        }

        public override string ToString()
        {            
            return String.Format("<{0}({1}) {2}:{3}>", GetType(), Model ?? "unknown", Host, Port);
        }

        protected void EnsureSocketConnected()
        {
            if (commandSocket == null)
            {
                commandSocket = new Socket(AddressFamily.InterNetwork, SocketType.Stream, ProtocolType.Tcp);
                commandSocket.Connect(Host, Port);
                commandSocket.Blocking = false;
            }
        }

        public virtual void Disconnect()
        {
            try
            {
                commandSocket.Close();
            }
            catch (Exception)
            { }

            commandSocket = null;
        }

        public void Dispose()
        {
            Disconnect();
        }
       
        /// <summary>
        /// Send a low-level ISCP message, like "MVL50".
        /// </summary>
        ///
        /// This does not return anything, nor does it wait for a response
        /// from the receiver. You can query responses via <see cref="Get"/>,
        /// or use <see cref="Raw"/> to send a message and waiting for one.
        public virtual void Send(string iscpMessage)
        {
            EnsureSocketConnected();
            commandSocket.Send(Utils.CommandToPacket(iscpMessage).Bytes);
        }

        /// Return the next message sent by the receiver, or, after
        /// <paramref name="timeout"/> has passed, return <c>null</c>.
        public virtual byte[] Get(double timeout = 0.1)
        {
            EnsureSocketConnected();

            int microsecondTimeout = (int)(timeout * 1000000);
            if (commandSocket.Poll(microsecondTimeout, SelectMode.SelectRead))
            {
                byte[] headerBytes = new byte[16];
                commandSocket.Receive(headerBytes);

                Header header = EiscpPacket.ParseHeader(headerBytes);

                byte[] message = new byte[header.messageSize];
                commandSocket.Receive(message);

                return IscpMessage.Parse(message);
            }

            return null;
        }


        /// <summary>
        /// Send a low-level ISCP message, like "MVL50", and wait
        /// for a response.
        /// </summary>
        ///
        /// <para>
        /// While the protocol is designed to acknowledge each message with
        /// a response, there is no fool-proof way to differentiate those
        /// from unsolicited status updates, though we'll do our best to
        /// try. Generally, this won't be an issue, though in theory the
        /// response this function returns to you sending <c>"SLI05"</c> may be
        /// a <c>"SLI06"</c> update from another controller.
        /// </para>
        /// 
        /// <para>
        /// It'd be preferable to design your app in a way where you are
        /// processing all incoming messages the same way, regardless of
        /// their origin.
        /// </para>
        public virtual byte[] Raw(string iscpMessage)
        {
            while (Get(0.0) != null)
            {
                // Clear all incoming messages. If not yet queried,
                // they are lost. This is so that we can find the real
                // response to our sent command later.
                ;
            }

            Send(iscpMessage);
            return Utils.FilterForMessage(this.Get, iscpMessage);
        }

        /// <summary>
        /// Send a high-level command to the receiver, return the
        /// receiver's response formatted has a command.
        /// </summary>
        ///
        /// This is basically a helper that combines <see cref="Raw"/>,
        /// <see cref="Utils.CommandToIscp"/> and <see cref="Utils.IscpToCommand"/>.
        public Tuple<string, string> Command(string command, string arguments = null, string zone = null)
        {
            var iscpMessage = Utils.CommandToIscp(command, arguments, zone);
            var response = Raw(iscpMessage);
            if (response != null)
            {
                string str = Encoding.ASCII.GetString(response);
                return Utils.IscpToCommand(str);
            }
            else
            {
                return null;
            }
        }

        /// <summary>
        /// Turn the receiver power on.
        /// </summary>
        public void PowerOn()
        {
            Command("power", "on");
        }

        /// <summary>
        /// Turn the receiver power off.
        /// </summary>
        public void PowerOff()
        {
            Command("power", "off");
        }
    }

    /// <summary>
	/// Changes the behaviour of <see cref="EiscpClient"/> to use a background
    /// thread for network operations.
    /// </summary>
    /// 
    /// This allows receiving messages
    /// from the receiver via a callback:
    /// <example>
    /// <code>
    /// <![CDATA[
    ///    public void OnMessage(IscpMessage message)
    ///    {
    ///        Console.Write(message);
    ///    }
    ///
    ///    var receiver = new Receiver(host, port);
    ///    receiver.Message += new Action<IscpMessage>(OnMessage);
    /// ]]>
    /// </code>
    /// </example>
    /// The argument <c>message</c> is
	public class Receiver : EiscpClient {
        private bool stop;
        private BlockingCollection<Tuple<string, EventWaitHandle, List<object>>> queue; 
        private Thread thread;

        public event Action<byte[]> Message;

        public Receiver(IPAddress host, int port = 60128, string model = "") :
            base(host, port, model)
        {
        }

        ~Receiver()
        {
            Dispose();
        }

        public static Receiver Create(IPAddress address, int port, string model)
        {
            return new Receiver(address, port, model);
        }

		public static new List<IReceiver> Discover(double timeout = 5) {
			return EiscpClient.Discover(timeout, Receiver.Create);
        }

        private void EnsureThreadRunning()
        {
            if (thread == null)
            {
                stop = false;
                queue = new BlockingCollection<Tuple<string, EventWaitHandle, List<object>>>(
                    new ConcurrentQueue<Tuple<string, EventWaitHandle, List<object>>>()
                );
                thread = new Thread(this.ThreadLoop);
                thread.Start();
            }
        }

        public override void Disconnect()
        {
            stop = true;
            thread.Join();
            thread = null;
        }

        /// <summary>
		/// Like <see cref="EiscpClient.Send"/>, but sends asynchronously via the
        /// background thread.
        /// </summary>        
        public override void Send(string iscpMessage)
        {
            EnsureThreadRunning();
            queue.Add(new Tuple<string, EventWaitHandle, List<object>>(iscpMessage, null, null));
        }

        /// <summary>
        /// Not supported by this class. Use the <see cref="Message"/>
        /// event to handle incoming messages.
        /// </summary>       
        public override byte[] Get(double timeout)
        {
            throw new NotImplementedException();
        }

        /// <summary>
		/// Like <see cref="EiscpClient.Raw"/>.
        /// </summary>        
        public override byte[] Raw(string iscpMessage)
        {
            EnsureThreadRunning();
            var ev = new EventWaitHandle(false, EventResetMode.ManualReset);
            var result = new List<object>();

            queue.Add(new Tuple<string, EventWaitHandle, List<object>>(iscpMessage, ev, result));
            ev.WaitOne();

            if (result[0] is Exception)
            {
                throw (Exception)result[0];
            }

            return (byte[])result[0];
        }

        private void ThreadLoop()
        {
            EnsureSocketConnected();
            try
            {
                while (!stop)
                {
                    // Clear all incoming messages first
                    while (true)
                    {
                        byte[] msg = base.Get();
                        if (msg == null)
                            break;
                        Message(msg);
                    }

                    // Send next message                    
                    Tuple<string, EventWaitHandle, List<object>> item;
                    if (!queue.TryTake(out item, 10)) // 10 ms timeout
                    {
                        continue;
                    }

                    if (item != null)
                    {
                        string message = item.Item1;
                        EventWaitHandle ev = item.Item2;
                        List<object> result = item.Item3;

                        base.Send(message);

                        // Wait for a response, if the caller so desires
                        if (ev != null)
                        {
                            byte[] response = null;
                            try
                            {
                                // XXX We are losing messages here, since
                                // those are not triggering the callback!
                                // Eiscp.Raw() really has the same problem,
                                // messages being dropped without a chance
                                // to Get() them. Maybe use a queue after all.
                                response = Utils.FilterForMessage(base.Get, message);
                            }
                            catch (ArgumentException e)
                            {
                                // No response within timeout
                                result.Add(e);
                            }

                            if (response != null)
                            {
                                result.Add(response);
                            }

                            // Mark as processed
                            ev.Set();                            
                        }
                    }
                }
            }
            finally
            {
                base.Disconnect();
            }
        }
    }
}