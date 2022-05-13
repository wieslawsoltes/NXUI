namespace MinimalAvalonia.Extensions;

public static partial class PanelExtensions
{
    // Children

    public static T Children<T>(this T panel, Control child) where T : Panel
    {
        panel.Children.Add(child);
        return panel;
    }

    public static T Children<T>(this T panel, params IControl[] children) where T : Panel
    {
        panel.Children.AddRange(children);
        return panel;
    }
}
