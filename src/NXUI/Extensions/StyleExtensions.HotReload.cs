#if NXUI_HOTRELOAD
namespace NXUI.Extensions;

using System;
using Avalonia;
using Avalonia.Animation;
using Avalonia.Controls;
using Avalonia.Styling;
using NXUI.HotReload.Nodes;

/// <summary>
/// Hot reload helpers for <see cref="Style"/> fluent extensions.
/// </summary>
public static partial class StyleExtensions
{
    /// <summary>
    /// Records a selector assignment for a builder style.
    /// </summary>
    public static ElementBuilder<Style> Selector(
        this ElementBuilder<Style> builder,
        Func<Selector?, Selector> selector)
    {
        ArgumentNullException.ThrowIfNull(selector);
        return builder.WithAction(style =>
        {
            style.Selector = selector(null);
        });
    }

    /// <summary>
    /// Records setters for a builder style.
    /// </summary>
    public static ElementBuilder<Style> Setters(
        this ElementBuilder<Style> builder,
        params Setter[] setters)
    {
        ArgumentNullException.ThrowIfNull(setters);
        return builder.WithAction(style =>
        {
            foreach (var setter in setters)
            {
                style.Setters.Add(setter);
            }
        });
    }

    /// <summary>
    /// Records a setter constructed from the provided property/value pair.
    /// </summary>
    public static ElementBuilder<Style> Setter(
        this ElementBuilder<Style> builder,
        AvaloniaProperty property,
        object value)
    {
        ArgumentNullException.ThrowIfNull(property);
        return builder.WithAction(style =>
        {
            style.Setters.Add(new Setter(property, value));
        });
    }

    /// <summary>
    /// Records a resource dictionary assignment for the builder style.
    /// </summary>
    public static ElementBuilder<Style> Resources(
        this ElementBuilder<Style> builder,
        IResourceDictionary resources)
    {
        ArgumentNullException.ThrowIfNull(resources);
        return builder.WithAction(style =>
        {
            style.Resources = resources;
        });
    }

    /// <summary>
    /// Records a builder-based resource dictionary assignment for the builder style.
    /// </summary>
    public static ElementBuilder<Style> Resources(
        this ElementBuilder<Style> builder,
        ElementBuilder<ResourceDictionary> resources)
    {
        ArgumentNullException.ThrowIfNull(resources);
        return builder.WithChild(
            resources,
            static (parentObj, builtResources) =>
            {
                ((Style)parentObj).Resources = (IResourceDictionary)builtResources;
            });
    }

    /// <summary>
    /// Records a single resource key/value pair on the style.
    /// </summary>
    public static ElementBuilder<Style> Resources(
        this ElementBuilder<Style> builder,
        object key,
        object value)
    {
        ArgumentNullException.ThrowIfNull(key);
        return builder.WithAction(style =>
        {
            style.Resources[key] = value;
        });
    }

    /// <summary>
    /// Records animation instances for the builder style.
    /// </summary>
    public static ElementBuilder<Style> Animations(
        this ElementBuilder<Style> builder,
        params IAnimation[] animations)
    {
        ArgumentNullException.ThrowIfNull(animations);
        return builder.WithAction(style =>
        {
            foreach (var animation in animations)
            {
                style.Animations.Add(animation);
            }
        });
    }

    /// <summary>
    /// Records builder animations for the style.
    /// </summary>
    public static ElementBuilder<Style> Animations(
        this ElementBuilder<Style> builder,
        params ElementBuilder<Animation>[] animations)
    {
        ArgumentNullException.ThrowIfNull(animations);
        return builder.WithChildren(
            animations,
            static (parent, builtAnimations) =>
            {
                var style = (Style)parent;
                foreach (var animation in builtAnimations)
                {
                    if (animation is IAnimation typed)
                    {
                        style.Animations.Add(typed);
                    }
                }
            });
    }
}
#endif
