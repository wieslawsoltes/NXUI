namespace MinimalAvalonia.Extensions;

/// <summary>
/// 
/// </summary>
public static partial class ControlExtensions
{
    // DataTemplates

    /// <summary>
    /// 
    /// </summary>
    /// <param name="control"></param>
    /// <param name="dataTemplates"></param>
    /// <typeparam name="T"></typeparam>
    /// <returns></returns>
    public static T DataTemplates<T>(this T control, params IDataTemplate[] dataTemplates) where T : Control
    {
        control.DataTemplates.AddRange(dataTemplates);
        return control;
    }
}
