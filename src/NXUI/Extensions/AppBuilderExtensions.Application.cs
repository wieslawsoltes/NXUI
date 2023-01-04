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
    /// <param name="name"></param>
    /// <returns></returns>
    public static AppBuilder WithApplicationName(
        this AppBuilder builder, 
        string name)
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
