namespace NXUI.HotReload;

using System;
using Avalonia;
using Avalonia.Controls;
using Avalonia.Controls.ApplicationLifetimes;
using Avalonia.Styling;
using NXUI.Extensions;
using DesktopBootstrap = NXUI.Desktop.NXUI;
#if NXUI_HOTRELOAD
using NXUI.HotReload.Nodes;
#endif

/// <summary>
/// Helper that wires NXUI hot reload into classic desktop lifetimes.
/// </summary>
public static class HotReloadHost
{
    public static int Run(
        Func<object> build,
        string applicationName,
        string[] args,
        ThemeVariant? themeVariant = null,
        ShutdownMode shutdownMode = ShutdownMode.OnLastWindowClose)
    {
        ArgumentNullException.ThrowIfNull(build);
        args ??= Array.Empty<string>();

#if NXUI_HOTRELOAD
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
#endif

        return DesktopBootstrap.Run(() => EnsureWindow(build()), applicationName, args, themeVariant, shutdownMode);
    }

#if NXUI_HOTRELOAD
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
        if (initial is not ElementBuilder<Window> initialBuilder)
        {
            HotReloadDiagnostics.Trace("Build delegate returned an instantiated Window. Falling back to cold path.");
            return false;
        }

        ElementNode CreateNode()
        {
            var snapshot = build() ?? throw new InvalidOperationException("Hot reload build delegate returned null.");
            if (snapshot is ElementBuilder<Window> builder)
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
#endif

    private static Window EnsureWindow(object? value)
    {
        if (value is Window window)
        {
            return window;
        }

#if NXUI_HOTRELOAD
        if (value is ElementBuilder<Window> builder)
        {
            return builder.Mount();
        }
#endif

        throw new InvalidOperationException(value is null
            ? "Build delegate returned null. Expected a Window."
            : $"Build delegate must return an Avalonia.Controls.Window. Received '{value.GetType().FullName}'.");
    }
}
