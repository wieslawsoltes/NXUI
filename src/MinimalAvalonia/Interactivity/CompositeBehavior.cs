namespace MinimalAvalonia.Interactivity;

public class CompositeBehavior : Behavior
{
    public static readonly DirectProperty<CompositeBehavior, IEnumerable<Behavior>?> BehaviorsProperty =
        AvaloniaProperty.RegisterDirect<CompositeBehavior, IEnumerable<Behavior>?>(nameof(Behaviors), o => o.Behaviors, (o, v) => o.Behaviors = v);

    private IEnumerable<Behavior>? _behaviors = new AvaloniaList<Behavior>();

    static CompositeBehavior()
    {
        BehaviorsProperty.Changed.AddClassHandler<CompositeBehavior>((x, e) => x.ItemsChanged(e));
    }

    [Content]
    public IEnumerable<Behavior>? Behaviors
    {
        get { return _behaviors; }
        set { SetAndRaise(BehaviorsProperty, ref _behaviors, value); }
    }

    protected virtual void ItemsChanged(AvaloniaPropertyChangedEventArgs e)
    {
        if (e.OldValue is IEnumerable<Behavior> oldValue)
        {
            if (AssociatedObject is { })
            {
                foreach (var oldBehavior in oldValue)
                {
                    Interaction.Detach(e.Sender, oldBehavior);
                }
            }
        }

        if (e.NewValue is IEnumerable<Behavior> newValue)
        {
            foreach (var newBehavior in newValue)
            {
                Interaction.Attach(e.Sender, newBehavior);
            }
        }
    }

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
