using System.Reflection;
using Avalonia;
using Generator.Model;

namespace Generator;

public static class Factory
{
    public static string ToString(Type? type)
    {
        return type is null 
            ? string.Empty 
            : FixType(type.ToString());
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

    private static Type[] GetClassTypes(Predicate<Assembly> assemblyFilter, Predicate<Type> typeFilter)
    {
       return(
           from assembly in AppDomain.CurrentDomain.GetAssemblies()
           where assembly?.FullName is not null 
                 && assemblyFilter(assembly)
           from assemblyType in assembly.GetTypes()
           where assemblyType is not null 
                 && typeFilter(assemblyType)
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
            Log.Error($"Could not find registered properties.");
            return properties;
        }

        registry.RegisteredProperties.TryGetValue(classType, out var registeredPropertiesDict);
        if (registeredPropertiesDict is null)
        {
            Log.Info($"No registered properties for `{classType.Name}`.");
            return properties;
        }

        var avaloniaProperties = registeredPropertiesDict.Values;
        foreach (var property in avaloniaProperties)
        {
            var propertyName = property.Name;
            var fieldInfo = classType.GetField($"{propertyName}Property", BindingFlags.Public | BindingFlags.NonPublic | BindingFlags.Static);
            if (fieldInfo is null)
            {
                Log.Error($"Could not find field for `{classType.Name}.{propertyName}Property`.");
                continue;
            }

            if (!fieldInfo.IsPublic)
            {
                Log.Info($"The `{classType.Name}.{propertyName}Property` field is not public.");
                continue;
            }

            if (fieldInfo.GetCustomAttributes().Any(x => x.GetType().Name == "ObsoleteAttribute"))
            {
                Log.Info($"The `{classType.Name}.{propertyName}Property` field is obsolete.");
                continue;
            }

            if (!property.PropertyType.IsPublic)
            {
                Log.Info($"The `{classType.Name}.{propertyName}Property` property type `{property.PropertyType.Name}` is not public.");
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
                            Log.Info($"Attached property `{classType.Name}.{propertyName}Property` registered owner type changed from `{ownerType.Name}` to `{kvp1.Key.Name}`.");
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

                Log.Info($"Attached property `{classType.Name}.{propertyName}Property` registered owner type changed from `{ownerType.Name}` to `{classType.Name}`.");
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
                ownerType,
                valueType,
                propertyType,
                alreadyExists,
                property.IsReadOnly,
                isEnum,
                isEnum ? enumNames.ToArray() : null);
            properties.Add(p);
            Log.Info($"Added `{classType.Name}.{propertyName}Property` property.");
        }

        return properties;
    }
    
    private static List<Event> GetEvents(Type classType, Registry registry)
    {
        var events = new List<Event>();

        if (registry.RegisteredRoutedEvents is null)
        {
            Log.Error($"Could not find registered routed events.");
            return events;
        }

        registry.RegisteredRoutedEvents.TryGetValue(classType, out var registeredRoutedEventsDict);
        if (registeredRoutedEventsDict is null)
        {
            Log.Info($"No registered routed events for `{classType.Name}`.");
            return events;
        }

        var avaloniaRoutedEvents = registeredRoutedEventsDict;
        foreach (var routedEvent in avaloniaRoutedEvents)
        {
            var eventName = routedEvent.Name;
            var fieldInfo = classType.GetField($"{eventName}Event", BindingFlags.Public | BindingFlags.NonPublic | BindingFlags.Static);
            if (fieldInfo is null)
            {
                Log.Error($"Could not find field for `{classType.Name}.{eventName}Event`.");
                continue;
            }

            if (!fieldInfo.IsPublic)
            {
                Log.Info($"The `{classType.Name}.{eventName}Event` field is not public.");
                continue;
            }

            if (fieldInfo.GetCustomAttributes().Any(x => x.GetType().Name == "ObsoleteAttribute"))
            {
                Log.Info($"The `{classType.Name}.{eventName}Event` field is obsolete.");
                continue;
            }

            if (!routedEvent.EventArgsType.IsPublic)
            {
                Log.Info($"The` {classType.Name}.{eventName}Event` args type `{routedEvent.EventArgsType.Name}` is not public.");
                continue;
            }

            var eventType = fieldInfo.FieldType; // property.GetType()

            var argsType = routedEvent.EventArgsType;
            var ownerType = routedEvent.OwnerType;
            var routingStrategies = routedEvent.RoutingStrategies;

            var e = new Event(
                eventName,
                ownerType,
                argsType,
                eventType,
                routingStrategies.ToString());
            events.Add(e);
            Log.Info($"Added `{classType.Name}.{eventName}Event` routed event.");
        }

        var eventInfos = classType.GetEvents(BindingFlags.Public | BindingFlags.Instance | BindingFlags.DeclaredOnly);
        foreach (var eventInfo in eventInfos)
        {
            var eventName = eventInfo.Name;
            if (eventInfo.GetCustomAttributes().Any(x => x.GetType().Name == "ObsoleteAttribute"))
            {
                Log.Info($"The `{classType.Name}.{eventName}` event is obsolete.");
                continue;
            }

            var eventHandlerType = eventInfo.EventHandlerType;
            if (eventHandlerType is null)
            {
                Log.Error($"Could not find `{classType.Name}.{eventName}` event handler type.");
                continue;
            }

            if (!eventHandlerType.IsPublic)
            {
                Log.Info($"The `{classType.Name}.{eventName}` event handler type `{eventHandlerType.Name}` is not public.");
                continue;
            }

            var argsType = eventHandlerType.GetGenericArguments().FirstOrDefault();
            if (argsType is null)
            {
                Log.Info($"Using default event args `for `{classType.Name}.{eventName}` event.");
            }

            if (argsType is { IsPublic: false })
            {
                Log.Info($"The `{classType.Name}.{eventName}` event handler type `{eventHandlerType.Name}` arguments `{argsType.Name}` are not public.");
                continue;
            }

            var e = new Event(
                eventName,
                classType,
                argsType,
                null,
                null);
            events.Add(e);
            Log.Info($"Added `{classType.Name}.{eventName}` event.");
        }

        return events;
    }

    public static List<Class>? CreateClasses(Predicate<Assembly> assemblyFilter, Predicate<Type> typeFilter)
    {
        var classTypes = GetClassTypes(assemblyFilter, typeFilter);
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
            var publicCtor = classType.GetConstructors().Any(x => x.IsPublic && x.GetParameters().Length == 0);

            var properties = GetProperties(classType, registry);

            var events = GetEvents(classType, registry);

            var c = new Class(
                FixClassNameType(classType.Name),
                classType,
                properties.ToArray(),
                events.ToArray(),
                classType.IsSealed,
                publicCtor,
                classType.IsAbstract);
            classes.Add(c);
            Log.Info($"The `{classType.Name}` class has {properties.Count} properties and {events.Count} events.");
        }

        Log.Info($"Found {classes.Count} classes with total of {classes.SelectMany(x => x.Properties).Count()} properties and {classes.SelectMany(x => x.Events).Count()} events.");

        return classes;
    }
}
