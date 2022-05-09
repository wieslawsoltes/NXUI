namespace MinimalAvalonia.Controls;

public static class StackPanelExtensions
{
    public static T Spacing<T>(this T stackPanel, double spacing) where T : StackPanel
    {
        stackPanel[Avalonia.Controls.StackPanel.SpacingProperty] = spacing;
        return stackPanel;
    }

    public static T Orientation<T>(this T stackPanel, Orientation orientation) where T : StackPanel
    {
        stackPanel[Avalonia.Controls.StackPanel.OrientationProperty] = orientation;
        return stackPanel;
    }

    public static T OrientationHorizontal<T>(this T stackPanel) where T : StackPanel
    {
        stackPanel[Avalonia.Controls.StackPanel.OrientationProperty] = Avalonia.Layout.Orientation.Horizontal;
        return stackPanel;
    }

    public static T OrientationVertical<T>(this T stackPanel) where T : StackPanel
    {
        stackPanel[Avalonia.Controls.StackPanel.OrientationProperty] = Avalonia.Layout.Orientation.Vertical;
        return stackPanel;
    }
}
