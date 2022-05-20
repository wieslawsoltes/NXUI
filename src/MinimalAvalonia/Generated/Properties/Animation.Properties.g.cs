namespace MinimalAvalonia;

/// <summary>
/// The minimal avalonia properties.
/// </summary>
[System.Diagnostics.CodeAnalysis.SuppressMessage("ReSharper", "InconsistentNaming")]
[System.Diagnostics.CodeAnalysis.SuppressMessage("ReSharper", "RedundantNameQualifier")]
public static partial class MinimalAvaloniaProperties
{
    public static Avalonia.DirectProperty<Avalonia.Animation.Animation,System.TimeSpan> AnimationDuration => Avalonia.Animation.Animation.DurationProperty;

    public static Avalonia.DirectProperty<Avalonia.Animation.Animation,Avalonia.Animation.IterationCount> AnimationIterationCount => Avalonia.Animation.Animation.IterationCountProperty;

    public static Avalonia.DirectProperty<Avalonia.Animation.Animation,Avalonia.Animation.PlaybackDirection> AnimationPlaybackDirection => Avalonia.Animation.Animation.PlaybackDirectionProperty;

    public static Avalonia.DirectProperty<Avalonia.Animation.Animation,Avalonia.Animation.FillMode> AnimationFillMode => Avalonia.Animation.Animation.FillModeProperty;

    public static Avalonia.DirectProperty<Avalonia.Animation.Animation,Avalonia.Animation.Easings.Easing> AnimationEasing => Avalonia.Animation.Animation.EasingProperty;

    public static Avalonia.DirectProperty<Avalonia.Animation.Animation,System.TimeSpan> AnimationDelay => Avalonia.Animation.Animation.DelayProperty;

    public static Avalonia.DirectProperty<Avalonia.Animation.Animation,System.TimeSpan> AnimationDelayBetweenIterations => Avalonia.Animation.Animation.DelayBetweenIterationsProperty;

    public static Avalonia.DirectProperty<Avalonia.Animation.Animation,System.Double> AnimationSpeedRatio => Avalonia.Animation.Animation.SpeedRatioProperty;
}
