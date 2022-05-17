using System.Reflection;
using Avalonia;
using Generator.Model;

namespace Generator;

internal static class Factory
{
    private static readonly HashSet<string> s_excludedClasses = new()
    {
        "AboutAvaloniaDialog"
    };

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

    private static List<Property> GetProperties(Type classType, Registry registry)
    {
        var properties = new List<Property>();

        if (registry.RegisteredProperties is null)
        {
            return properties;
        }

        registry.RegisteredProperties.TryGetValue(classType, out var registeredPropertiesDict);
        if (registeredPropertiesDict is null)
        {
            return properties;
        }

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
                && registry.RegisteredAttachedProperties is { })
            {
                foreach (var kvp1 in registry.RegisteredAttachedProperties)
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

            properties.Add(new Property(
                property.Name,
                FixType(ownerType.ToString()),
                FixType(valueType.ToString()),
                FixType(propertyType.ToString()),
                alreadyExists,
                property.IsReadOnly,
                isEnum,
                isEnum ? enumNames.ToArray() : null));
        }

        return properties;
    }
    
    private static List<Event> GetEvents(Type classType, Registry registry)
    {
        var events = new List<Event>();

        if (registry.RegisteredRoutedEvents is null)
        {
            return events;
        }

        registry.RegisteredRoutedEvents.TryGetValue(classType, out var registeredRoutedEventsDict);
        if (registeredRoutedEventsDict is null)
        {
            return events;
        }

        var avaloniaRoutedEvents = registeredRoutedEventsDict;
 
        foreach (var routedEvent in avaloniaRoutedEvents)
        {
            var fieldInfo = classType.GetField($"{routedEvent.Name}Event");
            if (fieldInfo is null)
                continue;

            if (!fieldInfo.IsPublic)
                continue;

            if (fieldInfo.GetCustomAttributes().Any(x => x.GetType().Name == "ObsoleteAttribute"))
                continue;

            if (!routedEvent.EventArgsType.IsPublic)
                continue;

            var eventType = fieldInfo.FieldType; // property.GetType()
            var argsType = routedEvent.EventArgsType;
            var ownerType = routedEvent.OwnerType;
            var routingStrategies = routedEvent.RoutingStrategies;

            events.Add(new Event(
                routedEvent.Name,
                FixType(ownerType.ToString()),
                FixType(argsType.ToString()),
                FixType(eventType.ToString()),
                routingStrategies.ToString()));
        }

        return events;
    }

    public static List<Class>? CreateClasses()
    {
        var classTypes = GetClassTypes();
        var classes = new List<Class>();

        var registry = new Registry(classTypes);
        if (registry.RegisteredProperties is null 
            || registry.RegisteredAttachedProperties is null 
            || registry.RegisteredRoutedEvents is null)
        {
            return null;
        }

        foreach (var classType in classTypes)
        {
            if (s_excludedClasses.Contains(classType.Name))
            {
                continue;
            }

            var publicCtor = classType.GetConstructors().Any(x => x.IsPublic && x.GetParameters().Length == 0);

            var properties = GetProperties(classType, registry);

            var events = GetEvents(classType, registry);

            classes.Add(new Class(
                FixClassNameType(classType.Name), 
                FixType(classType.ToString()), 
                properties.ToArray(),
                events.ToArray(),
                classType.IsSealed,
                publicCtor,
                classType.IsAbstract));
        }

        return classes;
    }
}
