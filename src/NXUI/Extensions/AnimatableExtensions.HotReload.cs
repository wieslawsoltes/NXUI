#if NXUI_HOTRELOAD
namespace NXUI.Extensions;

using System;
using Avalonia.Animation;
using NXUI.HotReload.Nodes;

/// <summary>
/// Hot reload helpers for <see cref="AnimatableExtensions"/>.
/// </summary>
public static partial class AnimatableExtensions
{
    /// <summary>
    /// Records transition additions for builder-based animatables.
    /// </summary>
    public static ElementBuilder<TAnimatable> Transitions<TAnimatable>(
        this ElementBuilder<TAnimatable> builder,
        params ITransition[] transitions)
        where TAnimatable : Animatable
    {
        ArgumentNullException.ThrowIfNull(transitions);

        return builder.WithAction(animatable =>
        {
            var collection = animatable.Transitions ?? new Transitions();
            collection.AddRange(transitions);
            animatable.Transitions ??= collection;
        });
    }
}
#endif
