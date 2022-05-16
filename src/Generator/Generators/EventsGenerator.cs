using System.Text;
using Generator.Model;

// ReSharper disable once CheckNamespace
namespace Generator;

internal static class EventsGenerator
{
    public static void Generate(string outputPath, List<Class> classes)
    {
        foreach (var c in classes)
        {
            if (c.Events.Length <= 0)
            {
                continue;
            }

            var outputFile = Path.Combine(outputPath, $"{c.Name}.Events.g.cs");

            using var file = File.CreateText(outputFile);
            void WriteLine(string x) => file.WriteLine(x);

            var fileHeaderBuilder = new StringBuilder(Templates.EventsHeaderTemplate);
            WriteLine(fileHeaderBuilder.ToString());

            for (var i = 0; i < c.Events.Length; i++)
            {
                var e = c.Events[i];

                WriteLine($"    public static {e.EventType} {c.Name}{e.Name} => {c.Type}.{e.Name}Event;");

                if (i < c.Events.Length - 1)
                {
                    WriteLine("");
                }
            }

            var classFooterBuilder = new StringBuilder(Templates.EventsFooterTemplate);
            WriteLine(classFooterBuilder.ToString());
        }
    }
}
