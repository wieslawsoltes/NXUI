namespace MinimalAvalonia.Extensions;

public static partial class BorderExtensions
{
    // BorderThicknessProperty

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

    // CornerRadiusProperty

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
}
