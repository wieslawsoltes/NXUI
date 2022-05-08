namespace MinimalAvalonia.Controls;

public static class TabItemExtensions
{
    public static T TabStripPlacementLeft<T>(this T tabItem) where T : TabItem
    {
        tabItem[TabItem.TabStripPlacementProperty] = Dock.Left;
        return tabItem;
    }

    public static T TabStripPlacementBottom<T>(this T tabItem) where T : TabItem
    {
        tabItem[TabItem.TabStripPlacementProperty] = Dock.Bottom;
        return tabItem;
    }

    public static T TabStripPlacementRight<T>(this T tabItem) where T : TabItem
    {
        tabItem[TabItem.TabStripPlacementProperty] = Dock.Right;
        return tabItem;
    }

    public static T TabStripPlacementTop<T>(this T tabItem) where T : TabItem
    {
        tabItem[TabItem.TabStripPlacementProperty] = Dock.Top;
        return tabItem;
    }

    public static T IsSelected<T>(this T tabItem, bool isSelected) where T : TabItem
    {
        tabItem[TabItem.IsSelectedProperty] = isSelected;
        return tabItem;
    }
}