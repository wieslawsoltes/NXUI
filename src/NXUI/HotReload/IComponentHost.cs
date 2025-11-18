namespace NXUI.HotReload;

using Avalonia;

/// <summary>
/// Abstraction for environments that can host a hot reload component root.
/// </summary>
internal interface IComponentHost
{
    /// <summary>
    /// Called once the root instance has been materialized.
    /// </summary>
    void AttachRoot(AvaloniaObject instance);

    /// <summary>
    /// Called when the diff engine replaces the root control.
    /// </summary>
    void OnRootReplaced(AvaloniaObject oldRoot, AvaloniaObject newRoot);

    /// <summary>
    /// Called after reconciliation completes, even if no replacement happened.
    /// </summary>
    void OnComponentUpdated(ReconcileResult result);

    /// <summary>
    /// Called when the registration is disposed.
    /// </summary>
    void OnComponentDisposed(AvaloniaObject? instance);
}
