namespace NXUI.HotReload;

using System;

/// <summary>
/// Placeholder disposable used until real component registrations are needed.
/// </summary>
internal sealed class HotReloadNoOpDisposable : IDisposable
{
    internal static readonly HotReloadNoOpDisposable Instance = new();

    private HotReloadNoOpDisposable()
    {
    }

    public void Dispose()
    {
        // Intentionally left blank.
    }
}
