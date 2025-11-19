namespace NXUI.HotReload;

using System;
using System.Diagnostics.CodeAnalysis;
using System.Threading;
using Avalonia;
using NXUI.HotReload.Nodes;

/// <summary>
/// Internal helper that centralizes conditional hot reload behavior.
/// </summary>
internal static class HotReloadGuards
{
    private static readonly ComponentRegistry s_registry = new();
    private static readonly HotReloadUpdateScheduler s_scheduler = new(s_registry);
    private static int _initialized;

    internal static bool IsHotReloadBuild => true;

    internal static bool TryInitialize(AppBuilder builder)
    {
        ArgumentNullException.ThrowIfNull(builder);

        if (Interlocked.Exchange(ref _initialized, 1) == 1)
        {
            return false;
        }

        EnsureModifiableAssemblies();
        HotReloadDiagnostics.Trace("NXUI hot reload runtime initialized.");
        return true;
    }

    internal static ComponentHandle RegisterComponent(string id, Func<ElementNode> factory, IComponentHost host)
    {
        return s_registry.Register(id, factory, host);
    }

    internal static void NotifyCodeUpdates(Type[]? updatedTypes, string source)
    {
        s_scheduler.RequestRefresh(updatedTypes, source);
    }

    private static void EnsureModifiableAssemblies()
    {
        var current = Environment.GetEnvironmentVariable("DOTNET_MODIFIABLE_ASSEMBLIES");
        if (string.IsNullOrEmpty(current))
        {
            Environment.SetEnvironmentVariable("DOTNET_MODIFIABLE_ASSEMBLIES", "debug");
        }
    }
}
