﻿using Avalonia.Markup.Xaml.Templates;
using Avalonia.Metadata;

namespace MinimalAvalonia;

public class CustomBehavior : Behavior
{
    protected override void OnAttached()
    {
        Debug.WriteLine($"{AssociatedObject}");
        base.OnAttached();
    }

    protected override void OnDetaching()
    {
        base.OnDetaching();
    }

    protected override void OnAttachedToVisualTree()
    {
        base.OnAttachedToVisualTree();
    }

    protected override void OnDetachedFromVisualTree()
    {
        base.OnDetachedFromVisualTree();
    }
}

public class BehaviorTemplate : ITemplate
{
    [Content]
    [TemplateContent(TemplateResultType = typeof(Behavior))]
    public object? Content { get; set; }

    object? ITemplate.Build() => TemplateContent.Load<Behavior>(Content).Result;
}

public abstract class Behavior : AvaloniaObject
{
    internal bool _isInitialized;

    public IAvaloniaObject? AssociatedObject { get; private set; }

    internal void Attach(IAvaloniaObject obj)
    {
        AssociatedObject = obj;
        OnAttached();
    }

    internal void Detach()
    {
        OnDetaching();
        AssociatedObject = null;
    }

    internal void AttachedToVisualTree()
    {
        OnAttachedToVisualTree();
    }

    internal void DetachedFromVisualTree()
    {
        OnDetachedFromVisualTree();
    }

    protected virtual void OnAttached()
    {
    }

    protected virtual void OnDetaching()
    {
    }
    
    protected virtual void OnAttachedToVisualTree()
    {
    }

    protected virtual void OnDetachedFromVisualTree()
    {
    }
}

public class Interaction
{
    static Interaction() => BehaviorProperty.Changed.Subscribe(BehaviorChanged);

    public static readonly AttachedProperty<Behavior?> BehaviorProperty =
        AvaloniaProperty.RegisterAttached<Interaction, AvaloniaObject, Behavior?>("Behavior");

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

        if (oldBehavior is { AssociatedObject: { } })
        {
            oldBehavior.Detach();
        }

        if (newBehavior is { _isInitialized: false })
        {
            newBehavior._isInitialized = true;
            newBehavior.Attach(e.Sender);
            SetVisualTreeEventHandlersRuntime(e.Sender);
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