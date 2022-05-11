namespace MinimalAvalonia.Extensions;

public static partial class BorderExtensions
{
    public static T Background<T>(this T border, IBrush background) where T : Border
    {
        border[Avalonia.Controls.Border.BackgroundProperty] = background;
        return border;
    }

    public static T BorderBrush<T>(this T border, IBrush borderBrush) where T : Border
    {
        border[Avalonia.Controls.Border.BorderBrushProperty] = borderBrush;
        return border;
    }

    public static T BorderThickness<T>(this T border, double uniformLength) where T : Border
    {
        border[Avalonia.Controls.Border.BorderThicknessProperty] = new Thickness(uniformLength);
        return border;
    }

    public static T BorderThickness<T>(this T border, double horizontal, double vertical) where T : Border
    {
        border[Avalonia.Controls.Border.BorderThicknessProperty] = new Thickness(horizontal, vertical);
        return border;
    }

    public static T BorderThickness<T>(this T border, double left, double top, double right, double bottom) where T : Border
    {
        border[Avalonia.Controls.Border.BorderThicknessProperty] = new Thickness(left, top, right, bottom);
        return border;
    }

    public static T CornerRadius<T>(this T border, double uniformRadius) where T : Border
    {
        border[Avalonia.Controls.Border.CornerRadiusProperty] = new CornerRadius(uniformRadius);
        return border;
    }

    public static T CornerRadius<T>(this T border, double top, double bottom) where T : Border
    {
        border[Avalonia.Controls.Border.CornerRadiusProperty] = new CornerRadius(top, bottom);
        return border;
    }

    public static T CornerRadius<T>(this T border, double topLeft, double topRight, double bottomRight, double bottomLeft) where T : Border
    {
        border[Avalonia.Controls.Border.CornerRadiusProperty] = new CornerRadius(topLeft, topRight, bottomRight, bottomLeft);
        return border;
    }

    public static T BoxShadow<T>(this T border, BoxShadows boxShadows) where T : Border
    {
        border[Avalonia.Controls.Border.BoxShadowProperty] = boxShadows;
        return border;
    }

    public static T BorderDashOffset<T>(this T border, double borderDashOffset) where T : Border
    {
        border[Avalonia.Controls.Border.BorderDashOffsetProperty] = borderDashOffset;
        return border;
    }

    public static T BorderDashArray<T>(this T border, AvaloniaList<double>? borderDashArray) where T : Border
    {
        border[Avalonia.Controls.Border.BorderDashArrayProperty] = borderDashArray;
        return border;
    }

    public static T BorderLineCap<T>(this T border, PenLineCap borderLineCap) where T : Border
    {
        border[Avalonia.Controls.Border.BorderLineCapProperty] = borderLineCap;
        return border;
    }

    public static T BorderLineJoin<T>(this T border, PenLineJoin borderLineJoin) where T : Border
    {
        border[Avalonia.Controls.Border.BorderLineJoinProperty] = borderLineJoin;
        return border;
    }
}
