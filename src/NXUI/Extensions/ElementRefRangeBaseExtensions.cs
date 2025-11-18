#if NXUI_HOTRELOAD
namespace NXUI.Extensions;

using System;
using Avalonia.Controls.Primitives;
using NXUI.HotReload.Nodes;

/// <summary>
/// ElementRef helpers for <see cref="RangeBase"/> derived controls.
/// </summary>
public static class ElementRefRangeBaseExtensions
{
    /// <summary>
    /// Observes the <see cref="RangeBase.ValueProperty"/> for the referenced control.
    /// </summary>
    public static IObservable<double> ObserveValue<TControl>(this ElementRef<TControl> elementRef)
        where TControl : RangeBase
    {
        return elementRef.Observe(RangeBase.ValueProperty);
    }
}
#endif
