namespace NXUI.Extensions;

#if NXUI_HOTRELOAD
using NXUI.HotReload.Nodes;
#endif

/// <summary>
/// 
/// </summary>
public static partial class StyledElementExtensions
{
#if NXUI_HOTRELOAD
    /// <summary>
    /// Records a name assignment and scope registration for hot reload builds.
    /// </summary>
    public static ElementBuilder<TElement> Name<TElement>(
        this ElementBuilder<TElement> builder,
        string value,
        INameScope scope)
        where TElement : StyledElement
    {
        ArgumentNullException.ThrowIfNull(scope);
        return builder.WithAction(styledElement =>
        {
            styledElement[Avalonia.StyledElement.NameProperty] = value;
            scope.Register(value, styledElement);
        });
    }

    /// <summary>
    /// Records class additions for hot reload builds.
    /// </summary>
    public static ElementBuilder<TElement> Classes<TElement>(
        this ElementBuilder<TElement> builder,
        params string[] items)
        where TElement : StyledElement
    {
        ArgumentNullException.ThrowIfNull(items);
        return builder.WithAction(styledElement =>
        {
            styledElement.Classes.AddRange(items);
        });
    }

    /// <summary>
    /// Records pseudo class additions for hot reload builds.
    /// </summary>
    public static ElementBuilder<TElement> PseudoClasses<TElement>(
        this ElementBuilder<TElement> builder,
        params string[] items)
        where TElement : StyledElement
    {
        ArgumentNullException.ThrowIfNull(items);
        return builder.WithAction(styledElement =>
        {
            if (styledElement.Classes is IPseudoClasses pseudoClasses)
            {
                foreach (var item in items)
                {
                    pseudoClasses.Add(item);
                }
            }
        });
    }

    /// <summary>
    /// Records builder styles for a styled element.
    /// </summary>
    public static ElementBuilder<TElement> Styles<TElement, TStyle>(
        this ElementBuilder<TElement> styledElement,
        params ElementBuilder<TStyle>[] styles)
        where TElement : StyledElement
        where TStyle : AvaloniaObject, IStyle
    {
        return styledElement.WithChildren(
            styles,
            static (parentObj, builtStyles) =>
            {
                var target = (StyledElement)parentObj;
                var targetStyles = target.Styles ?? throw new InvalidOperationException("StyledElement.Styles collection is not initialized.");

                for (var i = 0; i < builtStyles.Count; i++)
                {
                    if (builtStyles[i] is IStyle builtStyle)
                    {
                        targetStyles.Add(builtStyle);
                    }
                }
            });
    }

    /// <summary>
    /// Records style instances for a styled element.
    /// </summary>
    public static ElementBuilder<TElement> Styles<TElement>(
        this ElementBuilder<TElement> styledElement,
        params IStyle[] styles)
        where TElement : StyledElement
    {
        ArgumentNullException.ThrowIfNull(styles);
        return styledElement.WithAction(target =>
        {
            var collection = target.Styles ?? throw new InvalidOperationException("StyledElement.Styles collection is not initialized.");
            collection.AddRange(styles);
        });
    }

    /// <summary>
    /// Records a builder resource dictionary for a styled element.
    /// </summary>
    public static ElementBuilder<TElement> Resources<TElement>(
        this ElementBuilder<TElement> styledElement,
        ElementBuilder<ResourceDictionary> resources)
        where TElement : StyledElement
    {
        return styledElement.WithChild(
            resources,
            static (parentObj, builtResources) =>
            {
                ((StyledElement)parentObj).Resources = (IResourceDictionary)builtResources;
            });
    }

    /// <summary>
    /// Records a resource dictionary assignment.
    /// </summary>
    public static ElementBuilder<TElement> Resources<TElement>(
        this ElementBuilder<TElement> styledElement,
        IResourceDictionary resources)
        where TElement : StyledElement
    {
        ArgumentNullException.ThrowIfNull(resources);
        return styledElement.WithAction(target => target.Resources = resources);
    }

    /// <summary>
    /// Records a single resource entry.
    /// </summary>
    public static ElementBuilder<TElement> Resource<TElement>(
        this ElementBuilder<TElement> styledElement,
        object key,
        object value)
        where TElement : StyledElement
    {
        ArgumentNullException.ThrowIfNull(key);
        return styledElement.WithAction(target => target.Resources[key] = value);
    }
#endif
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
