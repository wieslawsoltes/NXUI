namespace MinimalAvalonia;

[System.Diagnostics.CodeAnalysis.SuppressMessage("ReSharper", "InconsistentNaming")]
[System.Diagnostics.CodeAnalysis.SuppressMessage("ReSharper", "RedundantNameQualifier")]
public static partial class MinimalAvaloniaProperties
{
    public static Avalonia.DirectProperty<Avalonia.Controls.TrayIcon,System.Windows.Input.ICommand> TrayIconCommand => Avalonia.Controls.TrayIcon.CommandProperty;

    public static Avalonia.AttachedProperty<Avalonia.Controls.TrayIcons> TrayIconIcons => Avalonia.Controls.TrayIcon.IconsProperty;

    public static Avalonia.StyledProperty<Avalonia.Controls.NativeMenu> TrayIconMenu => Avalonia.Controls.TrayIcon.MenuProperty;

    public static Avalonia.StyledProperty<System.String> TrayIconToolTipText => Avalonia.Controls.TrayIcon.ToolTipTextProperty;
}
