using System.Reflection;
using Avalonia;
using Avalonia.Interactivity;
using Generator.Model;

// ReSharper disable once CheckNamespace
namespace Generator;

internal static class Factory
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

    private static Type[] GetClassTypes()
    {
       return(
           from assembly in AppDomain.CurrentDomain.GetAssemblies()
           where assembly?.FullName is not null && assembly.FullName.StartsWith("Avalonia")
           from assemblyType in assembly.GetTypes()
           where assemblyType is not null 
                 && assemblyType.IsSubclassOf(typeof(AvaloniaObject))
                 && assemblyType.GetCustomAttributes().All(x => x.GetType().Name != "ObsoleteAttribute")
                 && assemblyType.IsPublic
           select assemblyType).ToArray();
    }

    public static List<Class>? CreateClasses()
    {
        var classTypes = GetClassTypes();
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

        if (registeredProperties is null 
            || registeredAttachedProperties is null 
            || registeredRoutedEvents is null)
        {
            return null;
        }

        foreach (var classType in classTypes)
        {
            if (s_excludedClasses.Contains(classType.Name))
            {
                continue;
            }

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
