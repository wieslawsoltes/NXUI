namespace MinimalAvalonia.Controls;

public static class BorderExtensions
{
    public static T Background<T>(this T border, IBrush background) where T : Border
    {
        border[Border.BackgroundProperty] = background;
        return border;
    }

    public static T BorderBrush<T>(this T border, IBrush borderBrush) where T : Border
    {
        border[Border.BorderBrushProperty] = borderBrush;
        return border;
    }

    public static T BorderThickness<T>(this T border, double uniformLength) where T : Border
    {
        border[Border.BorderThicknessProperty] = new Thickness(uniformLength);
        return border;
    }

    public static T BorderThickness<T>(this T border, double horizontal, double vertical) where T : Border
    {
        border[Border.BorderThicknessProperty] = new Thickness(horizontal, vertical);
        return border;
    }

    public static T BorderThickness<T>(this T border, double left, double top, double right, double bottom) where T : Border
    {
        border[Border.BorderThicknessProperty] = new Thickness(left, top, right, bottom);
        return border;
    }
    
    // TODO:
    // CornerRadiusProperty
    // BoxShadowProperty
    // BorderDashOffsetProperty
    // BorderDashArrayProperty
    // BorderLineCapProperty
    // BorderLineJoinProperty
}
