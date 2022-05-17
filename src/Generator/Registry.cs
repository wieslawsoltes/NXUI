using System.Reflection;
using Avalonia;
using Avalonia.Interactivity;

namespace Generator;

internal class Registry
{
    private static readonly FieldInfo? s_registered = 
        typeof(AvaloniaPropertyRegistry).GetField("_registered", BindingFlags.NonPublic | BindingFlags.Instance);

    private static readonly FieldInfo? s_attached = 
        typeof(AvaloniaPropertyRegistry).GetField("_attached", BindingFlags.NonPublic | BindingFlags.Instance);

    private static readonly FieldInfo? s_registeredRoutedEvents = 
        typeof(RoutedEventRegistry).GetField("_registeredRoutedEvents", BindingFlags.NonPublic | BindingFlags.Instance);

    public Dictionary<Type, Dictionary<int, AvaloniaProperty>>? RegisteredProperties { get; }

    public Dictionary<Type, Dictionary<int, AvaloniaProperty>>? RegisteredAttachedProperties { get; }

    public Dictionary<Type, List<RoutedEvent>>? RegisteredRoutedEvents { get; }

    public Registry(Type[] classTypes)
    {
        foreach (var classType in classTypes)
        {
            System.Runtime.CompilerServices.RuntimeHelpers.RunClassConstructor(classType.TypeHandle);
        }

        RegisteredProperties = (Dictionary<Type, Dictionary<int, AvaloniaProperty>>?)
            s_registered?.GetValue(AvaloniaPropertyRegistry.Instance);

        RegisteredAttachedProperties = (Dictionary<Type, Dictionary<int, AvaloniaProperty>>?)
            s_attached?.GetValue(AvaloniaPropertyRegistry.Instance);

        RegisteredRoutedEvents = (Dictionary<Type, List<RoutedEvent>>?)
            s_registeredRoutedEvents?.GetValue(RoutedEventRegistry.Instance);
    }
}
