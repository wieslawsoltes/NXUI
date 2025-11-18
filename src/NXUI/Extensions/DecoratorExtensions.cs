namespace NXUI.Extensions;

#if NXUI_HOTRELOAD
using NXUI.HotReload.Nodes;
#endif

/// <summary>
/// 
/// </summary>
public static partial class DecoratorExtensions
{
#if NXUI_HOTRELOAD
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
#endif
}
