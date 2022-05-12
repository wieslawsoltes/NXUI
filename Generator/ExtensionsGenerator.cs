using System.Reflection;
using System.Text;
using Avalonia;

namespace Generator;

internal record Property(string Name, string OwnerType, string ValueType, string PropertyType, bool IsReadOnly = false, bool IsEnum = false, string[]? EnumNames = null);

internal record Class(string Name, string Type, Property[] Properties, bool IsSealed = false, bool PublicCtor = true);

internal static class ExtensionsGenerator
{
    private static readonly HashSet<string> s_excludedClasses = new()
    {
        "AboutAvaloniaDialog"
    };

    public static void Generate(string outputPath)
    {
        var buildersPath = Path.Combine(outputPath, "Builders");
        var propertiesPath = Path.Combine(outputPath, "Properties");
        var extensionsPath = Path.Combine(outputPath, "Extensions");

        var classes = GetClasses();

        if (!Directory.Exists(buildersPath))
        {
            Directory.CreateDirectory(buildersPath);
        }

        GenerateBuilders(buildersPath, classes);

        if (!Directory.Exists(propertiesPath))
        {
            Directory.CreateDirectory(propertiesPath);
        }

        GenerateProperties(propertiesPath, classes);

        if (!Directory.Exists(extensionsPath))
        {
            Directory.CreateDirectory(extensionsPath);
        }

        GenerateExtensions(extensionsPath, classes);
    }

    private static void GenerateBuilders(string outputPath, List<Class> classes)
    {
        var outputFile = Path.Combine(outputPath, $"Builders.g.cs");

        using var file = File.CreateText(outputFile);
        void WriteLine(string x) => file.WriteLine(x);

        var fileHeaderBuilder = new StringBuilder(Templates.BuildersHeaderTemplate);
        WriteLine(fileHeaderBuilder.ToString());

        for (var i = 0; i < classes.Count; i++)
        {
            var c = classes[i];

            if (s_excludedClasses.Contains(c.Name))
            {
                continue;
            }

            if (!c.PublicCtor)
            {
                continue;
            }

            WriteLine($"    public static {c.Type} {c.Name}() => new();");
            WriteLine("");
            WriteLine($"    public static {c.Type} {c.Name}(out {c.Type} @ref) => @ref = new();");

            if (i < classes.Count - 1)
            {
                WriteLine("");
            }
        }

        var classFooterBuilder = new StringBuilder(Templates.BuildersFooterTemplate);
        WriteLine(classFooterBuilder.ToString());
    }

    private static void GenerateProperties(string outputPath, List<Class> classes)
    {
        foreach (var c in classes)
        {
            if (s_excludedClasses.Contains(c.Name))
            {
                continue;
            }

            var outputFile = Path.Combine(outputPath, $"{c.Name}.Properties.g.cs");

            using var file = File.CreateText(outputFile);
            void WriteLine(string x) => file.WriteLine(x);

            var fileHeaderBuilder = new StringBuilder(Templates.PropertiesHeaderTemplate);
            WriteLine(fileHeaderBuilder.ToString());

            if (c.Properties.Length > 0)
            {
                for (var i = 0; i < c.Properties.Length; i++)
                {
                    var p = c.Properties[i];

                    WriteLine($"    public static {p.PropertyType} {c.Name}{p.Name} => {c.Type}.{p.Name}Property;");

                    if (i < c.Properties.Length - 1)
                    {
                        WriteLine("");
                    }
                }
            }

            var classFooterBuilder = new StringBuilder(Templates.PropertiesFooterTemplate);
            WriteLine(classFooterBuilder.ToString());
        }
    }

