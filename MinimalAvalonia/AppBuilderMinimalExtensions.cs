public static class AppBuilderMinimalExtensions
{
    public static TAppBuilder UseFluentTheme<TAppBuilder>(this TAppBuilder builder, FluentThemeMode mode = FluentThemeMode.Light)
        where TAppBuilder : AppBuilderBase<TAppBuilder>, new() {
        return builder.AfterSetup(_ =>
            builder.Instance.Styles.Add(new FluentTheme(new Uri($"avares://{System.Reflection.Assembly.GetExecutingAssembly().GetName()}")) { Mode = mode }));
    }

    public static TAppBuilder WithClassicDesktopStyleApplicationLifetime<TAppBuilder>(this TAppBuilder builder, Action<IClassicDesktopStyleApplicationLifetime> callback)
        where TAppBuilder : AppBuilderBase<TAppBuilder>, new() {
        return builder.AfterSetup(_ => {
            if (builder.Instance.ApplicationLifetime is IClassicDesktopStyleApplicationLifetime desktop) {
                callback?.Invoke(desktop);
            }
        });
    }
}
