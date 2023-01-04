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
    /// <param name="mode"></param>
    /// <returns></returns>
    public static AppBuilder UseFluentTheme(
        this AppBuilder builder, 
        FluentThemeMode mode = Avalonia.Themes.Fluent.FluentThemeMode.Light) 
    {
        return builder.AfterSetup(_ => builder.Instance?.Styles.Add(new FluentTheme { Mode = mode }));
    }
}
