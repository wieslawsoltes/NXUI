namespace NXUI.Extensions;

#if NXUI_HOTRELOAD
using Avalonia;
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
            });
    }

    /// <summary>
    /// Applies uniform padding when using builders.
    /// </summary>
    public static ElementBuilder<TDecorator> Padding<TDecorator>(this ElementBuilder<TDecorator> decorator, double uniformLength)
        where TDecorator : Decorator
    {
        return decorator.Padding(new Thickness(uniformLength));
    }

    /// <summary>
    /// Applies horizontal/vertical padding when using builders.
    /// </summary>
    public static ElementBuilder<TDecorator> Padding<TDecorator>(this ElementBuilder<TDecorator> decorator, double horizontal, double vertical)
        where TDecorator : Decorator
    {
        return decorator.Padding(new Thickness(horizontal, vertical));
    }

    /// <summary>
    /// Applies per-edge padding when using builders.
    /// </summary>
    public static ElementBuilder<TDecorator> Padding<TDecorator>(this ElementBuilder<TDecorator> decorator, double left, double top, double right, double bottom)
        where TDecorator : Decorator
    {
        return decorator.Padding(new Thickness(left, top, right, bottom));
    }
#endif
    // PaddingProperty

    /// <summary>
    /// 
    /// </summary>
    /// <param name="decorator"></param>
    /// <param name="uniformLength"></param>
    /// <typeparam name="T"></typeparam>
    /// <returns></returns>
    public static T Padding<T>(this T decorator, double uniformLength) where T : Decorator
    {
        decorator[Avalonia.Controls.Decorator.PaddingProperty] = new Thickness(uniformLength);
        return decorator;
    }

    /// <summary>
    /// 
    /// </summary>
    /// <param name="decorator"></param>
    /// <param name="horizontal"></param>
    /// <param name="vertical"></param>
    /// <typeparam name="T"></typeparam>
    /// <returns></returns>
    public static T Padding<T>(this T decorator, double horizontal, double vertical) where T : Decorator
    {
        decorator[Avalonia.Controls.Decorator.PaddingProperty] = new Thickness(horizontal, vertical);
        return decorator;
    }

    /// <summary>
    /// 
    /// </summary>
    /// <param name="decorator"></param>
    /// <param name="left"></param>
    /// <param name="top"></param>
    /// <param name="right"></param>
    /// <param name="bottom"></param>
    /// <typeparam name="T"></typeparam>
    /// <returns></returns>
    public static T Padding<T>(this T decorator, double left, double top, double right, double bottom) where T : Decorator
    {
        decorator[Avalonia.Controls.Decorator.PaddingProperty] = new Thickness(left, top, right, bottom);
        return decorator;
    }
}
