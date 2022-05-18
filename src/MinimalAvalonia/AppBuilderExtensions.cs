namespace MinimalAvalonia;

public static class AppBuilderExtensions
{
    public static TAppBuilder UseFluentTheme<TAppBuilder>(this TAppBuilder builder, FluentThemeMode mode = Avalonia.Themes.Fluent.FluentThemeMode.Light)
        where TAppBuilder : AppBuilderBase<TAppBuilder>, new() 
    {
        return builder.AfterSetup(_ =>
            builder.Instance?.Styles.Add(new FluentTheme(new Uri($"avares://{System.Reflection.Assembly.GetExecutingAssembly().GetName()}")) { Mode = mode }));
    }

    public static int StartWithClassicDesktopLifetime<T>(this T builder, Action<IClassicDesktopStyleApplicationLifetime>? callback, string[] args, ShutdownMode shutdownMode = ShutdownMode.OnLastWindowClose)
        where T : AppBuilderBase<T>, new()
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

    public static int StartWithClassicDesktopLifetime<T>(this T builder, Func<Window>? callback, string[] args, ShutdownMode shutdownMode = ShutdownMode.OnLastWindowClose)
        where T : AppBuilderBase<T>, new()
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

    public static TAppBuilder WithApplicationName<TAppBuilder>(this TAppBuilder builder, string name)
        where TAppBuilder : AppBuilderBase<TAppBuilder>, new()
    {
        return builder.AfterSetup(_ =>
        {
            if (builder.Instance is { })
            {
                builder.Instance.Name = name;
            }
        });
    }
}
