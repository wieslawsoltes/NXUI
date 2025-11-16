#if NXUI_HOTRELOAD
namespace NXUI.Extensions;

using Avalonia.Collections;
using Avalonia.Controls;
using NXUI.HotReload.Nodes;

/// <summary>
/// Hot reload helpers for <see cref="ItemsControl"/>.
/// </summary>
public static partial class ItemsControlExtensions
{
    /// <summary>
    /// Records builder items for <see cref="ItemsControl.ItemsSource"/>.
    /// </summary>
    public static ElementBuilder<TControl> ItemsSource<TControl, TItem>(
        this ElementBuilder<TControl> builder,
        params ElementBuilder<TItem>[] items)
        where TControl : ItemsControl
        where TItem : Control
    {
        ArgumentNullException.ThrowIfNull(items);

        return builder.WithChildren(
            items,
            static (parent, builtChildren) =>
            {
                var itemsControl = (ItemsControl)parent;
                var values = new AvaloniaList<object>(builtChildren.Count);
                for (var i = 0; i < builtChildren.Count; i++)
                {
                    values.Add(builtChildren[i]!);
                }
                itemsControl.ItemsSource = values;
            });
    }
}
#endif
