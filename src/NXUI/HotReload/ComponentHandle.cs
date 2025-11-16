#if NXUI_HOTRELOAD
namespace NXUI.HotReload;

using System;
using Avalonia;
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
    private ElementNode? _current;
    private bool _disposed;

    internal ComponentHandle(string id, Func<ElementNode> factory, IComponentHost host, Action<string>? onDisposed)
    {
        _id = id;
        _factory = factory;
        _host = host;
        _onDisposed = onDisposed;
    }

    internal string Id => _id;

    internal bool IsMaterialized => _current?.AdoptedInstance is not null;

    /// <summary>
    /// Builds the initial node tree and attaches the result to the host.
    /// </summary>
    internal AvaloniaObject Attach(ElementNode? initialSnapshot = null)
    {
        AvaloniaObject instance;

        if (initialSnapshot is not null)
        {
            _current = initialSnapshot;
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
#endif
