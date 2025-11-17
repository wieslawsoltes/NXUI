#if NXUI_HOTRELOAD
namespace NXUI.Extensions;

using System;
using Avalonia;
using Avalonia.Media;
using NXUI.HotReload.Metadata;
using NXUI.HotReload.Nodes;

/// <summary>
/// Hot reload helpers for <see cref="Visual"/> transform APIs.
/// </summary>
public static partial class VisualExtensions
{
    /// <summary>
    /// Records a builder-based render transform so fluent calls like <c>line.RenderTransform(RotateTransform())</c> compile under hot reload.
    /// </summary>
    public static ElementBuilder<TVisual> RenderTransform<TVisual, TTransform>(
        this ElementBuilder<TVisual> visual,
        ElementBuilder<TTransform> transform)
        where TVisual : Visual
        where TTransform : AvaloniaObject, ITransform
    {
        return visual.WithValue(
            PropertyMetadata.Visual_RenderTransform,
            Avalonia.Visual.RenderTransformProperty,
            transform.Node);
    }

    /// <summary>
    /// Records a render transform by invoking the builder factory on demand.
    /// </summary>
    public static ElementBuilder<TVisual> RenderTransform<TVisual, TTransform>(
        this ElementBuilder<TVisual> visual,
        Func<ElementBuilder<TTransform>> buildTransform)
        where TVisual : Visual
        where TTransform : AvaloniaObject, ITransform
    {
        ArgumentNullException.ThrowIfNull(buildTransform);
        return visual.RenderTransform(buildTransform());
    }

    /// <summary>
    /// Records a render transform created from a runtime factory without requiring a builder overload.
    /// </summary>
    public static ElementBuilder<TVisual> RenderTransform<TVisual>(
        this ElementBuilder<TVisual> visual,
        Func<ITransform> buildTransform)
        where TVisual : Visual
    {
        ArgumentNullException.ThrowIfNull(buildTransform);
        return visual.WithAction(target =>
        {
            target.RenderTransform = buildTransform();
        });
    }

    /// <summary>
    /// Records a render transform origin computed at instantiation time.
    /// </summary>
    public static ElementBuilder<TVisual> RenderTransformOrigin<TVisual>(
        this ElementBuilder<TVisual> visual,
        Func<RelativePoint> buildOrigin)
        where TVisual : Visual
    {
        ArgumentNullException.ThrowIfNull(buildOrigin);
        return visual.WithAction(target =>
        {
            target.RenderTransformOrigin = buildOrigin();
        });
    }
}
#endif
