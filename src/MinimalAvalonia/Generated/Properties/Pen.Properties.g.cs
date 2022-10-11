namespace MinimalAvalonia;

/// <summary>
/// The minimal avalonia properties.
/// </summary>
[System.Diagnostics.CodeAnalysis.SuppressMessage("ReSharper", "InconsistentNaming")]
[System.Diagnostics.CodeAnalysis.SuppressMessage("ReSharper", "RedundantNameQualifier")]
public static partial class MinimalAvaloniaProperties
{
    /// <summary>
    /// The <see cref="Avalonia.Media.Pen.BrushProperty"/> property defined in <see cref="Avalonia.Media.Pen"/> class.
    /// </summary>
    public static Avalonia.StyledProperty<Avalonia.Media.IBrush> PenBrush => Avalonia.Media.Pen.BrushProperty;

    /// <summary>
    /// The <see cref="Avalonia.Media.Pen.ThicknessProperty"/> property defined in <see cref="Avalonia.Media.Pen"/> class.
    /// </summary>
    public static Avalonia.StyledProperty<System.Double> PenThickness => Avalonia.Media.Pen.ThicknessProperty;

    /// <summary>
    /// The <see cref="Avalonia.Media.Pen.DashStyleProperty"/> property defined in <see cref="Avalonia.Media.Pen"/> class.
    /// </summary>
    public static Avalonia.StyledProperty<Avalonia.Media.IDashStyle> PenDashStyle => Avalonia.Media.Pen.DashStyleProperty;

    /// <summary>
    /// The <see cref="Avalonia.Media.Pen.LineCapProperty"/> property defined in <see cref="Avalonia.Media.Pen"/> class.
    /// </summary>
    public static Avalonia.StyledProperty<Avalonia.Media.PenLineCap> PenLineCap => Avalonia.Media.Pen.LineCapProperty;

    /// <summary>
    /// The <see cref="Avalonia.Media.Pen.LineJoinProperty"/> property defined in <see cref="Avalonia.Media.Pen"/> class.
    /// </summary>
    public static Avalonia.StyledProperty<Avalonia.Media.PenLineJoin> PenLineJoin => Avalonia.Media.Pen.LineJoinProperty;

    /// <summary>
    /// The <see cref="Avalonia.Media.Pen.MiterLimitProperty"/> property defined in <see cref="Avalonia.Media.Pen"/> class.
    /// </summary>
    public static Avalonia.StyledProperty<System.Double> PenMiterLimit => Avalonia.Media.Pen.MiterLimitProperty;
}
