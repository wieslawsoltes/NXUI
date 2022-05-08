using Avalonia.Collections;

namespace MinimalAvalonia.Controls;

public static class TabControlExtensions
{
    public static T Items<T>(this T tabControl, object item) where T : TabControl
    {
        switch (tabControl.Items)
        {
            case AvaloniaList<object> list:
                list.Add(item);
                break;
            default:
                tabControl.Items = new AvaloniaList<object>(item);
                break;
        }
        return tabControl;
    }

    public static T Items<T>(this T tabControl, params object[] items) where T : TabControl
    {
        switch (tabControl.Items)
        {
            case AvaloniaList<object> list:
                list.AddRange(items);
                break;
            default:
                tabControl.Items = new AvaloniaList<object>(items);
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
