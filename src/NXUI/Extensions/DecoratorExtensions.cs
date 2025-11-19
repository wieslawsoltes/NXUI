namespace NXUI.Extensions;

using NXUI.HotReload.Nodes;

/// <summary>
/// 
/// </summary>
public static partial class DecoratorExtensions
{
    /// <summary>
    /// Records a builder child for hot reload builds.
    /// </summary>
    public static ElementBuilder<TDecorator> Child<TDecorator, TChild>(
        this ElementBuilder<TDecorator> decorator,
        ElementBuilder<TChild> child)
        where TDecorator : Decorator
        where TChild : Control
    {
        return decorator.WithChild(
            child,
            static (parent, builtChild) =>
            {
                ((Decorator)parent).Child = builtChild;
            },
            ChildSlot.Content);
    }
}
