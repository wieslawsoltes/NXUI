namespace MinimalAvalonia.Extensions;

public static partial class TemplatedControlExtensions
{
    // ControlTemplate

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

    public static T BorderThickness<T>(this T templatedControl, double uniformLength) where T : TemplatedControl
    {
        templatedControl[Avalonia.Controls.Primitives.TemplatedControl.BorderThicknessProperty] = new Thickness(uniformLength);
        return templatedControl;
    }

    public static T BorderThickness<T>(this T templatedControl, double horizontal, double vertical) where T : TemplatedControl
    {
        templatedControl[Avalonia.Controls.Primitives.TemplatedControl.BorderThicknessProperty] = new Thickness(horizontal, vertical);
        return templatedControl;
    }

    public static T BorderThickness<T>(this T templatedControl, double left, double top, double right, double bottom) where T : TemplatedControl
    {
        templatedControl[Avalonia.Controls.Primitives.TemplatedControl.BorderThicknessProperty] = new Thickness(left, top, right, bottom);
        return templatedControl;
    }

    // CornerRadiusProperty

    public static T CornerRadius<T>(this T templatedControl, double uniformRadius) where T : TemplatedControl
    {
        templatedControl[Avalonia.Controls.Primitives.TemplatedControl.CornerRadiusProperty] = new CornerRadius(uniformRadius);
        return templatedControl;
    }

    public static T CornerRadius<T>(this T templatedControl, double top, double bottom) where T : TemplatedControl
    {
        templatedControl[Avalonia.Controls.Primitives.TemplatedControl.CornerRadiusProperty] = new CornerRadius(top, bottom);
        return templatedControl;
    }

    public static T CornerRadius<T>(this T templatedControl, double topLeft, double topRight, double bottomRight, double bottomLeft) where T : TemplatedControl
    {
        templatedControl[Avalonia.Controls.Primitives.TemplatedControl.CornerRadiusProperty] = new CornerRadius(topLeft, topRight, bottomRight, bottomLeft);
        return templatedControl;
    }

    // PaddingProperty

    public static T Padding<T>(this T templatedControl, double uniformLength) where T : TemplatedControl
    {
        templatedControl[Avalonia.Controls.Primitives.TemplatedControl.PaddingProperty] = new Thickness(uniformLength);
        return templatedControl;
    }

    public static T Padding<T>(this T templatedControl, double horizontal, double vertical) where T : TemplatedControl
    {
        templatedControl[Avalonia.Controls.Primitives.TemplatedControl.PaddingProperty] = new Thickness(horizontal, vertical);
        return templatedControl;
    }

    public static T Padding<T>(this T templatedControl, double left, double top, double right, double bottom) where T : TemplatedControl
    {
        templatedControl[Avalonia.Controls.Primitives.TemplatedControl.PaddingProperty] = new Thickness(left, top, right, bottom);
        return templatedControl;
    }
}
