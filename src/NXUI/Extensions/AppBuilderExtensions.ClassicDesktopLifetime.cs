namespace NXUI.Extensions;

/// <summary>
/// 
/// </summary>
public static partial class AppBuilderExtensions
{
    /// <summary>
    /// 
    /// </summary>
    /// <param name="builder"></param>
    /// <param name="callback"></param>
    /// <param name="args"></param>
    /// <param name="shutdownMode"></param>
    /// <typeparam name="T"></typeparam>
    /// <returns></returns>
    public static int StartWithClassicDesktopLifetime<T>(
        this T builder, 
        Action<IClassicDesktopStyleApplicationLifetime>? callback, 
        string[] args, 
        ShutdownMode shutdownMode = ShutdownMode.OnLastWindowClose) where T : AppBuilderBase<T>, new()
    {
        var lifetime = new ClassicDesktopStyleApplicationLifetime
        {
            Args = args,
            ShutdownMode = shutdownMode
        };

        builder.SetupWithLifetime(lifetime);

        callback?.Invoke(lifetime);
        
        return lifetime.Start(args);
    }

    /// <summary>
    /// 
    /// </summary>
    /// <param name="builder"></param>
    /// <param name="callback"></param>
    /// <param name="args"></param>
    /// <param name="shutdownMode"></param>
    /// <typeparam name="T"></typeparam>
    /// <returns></returns>
    public static int StartWithClassicDesktopLifetime<T>(
        this T builder, 
        Func<Window>? callback, 
        string[] args, 
        ShutdownMode shutdownMode = ShutdownMode.OnLastWindowClose) where T : AppBuilderBase<T>, new()
    {
        var lifetime = new ClassicDesktopStyleApplicationLifetime
        {
            Args = args,
            ShutdownMode = shutdownMode
        };

        builder.SetupWithLifetime(lifetime);

        lifetime.MainWindow = callback?.Invoke();

        return lifetime.Start(args);
    }
}
