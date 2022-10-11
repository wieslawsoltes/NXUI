namespace MinimalAvalonia.Extensions;

/// <summary>
/// 
/// </summary>
public static partial class StyledElementExtensions
{
    // Name

    /// <summary>
    /// 
    /// </summary>
    /// <param name="obj"></param>
    /// <param name="value"></param>
    /// <param name="scope"></param>
    /// <typeparam name="T"></typeparam>
    /// <returns></returns>
    public static T Name<T>(this T obj, string value, INameScope scope) where T : Avalonia.StyledElement
    {
        obj[Avalonia.StyledElement.NameProperty] = value;
        scope.Register(value, obj);
        return obj;
    }

    // Classes

    /// <summary>
    /// 
    /// </summary>
    /// <param name="styledElement"></param>
    /// <param name="items"></param>
    /// <typeparam name="T"></typeparam>
    /// <returns></returns>
    public static T Classes<T>(this T styledElement, params string[] items) where T : StyledElement
    {
        styledElement.Classes.AddRange(items);
        return styledElement;
    }

    /// <summary>
    /// 
    /// </summary>
    /// <param name="styledElement"></param>
    /// <param name="items"></param>
    /// <typeparam name="T"></typeparam>
    /// <returns></returns>
    public static T PseudoClasses<T>(this T styledElement, params string[] items) where T : StyledElement
    {
        foreach (var item in items)
        {
            ((IPseudoClasses)styledElement.Classes).Add(item);
        }
        return styledElement;
    }

    // Styles

    /// <summary>
    /// 
    /// </summary>
    /// <param name="styledElement"></param>
    /// <param name="styles"></param>
    /// <typeparam name="T"></typeparam>
    /// <returns></returns>
    public static T Styles<T>(this T styledElement, params IStyle[] styles) where T : StyledElement
    {
        styledElement.Styles.AddRange(styles);
        return styledElement;
    }

    // Resources

    /// <summary>
    /// 
    /// </summary>
    /// <param name="styledElement"></param>
    /// <param name="resources"></param>
    /// <typeparam name="T"></typeparam>
    /// <returns></returns>
    public static T Resources<T>(this T styledElement, IResourceDictionary resources) where T : StyledElement
    {
        styledElement.Resources = resources;
        return styledElement;
    }

    /// <summary>
    /// 
    /// </summary>
    /// <param name="styledElement"></param>
    /// <param name="key"></param>
    /// <param name="value"></param>
    /// <typeparam name="T"></typeparam>
    /// <returns></returns>
    public static T Resource<T>(this T styledElement, object key, object value) where T : StyledElement
    {
        styledElement.Resources[key] = value;
        return styledElement;
    }
}
