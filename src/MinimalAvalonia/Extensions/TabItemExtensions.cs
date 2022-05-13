namespace MinimalAvalonia.Extensions;

public static partial class TabItemExtensions
{
    // TabStripPlacementProperty

    public static T TabStripPlacement<T>(this T tabItem, Dock tabStripPlacement) where T : TabItem
    {
        tabItem[Avalonia.Controls.TabItem.TabStripPlacementProperty] = tabStripPlacement;
        return tabItem;
    }

    public static T TabStripPlacementLeft<T>(this T tabItem) where T : TabItem
    {
        tabItem[Avalonia.Controls.TabItem.TabStripPlacementProperty] = Dock.Left;
        return tabItem;
    }

    public static T TabStripPlacementBottom<T>(this T tabItem) where T : TabItem
    {
        tabItem[Avalonia.Controls.TabItem.TabStripPlacementProperty] = Dock.Bottom;
        return tabItem;
    }

    public static T TabStripPlacementRight<T>(this T tabItem) where T : TabItem
    {
        tabItem[Avalonia.Controls.TabItem.TabStripPlacementProperty] = Dock.Right;
        return tabItem;
    }

    public static T TabStripPlacementTop<T>(this T tabItem) where T : TabItem
    {
        tabItem[Avalonia.Controls.TabItem.TabStripPlacementProperty] = Dock.Top;
        return tabItem;
    }

    // IsSelectedProperty

    public static T IsSelected<T>(this T tabItem, bool isSelected) where T : TabItem
    {
        tabItem[Avalonia.Controls.TabItem.IsSelectedProperty] = isSelected;
        return tabItem;
    }
}
