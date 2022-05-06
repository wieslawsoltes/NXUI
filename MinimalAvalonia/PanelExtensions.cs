namespace MinimalAvalonia;

public static class PanelExtensions
{
    public static T Background<T>(this T panel, IBrush background) where T : Panel
    {
        panel[Panel.BackgroundProperty] = background;
        return panel;
    }

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
