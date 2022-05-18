namespace MinimalAvalonia;

[System.Diagnostics.CodeAnalysis.SuppressMessage("ReSharper", "InconsistentNaming")]
[System.Diagnostics.CodeAnalysis.SuppressMessage("ReSharper", "RedundantNameQualifier")]
public static partial class MinimalAvaloniaProperties
{
    public static Avalonia.StyledProperty<Avalonia.Media.Stretch> ViewboxStretch => Avalonia.Controls.Viewbox.StretchProperty;

    public static Avalonia.StyledProperty<Avalonia.Media.StretchDirection> ViewboxStretchDirection => Avalonia.Controls.Viewbox.StretchDirectionProperty;

    public static Avalonia.StyledProperty<Avalonia.Controls.IControl> ViewboxChild => Avalonia.Controls.Viewbox.ChildProperty;
}
