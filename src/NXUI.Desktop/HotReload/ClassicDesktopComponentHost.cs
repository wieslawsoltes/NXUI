#if NXUI_HOTRELOAD
namespace NXUI.HotReload;

using System;
using Avalonia;
using Avalonia.Controls;
using Avalonia.Controls.ApplicationLifetimes;

/// <summary>
/// Hosts a single <see cref="Window"/> instance inside a classic desktop lifetime.
/// </summary>
internal sealed class ClassicDesktopComponentHost : IComponentHost
{
    private readonly IClassicDesktopStyleApplicationLifetime _lifetime;
    private Window? _currentWindow;

    internal ClassicDesktopComponentHost(IClassicDesktopStyleApplicationLifetime lifetime)
    {
        _lifetime = lifetime ?? throw new ArgumentNullException(nameof(lifetime));
    }

    public void AttachRoot(AvaloniaObject instance)
    {
        if (instance is not Window window)
        {
            throw new InvalidOperationException("Hot reload desktop host requires a Window root.");
        }

        _currentWindow = window;
        _lifetime.MainWindow = window;
    }

    public void OnRootReplaced(AvaloniaObject oldRoot, AvaloniaObject newRoot)
    {
        if (oldRoot is not Window oldWindow || newRoot is not Window newWindow)
        {
            return;
        }

        _currentWindow = newWindow;
        _lifetime.MainWindow = newWindow;
        newWindow.Show();
        oldWindow.Close();
    }

    public void OnComponentUpdated(ReconcileResult result)
    {
        if (result.HasChanges)
        {
            HotReloadDiagnostics.Trace($"[HotReload] Applied updates to '{_currentWindow?.Title ?? "MainWindow"}' ({result.ReplaceSubtreeCount} replaces, {result.SetPropertyCount} sets).");
        }
    }

    public void OnComponentDisposed(AvaloniaObject? instance)
    {
        if (instance is Window window)
        {
            window.Close();
        }

        _currentWindow = null;
    }
}
#endif
