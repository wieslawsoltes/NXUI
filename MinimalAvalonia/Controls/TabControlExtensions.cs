using Avalonia.Collections;

namespace MinimalAvalonia.Controls;

public static class TabControlExtensions
{
    public static T TabItem<T>(this T tabControl, TabItem tabItem) where T : TabControl
    {
        switch (tabControl.Items)
        {
            case AvaloniaList<TabItem> list:
                list.Add(tabItem);
                break;
            default:
                tabControl.Items = new AvaloniaList<TabItem>(tabItem);
                break;
        }
        return tabControl;
    }

    public static T TabItem<T>(this T tabControl, params TabItem[] tabItems) where T : TabControl
    {
        switch (tabControl.Items)
        {
            case AvaloniaList<TabItem> list:
                list.AddRange(tabItems);
                break;
            default:
                tabControl.Items = new AvaloniaList<TabItem>(tabItems);
                break;
        }
        return tabControl;
    }

    public static T TabStripPlacementLeft<T>(this T tabControl) where T : TabControl
    {
        tabControl[TabControl.TabStripPlacementProperty] = Dock.Left;
        return tabControl;
    }

    public static T TabStripPlacementBottom<T>(this T tabControl) where T : TabControl
    {
        tabControl[TabControl.TabStripPlacementProperty] = Dock.Bottom;
        return tabControl;
    }

    public static T TabStripPlacementRight<T>(this T tabControl) where T : TabControl
    {
        tabControl[TabControl.TabStripPlacementProperty] = Dock.Right;
        return tabControl;
    }

    public static T TabStripPlacementTop<T>(this T tabControl) where T : TabControl
    {
        tabControl[TabControl.TabStripPlacementProperty] = Dock.Top;
        return tabControl;
    }

    // TODO:
    // HorizontalContentAlignmentProperty
    // VerticalContentAlignmentProperty
    // ContentTemplateProperty
    // SelectedContentProperty
    // SelectedContentTemplateProperty
}
