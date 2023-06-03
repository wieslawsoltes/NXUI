// ReSharper disable InconsistentNaming
namespace NXUI.FSharp.Extensions;

/// <summary>
/// 
/// </summary>
public static partial class DecoratorExtensions
{
    // PaddingProperty

    /// <summary>
    /// 
    /// </summary>
    /// <param name="decorator"></param>
    /// <param name="uniformLength"></param>
    /// <typeparam name="T"></typeparam>
    /// <returns></returns>
    public static T padding<T>(this T decorator, double uniformLength) where T : Decorator
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
    public static T padding<T>(this T decorator, double horizontal, double vertical) where T : Decorator
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
    public static T padding<T>(this T decorator, double left, double top, double right, double bottom) where T : Decorator
    {
        decorator[Avalonia.Controls.Decorator.PaddingProperty] = new Thickness(left, top, right, bottom);
        return decorator;
    }
}
