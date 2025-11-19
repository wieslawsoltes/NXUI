namespace NXUI.HotReload;

using System;
using System.Collections.Generic;
using System.Threading.Tasks;
using Avalonia.Threading;

/// <summary>
/// Debounces metadata update notifications to avoid redundant reconcile passes.
/// </summary>
internal sealed class HotReloadUpdateScheduler
{
    private readonly ComponentRegistry _registry;
    private readonly TimeSpan _debounce;
    private readonly object _gate = new();
    private readonly HashSet<Type> _pendingTypes = new();
    private readonly List<string> _sources = new();
    private readonly Action<Type[]?, string>? _onRefresh;
    private bool _scheduled;
    private bool _globalRefresh;

    internal HotReloadUpdateScheduler(ComponentRegistry registry, TimeSpan? debounce = null, Action<Type[]?, string>? onRefresh = null)
    {
        _registry = registry ?? throw new ArgumentNullException(nameof(registry));
        _debounce = debounce ?? TimeSpan.FromMilliseconds(200);
        _onRefresh = onRefresh;
    }

    internal void RequestRefresh(Type[]? updatedTypes, string source)
    {
        var normalizedSource = string.IsNullOrWhiteSpace(source) ? "Unknown" : source;
        var schedule = false;

        lock (_gate)
        {
            _sources.Add(normalizedSource);

            if (_globalRefresh)
            {
                // Once a global refresh is requested we ignore further type collection.
            }
            else if (updatedTypes is null || updatedTypes.Length == 0)
            {
                _globalRefresh = true;
                _pendingTypes.Clear();
            }
            else
            {
                for (var i = 0; i < updatedTypes.Length; i++)
                {
                    var type = updatedTypes[i];
                    if (type is not null)
                    {
                        _pendingTypes.Add(type);
                    }
                }
            }

            if (!_scheduled)
            {
                _scheduled = true;
                schedule = true;
            }
        }

        if (!schedule)
        {
            return;
        }

        _ = Task.Run(async () =>
        {
            try
            {
                await Task.Delay(_debounce).ConfigureAwait(false);

                Type[]? snapshotTypes;
                string sourceSummary;
                lock (_gate)
                {
                    snapshotTypes = _globalRefresh
                        ? null
                        : (_pendingTypes.Count > 0 ? _pendingTypes.ToArray() : Array.Empty<Type>());

                    sourceSummary = _sources.Count switch
                    {
                        0 => "Unknown",
                        1 => _sources[0],
                        _ => string.Join(", ", _sources),
                    };

                    _pendingTypes.Clear();
                    _sources.Clear();
                    _globalRefresh = false;
                    _scheduled = false;
                }

                _onRefresh?.Invoke(snapshotTypes, sourceSummary);

                if (Dispatcher.UIThread.CheckAccess())
                {
                    _registry.RefreshMatching(snapshotTypes, sourceSummary);
                }
                else
                {
                    await Dispatcher.UIThread.InvokeAsync(() => _registry.RefreshMatching(snapshotTypes, sourceSummary));
                }
            }
            catch (Exception ex)
            {
                HotReloadDiagnostics.Trace($"Hot reload refresh failure: {ex}");
            }
        });
    }
}
