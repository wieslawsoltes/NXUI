namespace NXUI.HotReload;

using System;
using System.Collections.Concurrent;

/// <summary>
/// Provides helpers for determining whether a control type should behave as a hot reload boundary.
/// </summary>
internal static class HotReloadBoundaryMetadata
{
    private static readonly ConcurrentDictionary<Type, bool> s_cache = new();

    internal static bool IsBoundary(Type? controlType)
    {
        if (controlType is null)
        {
            return false;
        }

        return s_cache.GetOrAdd(
            controlType,
            static type => typeof(IHotReloadBoundaryMarker).IsAssignableFrom(type)
                || type.IsDefined(typeof(HotReloadBoundaryAttribute), inherit: true)
                || type.IsDefined(typeof(HotReloadCandidateBoundaryAttribute), inherit: true));
    }
}
