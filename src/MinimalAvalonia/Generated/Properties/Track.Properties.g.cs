namespace MinimalAvalonia;

[System.Diagnostics.CodeAnalysis.SuppressMessage("ReSharper", "InconsistentNaming")]
[System.Diagnostics.CodeAnalysis.SuppressMessage("ReSharper", "RedundantNameQualifier")]
public static partial class MinimalAvaloniaProperties
{
    public static Avalonia.DirectProperty<Avalonia.Controls.Primitives.Track,System.Double> TrackMinimum => Avalonia.Controls.Primitives.Track.MinimumProperty;

    public static Avalonia.DirectProperty<Avalonia.Controls.Primitives.Track,System.Double> TrackMaximum => Avalonia.Controls.Primitives.Track.MaximumProperty;

    public static Avalonia.DirectProperty<Avalonia.Controls.Primitives.Track,System.Double> TrackValue => Avalonia.Controls.Primitives.Track.ValueProperty;

    public static Avalonia.StyledProperty<System.Double> TrackViewportSize => Avalonia.Controls.Primitives.Track.ViewportSizeProperty;

    public static Avalonia.StyledProperty<Avalonia.Layout.Orientation> TrackOrientation => Avalonia.Controls.Primitives.Track.OrientationProperty;

    public static Avalonia.StyledProperty<Avalonia.Controls.Primitives.Thumb> TrackThumb => Avalonia.Controls.Primitives.Track.ThumbProperty;

    public static Avalonia.StyledProperty<Avalonia.Controls.Button> TrackIncreaseButton => Avalonia.Controls.Primitives.Track.IncreaseButtonProperty;

    public static Avalonia.StyledProperty<Avalonia.Controls.Button> TrackDecreaseButton => Avalonia.Controls.Primitives.Track.DecreaseButtonProperty;

    public static Avalonia.StyledProperty<System.Boolean> TrackIsDirectionReversed => Avalonia.Controls.Primitives.Track.IsDirectionReversedProperty;
}
