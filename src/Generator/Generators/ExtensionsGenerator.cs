using System.Text;
using Reflectonia;
using Reflectonia.Model;

// ReSharper disable once CheckNamespace
namespace Generator;

public class ExtensionsGenerator
{
    public ExtensionsGenerator(ReflectoniaFactory reflectoniaFactory, IReflectoniaLog log)
    {
        ReflectoniaFactory = reflectoniaFactory;
        Log = log;
    }
    
    private ReflectoniaFactory ReflectoniaFactory { get; }

    private IReflectoniaLog Log { get; }

    public void Generate(string outputPath, List<Class> classes, bool genFSharp = false)
    {
        foreach (var c in classes)
        {
            if (c.Properties.Length <= 0 && c.Events.Length <= 0)
            {
                continue;
            }

            var outputFile = Path.Combine(outputPath, $"{c.Name}.Extensions.g.cs");
            using var file = File.CreateText(outputFile);
            void WriteLine(string x) => file.WriteLine(x);

            var fileHeaderBuilder = new StringBuilder(Templates.FileHeaderTemplate);

            if (genFSharp)
            {
                fileHeaderBuilder.Replace("%Namespace%", ".FSharp");
            }
            else
            {
                fileHeaderBuilder.Replace("%Namespace%", "");
            }

            WriteLine(fileHeaderBuilder.ToString());

            var classHeaderBuilder = new StringBuilder(Templates.ClassExtensionsHeaderTemplate);
            classHeaderBuilder.Replace("%ClassName%", c.Name);
            classHeaderBuilder.Replace("%ClassType%", ReflectoniaFactory.ToString(c.Type));
            WriteLine(classHeaderBuilder.ToString());

            var addedProperties = new HashSet<string>();
            var addedRoutedEvents = new HashSet<string>();
            var addedClrEvents = new HashSet<string>();

            for (var i = 0; i < c.Properties.Length; i++)
            {
                var p = c.Properties[i];
                if (p.AlreadyExists)
                {
                    continue;
                }

                if (addedProperties.Contains(p.Name))
                {
                    Log.Error($"Property {c.Name}.{p.Name} extensions have been already added.");
                    continue;
                }
                addedProperties.Add(p.Name);

                var template = p.IsReadOnly
                    ? Templates.PropertyMethodsTemplateReadOnly
                    : c.IsSealed
                        ? Templates.PropertyMethodsTemplateSealed
                        : Templates.PropertyMethodsTemplate;

                var propertyBuilder = new StringBuilder(template);

                propertyBuilder.Replace("%ClassType%", ReflectoniaFactory.ToString(c.Type));
                if (genFSharp)
                {
                    // fsharp can't consume extension methods with the same name as properties
                    // https://github.com/fsharp/fslang-suggestions/issues/1039
                    var name = $"{Char.ToLower(p.Name[0])}{p.Name[1..]}";
                    propertyBuilder.Replace("%MethodName%", name);
                }
                else
                {
                    propertyBuilder.Replace("%MethodName%", p.Name);
                }
                propertyBuilder.Replace("%Name%", p.Name);
                propertyBuilder.Replace("%OwnerType%", ReflectoniaFactory.ToString(p.OwnerType));
                propertyBuilder.Replace("%ValueType%", ReflectoniaFactory.ToString(p.ValueType));

                WriteLine(propertyBuilder.ToString());

                if (p.IsEnum && !p.IsReadOnly && p.EnumNames is { })
                {
                    foreach (var enumName in p.EnumNames)
                    {
                        var templateEnum = c.IsSealed
                            ? Templates.PropertyMethodEnumSealedTemplate
                            : Templates.PropertyMethodEnumTemplate;

                        var propertyEnumBuilder = new StringBuilder(templateEnum);

                        propertyEnumBuilder.Replace("%ClassType%", ReflectoniaFactory.ToString(c.Type));
                        propertyEnumBuilder.Replace("%Name%", p.Name);
                        propertyEnumBuilder.Replace("%OwnerType%", ReflectoniaFactory.ToString(p.OwnerType));
                        propertyEnumBuilder.Replace("%ValueType%", ReflectoniaFactory.ToString(p.ValueType));
                        propertyEnumBuilder.Replace("%EnumValue%", enumName);

                        WriteLine(propertyEnumBuilder.ToString());
                    }
                }

                if (i < c.Properties.Length - 1 || c.Events.Length > 0)
                {
                    WriteLine("");
                }
            }

            var routedEvents = c.Events.Where(x => x.RoutingStrategies is not null).ToArray();
            var clrEvents = c.Events.Where(x => x.RoutingStrategies is null).ToArray();

            for (var i = 0; i < routedEvents.Length; i++)
            {
                var e = routedEvents[i];

                if (addedRoutedEvents.Contains(e.Name))
                {
                    Log.Error($"Routed event {c.Name}.{e.Name} extensions have been already added.");
                    continue;
                }
                addedRoutedEvents.Add(e.Name);

                if (e.RoutingStrategies is null)
                    continue;

                var template = c.IsSealed
                    ? Templates.RoutedEventMethodsTemplateSealed
                    : Templates.RoutedEventMethodsTemplate;

                var eventBuilder = new StringBuilder(template);

                eventBuilder.Replace("%ClassType%", ReflectoniaFactory.ToString(c.Type));
                eventBuilder.Replace("%Name%", e.Name);
                eventBuilder.Replace("%OwnerType%", ReflectoniaFactory.ToString(e.OwnerType));
                eventBuilder.Replace("%ArgsType%", ReflectoniaFactory.ToString(e.ArgsType));

                var routes = e.RoutingStrategies.Split(new[] { ',', ' ' }, StringSplitOptions.RemoveEmptyEntries);
                var routingStrategiesBuilder = new StringBuilder();
                for (var j = 0; j < routes.Length; j++)
                {
                    if (j > 0)
                    {
                        routingStrategiesBuilder.Append(" | ");
                    }

                    routingStrategiesBuilder.Append("Avalonia.Interactivity.RoutingStrategies.");
                    routingStrategiesBuilder.Append(routes[j]);
                }

                eventBuilder.Replace("%RoutingStrategies%", routingStrategiesBuilder.ToString());

                WriteLine(eventBuilder.ToString());

                if (i < routedEvents.Length - 1 || clrEvents.Length > 0)
                {
                    WriteLine("");
                }
            }

            for (var i = 0; i < clrEvents.Length; i++)
            {
                var e = clrEvents[i];

                if (addedClrEvents.Contains(e.Name))
                {
                    Log.Error($"Clr event {c.Name}.{e.Name} extensions have been already added.");
                    continue;
                }
                addedClrEvents.Add(e.Name);

                if (e.RoutingStrategies is { })
                    continue;

                var template = c.IsSealed
                    ? Templates.EventMethodsTemplateSealed
                    : Templates.EventMethodsTemplate;

                var eventBuilder = new StringBuilder(template);

                eventBuilder.Replace("%ClassType%", ReflectoniaFactory.ToString(c.Type));
                eventBuilder.Replace("%Name%", e.Name);
                eventBuilder.Replace("%OwnerType%", ReflectoniaFactory.ToString(e.OwnerType));

                if (e.ArgsType is { })
                {
                    eventBuilder.Replace("%ArgsType%", ReflectoniaFactory.ToString(e.ArgsType));
                    eventBuilder.Replace("%EventHandler%", $"EventHandler<{ReflectoniaFactory.ToString(e.ArgsType)}>");
                }
                else
                {
                    eventBuilder.Replace("%ArgsType%", nameof(EventArgs));
                    eventBuilder.Replace("%EventHandler%", $"EventHandler");
                }

                WriteLine(eventBuilder.ToString());

                if (i < clrEvents.Length - 1)
                {
                    WriteLine("");
                }
            }

            var classFooterBuilder = new StringBuilder(Templates.ClassExtensionsFooterTemplate);
            WriteLine(classFooterBuilder.ToString());
        }
    }
}
