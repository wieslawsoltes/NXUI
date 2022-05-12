namespace MinimalAvalonia.Extensions;

public static partial class TabControlExtensions
{
    // ItemsProperty

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
}
