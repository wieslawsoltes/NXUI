#if NXUI_HOTRELOAD
namespace NXUI.HotReload;

using System;
using System.Collections.Concurrent;
using System.Collections.Generic;
using System.Linq;
using NXUI.HotReload.Nodes;

/// <summary>
/// Tracks registered hot reload components and orchestrates refresh operations.
/// </summary>
internal sealed class ComponentRegistry
{
    private readonly ConcurrentDictionary<string, ComponentHandle> _components = new(StringComparer.Ordinal);

    /// <summary>
    /// Registers a component factory and host.
    /// </summary>
    internal ComponentHandle Register(string id, Func<ElementNode> factory, IComponentHost host)
    {
        ArgumentException.ThrowIfNullOrWhiteSpace(id);
        ArgumentNullException.ThrowIfNull(factory);
        ArgumentNullException.ThrowIfNull(host);

        var handle = new ComponentHandle(id, factory, host, Remove);
        if (!_components.TryAdd(id, handle))
        {
            handle.Dispose();
            throw new InvalidOperationException($"Component '{id}' is already registered.");
        }

        HotReloadDiagnostics.Trace($"Registered hot reload component '{id}'.");
        return handle;
    }

    /// <summary>
    /// Returns a stable snapshot of the currently tracked handles.
    /// </summary>
    internal IReadOnlyList<ComponentHandle> Snapshot()
    {
        return _components.Values.ToArray();
    }

    /// <summary>
    /// Refreshes all registered components.
    /// </summary>
    internal void RefreshAll(Type[]? updatedTypes, string source)
    {
        var handles = Snapshot();
        if (handles.Count == 0)
        {
            return;
        }

        HotReloadDiagnostics.Trace($"Applying hot reload updates (source={source}, types={DescribeTypes(updatedTypes)}) to {handles.Count} component(s).");

        foreach (var handle in handles)
        {
            try
            {
                handle.TryRefresh(source);
            }
            catch (Exception ex)
            {
                HotReloadDiagnostics.Trace($"Hot reload refresh failed for component '{handle.Id}': {ex}");
            }
        }
    }

    private void Remove(string id)
    {
        _components.TryRemove(id, out _);
    }

    private static string DescribeTypes(Type[]? types)
    {
        if (types is null || types.Length == 0)
        {
            return "none";
        }

        if (types.Length == 1)
        {
            return types[0].FullName ?? types[0].Name;
        }

        return string.Join(", ", types.Select(t => t.Name));
    }
}
#endif
