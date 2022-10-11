namespace MinimalAvalonia;

/// <summary>
/// The minimal avalonia properties.
/// </summary>
[System.Diagnostics.CodeAnalysis.SuppressMessage("ReSharper", "InconsistentNaming")]
[System.Diagnostics.CodeAnalysis.SuppressMessage("ReSharper", "RedundantNameQualifier")]
public static partial class MinimalAvaloniaProperties
{
    /// <summary>
    /// The <see cref="Avalonia.Controls.TrayIcon.CommandProperty"/> property defined in <see cref="Avalonia.Controls.TrayIcon"/> class.
    /// </summary>
    public static Avalonia.DirectProperty<Avalonia.Controls.TrayIcon,System.Windows.Input.ICommand> TrayIconCommand => Avalonia.Controls.TrayIcon.CommandProperty;

    /// <summary>
    /// The <see cref="Avalonia.Controls.TrayIcon.IconsProperty"/> property defined in <see cref="Avalonia.Controls.TrayIcon"/> class.
    /// </summary>
    public static Avalonia.AttachedProperty<Avalonia.Controls.TrayIcons> TrayIconIcons => Avalonia.Controls.TrayIcon.IconsProperty;

    /// <summary>
    /// The <see cref="Avalonia.Controls.TrayIcon.MenuProperty"/> property defined in <see cref="Avalonia.Controls.TrayIcon"/> class.
    /// </summary>
    public static Avalonia.StyledProperty<Avalonia.Controls.NativeMenu> TrayIconMenu => Avalonia.Controls.TrayIcon.MenuProperty;

    /// <summary>
    /// The <see cref="Avalonia.Controls.TrayIcon.IconProperty"/> property defined in <see cref="Avalonia.Controls.TrayIcon"/> class.
    /// </summary>
    public static Avalonia.StyledProperty<Avalonia.Controls.WindowIcon> TrayIconIcon => Avalonia.Controls.TrayIcon.IconProperty;

    /// <summary>
    /// The <see cref="Avalonia.Controls.TrayIcon.ToolTipTextProperty"/> property defined in <see cref="Avalonia.Controls.TrayIcon"/> class.
    /// </summary>
    public static Avalonia.StyledProperty<System.String> TrayIconToolTipText => Avalonia.Controls.TrayIcon.ToolTipTextProperty;

    /// <summary>
    /// The <see cref="Avalonia.Controls.TrayIcon.IsVisibleProperty"/> property defined in <see cref="Avalonia.Controls.TrayIcon"/> class.
    /// </summary>
    public static Avalonia.StyledProperty<System.Boolean> TrayIconIsVisible => Avalonia.Controls.TrayIcon.IsVisibleProperty;
}