    private static void GenerateExtensions(string outputPath, List<Class> classes)
    {
        foreach (var c in classes)
        {
            if (s_excludedClasses.Contains(c.Name))
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

                if (i < c.Properties.Length - 1)
                {
                    WriteLine("");
                }
            }

            var classFooterBuilder = new StringBuilder(Templates.ClassExtensionsFooterTemplate);
            WriteLine(classFooterBuilder.ToString());
        }
    }

    private static readonly FieldInfo? s_attached = 
        typeof(AvaloniaPropertyRegistry).GetField("_attached", BindingFlags.NonPublic | BindingFlags.Instance);

    private static List<Class> GetClasses()
    {
        var assemblies = AppDomain.CurrentDomain.GetAssemblies();
        var classTypes = (
            from assembly in assemblies
            where assembly?.FullName is not null && assembly.FullName.StartsWith("Avalonia")
            from assemblyType in assembly.GetTypes()
            where assemblyType is not null
                  && assemblyType.IsSubclassOf(typeof(AvaloniaObject))
                  && assemblyType.GetCustomAttributes().All(x => x.GetType().Name != "ObsoleteAttribute")
                  && !assemblyType.IsAbstract
                  && assemblyType.IsPublic
            select assemblyType).ToArray();

        var classes = new List<Class>();
        var attachedRegistry = (Dictionary<Type, Dictionary<int, AvaloniaProperty>>?)s_attached?.GetValue(AvaloniaPropertyRegistry.Instance);

        foreach (var classType in classTypes)
        {
            // var avaloniaPropertiesRegistered = AvaloniaPropertyRegistry.Instance.GetRegistered(classType);
            // var avaloniaPropertiesAttached = AvaloniaPropertyRegistry.Instance.GetRegisteredAttached(classType);
            // var avaloniaProperties = avaloniaPropertiesRegistered.Concat(avaloniaPropertiesAttached).ToList();
            var avaloniaProperties = AvaloniaPropertyRegistry.Instance.GetRegistered(classType);
            if (avaloniaProperties.Count <= 0)
                continue;

            var properties = new List<Property>();

            static string FixType(string t)
                => t.Replace("`1[", "<")
                    .Replace("`2[", "<")
                    .Replace("`3[", "<")
                    .Replace("]", ">")
                    .Replace("+", ".");

            static string FixClassNameType(string t)
                => t.Replace("`1", "")
                    .Replace("`2", "")
                    .Replace("`3", "")
                    .Replace("+", "");

            foreach (var property in avaloniaProperties)
            {
                var fieldInfo = classType.GetField($"{property.Name}Property");
                if (fieldInfo is null)
                    continue;

                if (!fieldInfo.IsPublic)
                    continue;

                if (fieldInfo.GetCustomAttributes().Any(x => x.GetType().Name == "ObsoleteAttribute"))
                    continue;

                if (property.OwnerType != classType || !property.PropertyType.IsPublic)
                    continue;

                var isEnum = false;
                var enumNames = new List<string>();

                var ownerType = property.OwnerType;
                if (property.IsAttached && attachedRegistry is { })
                {
                    foreach (var kvp1 in attachedRegistry)
                    {
                        foreach (var kvp2 in kvp1.Value)
                        {
                            if (kvp2.Value == property)
                            {
                                ownerType = kvp1.Key;
                            }
                        }
                    }
                }

                if (property.PropertyType.BaseType == typeof(Enum))
                {
                    var names = Enum.GetNames(property.PropertyType);
                    enumNames.AddRange(names);
                    isEnum = true;
                }

                var p = new Property(
                    property.Name,
                    FixType(ownerType.ToString()),
                    FixType(property.PropertyType.ToString()),
                    FixType(property.GetType().ToString()),
                    property.IsReadOnly,
                    isEnum,
                    isEnum ? enumNames.ToArray() : null);

                properties.Add(p);
            }

            var publicCtor = classType
                .GetConstructors()
                .Any(x => x.IsPublic && x.GetParameters().Length == 0);

            var c = new Class(
                FixClassNameType(classType.Name), 
                FixType(classType.ToString()), 
                properties.ToArray(),
                classType.IsSealed,
                publicCtor);

            classes.Add(c);
        }

        return classes;
    }
}
