namespace NXUI.HotReload.State;

using System;
using Avalonia;

/// <summary>
/// Describes how to capture and restore control-specific state when hot reload replaces an instance.
/// </summary>
public interface IHotReloadStateAdapter
{
    /// <summary>
    /// Gets the control type this adapter supports.
    /// </summary>
    Type ControlType { get; }

    /// <summary>
    /// Captures control state prior to replacement.
    /// </summary>
    /// <param name="control">The source control.</param>
    /// <returns>A serializable state object.</returns>
    object? CaptureState(AvaloniaObject control);

    /// <summary>
    /// Restores previously captured control state onto the replacement control.
    /// </summary>
    /// <param name="control">The replacement control.</param>
    /// <param name="state">The captured state.</param>
    void RestoreState(AvaloniaObject control, object? state);
}
