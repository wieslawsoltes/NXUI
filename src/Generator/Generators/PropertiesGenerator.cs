using System.Diagnostics;
using System.Text;
using Reflectonia;
using Reflectonia.Model;

// ReSharper disable once CheckNamespace
namespace Generator;

public class PropertiesGenerator
{
    public PropertiesGenerator(ReflectoniaFactory reflectoniaFactory, IReflectoniaLog log)
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
            if (c.Properties.Length <= 0)
            {
                continue;
            }

            var outputFile = Path.Combine(outputPath, $"{c.Name}.Properties.g.cs");

            using var file = File.CreateText(outputFile);
            void WriteLine(string x) => file.WriteLine(x);

            var fileHeaderBuilder = new StringBuilder(Templates.PropertiesHeaderTemplate);

            fileHeaderBuilder.Replace("%Namespace%", "");

            WriteLine(fileHeaderBuilder.ToString());

            var addedProperties = new HashSet<string>();

            for (var i = 0; i < c.Properties.Length; i++)
            {
                var p = c.Properties[i];

                if (addedProperties.Contains(p.Name))
                {
                    Log.Error($"Property {c.Name}.{p.Name} was already added.");
                    continue;
                }
                addedProperties.Add(p.Name);

                var propertyBuilder = new StringBuilder(Templates.PropertyTemplate);
                propertyBuilder.Replace("%ClassName%", c.Name);
                propertyBuilder.Replace("%ClassType%", ReflectoniaFactory.ToString(c.Type));
                propertyBuilder.Replace("%PropertyName%", p.Name);
                propertyBuilder.Replace("%PropertyType%", ReflectoniaFactory.ToString(p.PropertyType));
                WriteLine(propertyBuilder.ToString());

                if (i < c.Properties.Length - 1)
                {
                    WriteLine("");
                }
            }

            var classFooterBuilder = new StringBuilder(Templates.PropertiesFooterTemplate);
            WriteLine(classFooterBuilder.ToString());
        }
    }
}
