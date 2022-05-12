namespace MinimalAvalonia;

[System.Diagnostics.CodeAnalysis.SuppressMessage("ReSharper", "InconsistentNaming")]
[System.Diagnostics.CodeAnalysis.SuppressMessage("ReSharper", "RedundantNameQualifier")]
public static partial class MinimalAvaloniaProperties
{
    public static Avalonia.StyledProperty<Avalonia.Media.IImage> ImageDrawingImageSource => Avalonia.Media.ImageDrawing.ImageSourceProperty;

    public static Avalonia.StyledProperty<Avalonia.Rect> ImageDrawingRect => Avalonia.Media.ImageDrawing.RectProperty;
}
