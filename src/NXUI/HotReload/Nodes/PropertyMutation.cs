#if NXUI_HOTRELOAD
namespace NXUI.HotReload.Nodes;

using System;
using System.Collections.Generic;
using System.Linq;
using Avalonia;
using Avalonia.Data;
using NXUI.HotReload.Metadata;

/// <summary>
/// Represents a mutation against an <see cref="AvaloniaObject"/> captured while recording a node.
/// </summary>
public sealed class PropertyMutation
{
    private readonly PropertyMutationKind _kind;
    private readonly AvaloniaProperty? _property;
    private readonly int _propertyId;
    private readonly object? _value;
    private readonly BindingDescriptor? _bindingDescriptor;
    private readonly ElementNode? _childNode;
    private readonly IReadOnlyList<ElementNode>? _childNodes;
    private readonly Action<AvaloniaObject, AvaloniaObject>? _childAttach;
    private readonly Action<AvaloniaObject, IReadOnlyList<AvaloniaObject>>? _childrenAttach;

    private PropertyMutation(
        PropertyMutationKind kind,
        int propertyId,
        AvaloniaProperty? property,
        object? value,
        BindingDescriptor? bindingDescriptor,
        ElementNode? childNode,
        IReadOnlyList<ElementNode>? childNodes,
        Action<AvaloniaObject, AvaloniaObject>? childAttach,
        Action<AvaloniaObject, IReadOnlyList<AvaloniaObject>>? childrenAttach)
    {
        _kind = kind;
        _propertyId = propertyId;
        _property = property;
        _value = value;
        _bindingDescriptor = bindingDescriptor;
        _childNode = childNode;
        _childNodes = childNodes;
        _childAttach = childAttach;
        _childrenAttach = childrenAttach;
    }

    /// <summary>
    /// Creates a mutation that sets a literal value.
    /// </summary>
    public static PropertyMutation ForValue(int propertyId, AvaloniaProperty property, object? value)
    {
        return new PropertyMutation(
            PropertyMutationKind.SetValue,
            propertyId,
            property ?? throw new ArgumentNullException(nameof(property)),
            value,
            bindingDescriptor: null,
            childNode: null,
            childNodes: null,
            childAttach: null,
            childrenAttach: null);
    }

    /// <summary>
    /// Creates a mutation that sets a binding.
    /// </summary>
    public static PropertyMutation ForBinding(BindingDescriptor descriptor, IBinding binding)
    {
        ArgumentNullException.ThrowIfNull(binding);

        return new PropertyMutation(
            PropertyMutationKind.SetBinding,
            descriptor.PropertyId,
            property: null,
            value: binding,
            descriptor,
            childNode: null,
            childNodes: null,
            childAttach: null,
            childrenAttach: null);
    }

    /// <summary>
    /// Creates a mutation that attaches a single child node.
    /// </summary>
    public static PropertyMutation ForChild(ElementNode childNode, Action<AvaloniaObject, AvaloniaObject> attach)
    {
        ArgumentNullException.ThrowIfNull(childNode);
        ArgumentNullException.ThrowIfNull(attach);

        return new PropertyMutation(
            PropertyMutationKind.AttachChild,
            PropertyMetadata.InvalidPropertyId,
            property: null,
            value: null,
            bindingDescriptor: null,
            childNode,
            childNodes: null,
            attach,
            childrenAttach: null);
    }

    /// <summary>
    /// Creates a mutation that attaches multiple child nodes in order.
    /// </summary>
    public static PropertyMutation ForChildren(IReadOnlyList<ElementNode> childNodes, Action<AvaloniaObject, IReadOnlyList<AvaloniaObject>> attach)
    {
        ArgumentNullException.ThrowIfNull(childNodes);
        ArgumentNullException.ThrowIfNull(attach);

        return new PropertyMutation(
            PropertyMutationKind.AttachChildren,
            PropertyMetadata.InvalidPropertyId,
            property: null,
            value: null,
            bindingDescriptor: null,
            childNode: null,
            childNodes,
            childAttach: null,
            attach);
    }

    /// <summary>
    /// Applies the recorded mutation to the provided control instance.
    /// </summary>
    public void Apply(AvaloniaObject target)
    {
        switch (_kind)
        {
            case PropertyMutationKind.SetValue:
                target[_property!] = MaterializeValue(_value);
                break;

            case PropertyMutationKind.SetBinding:
                var descriptor = _bindingDescriptor!.Value.Property.Bind()
                    .WithMode(_bindingDescriptor.Value.Mode)
                    .WithPriority(_bindingDescriptor.Value.Priority);
                target[descriptor] = (IBinding)_value!;
                break;

            case PropertyMutationKind.AttachChild:
                AttachChild(target);
                break;

            case PropertyMutationKind.AttachChildren:
                AttachChildren(target);
                break;

            default:
                throw new InvalidOperationException($"Unsupported mutation kind '{_kind}'.");
        }
    }

    private void AttachChild(AvaloniaObject target)
    {
        var builtChild = _childNode!.Build();
        _childAttach!(target, builtChild);
    }

    private void AttachChildren(AvaloniaObject target)
    {
        var builtChildren = _childNodes!
            .Select(node => node.Build())
            .ToArray();
        _childrenAttach!(target, builtChildren);
    }

    internal int PropertyId => _propertyId;

    internal PropertyMutationKind Kind => _kind;

    internal object? Value => _value;

    internal AvaloniaProperty? Property => _property;

    internal BindingDescriptor? Descriptor => _bindingDescriptor;

    internal ElementNode? ChildNode => _childNode;

    internal IReadOnlyList<ElementNode>? ChildNodes => _childNodes;

    internal Action<AvaloniaObject, AvaloniaObject>? ChildAttach => _childAttach;

    internal Action<AvaloniaObject, IReadOnlyList<AvaloniaObject>>? ChildrenAttach => _childrenAttach;

    private static object? MaterializeValue(object? value)
    {
        return value switch
        {
            null => null,
            ElementNode node => node.Build(),
            IReadOnlyList<ElementNode> children => children.Select(node => node.Build()).ToArray(),
            _ => value,
        };
    }
}

internal enum PropertyMutationKind
{
    SetValue,
    SetBinding,
    AttachChild,
    AttachChildren,
}
#endif
