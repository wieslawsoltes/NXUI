namespace MinimalAvalonia.Interactivity;

/// <summary>
/// 
/// </summary>
public abstract class Behavior : AvaloniaObject
{
    internal bool _isInitialized;

    /// <summary>
    /// 
    /// </summary>
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

    /// <summary>
    /// 
    /// </summary>
    protected virtual void OnAttached()
    {
    }

    /// <summary>
    /// 
    /// </summary>
    protected virtual void OnDetaching()
    {
    }

    /// <summary>
    /// 
    /// </summary>
    protected virtual void OnAttachedToVisualTree()
    {
    }

    /// <summary>
    /// 
    /// </summary>
    protected virtual void OnDetachedFromVisualTree()
    {
    }
}
