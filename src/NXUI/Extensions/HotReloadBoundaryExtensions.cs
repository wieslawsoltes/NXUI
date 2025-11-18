#if NXUI_HOTRELOAD
namespace NXUI.Extensions;

using Avalonia;
using NXUI.HotReload.Nodes;

/// <summary>
/// Fluent helpers for declaring hot reload boundaries.
/// </summary>
public static class HotReloadBoundaryExtensions
{
    /// <summary>
    /// Marks the builder node as a hot reload boundary so the diff engine treats the subtree as opaque.
    /// </summary>
    public static ElementBuilder<TControl> HotReloadBoundary<TControl>(this ElementBuilder<TControl> builder)
        where TControl : AvaloniaObject
    {
        return builder.MarkBoundary();
    }
}
#endif
