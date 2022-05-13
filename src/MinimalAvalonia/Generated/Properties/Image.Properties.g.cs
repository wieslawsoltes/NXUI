namespace MinimalAvalonia;

[System.Diagnostics.CodeAnalysis.SuppressMessage("ReSharper", "InconsistentNaming")]
[System.Diagnostics.CodeAnalysis.SuppressMessage("ReSharper", "RedundantNameQualifier")]
public static partial class MinimalAvaloniaProperties
{
    public static Avalonia.StyledProperty<Avalonia.Media.IImage> ImageSource => Avalonia.Controls.Image.SourceProperty;

    public static Avalonia.StyledProperty<Avalonia.Media.Stretch> ImageStretch => Avalonia.Controls.Image.StretchProperty;

    public static Avalonia.StyledProperty<Avalonia.Media.StretchDirection> ImageStretchDirection => Avalonia.Controls.Image.StretchDirectionProperty;
}
