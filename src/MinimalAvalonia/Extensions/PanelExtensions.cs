namespace MinimalAvalonia.Extensions;

/// <summary>
/// 
/// </summary>
public static partial class PanelExtensions
{
    // Children

    /// <summary>
    /// 
    /// </summary>
    /// <param name="panel"></param>
    /// <param name="child"></param>
    /// <typeparam name="T"></typeparam>
    /// <returns></returns>
    public static T Children<T>(this T panel, Control child) where T : Panel
    {
        panel.Children.Add(child);
        return panel;
    }

    /// <summary>
    /// 
    /// </summary>
    /// <param name="panel"></param>
    /// <param name="children"></param>
    /// <typeparam name="T"></typeparam>
    /// <returns></returns>
    public static T Children<T>(this T panel, params IControl[] children) where T : Panel
    {
        panel.Children.AddRange(children);
        return panel;
    }
}
