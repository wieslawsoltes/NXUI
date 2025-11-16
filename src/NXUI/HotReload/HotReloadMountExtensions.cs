namespace NXUI.HotReload;

using Avalonia;

/// <summary>
/// Provides shim helpers so fluent code can call <c>.Mount()</c> regardless of build configuration.
/// </summary>
public static class HotReloadMountExtensions
{
    /// <summary>
    /// No-op helper that keeps fluent code source-compatible when hot reload is disabled.
    /// </summary>
    /// <typeparam name="T">Avalonia object type.</typeparam>
    /// <param name="control">The control instance.</param>
    /// <returns>The same control instance.</returns>
    public static T Mount<T>(this T control) where T : AvaloniaObject
    {
        return control;
    }
}
