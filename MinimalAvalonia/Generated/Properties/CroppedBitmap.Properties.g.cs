namespace MinimalAvalonia;

[System.Diagnostics.CodeAnalysis.SuppressMessage("ReSharper", "InconsistentNaming")]
[System.Diagnostics.CodeAnalysis.SuppressMessage("ReSharper", "RedundantNameQualifier")]
public static partial class MinimalAvaloniaProperties
{
    public static Avalonia.StyledProperty<Avalonia.Media.IImage> CroppedBitmapSource => Avalonia.Media.Imaging.CroppedBitmap.SourceProperty;

    public static Avalonia.StyledProperty<Avalonia.PixelRect> CroppedBitmapSourceRect => Avalonia.Media.Imaging.CroppedBitmap.SourceRectProperty;
}
