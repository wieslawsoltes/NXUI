namespace NXUI.HotReload.Nodes;

using System;
using Avalonia;
using Avalonia.Data;

/// <summary>
/// Describes a binding request captured while recording a fluent node tree.
/// </summary>
public readonly struct BindingDescriptor : IEquatable<BindingDescriptor>
{
    /// <summary>
    /// Initializes a new instance of the <see cref="BindingDescriptor"/> struct.
    /// </summary>
    /// <param name="propertyId">The metadata id for the property.</param>
    /// <param name="property">The target property.</param>
    /// <param name="mode">The binding mode.</param>
    /// <param name="priority">The binding priority.</param>
    public BindingDescriptor(int propertyId, AvaloniaProperty property, BindingMode mode, BindingPriority priority)
    {
        if (propertyId <= 0)
        {
            throw new ArgumentOutOfRangeException(nameof(propertyId));
        }

        PropertyId = propertyId;
        Property = property ?? throw new ArgumentNullException(nameof(property));
        Mode = mode;
        Priority = priority;
    }

    /// <summary>
    /// Gets the property this descriptor targets.
    /// </summary>
    public AvaloniaProperty Property { get; }

    /// <summary>
    /// Gets the requested binding mode.
    /// </summary>
    public BindingMode Mode { get; }

    /// <summary>
    /// Gets the requested binding priority.
    /// </summary>
    public BindingPriority Priority { get; }

    /// <summary>
    /// Gets the metadata identifier for the property.
    /// </summary>
    public int PropertyId { get; }

    /// <inheritdoc/>
    public bool Equals(BindingDescriptor other)
    {
        return PropertyId == other.PropertyId
            && ReferenceEquals(Property, other.Property)
            && Mode == other.Mode
            && Priority == other.Priority;
    }

    /// <inheritdoc/>
    public override bool Equals(object? obj)
    {
        return obj is BindingDescriptor other && Equals(other);
    }

    /// <inheritdoc/>
    public override int GetHashCode()
    {
        return HashCode.Combine(PropertyId, Property, Mode, Priority);
    }
}
