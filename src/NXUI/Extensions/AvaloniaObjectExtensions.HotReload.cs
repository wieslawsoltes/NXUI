#if NXUI_HOTRELOAD
namespace NXUI.Extensions;

using System;
using Avalonia;
using Avalonia.Data;
using NXUI.HotReload.Nodes;

/// <summary>
/// Hot reload builder overloads for binding helpers.
/// </summary>
public static partial class AvaloniaObjectExtensions
{
    /// <summary>
    /// Records a one-way binding between two Avalonia properties for hot reload builds.
    /// </summary>
    /// <remarks>The disposable handle is not available until the control is materialized, so the <paramref name="targetDisposable"/> output is always <c>null</c>.</remarks>
    public static ElementBuilder<T> BindOneWay<T>(
        this ElementBuilder<T> builder,
        AvaloniaProperty targetProperty,
        AvaloniaObject source,
        AvaloniaProperty sourceProperty,
        out IDisposable? targetDisposable) where T : AvaloniaObject
    {
        ArgumentNullException.ThrowIfNull(targetProperty);
        ArgumentNullException.ThrowIfNull(source);
        ArgumentNullException.ThrowIfNull(sourceProperty);
        targetDisposable = null;
        return builder.WithAction(target =>
        {
            target.Bind(targetProperty, source.GetObservable(sourceProperty));
        });
    }

    /// <summary>
    /// Records a one-way binding using a typed Avalonia property for hot reload builds.
    /// </summary>
    public static ElementBuilder<T> BindOneWay<T>(
        this ElementBuilder<T> builder,
        AvaloniaProperty<T> targetProperty,
        IObservable<BindingValue<T>> source,
        out IDisposable? targetDisposable) where T : AvaloniaObject
    {
        ArgumentNullException.ThrowIfNull(targetProperty);
        ArgumentNullException.ThrowIfNull(source);
        targetDisposable = null;
        return builder.WithAction(target =>
        {
            target.Bind(targetProperty, source);
        });
    }

    /// <summary>
    /// Records a one-way binding that adapts a <see cref="BindingValue{T}"/> observable for hot reload builds.
    /// </summary>
    public static ElementBuilder<T> BindOneWay<T>(
        this ElementBuilder<T> builder,
        AvaloniaProperty targetProperty,
        IObservable<BindingValue<T>> source,
        out IDisposable? targetDisposable) where T : AvaloniaObject
    {
        ArgumentNullException.ThrowIfNull(targetProperty);
        ArgumentNullException.ThrowIfNull(source);
        targetDisposable = null;
        return builder.WithAction(target =>
        {
            target.Bind(targetProperty, source.ToBinding());
        });
    }

    /// <summary>
    /// Records a one-way binding from an object observable to a typed property for hot reload builds.
    /// </summary>
    public static ElementBuilder<T> BindOneWay<T>(
        this ElementBuilder<T> builder,
        AvaloniaProperty<T> targetProperty,
        IObservable<object?> source,
        out IDisposable? targetDisposable) where T : AvaloniaObject
    {
        ArgumentNullException.ThrowIfNull(targetProperty);
        ArgumentNullException.ThrowIfNull(source);
        targetDisposable = null;
        return builder.WithAction(target =>
        {
            target.Bind(targetProperty, source);
        });
    }

    /// <summary>
    /// Records a one-way binding from an object observable to an untyped property for hot reload builds.
    /// </summary>
    public static ElementBuilder<T> BindOneWay<T>(
        this ElementBuilder<T> builder,
        AvaloniaProperty targetProperty,
        IObservable<object?> source,
        out IDisposable? targetDisposable) where T : AvaloniaObject
    {
        ArgumentNullException.ThrowIfNull(targetProperty);
        ArgumentNullException.ThrowIfNull(source);
        targetDisposable = null;
        return builder.WithAction(target =>
        {
            target.Bind(targetProperty, source);
        });
    }

    /// <summary>
    /// Records a two-way binding between two Avalonia properties for hot reload builds.
    /// </summary>
    /// <remarks>Disposable handles are not available during build-time recording, so both outputs are <c>null</c>.</remarks>
    public static ElementBuilder<T> BindTwoWay<T>(
        this ElementBuilder<T> builder,
        AvaloniaProperty targetProperty,
        AvaloniaObject source,
        AvaloniaProperty sourceProperty,
        out IDisposable? targetDisposable,
        out IDisposable? sourceDisposable) where T : AvaloniaObject
    {
        ArgumentNullException.ThrowIfNull(targetProperty);
        ArgumentNullException.ThrowIfNull(source);
        ArgumentNullException.ThrowIfNull(sourceProperty);
        targetDisposable = null;
        sourceDisposable = null;
        return builder.WithAction(target =>
        {
            target.Bind(targetProperty, source.GetObservable(sourceProperty));
            source.Bind(sourceProperty, target.GetObservable(targetProperty));
        });
    }
}
#endif
