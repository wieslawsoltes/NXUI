#if NXUI_HOTRELOAD
namespace NXUI.HotReload.Nodes;

using System;
using System.Collections.Generic;
using Avalonia;
using NXUI.HotReload;

/// <summary>
/// Represents a recorded fluent node that can later be materialized into a control.
/// </summary>
public sealed class ElementNode
{
    private readonly Func<AvaloniaObject> _factory;
    private readonly List<PropertyMutation> _properties = new();
    private readonly List<EventMutation> _events = new();
    private readonly List<ElementNode> _children = new();
    private AvaloniaObject? _materializedInstance;

    /// <summary>
    /// Initializes a new instance of the <see cref="ElementNode"/> class.
    /// </summary>
    /// <param name="controlType">The Avalonia control type.</param>
    /// <param name="typeId">Metadata id of the control type.</param>
    /// <param name="factory">Factory used to instantiate the control when mounting.</param>
    public ElementNode(Type controlType, int typeId, Func<AvaloniaObject> factory)
    {
        ControlType = controlType ?? throw new ArgumentNullException(nameof(controlType));
        if (typeId < 0)
        {
            throw new ArgumentOutOfRangeException(nameof(typeId));
        }

        TypeId = typeId;
        _factory = factory ?? throw new ArgumentNullException(nameof(factory));
    }

    /// <summary>
    /// Gets the underlying Avalonia control type.
    /// </summary>
    public Type ControlType { get; }

    /// <summary>
    /// Gets the generated metadata identifier for the control type.
    /// </summary>
    public int TypeId { get; }

    /// <summary>
    /// Gets or sets an optional key associated with the node for diff/preserve semantics.
    /// </summary>
    public string? Key { get; private set; }

    /// <summary>
    /// Gets the recorded property mutations.
    /// </summary>
    public IReadOnlyList<PropertyMutation> Properties => _properties;

    /// <summary>
    /// Gets the recorded event mutations.
    /// </summary>
    public IReadOnlyList<EventMutation> Events => _events;

    /// <summary>
    /// Gets the recorded direct child nodes.
    /// </summary>
    public IReadOnlyList<ElementNode> Children => _children;

    /// <summary>
    /// Gets the currently adopted control instance, if any.
    /// </summary>
    internal AvaloniaObject? AdoptedInstance => _materializedInstance;

    /// <summary>
    /// Builds the control represented by this node.
    /// </summary>
    /// <returns>The instantiated control.</returns>
    public AvaloniaObject Build()
    {
        return NodeRenderer.Instance.Build(this);
    }

    /// <summary>
    /// Sets the optional key for this node.
    /// </summary>
    public void SetKey(string? key)
    {
        Key = key;
    }

    internal void AddProperty(PropertyMutation mutation)
    {
        ArgumentNullException.ThrowIfNull(mutation);
        _properties.Add(mutation);
    }

    internal void AddEvent(EventMutation mutation)
    {
        ArgumentNullException.ThrowIfNull(mutation);
        _events.Add(mutation);
    }

    internal void AddChild(ElementNode child)
    {
        ArgumentNullException.ThrowIfNull(child);
        _children.Add(child);
    }

    internal void AddChildren(IEnumerable<ElementNode> children)
    {
        ArgumentNullException.ThrowIfNull(children);
        _children.AddRange(children);
    }

    internal void AdoptInstanceFrom(ElementNode previous)
    {
        ArgumentNullException.ThrowIfNull(previous);
        _materializedInstance = previous._materializedInstance;
    }

    internal void SetMaterializedInstance(AvaloniaObject instance)
    {
        ArgumentNullException.ThrowIfNull(instance);
        _materializedInstance = instance;
    }

    internal AvaloniaObject Instantiate()
        => _factory();
}
#endif
