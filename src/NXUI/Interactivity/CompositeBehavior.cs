namespace NXUI.Interactivity;

/// <summary>
/// 
/// </summary>
public class CompositeBehavior : Behavior
{
    /// <summary>
    /// 
    /// </summary>
    public static readonly DirectProperty<CompositeBehavior, IEnumerable<Behavior>?> BehaviorsProperty =
        AvaloniaProperty.RegisterDirect<CompositeBehavior, IEnumerable<Behavior>?>(
            nameof(Behaviors), 
            o => o.Behaviors, 
            (o, v) => o.Behaviors = v);

    private IEnumerable<Behavior>? _behaviors = new AvaloniaList<Behavior>();

    static CompositeBehavior()
    {
        BehaviorsProperty.Changed.AddClassHandler<CompositeBehavior>((x, e) => x.ItemsChanged(e));
    }

    /// <summary>
    /// 
    /// </summary>
    [Content]
    public IEnumerable<Behavior>? Behaviors
    {
        get { return _behaviors; }
        set { SetAndRaise(BehaviorsProperty, ref _behaviors, value); }
    }

    /// <summary>
    /// 
    /// </summary>
    /// <param name="e"></param>
    protected virtual void ItemsChanged(AvaloniaPropertyChangedEventArgs e)
    {
        if (e.OldValue is IEnumerable<Behavior> oldValue)
        {
            if (AssociatedObject is { })
            {
                foreach (var oldBehavior in oldValue)
                {
                    Interaction.Detach(AssociatedObject, oldBehavior);
                }
            }
        }

        if (e.NewValue is IEnumerable<Behavior> newValue)
        {
            if (AssociatedObject is { })
            {
                foreach (var newBehavior in newValue)
                {
                    Interaction.Attach(AssociatedObject, newBehavior);
                }
            }
        }
    }

    /// <summary>
    /// 
    /// </summary>
    protected override void OnAttached()
    {
        base.OnAttached();

        if (_behaviors is { } && AssociatedObject is { })
        {
            foreach (var behavior in _behaviors)
            {
                Interaction.Attach(AssociatedObject, behavior);
            }
        }
    }

    /// <summary>
    /// 
    /// </summary>
    protected override void OnDetaching()
    {
        base.OnDetaching();

        if (_behaviors is { } && AssociatedObject is { })
        {
            foreach (var behavior in _behaviors)
            {
                Interaction.Detach(AssociatedObject, behavior);
            }
        }
    }

    /// <summary>
    /// 
    /// </summary>
    protected override void OnAttachedToVisualTree()
    {
        base.OnAttachedToVisualTree();

        if (_behaviors is { } && AssociatedObject is { })
        {
            foreach (var behavior in _behaviors)
            {
                behavior.AttachedToVisualTree();
            }
        }
    }

    /// <summary>
    /// 
    /// </summary>
    protected override void OnDetachedFromVisualTree()
    {
        base.OnDetachedFromVisualTree();

        if (_behaviors is { } && AssociatedObject is { })
        {
            foreach (var behavior in _behaviors)
            {
                behavior.DetachedFromVisualTree();
            }
        }
    }
}
