using System;
using System.Collections;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.IO;
using System.Net;
using Eiscp.Core;
using Mono.Options;
using System.Net.Sockets;

namespace Eiscp
{
    class Program
    {        
        private const string usage =
@"Control Onkyo A/V receivers.

Usage:
  onkyo [--host <host>] [--port <port>] [--all] [--name <name>] <command>...
  onkyo --discover
  onkyo --help-commands [<zone> <command>]
  onkyo -h | --help

Selecting the receiver:

  --host, -t <host>     Connect to this host
  --port, -p <port>     Connect to this port [default: 60128]
  --all, -a             Discover receivers, send to all found
  --name, -n <name>     Discover receivers, send to those matching name.

If none of these options is given, the program searches for receivers,
and uses the first one found.

  --discover            List all discoverable receivers
  --help-commands       List available commands.

Examples:
  onkyo power:on source:pc volume:75
    Turn receiver on, select ""PC"" source, set volume to 75.
  onkyo zone2.power:standby
    To execute a command for zone that isn't the main one.";

        static int Main(string[] args)
        {
            if (args.Length == 0)
            {
                Console.WriteLine(usage);
                return 1;
            }

            string baseName = Path.GetFileName(Environment.GetCommandLineArgs()[0]);

            bool all = false;
            bool discover = false;
            bool commandHelp = false;
            bool help = false;
            string name = null;
            string host = null;
            string port = null;

            var optionSet = new OptionSet()
            {
                { "t|host=", "Connect to this host", v => { host = v; } },
                { "p|port=", "Connect to this port [default: 60128]", v => { port = v; } },
                { "a|all", "Discover receivers, send to all found", v => { all = v != null; } },
                { "n|name=", "Discover receivers, send to those matching name", v => { name = v; } },
                { "discover", "List all discoverable receivers", v => { discover = v != null; } },
                { "help-commands", "List available commands", v => { commandHelp = v != null; } },
                { "h|help", "Print help", v => { help = v != null; } }
            };

            List<string> command = new List<string>();

            try
            {
                command = optionSet.Parse(args);
            }
            catch (OptionException e)
            {
                Console.WriteLine(e.Message);
                Console.WriteLine(usage);

                return 1;
            }

            if (help)
            {
                Console.WriteLine(usage);
                return 0;
            }

            // List commands
            if (discover)
            {
                foreach (var receiver in EiscpClient.Discover(timeout: 1))
                {
                    Console.WriteLine("{0} {1}:{2}", receiver.Model, receiver.Host, receiver.Port);
                }

                return 0;
            }

            // List available commands
            if (commandHelp)
            {
                // List the zones
                if (command.Count == 0) // no zone, no command
                {
                    Console.WriteLine("Available zones:");
                    foreach (string zone in EiscpCommands.Commands.Keys)
                    {
                        Console.WriteLine(zone);
                    }

                    return 1;
                }

                // List the commands
                string selectedZone = command[0];

                if (EiscpCommands.Commands[selectedZone] == null)
                {
                    Console.WriteLine("No such zone: " + selectedZone);
                    return 1;
                }

                if (command.Count == 1) // zone specified, command not
                {
                    Console.WriteLine("Available commands for this zone:");

                    IDictionary commandsInZone = (IDictionary)EiscpCommands.Commands[selectedZone];
                    foreach (IDictionary commandInfo in commandsInZone.Values)
                    {
                        Console.WriteLine("  {0} - {1}", commandInfo["name"], commandInfo["description"]);
                    }

                    Console.WriteLine("Use {0} --help-commands {1} <command> to see a list " +
                        "of possible values.", baseName, selectedZone);

                    return 0;
                }

                // List values
                var selectedCommand = Utils.Nav<string>(EiscpCommands.CommandMappings, selectedZone, command[1]) ?? command[1];
                if (Utils.Nav<object>(EiscpCommands.Commands, selectedZone, selectedCommand) == null)
                {
                    Console.WriteLine("No such command in the selected zone: " + selectedCommand);
                    return 1;
                }

                Console.WriteLine("Possible values for this command:");
                IDictionary valuesForCommandDict = Utils.Nav<IDictionary>(EiscpCommands.Commands, selectedZone, selectedCommand, "values");
                foreach (IDictionary valueInfo in valuesForCommandDict.Values)
                {
                    Console.WriteLine("  {0} - {1}", valueInfo["name"], valueInfo["description"]);
                }

                return 0;
            }

            // Determine the receivers the command should run on

            var receivers = new List<IReceiver>();

            if (host != null)
            {
                IPAddress[] addresses = new IPAddress[0];
                try
                {
                    addresses = Dns.GetHostAddresses(host);
                }
                catch (SocketException e)
                {
                    Console.WriteLine(e.Message);
                    return 2;
                }
               
                if (addresses.Length == 0)
                {
                    Console.WriteLine("Could not resolve the host");
                    return 1;
                }

                UInt16 portNum;
                port = port ?? "60128";
                if (!UInt16.TryParse(port, out portNum))
                {
                    Console.WriteLine(usage);
                    return 1;
                }

                receivers.Add(new EiscpClient(addresses[0], portNum));
            }
            else
            {
                receivers = EiscpClient.Discover(timeout: 1);

                if (!all)
                {
                    if (name != null)
                    {
                        receivers = receivers.Where(r => r.Model.Contains(name)).ToList();
                    }
                    else
                    {
                        receivers = receivers.Take(1).ToList();
                    }
                }

                if (receivers.Count == 0)
                {
                    Console.WriteLine("No receivers found");
                    return 1;
                }
            }

            // Execute commands
            foreach (var receiver in receivers)
            {
                using (receiver)
                {
                    foreach(var cmd in command)
                    {
                        string iscpCommand = null;
                        bool rawResponse = false;

                        if(cmd.All(ch => char.IsUpper(ch) || char.IsDigit(ch)))
                        {
                            iscpCommand = cmd;
                            rawResponse = true;
                        }
                        else 
                        {
                            try
                            {
                                iscpCommand = Utils.CommandToIscp(cmd);
                            }
                            catch(ArgumentException e)
                            {
                                Console.WriteLine("Error: " + e.Message);
                                return 2;
                            }
                            rawResponse = false;
                        }

                        Console.WriteLine("{0}: {1}", receiver, iscpCommand);
                        string response;
                        try
                        {
                            response = Encoding.ASCII.GetString(receiver.Raw(iscpCommand));
                        }
                        catch (ArgumentException e)
                        {
                            Console.WriteLine(e.Message);
                            return 0;
                        }
                        if (rawResponse)
                        {
                            Console.WriteLine(response);
                        }
                        else
                        {
                            try
                            {
                                Console.WriteLine(Utils.IscpToCommand(response));
                            }
                            catch (ArgumentException e)
                            {
                                Console.WriteLine(e.Message);
                                return 0;
                            }
                        }
                    }
                }
            }

            return 0;
        }
    }
}