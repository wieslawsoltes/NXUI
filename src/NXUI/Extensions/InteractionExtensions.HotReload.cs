#if NXUI_HOTRELOAD
namespace NXUI.Extensions;

using System;
using Avalonia.Interactivity;
using Avalonia.Styling;
using NXUI.HotReload.Nodes;

/// <summary>
/// Builder-aware interaction helpers.
/// </summary>
public static partial class InteractionExtensions
{
    /// <summary>
    /// Records a behavior assignment built from <typeparamref name="T"/>.
    /// </summary>
    public static ElementBuilder<Style> SetInteractionBehavior<T>(this ElementBuilder<Style> builder)
        where T : Behavior, new()
    {
        return builder.WithAction(style => style.SetInteractionBehavior<T>());
    }

    /// <summary>
    /// Records behavior assignments created from runtime factories.
    /// </summary>
    public static ElementBuilder<Style> SetInteractionBehavior(
        this ElementBuilder<Style> builder,
        params Func<Behavior>[] factories)
    {
        return builder.WithAction(style => style.SetInteractionBehavior(factories));
    }
}
#endif
