namespace MinimalAvalonia.Extensions;

public static partial class LayoutableExtensions
{
    // MarginProperty

    public static T Margin<T>(this T layoutable, double uniformLength) where T : Layoutable
    {
        layoutable[Avalonia.Layout.Layoutable.MarginProperty] = new Thickness(uniformLength);
        return layoutable;
    }

    public static T Margin<T>(this T layoutable, double horizontal, double vertical) where T : Layoutable
    {
        layoutable[Avalonia.Layout.Layoutable.MarginProperty] = new Thickness(horizontal, vertical);
        return layoutable;
    }

    public static T Margin<T>(this T layoutable, double left, double top, double right, double bottom) where T : Layoutable
    {
        layoutable[Avalonia.Layout.Layoutable.MarginProperty] = new Thickness(left, top, right, bottom);
        return layoutable;
    }
}
