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
            var events = c.Events.Where(x => x.RoutingStrategies is not null).ToArray();
            if (events.Length <= 0)
            {
                continue;
            }

            var outputFile = Path.Combine(outputPath, $"{c.Name}.Events.g.cs");

            using var file = File.CreateText(outputFile);
            void WriteLine(string x) => file.WriteLine(x);

            var fileHeaderBuilder = new StringBuilder(Templates.EventsHeaderTemplate);
            WriteLine(fileHeaderBuilder.ToString());

            var addedEvents = new HashSet<string>();

            for (var i = 0; i < events.Length; i++)
            {
                var e = events[i];

                if (addedEvents.Contains(e.Name))
                {
                    Console.WriteLine($"Event {c.Name}.{e.Name} was already added.");
                    continue;
                }
                addedEvents.Add(e.Name);

                WriteLine($"    public static {e.EventType} {c.Name}{e.Name} => {c.Type}.{e.Name}Event;");

                if (i  < events.Length - 1)
                {
                    WriteLine("");
                }
            }

            var classFooterBuilder = new StringBuilder(Templates.EventsFooterTemplate);
            WriteLine(classFooterBuilder.ToString());
        }
    }
}
