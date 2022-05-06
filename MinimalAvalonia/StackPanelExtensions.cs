namespace MinimalAvalonia;

public static class StackPanelExtensions
{
    public static T Spacing<T>(this T stackPanel, double spacing) where T : StackPanel
    {
        stackPanel[StackPanel.SpacingProperty] = spacing;
        return stackPanel;
    }

    public static T OrientationHorizontal<T>(this T stackPanel) where T : StackPanel
    {
        stackPanel[StackPanel.OrientationProperty] = Orientation.Horizontal;
        return stackPanel;
    }

    public static T OrientationVertical<T>(this T stackPanel) where T : StackPanel
    {
        stackPanel[StackPanel.OrientationProperty] = Orientation.Vertical;
        return stackPanel;
    }
}
