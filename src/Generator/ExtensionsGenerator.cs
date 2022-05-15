using System.Reflection;
using System.Text;
using Avalonia;
using Avalonia.Interactivity;

namespace Generator;

internal record Property(string Name, string OwnerType, string ValueType, string PropertyType, bool AlreadyExists, bool IsReadOnly = false, bool IsEnum = false, string[]? EnumNames = null);

internal record Event(string Name, string OwnerType, string ArgsType, string EventType);

internal record Class(string Name, string Type, Property[] Properties, Event[] Events, bool IsSealed = false, bool PublicCtor = true, bool IsAbstract = false);

internal static class ExtensionsGenerator
{
    private static readonly HashSet<string> s_excludedClasses = new()
    {
        "AboutAvaloniaDialog"
    };

    private static readonly FieldInfo? s_registered = 
        typeof(AvaloniaPropertyRegistry).GetField("_registered", BindingFlags.NonPublic | BindingFlags.Instance);

    private static readonly FieldInfo? s_attached = 
        typeof(AvaloniaPropertyRegistry).GetField("_attached", BindingFlags.NonPublic | BindingFlags.Instance);

    private static readonly FieldInfo? s_registeredRoutedEvents = 
        typeof(RoutedEventRegistry).GetField("_registeredRoutedEvents", BindingFlags.NonPublic | BindingFlags.Instance);

