namespace MinimalAvalonia.Interactivity;

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
