using System.Reflection;
using Reflectonia;
using Reflectonia.Model;

// ReSharper disable once CheckNamespace
namespace Generator;

public class MainGenerator
{
    public MainGenerator(ReflectoniaFactory reflectoniaFactory, IReflectoniaLog log)
    {
        ReflectoniaFactory = reflectoniaFactory;

        BuildersGenerator = new BuildersGenerator(reflectoniaFactory, log);
        PropertiesGenerator = new PropertiesGenerator(reflectoniaFactory, log);
        EventsGenerator = new EventsGenerator(reflectoniaFactory, log);
        ExtensionsGenerator = new ExtensionsGenerator(reflectoniaFactory, log);
        ElementRefExtensionsGenerator = new ElementRefExtensionsGenerator(reflectoniaFactory, log);
        SettersGenerator = new SettersGenerator(reflectoniaFactory, log);
        MetadataGenerator = new MetadataGenerator(reflectoniaFactory, log);
        BuilderAliasesGenerator = new BuilderAliasesGenerator(reflectoniaFactory, log);
    }

    private ReflectoniaFactory ReflectoniaFactory { get; }

    public BuildersGenerator BuildersGenerator { get; }

    public PropertiesGenerator PropertiesGenerator { get; }

    public EventsGenerator EventsGenerator { get; }

    public ExtensionsGenerator ExtensionsGenerator { get; }

    public ElementRefExtensionsGenerator ElementRefExtensionsGenerator { get; }

    public SettersGenerator SettersGenerator { get; }

    public MetadataGenerator MetadataGenerator { get; }

    public BuilderAliasesGenerator BuilderAliasesGenerator { get; }

    public void Generate(string outputPath, Predicate<Assembly> assemblyFilter, Predicate<Type> typeFilter)
    {
        var buildersPath = Path.Combine(outputPath, "Builders");
        var propertiesPath = Path.Combine(outputPath, "Properties");
        var eventsPath = Path.Combine(outputPath, "Events");
        var extensionsPath = Path.Combine(outputPath, "Extensions");
        var elementRefExtensionsPath = Path.Combine(outputPath, "ElementRef");
        var settersPath = Path.Combine(outputPath, "Setters");
        var hotReloadPath = Path.Combine(outputPath, "HotReload");

        var classes = ReflectoniaFactory.CreateClasses(assemblyFilter, typeFilter);

        if (classes is null)
        {
            return;
        }

        BuilderAliasRegistry.Initialize(classes, ReflectoniaFactory);

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

        if (!Directory.Exists(elementRefExtensionsPath))
        {
            Directory.CreateDirectory(elementRefExtensionsPath);
        }
        ElementRefExtensionsGenerator.Generate(elementRefExtensionsPath, classes);

        if (!Directory.Exists(settersPath))
        {
            Directory.CreateDirectory(settersPath);
        }
        SettersGenerator.Generate(settersPath, classes);

        MetadataGenerator.Generate(hotReloadPath, classes);

        var projectRoot = Path.GetFullPath(Path.Combine(outputPath, ".."));
        var builderAliasesProps = Path.Combine(projectRoot, "ElementBuilderAliases.props");
        BuilderAliasesGenerator.Generate(builderAliasesProps, classes);
    }
}
