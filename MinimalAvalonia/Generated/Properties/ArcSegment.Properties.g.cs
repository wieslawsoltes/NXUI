namespace MinimalAvalonia;

[System.Diagnostics.CodeAnalysis.SuppressMessage("ReSharper", "InconsistentNaming")]
[System.Diagnostics.CodeAnalysis.SuppressMessage("ReSharper", "RedundantNameQualifier")]
public static partial class MinimalAvaloniaProperties
{
    public static Avalonia.StyledProperty<System.Boolean> ArcSegmentIsLargeArc => Avalonia.Media.ArcSegment.IsLargeArcProperty;

    public static Avalonia.StyledProperty<Avalonia.Point> ArcSegmentPoint => Avalonia.Media.ArcSegment.PointProperty;

    public static Avalonia.StyledProperty<System.Double> ArcSegmentRotationAngle => Avalonia.Media.ArcSegment.RotationAngleProperty;

    public static Avalonia.StyledProperty<Avalonia.Size> ArcSegmentSize => Avalonia.Media.ArcSegment.SizeProperty;

    public static Avalonia.StyledProperty<Avalonia.Media.SweepDirection> ArcSegmentSweepDirection => Avalonia.Media.ArcSegment.SweepDirectionProperty;
}
