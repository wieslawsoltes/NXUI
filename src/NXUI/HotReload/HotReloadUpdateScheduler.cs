#if NXUI_HOTRELOAD
namespace NXUI.HotReload;

using System;
using System.Threading;
using System.Threading.Tasks;
using Avalonia.Threading;

/// <summary>
/// Debounces metadata update notifications to avoid redundant reconcile passes.
/// </summary>
internal sealed class HotReloadUpdateScheduler
{
    private readonly ComponentRegistry _registry;
    private readonly TimeSpan _debounce;
    private int _pending;

    internal HotReloadUpdateScheduler(ComponentRegistry registry, TimeSpan? debounce = null)
    {
        _registry = registry ?? throw new ArgumentNullException(nameof(registry));
        _debounce = debounce ?? TimeSpan.FromMilliseconds(200);
    }

    internal void RequestRefresh(Type[]? updatedTypes, string source)
    {
        if (Interlocked.Exchange(ref _pending, 1) == 1)
        {
            return;
        }

        _ = Task.Run(async () =>
        {
            try
            {
                await Task.Delay(_debounce).ConfigureAwait(false);

                if (Dispatcher.UIThread.CheckAccess())
                {
                    _registry.RefreshMatching(updatedTypes, source);
                }
                else
                {
                    await Dispatcher.UIThread.InvokeAsync(() => _registry.RefreshMatching(updatedTypes, source));
                }
            }
            catch (Exception ex)
            {
                HotReloadDiagnostics.Trace($"Hot reload refresh failure: {ex}");
            }
            finally
            {
                Volatile.Write(ref _pending, 0);
            }
        });
    }
}
#endif
