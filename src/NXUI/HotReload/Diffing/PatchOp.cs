#if NXUI_HOTRELOAD
namespace NXUI.HotReload.Diffing;

using System;
using Avalonia;
using NXUI.HotReload.Nodes;

/// <summary>
/// Represents a single diff instruction.
/// </summary>
public readonly struct PatchOp
{
    private PatchOp(
        PatchOpKind kind,
        NodePath path,
        PropertyMutation? property,
        EventMutation? evt,
        ElementNode? node,
        int index,
        int toIndex,
        string? key,
        AvaloniaProperty? avaloniaProperty,
        int propertyId)
    {
        Kind = kind;
        Path = path;
        Property = property;
        Event = evt;
        Node = node;
        Index = index;
        ToIndex = toIndex;
        Key = key;
        AvaloniaProperty = avaloniaProperty;
        PropertyId = propertyId;
    }

    /// <summary>
    /// Gets the operation kind.
    /// </summary>
    public PatchOpKind Kind { get; }

    /// <summary>
    /// Gets the target path.
    /// </summary>
    public NodePath Path { get; }

    /// <summary>
    /// Gets the property mutation payload when <see cref="Kind"/> targets a property.
    /// </summary>
    public PropertyMutation? Property { get; }

    /// <summary>
    /// Gets the event mutation payload when <see cref="Kind"/> targets an event.
    /// </summary>
    public EventMutation? Event { get; }

    /// <summary>
    /// Gets the child node payload.
    /// </summary>
    public ElementNode? Node { get; }

    /// <summary>
    /// Gets the index associated with the operation (child insert/remove/move).
    /// </summary>
    public int Index { get; }

    /// <summary>
    /// Gets the new index for move operations.
    /// </summary>
    public int ToIndex { get; }

    /// <summary>
    /// Gets the key associated with the child operation (if any).
    /// </summary>
    public string? Key { get; }

    /// <summary>
    /// Gets the Avalonia property targeted by the mutation.
    /// </summary>
    public AvaloniaProperty? AvaloniaProperty { get; }

    /// <summary>
    /// Gets the property metadata identifier.
    /// </summary>
    public int PropertyId { get; }

    /// <summary>
    /// Creates an operation that replaces an entire subtree.
    /// </summary>
    public static PatchOp ReplaceSubtree(NodePath path, ElementNode replacement)
    {
        ArgumentNullException.ThrowIfNull(replacement);
        return new PatchOp(
            PatchOpKind.ReplaceSubtree,
            path,
            property: null,
            evt: null,
            node: replacement,
            index: -1,
            toIndex: -1,
            key: replacement.Key,
            avaloniaProperty: null,
            propertyId: 0);
    }

    /// <summary>
    /// Creates an operation that sets or updates a property value.
    /// </summary>
    public static PatchOp ForProperty(NodePath path, PropertyMutation mutation)
    {
        ArgumentNullException.ThrowIfNull(mutation);

        var kind = mutation.Kind switch
        {
            PropertyMutationKind.SetBinding => PatchOpKind.SetBinding,
            _ => PatchOpKind.SetProperty,
        };

        return new PatchOp(
            kind,
            path,
            mutation,
            evt: null,
            node: null,
            index: -1,
            toIndex: -1,
            key: null,
            mutation.Property ?? mutation.Descriptor?.Property,
            mutation.PropertyId);
    }

    /// <summary>
    /// Creates an operation that clears a property back to its default value.
    /// </summary>
    public static PatchOp ClearProperty(NodePath path, int propertyId, AvaloniaProperty property)
    {
        ArgumentNullException.ThrowIfNull(property);

        return new PatchOp(
            PatchOpKind.ClearProperty,
            path,
            property: null,
            evt: null,
            node: null,
            index: -1,
            toIndex: -1,
            key: null,
            property,
            propertyId);
    }

    /// <summary>
    /// Creates an operation that attaches a new event handler.
    /// </summary>
    public static PatchOp AttachEvent(NodePath path, EventMutation mutation)
    {
        ArgumentNullException.ThrowIfNull(mutation);
        return new PatchOp(
            PatchOpKind.AttachEvent,
            path,
            property: null,
            evt: mutation,
            node: null,
            index: -1,
            toIndex: -1,
            key: null,
            avaloniaProperty: null,
            propertyId: 0);
    }

    /// <summary>
    /// Creates an operation that detaches an existing event handler.
    /// </summary>
    public static PatchOp DetachEvent(NodePath path, EventMutation mutation)
    {
        ArgumentNullException.ThrowIfNull(mutation);
        return new PatchOp(
            PatchOpKind.DetachEvent,
            path,
            property: null,
            evt: mutation,
            node: null,
            index: -1,
            toIndex: -1,
            key: null,
            avaloniaProperty: null,
            propertyId: 0);
    }

    /// <summary>
    /// Creates an operation that inserts a new child node.
    /// </summary>
    public static PatchOp AddChild(NodePath path, int index, ElementNode child)
    {
        ArgumentNullException.ThrowIfNull(child);
        return new PatchOp(
            PatchOpKind.AddChild,
            path,
            property: null,
            evt: null,
            node: child,
            index,
            toIndex: -1,
            key: child.Key,
            avaloniaProperty: null,
            propertyId: 0);
    }

    /// <summary>
    /// Creates an operation that removes a child node.
    /// </summary>
    public static PatchOp RemoveChild(NodePath path, int index, string? key = null)
    {
        return new PatchOp(
            PatchOpKind.RemoveChild,
            path,
            property: null,
            evt: null,
            node: null,
            index,
            toIndex: -1,
            key,
            avaloniaProperty: null,
            propertyId: 0);
    }

    /// <summary>
    /// Creates an operation that reorders a child node.
    /// </summary>
    public static PatchOp MoveChild(NodePath path, int fromIndex, int toIndex, string? key = null)
    {
        return new PatchOp(
            PatchOpKind.MoveChild,
            path,
            property: null,
            evt: null,
            node: null,
            fromIndex,
            toIndex,
            key,
            avaloniaProperty: null,
            propertyId: 0);
    }
}
#endif
