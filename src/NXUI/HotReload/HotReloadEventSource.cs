namespace NXUI.HotReload;

using System.Diagnostics.Tracing;

/// <summary>
/// Emits structured diagnostics for NXUI hot reload operations.
/// </summary>
[EventSource(Name = "NXUI-HotReload")]
internal sealed class HotReloadEventSource : EventSource
{
    internal static readonly HotReloadEventSource Log = new();

    [NonEvent]
    internal void PatchSummary(ReconcileResult result, string rootDescription)
    {
        PatchSummary(
            rootDescription,
            result.ReplaceSubtreeCount,
            result.SetPropertyCount,
            result.SetBindingCount,
            result.ClearPropertyCount,
            result.AddChildCount,
            result.RemoveChildCount,
            result.MoveChildCount,
            result.AttachEventCount,
            result.DetachEventCount,
            result.ReplacedRoot ? 1 : 0);
    }

    [NonEvent]
    internal void NodeSnapshot(string snapshotJson)
    {
        NodeSnapshotInternal(snapshotJson ?? string.Empty);
    }

    [Event(1, Level = EventLevel.Informational)]
    private void PatchSummary(
        string rootDescription,
        int replaceCount,
        int setPropertyCount,
        int setBindingCount,
        int clearPropertyCount,
        int addChildCount,
        int removeChildCount,
        int moveChildCount,
        int attachEventCount,
        int detachEventCount,
        int replacedRoot)
    {
        WriteEvent(
            1,
            rootDescription,
            replaceCount,
            setPropertyCount,
            setBindingCount,
            clearPropertyCount,
            addChildCount,
            removeChildCount,
            moveChildCount,
            attachEventCount,
            detachEventCount,
            replacedRoot);
    }

    [Event(2, Level = EventLevel.Informational)]
    private void NodeSnapshotInternal(string snapshotJson)
    {
        WriteEvent(2, snapshotJson);
    }

    [NonEvent]
    internal void BoundaryShortCircuit(string path, string nodeDescription, string reason)
    {
        BoundaryShortCircuitInternal(
            path ?? string.Empty,
            nodeDescription ?? string.Empty,
            reason ?? string.Empty);
    }

    [Event(3, Level = EventLevel.Verbose)]
    private void BoundaryShortCircuitInternal(string path, string nodeDescription, string reason)
    {
        WriteEvent(3, path, nodeDescription, reason);
    }
}
