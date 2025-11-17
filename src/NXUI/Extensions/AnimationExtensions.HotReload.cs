#if NXUI_HOTRELOAD
namespace NXUI.Extensions;

using System;
using NXUI.HotReload.Nodes;
using AnimationIterationCount = Avalonia.Animation.IterationCount;

/// <summary>
/// Hot reload helpers for <see cref="Avalonia.Animation.Animation"/>.
/// </summary>
public static partial class AnimationExtensions
{
    /// <summary>
    /// Records the iteration count with the specified <see cref="IterationType"/>.
    /// </summary>
    public static ElementBuilder<Animation> IterationCount(
        this ElementBuilder<Animation> builder,
        ulong value,
        IterationType type)
    {
        return builder.WithAction(animation =>
        {
            animation[Avalonia.Animation.Animation.IterationCountProperty] = new AnimationIterationCount(value, type);
        });
    }

    /// <summary>
    /// Records the iteration count for the specified number of iterations.
    /// </summary>
    public static ElementBuilder<Animation> IterationCountMany(
        this ElementBuilder<Animation> builder,
        ulong value)
    {
        return builder.WithAction(animation =>
        {
            animation[Avalonia.Animation.Animation.IterationCountProperty] = new AnimationIterationCount(value);
        });
    }

    /// <summary>
    /// Records the infinite iteration count.
    /// </summary>
    public static ElementBuilder<Animation> IterationCountInfinite(this ElementBuilder<Animation> builder)
    {
        return builder.WithAction(animation =>
        {
            animation[Avalonia.Animation.Animation.IterationCountProperty] = AnimationIterationCount.Infinite;
        });
    }

    /// <summary>
    /// Records an existing <see cref="Avalonia.Animation.KeyFrame"/> instance on the animation.
    /// </summary>
    public static ElementBuilder<Animation> KeyFrames(this ElementBuilder<Animation> builder, KeyFrame keyFrame)
    {
        ArgumentNullException.ThrowIfNull(keyFrame);

        return builder.WithAction(animation =>
        {
            animation.Children.Add(keyFrame);
        });
    }

    /// <summary>
    /// Records an array of <see cref="Avalonia.Animation.KeyFrame"/> instances on the animation.
    /// </summary>
    public static ElementBuilder<Animation> KeyFrames(this ElementBuilder<Animation> builder, params KeyFrame[] keyFrames)
    {
        ArgumentNullException.ThrowIfNull(keyFrames);

        return builder.WithAction(animation =>
        {
            animation.Children.AddRange(keyFrames);
        });
    }

    /// <summary>
    /// Records a builder-based <see cref="Avalonia.Animation.KeyFrame"/>.
    /// </summary>
    public static ElementBuilder<Animation> KeyFrames(
        this ElementBuilder<Animation> builder,
        ElementBuilder<KeyFrame> keyFrame)
    {
        return builder.WithChild(
            keyFrame,
            static (parent, builtChild) =>
            {
                parent.Children.Add(builtChild);
            });
    }

    /// <summary>
    /// Records multiple builder-based keyframes.
    /// </summary>
    public static ElementBuilder<Animation> KeyFrames(
        this ElementBuilder<Animation> builder,
        params ElementBuilder<KeyFrame>[] keyFrames)
    {
        ArgumentNullException.ThrowIfNull(keyFrames);

        foreach (var keyFrame in keyFrames)
        {
            builder = builder.KeyFrames(keyFrame);
        }

        return builder;
    }
}
#endif
