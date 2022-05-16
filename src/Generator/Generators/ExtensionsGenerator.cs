using System.Text;
using Generator.Model;

// ReSharper disable once CheckNamespace
namespace Generator;

internal static class ExtensionsGenerator
{
    public static void Generate(string outputPath, List<Class> classes)
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
            WriteLine(fileHeaderBuilder.ToString());

            var classHeaderBuilder = new StringBuilder(Templates.ClassExtensionsHeaderTemplate);
            classHeaderBuilder.Replace("%ClassName%", c.Name);
            WriteLine(classHeaderBuilder.ToString());

            for (var i = 0; i < c.Properties.Length; i++)
            {
                var p = c.Properties[i];
                if (p.AlreadyExists)
                {
                    continue;
                }

                var template = p.IsReadOnly
                    ? Templates.PropertyMethodsTemplateReadOnly
                    : c.IsSealed
                        ? Templates.PropertyMethodsTemplateSealed
                        : Templates.PropertyMethodsTemplate;

                var propertyBuilder = new StringBuilder(template);

                propertyBuilder.Replace("%ClassType%", c.Type);
                propertyBuilder.Replace("%Name%", p.Name);
                propertyBuilder.Replace("%OwnerType%", p.OwnerType);
                propertyBuilder.Replace("%ValueType%", p.ValueType);

                WriteLine(propertyBuilder.ToString());

                if (p.IsEnum && !p.IsReadOnly && p.EnumNames is { })
                {
                    foreach (var enumName in p.EnumNames)
                    {
                        var templateEnum = c.IsSealed
                            ? Templates.PropertyMethodEnumSealedTemplate
                            : Templates.PropertyMethodEnumTemplate;

                        var propertyEnumBuilder = new StringBuilder(templateEnum);

                        propertyEnumBuilder.Replace("%ClassType%", c.Type);
                        propertyEnumBuilder.Replace("%Name%", p.Name);
                        propertyEnumBuilder.Replace("%OwnerType%", p.OwnerType);
                        propertyEnumBuilder.Replace("%ValueType%", p.ValueType);
                        propertyEnumBuilder.Replace("%EnumValue%", enumName);

                        WriteLine(propertyEnumBuilder.ToString());
                    }
                }

                if (i < c.Properties.Length - 1 || c.Events.Length > 0)
                {
                    WriteLine("");
                }
            }

            for (var i = 0; i < c.Events.Length; i++)
            {
                var e = c.Events[i];

                var template = c.IsSealed
                    ? Templates.EventMethodsTemplateSealed
                    : Templates.EventMethodsTemplate;

                var eventBuilder = new StringBuilder(template);

                eventBuilder.Replace("%ClassType%", c.Type);
                eventBuilder.Replace("%Name%", e.Name);
                eventBuilder.Replace("%OwnerType%", e.OwnerType);
                eventBuilder.Replace("%ArgsType%", e.ArgsType);

                var routes = e.RoutingStrategies.Split(new[] {',', ' '}, StringSplitOptions.RemoveEmptyEntries);
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

                if (i < c.Events.Length - 1)
                {
                    WriteLine("");
                }
            }

            var classFooterBuilder = new StringBuilder(Templates.ClassExtensionsFooterTemplate);
            WriteLine(classFooterBuilder.ToString());
        }
    }
}
