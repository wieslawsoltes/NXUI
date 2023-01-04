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
    /// <returns></returns>
    public static int StartWithClassicDesktopLifetime(
        this AppBuilder builder, 
        Action<IClassicDesktopStyleApplicationLifetime>? callback, 
        string[] args, 
        ShutdownMode shutdownMode = ShutdownMode.OnLastWindowClose)
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
    /// <returns></returns>
    public static int StartWithClassicDesktopLifetime(
        this AppBuilder builder, 
        Func<Window>? callback, 
        string[] args, 
        ShutdownMode shutdownMode = ShutdownMode.OnLastWindowClose)
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

    /// <summary>
    /// 
    /// </summary>
    /// <param name="builder"></param>
    /// <param name="callback"></param>
    /// <param name="args"></param>
    /// <param name="shutdownMode"></param>
    /// <returns></returns>
    public static int StartWithClassicDesktopLifetime(
        this AppBuilder builder, 
        Builder<Window>? callback, 
        string[] args, 
        ShutdownMode shutdownMode = ShutdownMode.OnLastWindowClose)
    {
        var lifetime = new ClassicDesktopStyleApplicationLifetime
        {
            Args = args,
            ShutdownMode = shutdownMode
        };

        builder.SetupWithLifetime(lifetime);

        lifetime.MainWindow = callback?.Build() as Window;

        return lifetime.Start(args);
    }
}
