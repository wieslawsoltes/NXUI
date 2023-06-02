// ReSharper disable InconsistentNaming
namespace NXUI.FSharp.Extensions;

/// <summary>
/// 
/// </summary>
public static partial class TabControlExtensions
{
    // ItemsProperty

    /// <summary>
    /// 
    /// </summary>
    /// <param name="tabControl"></param>
    /// <param name="item"></param>
    /// <typeparam name="T"></typeparam>
    /// <returns></returns>
    public static T itemsSource<T>(this T tabControl, object item) where T : TabControl
    {
        switch (tabControl.ItemsSource)
        {
            case AvaloniaList<object> list:
                list.Add(item);
                break;
            default:
                tabControl.ItemsSource = new AvaloniaList<object>(item);
                break;
        }
        return tabControl;
    }

    /// <summary>
    /// 
    /// </summary>
    /// <param name="tabControl"></param>
    /// <param name="items"></param>
    /// <typeparam name="T"></typeparam>
    /// <returns></returns>
    public static T itemsSource<T>(this T tabControl, params object[] items) where T : TabControl
    {
        switch (tabControl.ItemsSource)
        {
            case AvaloniaList<object> list:
                list.AddRange(items);
                break;
            default:
                tabControl.ItemsSource = new AvaloniaList<object>(items);
                break;
        }
        return tabControl;
    }
}