    public static void Generate(string outputPath)
    {
        var buildersPath = Path.Combine(outputPath, "Builders");
        var propertiesPath = Path.Combine(outputPath, "Properties");
        var eventsPath = Path.Combine(outputPath, "Events");
        var extensionsPath = Path.Combine(outputPath, "Extensions");

        var classes = GetClasses();

        if (classes is null)
        {
            return;
        }

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

        if (!Directory.Exists(eventsPath))
        {
            Directory.CreateDirectory(eventsPath);
        }
        GenerateEvents(eventsPath, classes);

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

            if (c.IsAbstract)
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

            if (c.Properties.Length <= 0)
            {
                continue;
            }

            var outputFile = Path.Combine(outputPath, $"{c.Name}.Properties.g.cs");

            using var file = File.CreateText(outputFile);
            void WriteLine(string x) => file.WriteLine(x);

            var fileHeaderBuilder = new StringBuilder(Templates.PropertiesHeaderTemplate);
            WriteLine(fileHeaderBuilder.ToString());

            for (var i = 0; i < c.Properties.Length; i++)
            {
                var p = c.Properties[i];

                WriteLine($"    public static {p.PropertyType} {c.Name}{p.Name} => {c.Type}.{p.Name}Property;");

                if (i < c.Properties.Length - 1)
                {
                    WriteLine("");
                }
            }

            var classFooterBuilder = new StringBuilder(Templates.PropertiesFooterTemplate);
            WriteLine(classFooterBuilder.ToString());
        }
    }

    private static void GenerateEvents(string outputPath, List<Class> classes)
    {
        foreach (var c in classes)
        {
            if (s_excludedClasses.Contains(c.Name))
            {
                continue;
            }

            if (c.Events.Length <= 0)
            {
                continue;
            }

            var outputFile = Path.Combine(outputPath, $"{c.Name}.Events.g.cs");

            using var file = File.CreateText(outputFile);
            void WriteLine(string x) => file.WriteLine(x);

            var fileHeaderBuilder = new StringBuilder(Templates.EventsHeaderTemplate);
            WriteLine(fileHeaderBuilder.ToString());

            for (var i = 0; i < c.Events.Length; i++)
            {
                var e = c.Events[i];

                WriteLine($"    public static {e.EventType} {c.Name}{e.Name} => {c.Type}.{e.Name}Event;");

                if (i < c.Events.Length - 1)
                {
                    WriteLine("");
                }
            }

            var classFooterBuilder = new StringBuilder(Templates.EventsFooterTemplate);
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

                if (i < c.Properties.Length - 1)
                {
                    WriteLine("");
                }
            }

            var classFooterBuilder = new StringBuilder(Templates.ClassExtensionsFooterTemplate);
            WriteLine(classFooterBuilder.ToString());
        }
    }

    private static string FixType(string t)
    {
        return t
            .Replace("`1[", "<")
            .Replace("`2[", "<")
            .Replace("`3[", "<")
            .Replace("]", ">")
            .Replace("+", ".");
    }

    private static string FixClassNameType(string t)
    {
        return t
            .Replace("`1", "")
            .Replace("`2", "")
            .Replace("`3", "")
            .Replace("+", "");
    }

    private static List<Class>? GetClasses()
    {
        var assemblies = AppDomain.CurrentDomain.GetAssemblies();
        var classTypes = (
            from assembly in assemblies
            where assembly?.FullName is not null && assembly.FullName.StartsWith("Avalonia")
            from assemblyType in assembly.GetTypes()
            where assemblyType is not null
                  && assemblyType.IsSubclassOf(typeof(AvaloniaObject))
                  && assemblyType.GetCustomAttributes().All(x => x.GetType().Name != "ObsoleteAttribute")
                  && assemblyType.IsPublic
            select assemblyType).ToArray();

        var classes = new List<Class>();

        foreach (var classType in classTypes)
        {
            System.Runtime.CompilerServices.RuntimeHelpers.RunClassConstructor(classType.TypeHandle);
        }

        var registeredProperties = (Dictionary<Type, Dictionary<int, AvaloniaProperty>>?)
            s_registered?.GetValue(AvaloniaPropertyRegistry.Instance);

        var registeredAttachedProperties = (Dictionary<Type, Dictionary<int, AvaloniaProperty>>?)
            s_attached?.GetValue(AvaloniaPropertyRegistry.Instance);

        var registeredRoutedEvents = (Dictionary<Type, List<RoutedEvent>>?)
            s_registeredRoutedEvents?.GetValue(RoutedEventRegistry.Instance);

        if (registeredProperties is null || registeredAttachedProperties is null || registeredRoutedEvents is null)
        {
            return null;
        }

        foreach (var classType in classTypes)
        {
            var properties = new List<Property>();
            var events = new List<Event>();

            registeredProperties.TryGetValue(classType, out var registeredPropertiesDict);
            if (registeredPropertiesDict is { })
            {
                var avaloniaProperties = registeredPropertiesDict.Values;

                foreach (var property in avaloniaProperties)
                {
                    var fieldInfo = classType.GetField($"{property.Name}Property");
                    if (fieldInfo is null)
                        continue;

                    if (!fieldInfo.IsPublic)
                        continue;

                    if (fieldInfo.GetCustomAttributes().Any(x => x.GetType().Name == "ObsoleteAttribute"))
                        continue;

                    if (!property.PropertyType.IsPublic)
                        continue;

                    var propertyType = fieldInfo.FieldType; // property.GetType()
                    var valueType = property.PropertyType;
                    var ownerType = property.OwnerType;

                    if (property.IsAttached 
                        // && property.GetType() == fieldInfo.FieldType 
                        && registeredAttachedProperties is { })
                    {
                        foreach (var kvp1 in registeredAttachedProperties)
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

                    var alreadyExists = false;

                    if (property.OwnerType != classType)
                    {
                        var t = classType;

                        while (t != null)
                        {
                            if (ownerType == t)
                            {
                                alreadyExists = true;
                                break;
                            }

                            t = t.BaseType;
                        }

                        ownerType = classType;
                    }

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
                        FixType(ownerType.ToString()),
                        FixType(valueType.ToString()),
                        FixType(propertyType.ToString()),
                        alreadyExists,
                        property.IsReadOnly,
                        isEnum,
                        isEnum ? enumNames.ToArray() : null);

                    properties.Add(p);
                }
            }

            registeredRoutedEvents.TryGetValue(classType, out var registeredRoutedEventsDict);
            if (registeredRoutedEventsDict is { })
            {
                var avaloniaRoutedEvents = registeredRoutedEventsDict;
 
                foreach (var @event in avaloniaRoutedEvents)
                {
                    var fieldInfo = classType.GetField($"{@event.Name}Event");
                    if (fieldInfo is null)
                        continue;

                    if (!fieldInfo.IsPublic)
                        continue;

                    if (fieldInfo.GetCustomAttributes().Any(x => x.GetType().Name == "ObsoleteAttribute"))
                        continue;

                    if (!@event.EventArgsType.IsPublic)
                        continue;

                    var eventType = fieldInfo.FieldType; // property.GetType()
                    var argsType = @event.EventArgsType;
                    var ownerType = @event.OwnerType;

                    var e = new Event(
                        @event.Name,
                        FixType(ownerType.ToString()),
                        FixType(argsType.ToString()),
                        FixType(eventType.ToString()));

                    events.Add(e);
                }
            }

            var publicCtor = classType
                .GetConstructors()
                .Any(x => x.IsPublic && x.GetParameters().Length == 0);

            var c = new Class(
                FixClassNameType(classType.Name), 
                FixType(classType.ToString()), 
                properties.ToArray(),
                events.ToArray(),
                classType.IsSealed,
                publicCtor,
                classType.IsAbstract);

            classes.Add(c);
        }

        return classes;
    }
}
