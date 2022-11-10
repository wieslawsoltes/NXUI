namespace NXUI.Extensions;

/// <summary>
/// 
/// </summary>
public static partial class LayoutableExtensions
{
    // MarginProperty

    /// <summary>
    /// 
    /// </summary>
    /// <param name="layoutable"></param>
    /// <param name="uniformLength"></param>
    /// <typeparam name="T"></typeparam>
    /// <returns></returns>
    public static T Margin<T>(this T layoutable, double uniformLength) where T : Layoutable
    {
        layoutable[Avalonia.Layout.Layoutable.MarginProperty] = new Thickness(uniformLength);
        return layoutable;
    }

    /// <summary>
    /// 
    /// </summary>
    /// <param name="layoutable"></param>
    /// <param name="horizontal"></param>
    /// <param name="vertical"></param>
    /// <typeparam name="T"></typeparam>
    /// <returns></returns>
    public static T Margin<T>(this T layoutable, double horizontal, double vertical) where T : Layoutable
    {
        layoutable[Avalonia.Layout.Layoutable.MarginProperty] = new Thickness(horizontal, vertical);
        return layoutable;
    }

    /// <summary>
    /// 
    /// </summary>
    /// <param name="layoutable"></param>
    /// <param name="left"></param>
    /// <param name="top"></param>
    /// <param name="right"></param>
    /// <param name="bottom"></param>
    /// <typeparam name="T"></typeparam>
    /// <returns></returns>
    public static T Margin<T>(this T layoutable, double left, double top, double right, double bottom) where T : Layoutable
    {
        layoutable[Avalonia.Layout.Layoutable.MarginProperty] = new Thickness(left, top, right, bottom);
        return layoutable;
    }
}
