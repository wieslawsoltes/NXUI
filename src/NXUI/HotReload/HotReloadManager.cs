namespace NXUI.HotReload;

using System;
using Avalonia;
using NXUI.HotReload.Nodes;

/// <summary>
/// Public surface that future hot reload integrations will hang from.
/// Milestone 0 provides no-op behavior but keeps the API stable for callers.
/// </summary>
public static class HotReloadManager
{
    /// <summary>
    /// Gets a value indicating whether the current build is compiled with the hot reload flag.
    /// </summary>
    public static bool IsHotReloadBuild => HotReloadGuards.IsHotReloadBuild;

    /// <summary>
    /// Initializes NXUI hot reload infrastructure. Currently a no-op placeholder.
    /// </summary>
    /// <param name="builder">Avalonia application builder.</param>
    /// <returns>True when initialization logic executed; false if already initialized or disabled.</returns>
    public static bool Initialize(AppBuilder builder)
    {
        ArgumentNullException.ThrowIfNull(builder);

        return HotReloadGuards.TryInitialize(builder);
    }

    /// <summary>
    /// Registers a component factory so future hot reload transports can refresh it in-place.
    /// </summary>
    /// <param name="id">Stable identifier for the component.</param>
    /// <param name="factory">Factory that produces a fresh node tree for the component root.</param>
    /// <param name="host">Host responsible for attaching the root instance.</param>
    /// <returns>A handle that can dispose the registration.</returns>
    internal static ComponentHandle RegisterComponent(string id, Func<ElementNode> factory, IComponentHost host)
    {
        if (string.IsNullOrWhiteSpace(id))
        {
            throw new ArgumentException("Component id must be provided.", nameof(id));
        }

        ArgumentNullException.ThrowIfNull(factory);
        ArgumentNullException.ThrowIfNull(host);

        return HotReloadGuards.RegisterComponent(id, factory, host);
    }

    internal static void NotifyCodeUpdates(Type[]? updatedTypes, string source)
    {
        HotReloadGuards.NotifyCodeUpdates(updatedTypes, source);
    }
}
