using System.Text;
using Generator.Model;

// ReSharper disable once CheckNamespace
namespace Generator;

internal static class SettersGenerator
{
    public static void Generate(string outputPath, List<Class> classes)
    {
        foreach (var c in classes)
        {
            if (c.Properties.Length <= 0 )
            {
                continue;
            }

            var outputFile = Path.Combine(outputPath, $"{c.Name}.Setters.g.cs");
            using var file = File.CreateText(outputFile);
            void WriteLine(string x) => file.WriteLine(x);

            var fileHeaderBuilder = new StringBuilder(Templates.FileHeaderTemplate);
            WriteLine(fileHeaderBuilder.ToString());

            var classHeaderBuilder = new StringBuilder(Templates.PropertySettersHeaderTemplate);
            classHeaderBuilder.Replace("%ClassName%", c.Name);
            classHeaderBuilder.Replace("%ClassType%", c.Type);
            WriteLine(classHeaderBuilder.ToString());

            var addedProperties = new HashSet<string>();

            for (var i = 0; i < c.Properties.Length; i++)
            {
                var p = c.Properties[i];
                if (p.AlreadyExists)
                {
                    continue;
                }

                if (addedProperties.Contains(p.Name))
                {
                    Console.WriteLine($"Property {c.Name}.{p.Name} setters have been already added.");
                    continue;
                }
                addedProperties.Add(p.Name);

                var propertyBuilder = new StringBuilder(Templates.PropertySettersTemplate);

                propertyBuilder.Replace("%ClassType%", c.Type);
                propertyBuilder.Replace("%ClassName%", c.Name);
                propertyBuilder.Replace("%Name%", p.Name);
                propertyBuilder.Replace("%ValueType%", p.ValueType);

                WriteLine(propertyBuilder.ToString());

                if (i < c.Properties.Length - 1 || c.Events.Length > 0)
                {
                    WriteLine("");
                }
            }

            var classFooterBuilder = new StringBuilder(Templates.PropertySettersFooterTemplate);
            WriteLine(classFooterBuilder.ToString());
        }
    }
}
