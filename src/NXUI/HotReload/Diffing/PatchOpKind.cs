#if NXUI_HOTRELOAD
namespace NXUI.HotReload.Diffing;

/// <summary>
/// Enumerates the patch operations emitted by <see cref="TreeDiffer"/>.
/// </summary>
public enum PatchOpKind
{
    ReplaceSubtree,
    SetProperty,
    SetBinding,
    ClearProperty,
    AddChild,
    RemoveChild,
    MoveChild,
    AttachEvent,
    DetachEvent,
}
#endif
