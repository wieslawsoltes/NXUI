#if NXUI_HOTRELOAD
namespace NXUI.HotReload.State;

using Avalonia;

/// <summary>
/// Coordinates state transfer between old and new control instances.
/// </summary>
internal static class HotReloadStateCoordinator
{
    internal static void TransferState(AvaloniaObject? source, AvaloniaObject? target)
    {
        if (source is null || target is null)
        {
            return;
        }

        if (!HotReloadStateRegistry.TryGetAdapter(source.GetType(), out var adapter)
            || adapter is null
            || !adapter.ControlType.IsInstanceOfType(target))
        {
            return;
        }

        var state = adapter.CaptureState(source);
        adapter.RestoreState(target, state);
        HotReloadDiagnostics.TraceStateTransfer(adapter.GetType(), source.GetType(), target.GetType());
    }
}
#endif
