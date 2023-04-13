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
    /// <param name="themeVariant"></param>
    /// <returns></returns>
    public static AppBuilder UseFluentTheme(
        this AppBuilder builder, 
        ThemeVariant? themeVariant = null) 
    {
        return builder.AfterSetup(_ =>
        {
            builder.Instance?.Styles.Add(new FluentTheme());
            if (themeVariant is { } && builder.Instance is { })
            {
                builder.Instance.RequestedThemeVariant = themeVariant;
            }
        });
    }
}
