namespace MinimalAvalonia.Interactivity;

/// <summary>
/// 
/// </summary>
public class Interaction
{
    static Interaction() => BehaviorProperty.Changed.Subscribe(BehaviorChanged);

    /// <summary>
    /// 
    /// </summary>
    public static readonly AttachedProperty<Behavior?> BehaviorProperty =
        AvaloniaProperty.RegisterAttached<Interaction, AvaloniaObject, Behavior?>("Behavior");

    /// <summary>
    /// 
    /// </summary>
    /// <param name="obj"></param>
    /// <returns></returns>
    /// <exception cref="ArgumentNullException"></exception>
    public static Behavior? GetBehavior(AvaloniaObject obj)
    {
        if (obj is null)
        {
            throw new ArgumentNullException(nameof(obj));
        }

        var behavior = obj.GetValue(BehaviorProperty);
        if (behavior is not null && behavior._isInitialized == false)
        {
            behavior._isInitialized = true;
            SetVisualTreeEventHandlersInitial(obj);
        }

        return behavior;
    }

    /// <summary>
    /// 
    /// </summary>
    /// <param name="obj"></param>
    /// <param name="value"></param>
    /// <exception cref="ArgumentNullException"></exception>
    public static void SetBehavior(AvaloniaObject obj, Behavior? value)
    {
        if (obj is null)
        {
            throw new ArgumentNullException(nameof(obj));
        }
        obj.SetValue(BehaviorProperty, value);
    }

    private static void BehaviorChanged(AvaloniaPropertyChangedEventArgs<Behavior?> e)
    {
        var oldBehavior = e.OldValue.GetValueOrDefault();
        var newBehavior = e.NewValue.GetValueOrDefault();

        if (Equals(oldBehavior, newBehavior))
        {
            return;
        }

        if (oldBehavior is { })
        {
            Detach(e.Sender, oldBehavior);
        }

        if (newBehavior is { })
        {
            Attach(e.Sender, newBehavior);
        }
    }

    internal static void Attach(IAvaloniaObject sender, Behavior behavior)
    {
        if (behavior is {_isInitialized: false})
        {
            behavior._isInitialized = true;
            behavior.Attach(sender);
            SetVisualTreeEventHandlersRuntime(sender);
        }
    }

    internal static void Detach(IAvaloniaObject sender, Behavior behavior)
    {
        if (behavior is { AssociatedObject: { } })
        {
            behavior.Detach();
        }
    }

    private static void SetVisualTreeEventHandlersInitial(IAvaloniaObject obj)
    {
        if (obj is not Control control)
        {
            return;
        }

        control.AttachedToVisualTree -= Control_AttachedToVisualTreeRuntime;
        control.DetachedFromVisualTree -= Control_DetachedFromVisualTreeRuntime;

        control.AttachedToVisualTree -= Control_AttachedToVisualTreeInitial;
        control.AttachedToVisualTree += Control_AttachedToVisualTreeInitial;

        control.DetachedFromVisualTree -= Control_DetachedFromVisualTreeInitial;
        control.DetachedFromVisualTree += Control_DetachedFromVisualTreeInitial;
    }

    private static void SetVisualTreeEventHandlersRuntime(IAvaloniaObject obj)
    {
        if (obj is not Control control)
        {
            return;
        }

        control.AttachedToVisualTree -= Control_AttachedToVisualTreeInitial;
        control.DetachedFromVisualTree -= Control_DetachedFromVisualTreeInitial;

        control.AttachedToVisualTree -= Control_AttachedToVisualTreeRuntime;
        control.AttachedToVisualTree += Control_AttachedToVisualTreeRuntime;

        control.DetachedFromVisualTree -= Control_DetachedFromVisualTreeRuntime;
        control.DetachedFromVisualTree += Control_DetachedFromVisualTreeRuntime;
    }

    private static void Control_AttachedToVisualTreeInitial(object? sender, VisualTreeAttachmentEventArgs e)
    {
        if (sender is AvaloniaObject d)
        {
            if (GetBehavior(d) is { } behavior)
            {
                behavior.Attach(d);
                behavior.AttachedToVisualTree();
            }
        }
    }

    private static void Control_DetachedFromVisualTreeInitial(object? sender, VisualTreeAttachmentEventArgs e)
    {
        if (sender is AvaloniaObject d)
        {
            if (GetBehavior(d) is { } behavior)
            {
                behavior.DetachedFromVisualTree();
                behavior.Detach();
            }
        }
    }
 
    private static void Control_AttachedToVisualTreeRuntime(object? sender, VisualTreeAttachmentEventArgs e)
    {
        if (sender is AvaloniaObject d)
        {
            if (GetBehavior(d) is { } behavior)
            {
                behavior.AttachedToVisualTree();
            }
        }
    }

    private static void Control_DetachedFromVisualTreeRuntime(object? sender, VisualTreeAttachmentEventArgs e)
    {
        if (sender is AvaloniaObject d)
        {
            if (GetBehavior(d) is { } behavior)
            {
                behavior.DetachedFromVisualTree();
            }
        }
    }
}
