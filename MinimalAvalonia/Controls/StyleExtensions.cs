namespace MinimalAvalonia.Controls;

public static class StyleExtensions
{
    public static T Selector<T>(this T style, Func<Selector?, Selector> selector) where T : Style
    {
        style.Selector = selector(null);
        return style;
    }

    public static T Setters<T>(this T style, params ISetter[] setters) where T : Style
    {
        foreach (var setter in setters)
        {
            style.Setters.Add(setter);
        }
        return style;
    }

    public static T Setter<T>(this T style, AvaloniaProperty property, object value) where T : Style
    {
        style.Setters.Add(new Setter(property, value));
        return style;
    }

    public static T Resources<T>(this T style, IResourceDictionary resources) where T : Style
    {
        style.Resources = resources;
        return style;
    }

    public static T Resources<T>(this T style, object key, object value) where T : Style
    {
        style.Resources[key] = value;
        return style;
    }

    public static T Animations<T>(this T style, params IAnimation[] animations) where T : Style
    {
        foreach (var animation in animations)
        {
            style.Animations.Add(animation);
        }
        return style;
    }

    public static T Animations<T>(this T style, IAnimation animation) where T : Style
    {
        style.Animations.Add(animation);
        return style;
    }
}
