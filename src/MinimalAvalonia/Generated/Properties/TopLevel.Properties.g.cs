namespace MinimalAvalonia;

/// <summary>
/// The minimal avalonia properties.
/// </summary>
[System.Diagnostics.CodeAnalysis.SuppressMessage("ReSharper", "InconsistentNaming")]
[System.Diagnostics.CodeAnalysis.SuppressMessage("ReSharper", "RedundantNameQualifier")]
public static partial class MinimalAvaloniaProperties
{
    public static Avalonia.DirectProperty<Avalonia.Controls.TopLevel,Avalonia.Size> TopLevelClientSize => Avalonia.Controls.TopLevel.ClientSizeProperty;

    public static Avalonia.DirectProperty<Avalonia.Controls.TopLevel,System.Nullable<Avalonia.Size>> TopLevelFrameSize => Avalonia.Controls.TopLevel.FrameSizeProperty;

    public static Avalonia.StyledProperty<Avalonia.Input.IInputElement> TopLevelPointerOverElement => Avalonia.Controls.TopLevel.PointerOverElementProperty;

    public static Avalonia.StyledProperty<Avalonia.Controls.WindowTransparencyLevel> TopLevelTransparencyLevelHint => Avalonia.Controls.TopLevel.TransparencyLevelHintProperty;

    public static Avalonia.DirectProperty<Avalonia.Controls.TopLevel,Avalonia.Controls.WindowTransparencyLevel> TopLevelActualTransparencyLevel => Avalonia.Controls.TopLevel.ActualTransparencyLevelProperty;

    public static Avalonia.StyledProperty<Avalonia.Media.IBrush> TopLevelTransparencyBackgroundFallback => Avalonia.Controls.TopLevel.TransparencyBackgroundFallbackProperty;
}
