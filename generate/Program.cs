using System;
using System.Collections;
using System.Collections.Specialized;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.CodeDom;
using YamlDotNet.Core;
using YamlDotNet.Core.Events;
using System.CodeDom.Compiler;


class Program
{
    private static object GetData(EventReader r)
    {
        if(r.Accept<Scalar>())
        {
            return r.Expect<Scalar>().Value;
        }
        else if(r.Accept<SequenceStart>()) {                
            var seq = new ArrayList();

            r.Expect<SequenceStart>();

            while(!r.Accept<SequenceEnd>())
            {
                seq.Add(GetData(r));
            }

            r.Expect<SequenceEnd>();

            // Arrays are IStructuralEquatable, ArrayLists are not.
            return seq.ToArray();
        }
        else if(r.Accept<MappingStart>())
        {
            // Since we use sequences as keys...
            var map = new OrderedDictionary(StructuralComparisons.StructuralEqualityComparer);

            r.Expect<MappingStart>();

            while(!r.Accept<MappingEnd>())
            {
                object key = GetData(r);
                object value = GetData(r);
                map.Add(key, value);
            }

            r.Expect<MappingEnd>();

            return map;
        }
        else {
            throw new YamlException();
        }
    }

    private static IEnumerable FindCommandAliases(OrderedDictionary commandList)
    {
        foreach (DictionaryEntry commandEntry in commandList)
        {
            object name = (commandEntry.Value as IDictionary)["name"];
            if (name is IEnumerable && !(name is string))
            {
                foreach (object item in (IEnumerable)name)
                {
                    yield return new DictionaryEntry(item, commandEntry.Key);
                }
            }
            else
            {
                yield return new DictionaryEntry(name, commandEntry.Key);
            }
        }
    }

    private static IEnumerable FindValueAliases(OrderedDictionary values)
    {
        foreach (DictionaryEntry valueEntry in values)
        {
            if ((valueEntry.Value as IDictionary).Contains("name"))
            {
                object name = (valueEntry.Value as IDictionary)["name"];
                if (name is IEnumerable && !(name is string))
                {
                    foreach (object item in (IEnumerable)name)
                    {
                        yield return new DictionaryEntry(item, valueEntry.Key);
                    }
                }
                else
                {
                    yield return new DictionaryEntry(name, valueEntry.Key);
                }
            }
        }
    }

    // Taken straight from:
    // http://stackoverflow.com/questions/323640/can-i-convert-a-c-sharp-string-value-to-an-escaped-string-literal
    private static string ToLiteral(string input)
    {
        using (var writer = new StringWriter())
        {
            using (var provider = CodeDomProvider.CreateProvider("CSharp"))
            {
                provider.GenerateCodeFromExpression(new CodePrimitiveExpression(input), writer, null);
                return writer.ToString();
            }
        }
    }

    private static string PrintData(bool indent, int nesting, object data)
    {
        var s = new StringBuilder();

        if (indent)
        {
            for (int i = 0; i < nesting; i++)
            {
                s.Append("\t");
            }
        }

        if (data == null)
        {
            s.Append("null");
        }
        else if (data is string)
        {
            s.Append(ToLiteral((string)data));
        }
        else if (data is Array)
        {
            s.Append("new object[]\n");
            for (int i = 0; i < nesting; i++)
            {
                s.Append("\t");
            }
            s.Append("{\n");

            bool comma = false;
            foreach (object o in (object[])data)
            {
                if (comma)
                {
                    s.Append(",\n");
                }
                s.Append(PrintData(true, nesting + 1, o));
                comma = true;
            }

            s.Append("\n");
            for (int i = 0; i < nesting; i++)
            {
                s.Append("\t");
            }
            s.Append("}");
        }
        else if (data is OrderedDictionary)
        {
            s.Append("new OrderedDictionary(StructuralComparisons.StructuralEqualityComparer)\n");
            for (int i = 0; i < nesting; i++)
            {
                s.Append("\t");
            }
            s.Append("{\n");

            bool comma = false;
            foreach (DictionaryEntry entry in (OrderedDictionary)data)
            {
                if (comma)
                {
                    s.Append(",\n");
                }

                for (int i = 0; i < nesting + 1; i++)
                {
                    s.Append("\t");
                }
                s.Append("{\n ");

                s.Append(PrintData(true, nesting + 2, entry.Key));

                s.Append(",\n");

                s.Append(PrintData(true, nesting + 2, entry.Value));

                s.Append("\n");
                for (int i = 0; i < nesting + 1; i++)
                {
                    s.Append("\t");
                }
                s.Append("}");

                comma = true;
            }

            s.Append("\n");
            for (int i = 0; i < nesting; i++)
            {
                s.Append("\t");
            }
            s.Append("}");
        }
        else
        {
            throw new ArgumentException();
        }

        return s.ToString();
    }

