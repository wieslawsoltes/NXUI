namespace NXUI;

/// <summary>
/// 
/// </summary>
public static partial class AppBuilderExtensions
{
    /// <summary>
    /// 
    /// </summary>
    /// <param name="builder"></param>
    /// <param name="mode"></param>
    /// <typeparam name="TAppBuilder"></typeparam>
    /// <returns></returns>
    public static TAppBuilder UseFluentTheme<TAppBuilder>(
        this TAppBuilder builder, 
        FluentThemeMode mode = Avalonia.Themes.Fluent.FluentThemeMode.Light) where TAppBuilder : AppBuilderBase<TAppBuilder>, new() 
    {
        return builder.AfterSetup(_ =>
            builder.Instance?.Styles.Add(
                new FluentTheme(new Uri($"avares://{System.Reflection.Assembly.GetExecutingAssembly().GetName()}"))
                {
                    Mode = mode
                }));
    }
}
