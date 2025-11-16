#if NXUI_HOTRELOAD
namespace NXUI.Extensions;

using Avalonia;
using Avalonia.Controls;
using NXUI.HotReload.Nodes;

/// <summary>
/// Hot reload helper extensions for <see cref="ContentControl"/>.
/// </summary>
public static partial class ContentControlExtensions
{
    /// <summary>
    /// Records a builder child as content for <see cref="ContentControl"/>.
    /// </summary>
    public static ElementBuilder<TControl> Content<TControl, TChild>(
        this ElementBuilder<TControl> builder,
        ElementBuilder<TChild> child)
        where TControl : ContentControl
        where TChild : AvaloniaObject
    {
        return builder.WithChild(
            child,
            static (parent, builtChild) =>
            {
                ((ContentControl)parent).Content = builtChild;
            });
    }
}
#endif
