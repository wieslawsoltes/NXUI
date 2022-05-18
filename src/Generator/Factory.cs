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

    private static void Log(string message)
    {
        Console.WriteLine(message);
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
            Log($"Could not find registered properties.");
            return properties;
        }

        registry.RegisteredProperties.TryGetValue(classType, out var registeredPropertiesDict);
        if (registeredPropertiesDict is null)
        {
            Log($"Did not find any registered properties for {classType.Name}.");
            return properties;
        }

        var avaloniaProperties = registeredPropertiesDict.Values;
        foreach (var property in avaloniaProperties)
        {
            var propertyName = property.Name;
            var fieldInfo = classType.GetField($"{propertyName}Property");
            if (fieldInfo is null)
            {
                Log($"Could not find field for {classType.Name}.{propertyName}Property.");
                continue;
            }

            if (!fieldInfo.IsPublic)
            {
                Log($"The {classType.Name}.{propertyName}Property field is not public.");
                continue;
            }

            if (fieldInfo.GetCustomAttributes().Any(x => x.GetType().Name == "ObsoleteAttribute"))
            {
                Log($"The {classType.Name}.{propertyName}Property field is obsolete.");
                continue;
            }

            if (!property.PropertyType.IsPublic)
            {
                Log($"The {classType.Name}.{propertyName}Property property type {property.PropertyType.Name} is not public.");
                continue;
            }

            var propertyType = fieldInfo.FieldType;
            var valueType = property.PropertyType;
            var ownerType = property.OwnerType;

            if (property.IsAttached && registry.RegisteredAttachedProperties is { })
            {
                foreach (var kvp1 in registry.RegisteredAttachedProperties)
                {
                    foreach (var kvp2 in kvp1.Value)
                    {
                        if (kvp2.Value == property)
                        {
                            Log($"Attached property {classType.Name}.{propertyName}Property registered owner type changed from {ownerType.Name} to {kvp1.Key.Name}.");
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

                Log($"Attached property {classType.Name}.{propertyName}Property registered owner type changed from {ownerType.Name} to {classType.Name}.");
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
                propertyName,
                FixType(ownerType.ToString()),
                FixType(valueType.ToString()),
                FixType(propertyType.ToString()),
                alreadyExists,
                property.IsReadOnly,
                isEnum,
                isEnum ? enumNames.ToArray() : null);
            properties.Add(p);
        }

        return properties;
    }
    
    private static List<Event> GetEvents(Type classType, Registry registry)
    {
        var events = new List<Event>();

        if (registry.RegisteredRoutedEvents is null)
        {
            Log($"Could not find any registered routed events.");
            return events;
        }

        registry.RegisteredRoutedEvents.TryGetValue(classType, out var registeredRoutedEventsDict);
        if (registeredRoutedEventsDict is null)
        {
            Log($"Did not find any registered routed events for {classType.Name}.");
            return events;
        }

        var avaloniaRoutedEvents = registeredRoutedEventsDict;
        foreach (var routedEvent in avaloniaRoutedEvents)
        {
            var eventName = routedEvent.Name;
            var fieldInfo = classType.GetField($"{eventName}Event");
            if (fieldInfo is null)
            {
                Log($"Could not find field for {classType.Name}.{eventName}Event.");
                continue;
            }

            if (!fieldInfo.IsPublic)
            {
                Log($"The {classType.Name}.{eventName}Event field is not public.");
                continue;
            }

            if (fieldInfo.GetCustomAttributes().Any(x => x.GetType().Name == "ObsoleteAttribute"))
            {
                Log($"The {classType.Name}.{eventName}Event field is obsolete.");
                continue;
            }

            if (!routedEvent.EventArgsType.IsPublic)
            {
                Log($"The {classType.Name}.{eventName}Event args type {routedEvent.EventArgsType.Name} is not public.");
                continue;
            }

            var eventType = fieldInfo.FieldType; // property.GetType()

            var argsType = routedEvent.EventArgsType;
            var ownerType = routedEvent.OwnerType;
            var routingStrategies = routedEvent.RoutingStrategies;

            var e = new Event(
                eventName,
                FixType(ownerType.ToString()),
                FixType(argsType.ToString()),
                FixType(eventType.ToString()),
                routingStrategies.ToString());
            events.Add(e);
        }

        var eventInfos = classType.GetEvents(BindingFlags.Public | BindingFlags.Instance | BindingFlags.DeclaredOnly);
        foreach (var eventInfo in eventInfos)
        {
            var eventName = eventInfo.Name;
            if (eventInfo.GetCustomAttributes().Any(x => x.GetType().Name == "ObsoleteAttribute"))
            {
                Log($"The {classType.Name}.{eventName} event is obsolete.");
                continue;
            }

            var eventHandlerType = eventInfo.EventHandlerType;
            if (eventHandlerType is null)
            {
                Log($"Could not find {classType.Name}.{eventName} event handler type.");
                continue;
            }

            if (!eventHandlerType.IsPublic)
            {
                Log($"The {classType.Name}.{eventName} event handler type {eventHandlerType.Name} is not public.");
                continue;
            }

            var argsType = eventHandlerType.GetGenericArguments().FirstOrDefault();
            if (argsType is null)
            {
                Log($"Could not find {classType.Name}.{eventName} event handler type {eventHandlerType.Name} generic arguments.");
                continue;
            }

            if (!argsType.IsPublic)
            {
                Log($"The {classType.Name}.{eventName} event handler type {eventHandlerType.Name} arguments {argsType.Name} are not public.");
                continue;
            }

            var e = new Event(
                eventName,
                FixType(classType.ToString()),
                FixType(argsType.ToString()),
                null,
                null);
            events.Add(e);
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
                Log($"The {classType.Name} class was excluded.");
                continue;
            }

            var publicCtor = classType.GetConstructors().Any(x => x.IsPublic && x.GetParameters().Length == 0);

            var properties = GetProperties(classType, registry);

            var events = GetEvents(classType, registry);

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
