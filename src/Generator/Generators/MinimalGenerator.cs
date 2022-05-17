// ReSharper disable once CheckNamespace
namespace Generator;

internal static class MinimalGenerator
{
    public static void Generate(string outputPath)
    {
        var buildersPath = Path.Combine(outputPath, "Builders");
        var propertiesPath = Path.Combine(outputPath, "Properties");
        var eventsPath = Path.Combine(outputPath, "Events");
        var extensionsPath = Path.Combine(outputPath, "Extensions");

        var classes = Factory.CreateClasses();

        if (classes is null)
        {
            return;
        }

        if (!Directory.Exists(buildersPath))
        {
            Directory.CreateDirectory(buildersPath);
        }
        
        BuildersGenerator.Generate(buildersPath, classes);

        if (!Directory.Exists(propertiesPath))
        {
            Directory.CreateDirectory(propertiesPath);
        }
        PropertiesGenerator.Generate(propertiesPath, classes);

        if (!Directory.Exists(eventsPath))
        {
            Directory.CreateDirectory(eventsPath);
        }
        EventsGenerator.Generate(eventsPath, classes);

        if (!Directory.Exists(extensionsPath))
        {
            Directory.CreateDirectory(extensionsPath);
        }
        ExtensionsGenerator.Generate(extensionsPath, classes);
    }
}
