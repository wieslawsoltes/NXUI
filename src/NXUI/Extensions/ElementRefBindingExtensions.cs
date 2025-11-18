#if NXUI_HOTRELOAD
namespace NXUI.Extensions;

using System;
using System.Reactive.Linq;
using Avalonia;
using Avalonia.Data;
using NXUI.HotReload.Nodes;

/// <summary>
/// Binding helpers for <see cref="ElementRef{TControl}"/>.
/// </summary>
public static class ElementRefBindingExtensions
{
    /// <summary>
    /// Creates a one-way binding that mirrors the specified property from the referenced element.
    /// </summary>
    public static IBinding Bind<TControl, TValue>(this ElementRef<TControl> elementRef, AvaloniaProperty<TValue> property)
        where TControl : AvaloniaObject
    {
        return elementRef.Observe(property).ToBinding();
    }

    /// <summary>
    /// Creates a one-way binding that projects the referenced property through <paramref name="selector"/>.
    /// </summary>
    public static IBinding Bind<TControl, TValue, TResult>(
        this ElementRef<TControl> elementRef,
        AvaloniaProperty<TValue> property,
        Func<TValue, TResult> selector)
        where TControl : AvaloniaObject
    {
        ArgumentNullException.ThrowIfNull(selector);
        return elementRef.Observe(property).Select(selector).ToBinding();
    }
}
#endif
