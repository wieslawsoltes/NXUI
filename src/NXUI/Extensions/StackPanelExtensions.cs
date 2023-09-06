namespace NXUI.Extensions;

public static partial class StackPanelExtensions
{
    // Children

    /// <summary>
    /// 
    /// </summary>
    /// <param name="panel"></param>
    /// <param name="children"></param>
    /// <typeparam name="T"></typeparam>
    /// <returns></returns>
    public static T Children<T>(this T panel, AvaloniaList<Control> children) where T : StackPanel
    {
        panel.Children.AddRange(children);
        return panel;
    }
}
