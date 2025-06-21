using System.Text;
using Reflectonia;
using Reflectonia.Model;

// ReSharper disable once CheckNamespace
namespace Generator;

public class EventsGenerator
{
    public EventsGenerator(ReflectoniaFactory reflectoniaFactory, IReflectoniaLog log)
    {
        ReflectoniaFactory = reflectoniaFactory;
        Log = log;
    }

    private ReflectoniaFactory ReflectoniaFactory { get; }

    private IReflectoniaLog Log { get; }

    public void Generate(string outputPath, List<Class> classes)
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

            fileHeaderBuilder.Replace("%Namespace%", "");

            WriteLine(fileHeaderBuilder.ToString());

            var addedEvents = new HashSet<string>();

            for (var i = 0; i < events.Length; i++)
            {
                var e = events[i];

                if (addedEvents.Contains(e.Name))
                {
                    Log.Error($"Event {c.Name}.{e.Name} was already added.");
                    continue;
                }
                addedEvents.Add(e.Name);

                var eventBuilder = new StringBuilder(Templates.EventTemplate);
                eventBuilder.Replace("%ClassName%", c.Name);
                eventBuilder.Replace("%ClassType%", ReflectoniaFactory.ToString(c.Type));
                eventBuilder.Replace("%EventName%", e.Name);
                eventBuilder.Replace("%EventType%", ReflectoniaFactory.ToString(e.EventType));
                WriteLine(eventBuilder.ToString());

                if (i < events.Length - 1)
                {
                    WriteLine("");
                }
            }

            var classFooterBuilder = new StringBuilder(Templates.EventsFooterTemplate);
            WriteLine(classFooterBuilder.ToString());
        }
    }
}
