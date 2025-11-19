namespace NXUI.HotReload;

using Avalonia;

/// <summary>
/// Summarizes the outcome of a reconciliation pass.
/// </summary>
public readonly record struct ReconcileResult(
    AvaloniaObject? RootInstance,
    bool ReplacedRoot,
    int ReplaceSubtreeCount,
    int SetPropertyCount,
    int SetBindingCount,
    int ClearPropertyCount,
    int AddChildCount,
    int RemoveChildCount,
    int MoveChildCount,
    int AttachEventCount,
    int DetachEventCount)
{
    /// <summary>
    /// Gets a value indicating whether any patch operations were applied.
    /// </summary>
    public bool HasChanges =>
        ReplaceSubtreeCount + SetPropertyCount + SetBindingCount + ClearPropertyCount +
        AddChildCount + RemoveChildCount + MoveChildCount + AttachEventCount + DetachEventCount > 0;
}
