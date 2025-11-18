#if NXUI_HOTRELOAD
namespace NXUI.HotReload.Nodes;

using System;
using System.Collections.Generic;
using Avalonia;
using Avalonia.Data;
using NXUI.HotReload.Metadata;

/// <summary>
/// Factory helpers for creating <see cref="ElementBuilder{TControl}"/> instances.
/// </summary>
public static class ElementBuilder
{
    /// <summary>
    /// Creates a builder that records mutations against type <typeparamref name="TControl"/> using a known metadata identifier.
    /// </summary>
    public static ElementBuilder<TControl> Create<TControl>(int typeId, Func<TControl> factory)
        where TControl : AvaloniaObject
    {
        ArgumentNullException.ThrowIfNull(factory);
        if (typeId <= TypeMetadata.InvalidTypeId)
        {
            throw new ArgumentOutOfRangeException(nameof(typeId));
        }

        var node = new ElementNode(typeof(TControl), typeId, () => factory());
        return new ElementBuilder<TControl>(node);
    }

    /// <summary>
    /// Creates a builder that records mutations against type <typeparamref name="TControl"/> resolving the metadata identifier at runtime.
    /// </summary>
    public static ElementBuilder<TControl> Create<TControl>(Func<TControl> factory)
        where TControl : AvaloniaObject
    {
        ArgumentNullException.ThrowIfNull(factory);

        if (!TypeMetadata.TryGetId(typeof(TControl), out var typeId))
        {
            typeId = TypeMetadata.InvalidTypeId;
        }

        var node = new ElementNode(typeof(TControl), typeId, () => factory());
        return new ElementBuilder<TControl>(node);
    }
}

/// <summary>
/// Fluent builder that records mutations instead of mutating live Avalonia controls.
/// </summary>
/// <typeparam name="TControl">Control type represented by the builder.</typeparam>
public readonly struct ElementBuilder<TControl>
    where TControl : AvaloniaObject
{
    private readonly ElementNode? _node;

    internal ElementBuilder(ElementNode node)
    {
        _node = node ?? throw new ArgumentNullException(nameof(node));
    }

    internal ElementNode Node
        => _node ?? throw new InvalidOperationException("ElementBuilder is not initialized.");

    /// <summary>
    /// Materializes the fluent node into a live control.
    /// </summary>
    /// <returns>The instantiated control.</returns>
    public TControl Mount()
    {
        return (TControl)Node.Build();
    }

    /// <summary>
    /// Adds a literal property mutation.
    /// </summary>
    internal ElementBuilder<TControl> WithValue(int propertyId, AvaloniaProperty property, object? value)
    {
        Node.AddProperty(PropertyMutation.ForValue(propertyId, property, value));
        return this;
    }

    /// <summary>
    /// Adds a binding mutation.
    /// </summary>
    internal ElementBuilder<TControl> WithBinding(int propertyId, AvaloniaProperty property, IBinding binding, BindingMode mode, BindingPriority priority)
    {
        var descriptor = new BindingDescriptor(propertyId, property, mode, priority);
        Node.AddProperty(PropertyMutation.ForBinding(descriptor, binding));
        return this;
    }

    /// <summary>
    /// Adds a mutation that attaches a child node.
    /// </summary>
    internal ElementBuilder<TControl> WithChild<TChild>(
        ElementBuilder<TChild> child,
        Action<TControl, TChild> attach,
        ChildSlot slot = ChildSlot.Unknown)
        where TChild : AvaloniaObject
    {
        ArgumentNullException.ThrowIfNull(attach);
        child.Node.SetParentSlot(slot);
        Node.AddChild(child.Node);
        Node.AddProperty(PropertyMutation.ForChild(
            child.Node,
            (parent, builtChild) => attach(
                (TControl)parent,
                (TChild)builtChild)));
        return this;
    }

    /// <summary>
    /// Adds a mutation that attaches multiple child nodes.
    /// </summary>
    internal ElementBuilder<TControl> WithChildren<TChild>(
        IReadOnlyList<ElementBuilder<TChild>> children,
        Action<TControl, IReadOnlyList<TChild>> attach,
        ChildSlot slot = ChildSlot.Unknown)
        where TChild : AvaloniaObject
    {
        ArgumentNullException.ThrowIfNull(children);
        ArgumentNullException.ThrowIfNull(attach);

        var childNodes = new List<ElementNode>(children.Count);
        foreach (var child in children)
        {
            var node = child.Node;
            node.SetParentSlot(slot);
            childNodes.Add(node);
        }

        Node.AddChildren(childNodes);
        Node.AddProperty(
            PropertyMutation.ForChildren(
                childNodes,
                (parent, builtChildren) =>
                {
                    var typedChildren = new List<TChild>(builtChildren.Count);
                    foreach (var builtChild in builtChildren)
                    {
                        typedChildren.Add((TChild)builtChild);
                    }

                    attach((TControl)parent, typedChildren);
                }));
        return this;
    }

    /// <summary>
    /// Adds a mutation that attaches an untyped child node.
    /// </summary>
    internal ElementBuilder<TControl> WithChild(ElementNode childNode, Action<TControl, AvaloniaObject> attach, ChildSlot slot = ChildSlot.Unknown)
    {
        ArgumentNullException.ThrowIfNull(childNode);
        ArgumentNullException.ThrowIfNull(attach);

        childNode.SetParentSlot(slot);
        Node.AddChild(childNode);
        Node.AddProperty(
            PropertyMutation.ForChild(
                childNode,
                (parent, builtChild) => attach((TControl)parent, builtChild)));
        return this;
    }

    /// <summary>
    /// Adds a recorded event mutation.
    /// </summary>
    internal ElementBuilder<TControl> WithEvent(EventMutation mutation)
    {
        Node.AddEvent(mutation);
        return this;
    }

    /// <summary>
    /// Adds a mutation that invokes a custom action when the control is instantiated.
    /// </summary>
    public ElementBuilder<TControl> WithAction(Action<TControl> action)
    {
        ArgumentNullException.ThrowIfNull(action);
        Node.AddProperty(PropertyMutation.ForAction(target => action((TControl)target)));
        return this;
    }

    /// <summary>
    /// Marks the builder node as a hot reload boundary.
    /// </summary>
    internal ElementBuilder<TControl> MarkBoundary()
    {
        Node.MarkBoundary();
        return this;
    }

    /// <summary>
    /// Assigns a stable key to the builder node.
    /// </summary>
    public ElementBuilder<TControl> Key(string key)
    {
        Node.SetKey(key);
        return this;
    }

    /// <summary>
    /// Implicitly converts the builder to a child wrapper so it can participate in heterogeneous collections (e.g., Panel.Children).
    /// </summary>
    public static implicit operator ElementChildBuilder(ElementBuilder<TControl> builder)
    {
        return new ElementChildBuilder(builder.Node);
    }
}
#endif
