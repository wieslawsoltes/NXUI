namespace NXUI.HotReload;

using System;
using System.Collections.Generic;
using System.Reflection;
using System.Runtime.CompilerServices;
using Avalonia;
using NXUI.HotReload.Metadata;
using NXUI.HotReload.State;
using NXUI.HotReload.Nodes;

/// <summary>
/// Represents a registered hot reload component and coordinates reconcile operations.
/// </summary>
internal sealed class ComponentHandle : IDisposable
{
    private readonly string _id;
    private readonly Func<ElementNode> _factory;
    private readonly IComponentHost _host;
    private readonly Action<string>? _onDisposed;
    private readonly Type? _factoryType;
    private readonly bool _factoryTypeIsCompilerGenerated;
    private readonly Assembly? _factoryAssembly;
    private readonly Type? _targetType;
    private readonly bool _targetTypeIsCompilerGenerated;
    private readonly Assembly? _targetAssembly;
    private readonly HashSet<int> _typeDependencies = new();
    private ElementNode? _current;
    private bool _disposed;

    internal ComponentHandle(string id, Func<ElementNode> factory, IComponentHost host, Action<string>? onDisposed)
    {
        _id = id;
        _factory = factory;
        _host = host;
        _onDisposed = onDisposed;

        var method = factory.Method;
        _factoryType = method.DeclaringType;
        _factoryTypeIsCompilerGenerated = IsCompilerGenerated(_factoryType);
        _factoryAssembly = _factoryType?.Assembly ?? method.Module?.Assembly;

        _targetType = factory.Target?.GetType();
        _targetTypeIsCompilerGenerated = IsCompilerGenerated(_targetType);
        _targetAssembly = _targetType?.Assembly;
    }

    internal string Id => _id;

    internal bool IsMaterialized => _current?.AdoptedInstance is not null;

    internal bool MatchesUpdate(Type[] updatedTypes, HashSet<Assembly> updatedAssemblies, HashSet<int> updatedTypeIds)
    {
        if (updatedTypes.Length == 0 && updatedTypeIds.Count == 0)
        {
            return true;
        }

        if (updatedTypeIds.Count > 0 && _typeDependencies.Count > 0)
        {
            foreach (var typeId in _typeDependencies)
            {
                if (updatedTypeIds.Contains(typeId))
                {
                    return true;
                }
            }
        }

        if (_factoryType is not null && TypeMatches(updatedTypes, _factoryType))
        {
            return true;
        }

        if (_targetType is not null && TypeMatches(updatedTypes, _targetType))
        {
            return true;
        }

        var allowAssemblyFallback = (_factoryType is null && _targetType is null)
            || _factoryTypeIsCompilerGenerated
            || _targetTypeIsCompilerGenerated;

        if (!allowAssemblyFallback)
        {
            return false;
        }

        if (updatedAssemblies.Count == 0)
        {
            return false;
        }

        if (_factoryAssembly is not null && updatedAssemblies.Contains(_factoryAssembly))
        {
            return true;
        }

        if (_targetAssembly is not null && updatedAssemblies.Contains(_targetAssembly))
        {
            return true;
        }

        return false;
    }

    private static bool TypeMatches(Type[] candidates, Type type)
    {
        for (var i = 0; i < candidates.Length; i++)
        {
            if (candidates[i] == type)
            {
                return true;
            }
        }

        return false;
    }

    private static bool IsCompilerGenerated(Type? type)
    {
        return type is not null
            && Attribute.IsDefined(type, typeof(System.Runtime.CompilerServices.CompilerGeneratedAttribute), inherit: false);
    }

    private void UpdateTypeDependencies(ElementNode root)
    {
        _typeDependencies.Clear();
        CollectTypeIds(root, _typeDependencies);
    }

    private static void CollectTypeIds(ElementNode node, HashSet<int> set)
    {
        if (node.TypeId > TypeMetadata.InvalidTypeId)
        {
            set.Add(node.TypeId);
        }
        else if (node.ControlType is { } type && TypeMetadata.TryGetId(type, out var typeId))
        {
            set.Add(typeId);
        }

        var children = node.Children;
        for (var i = 0; i < children.Count; i++)
        {
            CollectTypeIds(children[i], set);
        }
    }

    /// <summary>
    /// Builds the initial node tree and attaches the result to the host.
    /// </summary>
    internal AvaloniaObject Attach(ElementNode? initialSnapshot = null)
    {
        AvaloniaObject instance;

        if (initialSnapshot is not null)
        {
            _current = initialSnapshot;
            UpdateTypeDependencies(initialSnapshot);
            instance = initialSnapshot.Build();
        }
        else
        {
            instance = EnsureMaterialized();
        }

        _host.AttachRoot(instance);
        return instance;
    }

    /// <summary>
    /// Attempts to refresh the component by diffing the previous and next trees.
    /// </summary>
    internal void TryRefresh(string source)
    {
        if (_current is null)
        {
            return;
        }

        var previousRoot = _current.AdoptedInstance;
        var next = CreateSnapshot();
        var result = NodeRenderer.Instance.Reconcile(_current, next);
        _current = next;

        var rootInstance = result.RootInstance ?? next.AdoptedInstance;
        if (rootInstance is null)
        {
            return;
        }

        if (!result.HasChanges)
        {
            return;
        }

        if (result.ReplacedRoot && previousRoot is not null && !ReferenceEquals(previousRoot, rootInstance))
        {
            HotReloadStateCoordinator.TransferState(previousRoot, rootInstance);
            HotReloadDiagnostics.Trace($"[{source}] Component '{_id}' replaced root instance.");
            _host.OnRootReplaced(previousRoot, rootInstance);
        }
        else
        {
            _host.OnComponentUpdated(result);
        }
    }

    private AvaloniaObject EnsureMaterialized()
    {
        ThrowIfDisposed();
        if (_current is { AdoptedInstance: { } existing })
        {
            return existing;
        }

        var snapshot = CreateSnapshot();
        var instance = snapshot.Build();
        _current = snapshot;
        return instance;
    }

    private ElementNode CreateSnapshot()
    {
        ThrowIfDisposed();
        var snapshot = _factory() ?? throw new InvalidOperationException("Hot reload component factory returned null.");
        UpdateTypeDependencies(snapshot);
        return snapshot;
    }

    private void ThrowIfDisposed()
    {
        if (_disposed)
        {
            throw new ObjectDisposedException(nameof(ComponentHandle));
        }
    }

    public void Dispose()
    {
        if (_disposed)
        {
            return;
        }

        _disposed = true;
        try
        {
            _host.OnComponentDisposed(_current?.AdoptedInstance);
        }
        catch (Exception ex)
        {
            HotReloadDiagnostics.Trace($"Component '{_id}' disposal failed: {ex}");
        }
        finally
        {
            _current = null;
            _onDisposed?.Invoke(_id);
        }
    }
}
