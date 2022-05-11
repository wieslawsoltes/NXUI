using System.Reflection;
using System.Text;
using Avalonia;

namespace Generator;

internal record Property(string Name, string OwnerType, string ValueType, string PropertyType, bool IsReadOnly = false, bool IsEnum = false, string[]? EnumNames = null);

internal record Class(string Name, string Type, Property[] Properties, bool IsSealed = false);

internal static class ExtensionsGenerator
{ 
    public static void Generate(string outputPath) 
    {
        var classes = GetClasses();

        if (!Directory.Exists(outputPath))
        {
            Directory.CreateDirectory(outputPath);
        }

        foreach (var c in classes)
        {
            var outputFile = Path.Combine(outputPath, $"{c.Name}Extensions.g.cs");

            using var file = File.CreateText(outputFile);
            void WriteLine(string x) => file.WriteLine(x);

            var fileHeaderBuilder = new StringBuilder(Templates.FileHeaderTemplate);
            WriteLine(fileHeaderBuilder.ToString());

            var classHeaderBuilder = new StringBuilder(Templates.ClassExtensionsHeaderTemplate);
            classHeaderBuilder.Replace("%ClassName%", c.Name);
            WriteLine(classHeaderBuilder.ToString());

            // Properties

            if (c.Properties.Length > 0)
            {
                WriteLine("    //");
                WriteLine("    // Properties");
                WriteLine("    //");
                WriteLine("");

                foreach (var p in c.Properties)
                {
                    WriteLine($"    public static {p.PropertyType} {c.Name}{p.Name} => {c.Type}.{p.Name}Property;");
                }

                WriteLine("");
            }

            // Methods

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
            select assemblyType).ToArray();

        var classes = new List<Class>();

        foreach (var classType in classTypes)
        {
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

                if (property.PropertyType.BaseType == typeof(Enum))
                {
                    var names = Enum.GetNames(property.PropertyType);
                    enumNames.AddRange(names);
                    isEnum = true;
                }

                var p = new Property(
                    property.Name,
                    FixType(property.OwnerType.ToString()),
                    FixType(property.PropertyType.ToString()),
                    FixType(property.GetType().ToString()),
                    property.IsReadOnly,
                    isEnum,
                    isEnum ? enumNames.ToArray() : null);

                properties.Add(p);
            }

            var c = new Class(
                FixClassNameType(classType.Name), 
                FixType(classType.ToString()), 
                properties.ToArray(),
                classType.IsSealed);

            classes.Add(c);
        }

        return classes;
    }
}
