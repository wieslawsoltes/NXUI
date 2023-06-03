// ReSharper disable InconsistentNaming
namespace NXUI.FSharp.Extensions;

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
    public static T name<T>(this T obj, string value, INameScope scope) where T : Avalonia.StyledElement
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
    public static T classes<T>(this T styledElement, params string[] items) where T : StyledElement
    {
        styledElement.Classes.AddRange(items);
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
    public static T styles<T>(this T styledElement, params IStyle[] styles) where T : StyledElement
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
    public static T resources<T>(this T styledElement, IResourceDictionary resources) where T : StyledElement
    {
        styledElement.Resources = resources;
        return styledElement;
    }
}
