namespace MinimalAvalonia.Extensions;

public static partial class WrapPanelExtensions
{
    public static T Orientation<T>(this T wrapPanel, Orientation orientation) where T : WrapPanel
    {
        wrapPanel[Avalonia.Controls.WrapPanel.OrientationProperty] = orientation;
        return wrapPanel;
    }

    public static T OrientationHorizontal<T>(this T wrapPanel) where T : WrapPanel
    {
        wrapPanel[Avalonia.Controls.WrapPanel.OrientationProperty] = Avalonia.Layout.Orientation.Horizontal;
        return wrapPanel;
    }

    public static T OrientationVertical<T>(this T wrapPanel) where T : WrapPanel
    {
        wrapPanel[Avalonia.Controls.WrapPanel.OrientationProperty] = Avalonia.Layout.Orientation.Vertical;
        return wrapPanel;
    }

    public static T ItemWidth<T>(this T wrapPanel, double itemWidth) where T : WrapPanel
    {
        wrapPanel[Avalonia.Controls.WrapPanel.ItemWidthProperty] = itemWidth;
        return wrapPanel;
    }

    public static T ItemHeight<T>(this T wrapPanel, double itemHeight) where T : WrapPanel
    {
        wrapPanel[Avalonia.Controls.WrapPanel.ItemHeightProperty] = itemHeight;
        return wrapPanel;
    }
}
