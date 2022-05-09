namespace MinimalAvalonia.Controls;

public static class TemplatedControlExtensions
{
    public static T Background<T>(this T templatedControl, IBrush background) where T : TemplatedControl
    {
        templatedControl[Avalonia.Controls.Primitives.TemplatedControl.BackgroundProperty] = background;
        return templatedControl;
    }

    public static T BorderBrush<T>(this T templatedControl, IBrush borderBrush) where T : TemplatedControl
    {
        templatedControl[Avalonia.Controls.Primitives.TemplatedControl.BorderBrushProperty] = borderBrush;
        return templatedControl;
    }

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

    public static T FontFamily<T>(this T templatedControl, FontFamily fontFamily) where T : TemplatedControl
    {
        templatedControl[Avalonia.Controls.Primitives.TemplatedControl.FontFamilyProperty] = fontFamily;
        return templatedControl;
    }

    public static T FontSize<T>(this T templatedControl, double fontSize) where T : TemplatedControl
    {
        templatedControl[Avalonia.Controls.Primitives.TemplatedControl.FontSizeProperty] = fontSize;
        return templatedControl;
    }

    public static T FontStyle<T>(this T templatedControl, FontStyle fontStyle) where T : TemplatedControl
    {
        templatedControl[Avalonia.Controls.Primitives.TemplatedControl.FontStyleProperty] = fontStyle;
        return templatedControl;
    }

    public static T FontWeight<T>(this T templatedControl, FontWeight fontWeight) where T : TemplatedControl
    {
        templatedControl[Avalonia.Controls.Primitives.TemplatedControl.FontWeightProperty] = fontWeight;
        return templatedControl;
    }

    public static T Foreground<T>(this T templatedControl, IBrush foreground) where T : TemplatedControl
    {
        templatedControl[Avalonia.Controls.Primitives.TemplatedControl.ForegroundProperty] = foreground;
        return templatedControl;
    }

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

    public static T Template<T>(this T templatedControl, IControlTemplate? template) where T : TemplatedControl
    {
        templatedControl[Avalonia.Controls.Primitives.TemplatedControl.TemplateProperty] = template;
        return templatedControl;
    }

    public static T IsTemplateFocusTarget<T>(this T control, bool isTemplateFocusTarget) where T : Control
    {
        control[Avalonia.Controls.Primitives.TemplatedControl.IsTemplateFocusTargetProperty] = isTemplateFocusTarget;
        return control;
    }

    // TODO:
    // TemplateAppliedEvent
}