    private static OrderedDictionary Odict(IEnumerable e)
    {
        OrderedDictionary odict = new OrderedDictionary(StructuralComparisons.StructuralEqualityComparer);

        foreach (DictionaryEntry entry in e)
        {
            odict[entry.Key] = entry.Value;
        }

        return odict;
    }

    static void Main(string[] args)
    {             
        OrderedDictionary zones;

        using (var sr = new StreamReader(args[0]))
        {   
            var parser = new Parser(sr);
            var er = new EventReader(parser);

            er.Expect<StreamStart>();
            er.Expect<DocumentStart>();
            zones = (OrderedDictionary)GetData(er);
            er.Expect<DocumentEnd>();
            er.Expect<StreamEnd>();
        }

        // Remove modelsets key, not a real zone
        zones.Remove("modelsets");

        // Generate the C# structures
        //
        // We want a command dictionary that does not include the model data, which we
        // are not using.
        var commands = new OrderedDictionary(StructuralComparisons.StructuralEqualityComparer);
        foreach (DictionaryEntry zoneEntry in zones)
        {
            object zone = zoneEntry.Key;
            OrderedDictionary commandsInZone = (OrderedDictionary)zoneEntry.Value;
            OrderedDictionary newCommands = new OrderedDictionary(StructuralComparisons.StructuralEqualityComparer);

            foreach (DictionaryEntry commandEntry in commandsInZone)
            {
                object command = commandEntry.Key;
                OrderedDictionary commandData = (OrderedDictionary)commandEntry.Value;

                OrderedDictionary values = (OrderedDictionary)commandData["values"];

                OrderedDictionary newValues = new OrderedDictionary(StructuralComparisons.StructuralEqualityComparer);
                foreach (DictionaryEntry valueEntry in values)
                {
                    object value = valueEntry.Key;
                    OrderedDictionary valueData = (OrderedDictionary)valueEntry.Value;

                    OrderedDictionary newValueData = new OrderedDictionary(StructuralComparisons.StructuralEqualityComparer)
                    {
                        { "name", valueData["name"] },
                        { "description", valueData["description"] }
                    };

                    newValues.Add(value, newValueData);
                }

                OrderedDictionary newCommandData = new OrderedDictionary(StructuralComparisons.StructuralEqualityComparer)
                {
                    { "name", commandData["name"] },
                    { "description", commandData["description"] },
                    { "values", newValues }
                };
                newCommands.Add(command, newCommandData);
            }
            commands.Add(zone, newCommands);
        }

        var zoneMappings = new OrderedDictionary()
        {
            // use main as default zone
            { "", "main" }
        };

        var commandMappings = Odict(
            from DictionaryEntry zoneEntry in zones
            select new DictionaryEntry
            {
                Key = zoneEntry.Key,
                Value = Odict(FindCommandAliases((OrderedDictionary)zoneEntry.Value))
            }
        );

        var valueMappings = Odict(
            from DictionaryEntry zoneEntry in zones
            let zone = zoneEntry.Key
            let commands_ = zoneEntry.Value
            select new DictionaryEntry
            {
                Key = zone,
                Value = Odict(
                    from DictionaryEntry commandEntry in (IEnumerable)commands_
                    let command = commandEntry.Key
                    let commandData = commandEntry.Value
                    select new DictionaryEntry
                    {
                        Key = command,
                        Value = Odict( FindValueAliases((OrderedDictionary)(commandData as IDictionary)["values"]) )
                    }
                )
            }
        );

        Console.OutputEncoding = Encoding.UTF8;

        Console.Write(
            "// Generated\n" +
            "// by {0}\n" +
            "// from {1}\n" +
            "// at {2}\n\n",
            Path.GetFileName(Environment.GetCommandLineArgs()[0]),
            Path.GetFileName(args[0]),
            DateTime.Now                
        );

        Console.Write(
            "using System.Collections;\n" +
            "using System.Collections.Specialized;\n\n" +
            "namespace Eiscp.Core\n" +
            "{{\n" +
            "\tpublic static class EiscpCommands\n" +
            "\t{{\n" +
            "\t\tpublic static readonly OrderedDictionary Commands = {0};\n" +
            "\n" +
            "\t\tpublic static readonly OrderedDictionary ZoneMappings = {1};\n" +
            "\n" +
            "\t\tpublic static readonly OrderedDictionary CommandMappings = {2};\n" +
            "\n" +
            "\t\tpublic static readonly OrderedDictionary ValueMappings = {3};\n" +
            "\t}}\n" +
            "}}\n",
            PrintData(false, 2, commands),
            PrintData(false, 2, zoneMappings),
            PrintData(false, 2, commandMappings),
            PrintData(false, 2, valueMappings)
        );
    }
}

