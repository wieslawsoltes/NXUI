namespace NXUI.Extensions;

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
    public static T Children<T>(this T panel, params Control[] children) where T : Panel
    {
        panel.Children.AddRange(children);
        return panel;
    }

    // TODO: No type checking for children builders (should check for return type of Control).
    // public static Builder<T> Children1<T>(this  Builder<T> builder, params Builder<Control>[] children) where T : Panel
    public static Builder<T> Children1<T>(this  Builder<T> builder, params IBuilder[] children) where T : Panel
    {
        void Setter(T obj) => obj.Children.AddRange(children.Select(x => (Control)x.Build()));
        builder.Setters.Add(Setter);
        return builder;
    }
}
