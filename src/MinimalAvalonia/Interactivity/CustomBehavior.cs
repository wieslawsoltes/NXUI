namespace MinimalAvalonia.Interactivity;

public class CustomBehavior : Behavior
{
    protected override void OnAttached()
    {
        Debug.WriteLine($"OnAttached() {AssociatedObject}");
        base.OnAttached();
    }

    protected override void OnDetaching()
    {
        Debug.WriteLine($"OnDetaching() {AssociatedObject}");
        base.OnDetaching();
    }

    protected override void OnAttachedToVisualTree()
    {
        Debug.WriteLine($"OnAttachedToVisualTree() {AssociatedObject}");
        base.OnAttachedToVisualTree();
    }

    protected override void OnDetachedFromVisualTree()
    {
        Debug.WriteLine($"OnDetachedFromVisualTree() {AssociatedObject}");
        base.OnDetachedFromVisualTree();
    }
}
