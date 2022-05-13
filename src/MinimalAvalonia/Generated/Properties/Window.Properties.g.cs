namespace MinimalAvalonia;

[System.Diagnostics.CodeAnalysis.SuppressMessage("ReSharper", "InconsistentNaming")]
[System.Diagnostics.CodeAnalysis.SuppressMessage("ReSharper", "RedundantNameQualifier")]
public static partial class MinimalAvaloniaProperties
{
    public static Avalonia.StyledProperty<Avalonia.Controls.SizeToContent> WindowSizeToContent => Avalonia.Controls.Window.SizeToContentProperty;

    public static Avalonia.StyledProperty<System.Boolean> WindowExtendClientAreaToDecorationsHint => Avalonia.Controls.Window.ExtendClientAreaToDecorationsHintProperty;

    public static Avalonia.StyledProperty<Avalonia.Platform.ExtendClientAreaChromeHints> WindowExtendClientAreaChromeHints => Avalonia.Controls.Window.ExtendClientAreaChromeHintsProperty;

    public static Avalonia.StyledProperty<System.Double> WindowExtendClientAreaTitleBarHeightHint => Avalonia.Controls.Window.ExtendClientAreaTitleBarHeightHintProperty;

    public static Avalonia.DirectProperty<Avalonia.Controls.Window,System.Boolean> WindowIsExtendedIntoWindowDecorations => Avalonia.Controls.Window.IsExtendedIntoWindowDecorationsProperty;

    public static Avalonia.DirectProperty<Avalonia.Controls.Window,Avalonia.Thickness> WindowWindowDecorationMargin => Avalonia.Controls.Window.WindowDecorationMarginProperty;

    public static Avalonia.DirectProperty<Avalonia.Controls.Window,Avalonia.Thickness> WindowOffScreenMargin => Avalonia.Controls.Window.OffScreenMarginProperty;

    public static Avalonia.StyledProperty<Avalonia.Controls.SystemDecorations> WindowSystemDecorations => Avalonia.Controls.Window.SystemDecorationsProperty;

    public static Avalonia.StyledProperty<System.Boolean> WindowShowActivated => Avalonia.Controls.Window.ShowActivatedProperty;

    public static Avalonia.StyledProperty<System.Boolean> WindowShowInTaskbar => Avalonia.Controls.Window.ShowInTaskbarProperty;

    public static Avalonia.StyledProperty<Avalonia.Controls.WindowState> WindowWindowState => Avalonia.Controls.Window.WindowStateProperty;

    public static Avalonia.StyledProperty<System.String> WindowTitle => Avalonia.Controls.Window.TitleProperty;

    public static Avalonia.StyledProperty<Avalonia.Controls.WindowIcon> WindowIcon => Avalonia.Controls.Window.IconProperty;

    public static Avalonia.DirectProperty<Avalonia.Controls.Window,Avalonia.Controls.WindowStartupLocation> WindowWindowStartupLocation => Avalonia.Controls.Window.WindowStartupLocationProperty;

    public static Avalonia.StyledProperty<System.Boolean> WindowCanResize => Avalonia.Controls.Window.CanResizeProperty;
}
