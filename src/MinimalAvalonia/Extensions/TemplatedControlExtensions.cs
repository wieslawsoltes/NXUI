namespace MinimalAvalonia.Extensions;

/// <summary>
/// 
/// </summary>
public static partial class TemplatedControlExtensions
{
    // ControlTemplate

    /// <summary>
    /// 
    /// </summary>
    /// <param name="style"></param>
    /// <param name="build"></param>
    /// <typeparam name="T"></typeparam>
    /// <returns></returns>
    /// <exception cref="InvalidCastException"></exception>
    public static Style SetTemplatedControlTemplate<T>(this Style style, Func<T, INameScope, IControl> build) 
        where T : ITemplatedControl
    {
        var value = new FuncControlTemplate((parent, scope) =>
        {
            if (parent is T t)
            {
                return build(t, scope);
            }

            throw new InvalidCastException();
        });
        style.Setters.Add(new Setter(Avalonia.Controls.Primitives.TemplatedControl.TemplateProperty, value));
        return style;
    }
    
    // BorderThicknessProperty

    /// <summary>
    /// 
    /// </summary>
    /// <param name="templatedControl"></param>
    /// <param name="uniformLength"></param>
    /// <typeparam name="T"></typeparam>
    /// <returns></returns>
    public static T BorderThickness<T>(this T templatedControl, double uniformLength) where T : TemplatedControl
    {
        templatedControl[Avalonia.Controls.Primitives.TemplatedControl.BorderThicknessProperty] = new Thickness(uniformLength);
        return templatedControl;
    }

    /// <summary>
    /// 
    /// </summary>
    /// <param name="templatedControl"></param>
    /// <param name="horizontal"></param>
    /// <param name="vertical"></param>
    /// <typeparam name="T"></typeparam>
    /// <returns></returns>
    public static T BorderThickness<T>(this T templatedControl, double horizontal, double vertical) where T : TemplatedControl
    {
        templatedControl[Avalonia.Controls.Primitives.TemplatedControl.BorderThicknessProperty] = new Thickness(horizontal, vertical);
        return templatedControl;
    }

    /// <summary>
    /// 
    /// </summary>
    /// <param name="templatedControl"></param>
    /// <param name="left"></param>
    /// <param name="top"></param>
    /// <param name="right"></param>
    /// <param name="bottom"></param>
    /// <typeparam name="T"></typeparam>
    /// <returns></returns>
    public static T BorderThickness<T>(this T templatedControl, double left, double top, double right, double bottom) where T : TemplatedControl
    {
        templatedControl[Avalonia.Controls.Primitives.TemplatedControl.BorderThicknessProperty] = new Thickness(left, top, right, bottom);
        return templatedControl;
    }

    // CornerRadiusProperty

    /// <summary>
    /// 
    /// </summary>
    /// <param name="templatedControl"></param>
    /// <param name="uniformRadius"></param>
    /// <typeparam name="T"></typeparam>
    /// <returns></returns>
    public static T CornerRadius<T>(this T templatedControl, double uniformRadius) where T : TemplatedControl
    {
        templatedControl[Avalonia.Controls.Primitives.TemplatedControl.CornerRadiusProperty] = new CornerRadius(uniformRadius);
        return templatedControl;
    }

    /// <summary>
    /// 
    /// </summary>
    /// <param name="templatedControl"></param>
    /// <param name="top"></param>
    /// <param name="bottom"></param>
    /// <typeparam name="T"></typeparam>
    /// <returns></returns>
    public static T CornerRadius<T>(this T templatedControl, double top, double bottom) where T : TemplatedControl
    {
        templatedControl[Avalonia.Controls.Primitives.TemplatedControl.CornerRadiusProperty] = new CornerRadius(top, bottom);
        return templatedControl;
    }

    /// <summary>
    /// 
    /// </summary>
    /// <param name="templatedControl"></param>
    /// <param name="topLeft"></param>
    /// <param name="topRight"></param>
    /// <param name="bottomRight"></param>
    /// <param name="bottomLeft"></param>
    /// <typeparam name="T"></typeparam>
    /// <returns></returns>
    public static T CornerRadius<T>(this T templatedControl, double topLeft, double topRight, double bottomRight, double bottomLeft) where T : TemplatedControl
    {
        templatedControl[Avalonia.Controls.Primitives.TemplatedControl.CornerRadiusProperty] = new CornerRadius(topLeft, topRight, bottomRight, bottomLeft);
        return templatedControl;
    }

    // PaddingProperty

    /// <summary>
    /// 
    /// </summary>
    /// <param name="templatedControl"></param>
    /// <param name="uniformLength"></param>
    /// <typeparam name="T"></typeparam>
    /// <returns></returns>
    public static T Padding<T>(this T templatedControl, double uniformLength) where T : TemplatedControl
    {
        templatedControl[Avalonia.Controls.Primitives.TemplatedControl.PaddingProperty] = new Thickness(uniformLength);
        return templatedControl;
    }

    /// <summary>
    /// 
    /// </summary>
    /// <param name="templatedControl"></param>
    /// <param name="horizontal"></param>
    /// <param name="vertical"></param>
    /// <typeparam name="T"></typeparam>
    /// <returns></returns>
    public static T Padding<T>(this T templatedControl, double horizontal, double vertical) where T : TemplatedControl
    {
        templatedControl[Avalonia.Controls.Primitives.TemplatedControl.PaddingProperty] = new Thickness(horizontal, vertical);
        return templatedControl;
    }

    /// <summary>
    /// 
    /// </summary>
    /// <param name="templatedControl"></param>
    /// <param name="left"></param>
    /// <param name="top"></param>
    /// <param name="right"></param>
    /// <param name="bottom"></param>
    /// <typeparam name="T"></typeparam>
    /// <returns></returns>
    public static T Padding<T>(this T templatedControl, double left, double top, double right, double bottom) where T : TemplatedControl
    {
        templatedControl[Avalonia.Controls.Primitives.TemplatedControl.PaddingProperty] = new Thickness(left, top, right, bottom);
        return templatedControl;
    }
}
