#if NXUI_HOTRELOAD
namespace NXUI.HotReload.Diffing;

/// <summary>
/// Enumerates the patch operations emitted by <see cref="TreeDiffer"/>.
/// </summary>
public enum PatchOpKind
{
    /// <summary>
    /// Replaces the entire subtree rooted at the target node.
    /// </summary>
    ReplaceSubtree,

    /// <summary>
    /// Assigns a property value on an existing node.
    /// </summary>
    SetProperty,

    /// <summary>
    /// Applies a binding to a property on the target node.
    /// </summary>
    SetBinding,

    /// <summary>
    /// Clears the current value or binding of a property.
    /// </summary>
    ClearProperty,

    /// <summary>
    /// Inserts a new child into a parent collection.
    /// </summary>
    AddChild,

    /// <summary>
    /// Removes an existing child from a parent collection.
    /// </summary>
    RemoveChild,

    /// <summary>
    /// Reorders an existing child within a parent collection.
    /// </summary>
    MoveChild,

    /// <summary>
    /// Attaches an event handler to the target node.
    /// </summary>
    AttachEvent,

    /// <summary>
    /// Detaches an event handler from the target node.
    /// </summary>
    DetachEvent,
}
#endif
