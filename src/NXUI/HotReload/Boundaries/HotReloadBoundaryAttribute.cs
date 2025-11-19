namespace NXUI.HotReload;

using System;

/// <summary>
/// Marks a control as a hot reload boundary so its subtree is treated as opaque during reconciliation.
/// </summary>
[AttributeUsage(AttributeTargets.Class, Inherited = true, AllowMultiple = false)]
public sealed class HotReloadBoundaryAttribute : Attribute
{
}

/// <summary>
/// Marks a control as a candidate for implicit weaving when the boundary weaver runs.
/// </summary>
[AttributeUsage(AttributeTargets.Class, Inherited = true, AllowMultiple = false)]
public sealed class HotReloadCandidateBoundaryAttribute : Attribute
{
}

/// <summary>
/// Marker interface alternative to <see cref="HotReloadBoundaryAttribute"/>.
/// </summary>
public interface IHotReloadBoundaryMarker
{
}
