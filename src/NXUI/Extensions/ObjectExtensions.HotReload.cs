namespace NXUI.Extensions;

using System;
using Avalonia;
using NXUI.HotReload.Nodes;

/// <summary>
/// Hot reload helpers that mirror the object fluent extensions.
/// </summary>
public static partial class ObjectExtensions
{
    /// <summary>
    /// Records a reference request so the caller can observe the built control.
    /// </summary>
    public static ElementBuilder<T> Ref<T>(this ElementBuilder<T> builder, out ElementRef<T> elementRef)
        where T : AvaloniaObject
    {
        return builder.WithRef(out elementRef);
    }

    /// <summary>
    /// Records a callback so it runs once the control is instantiated.
    /// </summary>
    public static ElementBuilder<T> Self<T>(this ElementBuilder<T> builder, Action<T>? callback)
        where T : AvaloniaObject
    {
        if (callback is null)
        {
            return builder;
        }

        return builder.WithAction(callback);
    }

    /// <summary>
    /// Passes through the builder while exposing an auxiliary value.
    /// </summary>
    public static ElementBuilder<T> Var<T, TValue>(this ElementBuilder<T> builder, TValue value, out TValue reference)
        where T : AvaloniaObject
    {
        reference = value;
        return builder;
    }
}
