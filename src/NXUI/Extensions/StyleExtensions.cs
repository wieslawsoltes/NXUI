namespace MinimalAvalonia.Extensions;

/// <summary>
/// 
/// </summary>
public static partial class StyleExtensions
{
    // Selector

    /// <summary>
    /// 
    /// </summary>
    /// <param name="style"></param>
    /// <param name="selector"></param>
    /// <typeparam name="T"></typeparam>
    /// <returns></returns>
    public static T Selector<T>(this T style, Func<Selector?, Selector> selector) where T : Style
    {
        style.Selector = selector(null);
        return style;
    }

    // Setters

    /// <summary>
    /// 
    /// </summary>
    /// <param name="style"></param>
    /// <param name="setters"></param>
    /// <typeparam name="T"></typeparam>
    /// <returns></returns>
    public static T Setters<T>(this T style, params ISetter[] setters) where T : Style
    {
        foreach (var setter in setters)
        {
            style.Setters.Add(setter);
        }
        return style;
    }

    /// <summary>
    /// 
    /// </summary>
    /// <param name="style"></param>
    /// <param name="property"></param>
    /// <param name="value"></param>
    /// <typeparam name="T"></typeparam>
    /// <returns></returns>
    public static T Setter<T>(this T style, AvaloniaProperty property, object value) where T : Style
    {
        style.Setters.Add(new Setter(property, value));
        return style;
    }

    // Resources

    /// <summary>
    /// 
    /// </summary>
    /// <param name="style"></param>
    /// <param name="resources"></param>
    /// <typeparam name="T"></typeparam>
    /// <returns></returns>
    public static T Resources<T>(this T style, IResourceDictionary resources) where T : Style
    {
        style.Resources = resources;
        return style;
    }

    /// <summary>
    /// 
    /// </summary>
    /// <param name="style"></param>
    /// <param name="key"></param>
    /// <param name="value"></param>
    /// <typeparam name="T"></typeparam>
    /// <returns></returns>
    public static T Resources<T>(this T style, object key, object value) where T : Style
    {
        style.Resources[key] = value;
        return style;
    }

    // Animations

    /// <summary>
    /// 
    /// </summary>
    /// <param name="style"></param>
    /// <param name="animations"></param>
    /// <typeparam name="T"></typeparam>
    /// <returns></returns>
    public static T Animations<T>(this T style, params IAnimation[] animations) where T : Style
    {
        foreach (var animation in animations)
        {
            style.Animations.Add(animation);
        }
        return style;
    }

    /// <summary>
    /// 
    /// </summary>
    /// <param name="style"></param>
    /// <param name="animation"></param>
    /// <typeparam name="T"></typeparam>
    /// <returns></returns>
    public static T Animations<T>(this T style, IAnimation animation) where T : Style
    {
        style.Animations.Add(animation);
        return style;
    }
}
