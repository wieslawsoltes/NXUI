namespace NXUI.HotReload;

using System;
using Avalonia;
using Avalonia.Controls;
using Avalonia.Controls.ApplicationLifetimes;
using Avalonia.Styling;
using NXUI.Extensions;
using DesktopBootstrap = NXUI.Desktop.NXUI;
using NXUI.HotReload.Nodes;

/// <summary>
/// Helper that wires NXUI hot reload into classic desktop lifetimes.
/// </summary>
public static class HotReloadHost
{
    /// <summary>
    /// Starts an NXUI application with optional hot reload support on classic desktop lifetimes.
    /// </summary>
    /// <param name="build">Delegate that produces the main window or window builder.</param>
    /// <param name="applicationName">The application name passed to Avalonia.</param>
    /// <param name="args">Command-line arguments.</param>
    /// <param name="themeVariant">Optional theme variant injected into the fluent theme.</param>
    /// <param name="shutdownMode">Determines how the desktop lifetime shuts down.</param>
    /// <returns>The process exit code.</returns>
    public static int Run(
        Func<object> build,
        string applicationName,
        string[] args,
        ThemeVariant? themeVariant = null,
        ShutdownMode shutdownMode = ShutdownMode.OnLastWindowClose)
    {
        ArgumentNullException.ThrowIfNull(build);
        args ??= Array.Empty<string>();

        if (HotReloadManager.IsHotReloadBuild)
        {
            return AppBuilder.Configure<Application>()
                .UsePlatformDetect()
                .UseFluentTheme(themeVariant)
                .WithApplicationName(applicationName)
                .UseNXUIHotReload()
                .StartWithClassicDesktopLifetime(
                    lifetime => ConfigureLifetime(build, applicationName, lifetime),
                    args,
                    shutdownMode);
        }

        return DesktopBootstrap.Run(() => EnsureWindow(build()), applicationName, args, themeVariant, shutdownMode);
    }

    private static void ConfigureLifetime(
        Func<object> build,
        string applicationName,
        IClassicDesktopStyleApplicationLifetime lifetime)
    {
        if (!TryAttachHotReload(build, applicationName, lifetime))
        {
            lifetime.MainWindow = EnsureWindow(build());
        }
    }

    private static bool TryAttachHotReload(
        Func<object> build,
        string applicationName,
        IClassicDesktopStyleApplicationLifetime lifetime)
    {
        var initial = build() ?? throw new InvalidOperationException("Hot reload build delegate returned null.");
        if (initial is not WindowBuilder initialBuilder)
        {
            HotReloadDiagnostics.Trace("Build delegate returned an instantiated Window. Falling back to cold path.");
            return false;
        }

        ElementNode CreateNode()
        {
            var snapshot = build() ?? throw new InvalidOperationException("Hot reload build delegate returned null.");
            if (snapshot is WindowBuilder builder)
            {
                return builder.Node;
            }

            throw new InvalidOperationException($"Unsupported hot reload root type '{snapshot.GetType().FullName}'.");
        }

        var host = new ClassicDesktopComponentHost(lifetime);
        var id = $"{applicationName ?? "NXUI"}.MainWindow";
        var handle = HotReloadManager.RegisterComponent(id, CreateNode, host);

        var root = handle.Attach(initialBuilder.Node);
        if (root is not Window window)
        {
            handle.Dispose();
            throw new InvalidOperationException("Hot reload root must be a Window.");
        }

        lifetime.MainWindow = window;
        window.Closed += (_, _) => handle.Dispose();
        return true;
    }

    private static Window EnsureWindow(object? value)
    {
        if (value is Window window)
        {
            return window;
        }

        if (value is WindowBuilder builder)
        {
            return builder.Mount();
        }

        throw new InvalidOperationException(value is null
            ? "Build delegate returned null. Expected a Window."
            : $"Build delegate must return an Avalonia.Controls.Window. Received '{value.GetType().FullName}'.");
    }
}
