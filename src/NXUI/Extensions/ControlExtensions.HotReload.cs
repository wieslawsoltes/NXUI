namespace NXUI.Extensions;

using System;
using Avalonia.Controls;
using Avalonia.Controls.Templates;
using NXUI.HotReload.Nodes;

/// <summary>
/// Hot reload helpers for <see cref="ControlExtensions"/>.
/// </summary>
public static partial class ControlExtensions
{
    /// <summary>
    /// Records data template additions for builder-based controls.
    /// </summary>
    public static ElementBuilder<TControl> DataTemplates<TControl>(
        this ElementBuilder<TControl> builder,
        params IDataTemplate[] dataTemplates)
        where TControl : Control
    {
        ArgumentNullException.ThrowIfNull(dataTemplates);

        return builder.WithAction(control =>
        {
            control.DataTemplates.AddRange(dataTemplates);
        });
    }
}
