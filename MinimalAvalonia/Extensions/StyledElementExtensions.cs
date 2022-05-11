namespace MinimalAvalonia.Extensions;

public static class StyledElementExtensions
{
    public static T DataContext<T>(this T styledElement, object dataContext) where T : StyledElement
    {
        styledElement[Avalonia.StyledElement.DataContextProperty] = dataContext;
        return styledElement;
    }
    
    public static T Name<T>(this T styledElement, string? name) where T : StyledElement
    {
        styledElement[Avalonia.StyledElement.NameProperty] = name;
        return styledElement;
    }
    
    public static T TemplatedParent<T>(this T styledElement, ITemplatedControl? templatedParent) where T : StyledElement
    {
        styledElement[Avalonia.StyledElement.TemplatedParentProperty] = templatedParent;
        return styledElement;
    }
    
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

    public static T Styles<T>(this T styledElement, params IStyle[] styles) where T : StyledElement
    {
        styledElement.Styles.AddRange(styles);
        return styledElement;
    }

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
