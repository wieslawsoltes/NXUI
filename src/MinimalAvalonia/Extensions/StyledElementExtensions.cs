namespace MinimalAvalonia.Extensions;

public static partial class StyledElementExtensions
{
    // Name

    public static T Name<T>(this T obj, string value, INameScope scope) where T : Avalonia.StyledElement
    {
        obj[Avalonia.StyledElement.NameProperty] = value;
        scope.Register(value, obj);
        return obj;
    }

    // Classes

    public static T Classes<T>(this T styledElement, params string[] items) where T : StyledElement
    {
        styledElement.Classes.AddRange(items);
        return styledElement;
    }

    public static T PseudoClasses<T>(this T styledElement, params string[] items) where T : StyledElement
    {
        foreach (var item in items)
        {
            ((IPseudoClasses)styledElement.Classes).Add(item);
        }
        return styledElement;
    }

    // Styles

    public static T Styles<T>(this T styledElement, params IStyle[] styles) where T : StyledElement
    {
        styledElement.Styles.AddRange(styles);
        return styledElement;
    }

    // Resources

    public static T Resources<T>(this T styledElement, IResourceDictionary resources) where T : StyledElement
    {
        styledElement.Resources = resources;
        return styledElement;
    }

    public static T Resource<T>(this T styledElement, object key, object value) where T : StyledElement
    {
        styledElement.Resources[key] = value;
        return styledElement;
    }
}
