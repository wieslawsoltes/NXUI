namespace MinimalAvalonia.Extensions;

/// <summary>
/// 
/// </summary>
public static partial class BorderExtensions
{
    // BorderThicknessProperty

    /// <summary>
    /// 
    /// </summary>
    /// <param name="border"></param>
    /// <param name="uniformLength"></param>
    /// <typeparam name="T"></typeparam>
    /// <returns></returns>
    public static T BorderThickness<T>(this T border, double uniformLength) where T : Border
    {
        border[Avalonia.Controls.Border.BorderThicknessProperty] = new Thickness(uniformLength);
        return border;
    }

    /// <summary>
    /// 
    /// </summary>
    /// <param name="border"></param>
    /// <param name="horizontal"></param>
    /// <param name="vertical"></param>
    /// <typeparam name="T"></typeparam>
    /// <returns></returns>
    public static T BorderThickness<T>(this T border, double horizontal, double vertical) where T : Border
    {
        border[Avalonia.Controls.Border.BorderThicknessProperty] = new Thickness(horizontal, vertical);
        return border;
    }

    /// <summary>
    /// 
    /// </summary>
    /// <param name="border"></param>
    /// <param name="left"></param>
    /// <param name="top"></param>
    /// <param name="right"></param>
    /// <param name="bottom"></param>
    /// <typeparam name="T"></typeparam>
    /// <returns></returns>
    public static T BorderThickness<T>(this T border, double left, double top, double right, double bottom) where T : Border
    {
        border[Avalonia.Controls.Border.BorderThicknessProperty] = new Thickness(left, top, right, bottom);
        return border;
    }

    // CornerRadiusProperty

    /// <summary>
    /// 
    /// </summary>
    /// <param name="border"></param>
    /// <param name="uniformRadius"></param>
    /// <typeparam name="T"></typeparam>
    /// <returns></returns>
    public static T CornerRadius<T>(this T border, double uniformRadius) where T : Border
    {
        border[Avalonia.Controls.Border.CornerRadiusProperty] = new CornerRadius(uniformRadius);
        return border;
    }

    /// <summary>
    /// 
    /// </summary>
    /// <param name="border"></param>
    /// <param name="top"></param>
    /// <param name="bottom"></param>
    /// <typeparam name="T"></typeparam>
    /// <returns></returns>
    public static T CornerRadius<T>(this T border, double top, double bottom) where T : Border
    {
        border[Avalonia.Controls.Border.CornerRadiusProperty] = new CornerRadius(top, bottom);
        return border;
    }

    /// <summary>
    /// 
    /// </summary>
    /// <param name="border"></param>
    /// <param name="topLeft"></param>
    /// <param name="topRight"></param>
    /// <param name="bottomRight"></param>
    /// <param name="bottomLeft"></param>
    /// <typeparam name="T"></typeparam>
    /// <returns></returns>
    public static T CornerRadius<T>(this T border, double topLeft, double topRight, double bottomRight, double bottomLeft) where T : Border
    {
        border[Avalonia.Controls.Border.CornerRadiusProperty] = new CornerRadius(topLeft, topRight, bottomRight, bottomLeft);
        return border;
    }
}
