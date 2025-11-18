namespace NXUI.Extensions;

using System;
using System.Globalization;
using NXUI.HotReload.Nodes;
using AnimationCue = Avalonia.Animation.Cue;
using AnimationKeySpline = Avalonia.Animation.KeySpline;
using StylingSetter = Avalonia.Styling.Setter;

/// <summary>
/// Hot reload helpers for <see cref="Avalonia.Animation.KeyFrame"/>.
/// </summary>
public static partial class KeyFrameExtensions
{
    /// <summary>
    /// Records the <see cref="Avalonia.Animation.KeyFrame.KeyTime"/> value.
    /// </summary>
    public static KeyFrameBuilder KeyTime(this KeyFrameBuilder builder, TimeSpan keyTime)
    {
        return builder.WithAction(keyFrame =>
        {
            keyFrame.KeyTime = keyTime;
        });
    }

    /// <summary>
    /// Records the cue instance on the builder.
    /// </summary>
    public static KeyFrameBuilder Cue(this KeyFrameBuilder builder, AnimationCue cue)
    {
        return builder.WithAction(keyFrame =>
        {
            keyFrame.Cue = cue;
        });
    }

    /// <summary>
    /// Records a numeric cue value on the builder.
    /// </summary>
    public static KeyFrameBuilder Cue(this KeyFrameBuilder builder, double cue)
    {
        return builder.Cue(new AnimationCue(cue));
    }

    /// <summary>
    /// Records a cue parsed from a string representation.
    /// </summary>
    public static KeyFrameBuilder Cue(this KeyFrameBuilder builder, string cue)
    {
        ArgumentNullException.ThrowIfNull(cue);

        return builder.Cue(AnimationCue.Parse(cue, CultureInfo.InvariantCulture));
    }

    /// <summary>
    /// Records the key spline value.
    /// </summary>
    public static KeyFrameBuilder KeySpline(this KeyFrameBuilder builder, AnimationKeySpline keySpline)
    {
        return builder.WithAction(keyFrame =>
        {
            keyFrame.KeySpline = keySpline;
        });
    }

    /// <summary>
    /// Records the key spline using control point values.
    /// </summary>
    public static KeyFrameBuilder KeySpline(this KeyFrameBuilder builder, double x1, double y1, double x2, double y2)
    {
        return builder.KeySpline(new AnimationKeySpline(x1, y1, x2, y2));
    }

    /// <summary>
    /// Records the key spline parsed from a string representation.
    /// </summary>
    public static KeyFrameBuilder KeySpline(this KeyFrameBuilder builder, string keySpline)
    {
        ArgumentNullException.ThrowIfNull(keySpline);

        return builder.KeySpline(AnimationKeySpline.Parse(keySpline, CultureInfo.InvariantCulture));
    }

    /// <summary>
    /// Records animation setters on the builder.
    /// </summary>
    public static KeyFrameBuilder Setters(this KeyFrameBuilder builder, params IAnimationSetter[] setters)
    {
        ArgumentNullException.ThrowIfNull(setters);

        return builder.WithAction(keyFrame =>
        {
            foreach (var setter in setters)
            {
                keyFrame.Setters.Add(setter);
            }
        });
    }

    /// <summary>
    /// Records a setter constructed from the provided property/value pair.
    /// </summary>
    public static KeyFrameBuilder Setter(this KeyFrameBuilder builder, AvaloniaProperty property, object value)
    {
        ArgumentNullException.ThrowIfNull(property);

        return builder.WithAction(keyFrame =>
        {
            keyFrame.Setters.Add(new StylingSetter(property, value));
        });
    }
}
