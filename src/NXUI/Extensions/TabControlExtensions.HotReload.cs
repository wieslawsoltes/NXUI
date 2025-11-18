namespace NXUI.Extensions;

using System;
using Avalonia.Collections;
using Avalonia.Controls;
using NXUI.HotReload.Nodes;

/// <summary>
/// Hot reload helpers for <see cref="TabControlExtensions"/>.
/// </summary>
public static partial class TabControlExtensions
{
    /// <summary>
    /// Records a single object as part of the tab control ItemsSource.
    /// </summary>
    public static ElementBuilder<TTabControl> ItemsSource<TTabControl>(
        this ElementBuilder<TTabControl> builder,
        object item)
        where TTabControl : TabControl
    {
        return builder.WithAction(tabControl =>
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
        });
    }

    /// <summary>
    /// Records multiple objects as part of the tab control ItemsSource.
    /// </summary>
    public static ElementBuilder<TTabControl> ItemsSource<TTabControl>(
        this ElementBuilder<TTabControl> builder,
        params object[] items)
        where TTabControl : TabControl
    {
        ArgumentNullException.ThrowIfNull(items);

        return builder.WithAction(tabControl =>
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
        });
    }
}
