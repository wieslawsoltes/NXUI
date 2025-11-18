namespace NXUI.Extensions;

using Avalonia;
using Avalonia.Controls.Presenters;
using NXUI.HotReload.Nodes;

/// <summary>
/// Hot reload helper extensions for <see cref="ContentPresenter"/>.
/// </summary>
public static partial class ContentPresenterExtensions
{
    /// <summary>
    /// Records a builder child as content for <see cref="ContentPresenter"/>.
    /// </summary>
    public static ElementBuilder<TPresenter> Content<TPresenter, TChild>(
        this ElementBuilder<TPresenter> builder,
        ElementBuilder<TChild> child)
        where TPresenter : ContentPresenter
        where TChild : AvaloniaObject
    {
        return builder.WithChild(
            child,
            static (parent, builtChild) => ((ContentPresenter)parent).Content = builtChild,
            ChildSlot.Content);
    }
}
