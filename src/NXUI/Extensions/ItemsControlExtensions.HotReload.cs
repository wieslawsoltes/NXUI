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
            },
            ChildSlot.Items);
    }

    /// <summary>
    /// Records raw objects for <see cref="ItemsControl.ItemsSource"/>.
    /// </summary>
    public static ElementBuilder<TControl> ItemsSource<TControl>(
        this ElementBuilder<TControl> builder,
        params object[] items)
        where TControl : ItemsControl
    {
        ArgumentNullException.ThrowIfNull(items);

        return builder.WithAction(itemsControl =>
        {
            switch (itemsControl.ItemsSource)
            {
                case AvaloniaList<object> list:
                    list.AddRange(items);
                    break;
                default:
                    itemsControl.ItemsSource = new AvaloniaList<object>(items);
                    break;
            }
        });
    }

    /// <summary>
    /// Records a single object for <see cref="ItemsControl.ItemsSource"/>.
    /// </summary>
    public static ElementBuilder<TControl> ItemsSource<TControl>(
        this ElementBuilder<TControl> builder,
        object item)
        where TControl : ItemsControl
    {
        return builder.WithAction(itemsControl =>
        {
            switch (itemsControl.ItemsSource)
            {
                case AvaloniaList<object> list:
                    list.Add(item);
                    break;
                default:
                    itemsControl.ItemsSource = new AvaloniaList<object>(item);
                    break;
            }
        });
    }
}
