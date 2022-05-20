namespace MinimalAvalonia;

/// <summary>
/// The minimal avalonia properties.
/// </summary>
[System.Diagnostics.CodeAnalysis.SuppressMessage("ReSharper", "InconsistentNaming")]
[System.Diagnostics.CodeAnalysis.SuppressMessage("ReSharper", "RedundantNameQualifier")]
public static partial class MinimalAvaloniaProperties
{
    public static Avalonia.StyledProperty<Avalonia.Media.IBrush> BorderBackground => Avalonia.Controls.Border.BackgroundProperty;

    public static Avalonia.StyledProperty<Avalonia.Media.IBrush> BorderBorderBrush => Avalonia.Controls.Border.BorderBrushProperty;

    public static Avalonia.StyledProperty<Avalonia.Thickness> BorderBorderThickness => Avalonia.Controls.Border.BorderThicknessProperty;

    public static Avalonia.StyledProperty<Avalonia.CornerRadius> BorderCornerRadius => Avalonia.Controls.Border.CornerRadiusProperty;

    public static Avalonia.StyledProperty<Avalonia.Media.BoxShadows> BorderBoxShadow => Avalonia.Controls.Border.BoxShadowProperty;

    public static Avalonia.StyledProperty<System.Double> BorderBorderDashOffset => Avalonia.Controls.Border.BorderDashOffsetProperty;

    public static Avalonia.StyledProperty<Avalonia.Collections.AvaloniaList<System.Double>> BorderBorderDashArray => Avalonia.Controls.Border.BorderDashArrayProperty;

    public static Avalonia.StyledProperty<Avalonia.Media.PenLineCap> BorderBorderLineCap => Avalonia.Controls.Border.BorderLineCapProperty;

    public static Avalonia.StyledProperty<Avalonia.Media.PenLineJoin> BorderBorderLineJoin => Avalonia.Controls.Border.BorderLineJoinProperty;
}
