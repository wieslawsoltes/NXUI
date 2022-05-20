namespace MinimalAvalonia;

/// <summary>
/// The minimal avalonia properties.
/// </summary>
[System.Diagnostics.CodeAnalysis.SuppressMessage("ReSharper", "InconsistentNaming")]
[System.Diagnostics.CodeAnalysis.SuppressMessage("ReSharper", "RedundantNameQualifier")]
public static partial class MinimalAvaloniaProperties
{
    public static Avalonia.StyledProperty<Avalonia.Media.IBrush> ShapeFill => Avalonia.Controls.Shapes.Shape.FillProperty;

    public static Avalonia.StyledProperty<Avalonia.Media.Stretch> ShapeStretch => Avalonia.Controls.Shapes.Shape.StretchProperty;

    public static Avalonia.StyledProperty<Avalonia.Media.IBrush> ShapeStroke => Avalonia.Controls.Shapes.Shape.StrokeProperty;

    public static Avalonia.StyledProperty<Avalonia.Collections.AvaloniaList<System.Double>> ShapeStrokeDashArray => Avalonia.Controls.Shapes.Shape.StrokeDashArrayProperty;

    public static Avalonia.StyledProperty<System.Double> ShapeStrokeDashOffset => Avalonia.Controls.Shapes.Shape.StrokeDashOffsetProperty;

    public static Avalonia.StyledProperty<System.Double> ShapeStrokeThickness => Avalonia.Controls.Shapes.Shape.StrokeThicknessProperty;

    public static Avalonia.StyledProperty<Avalonia.Media.PenLineCap> ShapeStrokeLineCap => Avalonia.Controls.Shapes.Shape.StrokeLineCapProperty;

    public static Avalonia.StyledProperty<Avalonia.Media.PenLineJoin> ShapeStrokeJoin => Avalonia.Controls.Shapes.Shape.StrokeJoinProperty;
}
