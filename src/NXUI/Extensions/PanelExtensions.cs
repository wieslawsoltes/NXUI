namespace NXUI.Extensions;

using System;

using NXUI.HotReload.Nodes;

/// <summary>
/// 
/// </summary>
public static partial class PanelExtensions
{
    // Children


    /// <summary>
    /// Adds an existing control instance as a child for hot reload builds.
    /// </summary>
    public static ElementBuilder<T> Children<T>(this ElementBuilder<T> panel, Control child) where T : Panel
    {
        ArgumentNullException.ThrowIfNull(child);
        var wrapped = ElementBuilder.Create(() => child);
        return panel.Children(wrapped);
    }

    /// <summary>
    /// Adds existing control instances as children for hot reload builds.
    /// </summary>
    public static ElementBuilder<T> Children<T>(this ElementBuilder<T> panel, params Control[] children) where T : Panel
    {
        ArgumentNullException.ThrowIfNull(children);
        foreach (var child in children)
        {
            panel = panel.Children(child);
        }

        return panel;
    }

    /// <summary>
    /// Adds a child builder to the panel for hot reload builds.
    /// </summary>
    public static ElementBuilder<T> Children<T>(this ElementBuilder<T> panel, ElementChildBuilder child) where T : Panel
    {
        return panel.AttachChild(child);
    }

    /// <summary>
    /// Adds child builders to the panel for hot reload builds.
    /// </summary>
    public static ElementBuilder<T> Children<T>(this ElementBuilder<T> panel, params ElementChildBuilder[] children) where T : Panel
    {
        foreach (var child in children)
        {
            panel = panel.AttachChild(child);
        }

        return panel;
    }

    private static ElementBuilder<T> AttachChild<T>(this ElementBuilder<T> panel, ElementChildBuilder child) where T : Panel
    {
        var node = child.Node;
        var controlType = node.ControlType;
        if (controlType is null || !typeof(Control).IsAssignableFrom(controlType))
        {
            throw new InvalidOperationException($"Panel children must derive from {nameof(Control)}. Received '{controlType?.FullName ?? "unknown"}'.");
        }

        return panel.WithChild(
            node,
            static (parent, builtChild) => parent.Children.Add((Control)builtChild),
            ChildSlot.Visual);
    }


    /// <summary>
    /// 
    /// </summary>
    /// <param name="panel"></param>
    /// <param name="child"></param>
    /// <typeparam name="T"></typeparam>
    /// <returns></returns>
    public static T Children<T>(this T panel, Control child) where T : Panel
    {
        panel.Children.Add(child);
        return panel;
    }

    /// <summary>
    /// 
    /// </summary>
    /// <param name="panel"></param>
    /// <param name="children"></param>
    /// <typeparam name="T"></typeparam>
    /// <returns></returns>
    public static T Children<T>(this T panel, params Control[] children) where T : Panel
    {
        panel.Children.AddRange(children);
        return panel;
    }
}
