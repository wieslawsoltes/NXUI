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
    /// <typeparam name="TAppBuilder"></typeparam>
    /// <returns></returns>
    public static TAppBuilder WithApplicationName<TAppBuilder>(
        this TAppBuilder builder, 
        string name) where TAppBuilder : AppBuilderBase<TAppBuilder>, new()
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
