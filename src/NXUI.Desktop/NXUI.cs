using Avalonia;
using Avalonia.Controls;
using Avalonia.Controls.ApplicationLifetimes;
using Avalonia.Styling;
using NXUI.Extensions;

namespace NXUI.Desktop;

/// <summary>
/// 
/// </summary>
public static class NXUI
{
    /// <summary>
    /// 
    /// </summary>
    /// <param name="callback"></param>
    /// <param name="name"></param>
    /// <param name="args"></param>
    /// <param name="themeVariant"></param>
    /// <param name="shutdownMode"></param>
    /// <returns></returns>
    public static int Run(
        Action<IClassicDesktopStyleApplicationLifetime>? callback, 
        string name,
        string[] args, 
        ThemeVariant? themeVariant = null,
        ShutdownMode shutdownMode = ShutdownMode.OnLastWindowClose)
    {
        return AppBuilder.Configure<Application>()
            .UsePlatformDetect()
            .UseFluentTheme(themeVariant)
            .WithApplicationName(name)
            .StartWithClassicDesktopLifetime(callback, args, shutdownMode);
    }

    /// <summary>
    /// 
    /// </summary>
    /// <param name="callback"></param>
    /// <param name="name"></param>
    /// <param name="args"></param>
    /// <param name="themeVariant"></param>
    /// <param name="shutdownMode"></param>
    /// <returns></returns>
    public static int Run(
        Func<Window>? callback, 
        string name,
        string[] args, 
        ThemeVariant? themeVariant = null,
        ShutdownMode shutdownMode = ShutdownMode.OnLastWindowClose)
    {
        return AppBuilder.Configure<Application>()
            .UsePlatformDetect()
            .UseFluentTheme(themeVariant)
            .WithApplicationName(name)
            .StartWithClassicDesktopLifetime(callback, args, shutdownMode);
    }
}
