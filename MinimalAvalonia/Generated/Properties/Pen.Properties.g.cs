namespace MinimalAvalonia;

[System.Diagnostics.CodeAnalysis.SuppressMessage("ReSharper", "InconsistentNaming")]
[System.Diagnostics.CodeAnalysis.SuppressMessage("ReSharper", "RedundantNameQualifier")]
public static partial class MinimalAvaloniaProperties
{
    public static Avalonia.StyledProperty<Avalonia.Media.IBrush> PenBrush => Avalonia.Media.Pen.BrushProperty;

    public static Avalonia.StyledProperty<System.Double> PenThickness => Avalonia.Media.Pen.ThicknessProperty;

    public static Avalonia.StyledProperty<Avalonia.Media.IDashStyle> PenDashStyle => Avalonia.Media.Pen.DashStyleProperty;

    public static Avalonia.StyledProperty<Avalonia.Media.PenLineCap> PenLineCap => Avalonia.Media.Pen.LineCapProperty;

    public static Avalonia.StyledProperty<Avalonia.Media.PenLineJoin> PenLineJoin => Avalonia.Media.Pen.LineJoinProperty;

    public static Avalonia.StyledProperty<System.Double> PenMiterLimit => Avalonia.Media.Pen.MiterLimitProperty;
}
