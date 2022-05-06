namespace MinimalAvalonia;

public static class LayoutableExtensions
{
    public static T Width<T>(this T layoutable, double width) where T : Layoutable
    {
        layoutable[Layoutable.WidthProperty] = width;
        return layoutable;
    }

    public static T Height<T>(this T layoutable, double height) where T : Layoutable
    {
        layoutable[Layoutable.HeightProperty] = height;
        return layoutable;
    }

    public static T MinWidth<T>(this T layoutable, double minWidth) where T : Layoutable
    {
        layoutable[Layoutable.MinWidthProperty] = minWidth;
        return layoutable;
    }

    public static T MaxWidth<T>(this T layoutable, double maxWidth) where T : Layoutable
    {
        layoutable[Layoutable.MaxWidthProperty] = maxWidth;
        return layoutable;
    }

    public static T MinHeight<T>(this T layoutable, double minHeight) where T : Layoutable
    {
        layoutable[Layoutable.MinHeightProperty] = minHeight;
        return layoutable;
    }

    public static T MaxHeight<T>(this T layoutable, double maxHeight) where T : Layoutable
    {
        layoutable[Layoutable.MaxHeightProperty] = maxHeight;
        return layoutable;
    }

    public static T Margin<T>(this T layoutable, double uniformLength) where T : Layoutable
    {
        layoutable[Layoutable.MarginProperty] = new Thickness(uniformLength);
        return layoutable;
    }

    public static T Margin<T>(this T layoutable, double horizontal, double vertical) where T : Layoutable
    {
        layoutable[Layoutable.MarginProperty] = new Thickness(horizontal, vertical);
        return layoutable;
    }

    public static T Margin<T>(this T layoutable, double left, double top, double right, double bottom) where T : Layoutable
    {
        layoutable[Layoutable.MarginProperty] = new Thickness(left, top, right, bottom);
        return layoutable;
    }

    public static T HorizontalAlignmentStretch<T>(this T layoutable) where T : Layoutable
    {
        layoutable[Layoutable.HorizontalAlignmentProperty] = HorizontalAlignment.Stretch;
        return layoutable;
    }

    public static T HorizontalAlignmentLeft<T>(this T layoutable) where T : Layoutable
    {
        layoutable[Layoutable.HorizontalAlignmentProperty] = HorizontalAlignment.Left;
        return layoutable;
    }

    public static T HorizontalAlignmentCenter<T>(this T layoutable) where T : Layoutable
    {
        layoutable[Layoutable.HorizontalAlignmentProperty] = HorizontalAlignment.Center;
        return layoutable;
    }

    public static T HorizontalAlignmentRight<T>(this T layoutable) where T : Layoutable
    {
        layoutable[Layoutable.HorizontalAlignmentProperty] = HorizontalAlignment.Right;
        return layoutable;
    }

    public static T VerticalAlignmentStretch<T>(this T layoutable) where T : Layoutable
    {
        layoutable[Layoutable.VerticalAlignmentProperty] = VerticalAlignment.Stretch;
        return layoutable;
    }

    public static T VerticalAlignmentTop<T>(this T layoutable) where T : Layoutable
    {
        layoutable[Layoutable.VerticalAlignmentProperty] = VerticalAlignment.Top;
        return layoutable;
    }

    public static T VerticalAlignmentCenter<T>(this T layoutable) where T : Layoutable
    {
        layoutable[Layoutable.VerticalAlignmentProperty] = VerticalAlignment.Center;
        return layoutable;
    }

    public static T VerticalAlignmentBottom<T>(this T layoutable) where T : Layoutable
    {
        layoutable[Layoutable.VerticalAlignmentProperty] = VerticalAlignment.Bottom;
        return layoutable;
    }

    public static T UseLayoutRounding<T>(this T layoutable, bool useLayoutRounding = true) where T : Layoutable
    {
        layoutable[Layoutable.UseLayoutRoundingProperty] = useLayoutRounding;
        return layoutable;
    }
}
