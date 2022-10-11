namespace MinimalAvalonia;

/// <summary>
/// The minimal avalonia properties.
/// </summary>
[System.Diagnostics.CodeAnalysis.SuppressMessage("ReSharper", "InconsistentNaming")]
[System.Diagnostics.CodeAnalysis.SuppressMessage("ReSharper", "RedundantNameQualifier")]
public static partial class MinimalAvaloniaProperties
{
    /// <summary>
    /// The <see cref="Avalonia.Controls.NativeMenuItem.MenuProperty"/> property defined in <see cref="Avalonia.Controls.NativeMenuItem"/> class.
    /// </summary>
    public static Avalonia.DirectProperty<Avalonia.Controls.NativeMenuItem,Avalonia.Controls.NativeMenu> NativeMenuItemMenu => Avalonia.Controls.NativeMenuItem.MenuProperty;

    /// <summary>
    /// The <see cref="Avalonia.Controls.NativeMenuItem.IconProperty"/> property defined in <see cref="Avalonia.Controls.NativeMenuItem"/> class.
    /// </summary>
    public static Avalonia.DirectProperty<Avalonia.Controls.NativeMenuItem,Avalonia.Media.Imaging.IBitmap> NativeMenuItemIcon => Avalonia.Controls.NativeMenuItem.IconProperty;

    /// <summary>
    /// The <see cref="Avalonia.Controls.NativeMenuItem.HeaderProperty"/> property defined in <see cref="Avalonia.Controls.NativeMenuItem"/> class.
    /// </summary>
    public static Avalonia.DirectProperty<Avalonia.Controls.NativeMenuItem,System.String> NativeMenuItemHeader => Avalonia.Controls.NativeMenuItem.HeaderProperty;

    /// <summary>
    /// The <see cref="Avalonia.Controls.NativeMenuItem.GestureProperty"/> property defined in <see cref="Avalonia.Controls.NativeMenuItem"/> class.
    /// </summary>
    public static Avalonia.DirectProperty<Avalonia.Controls.NativeMenuItem,Avalonia.Input.KeyGesture> NativeMenuItemGesture => Avalonia.Controls.NativeMenuItem.GestureProperty;

    /// <summary>
    /// The <see cref="Avalonia.Controls.NativeMenuItem.IsCheckedProperty"/> property defined in <see cref="Avalonia.Controls.NativeMenuItem"/> class.
    /// </summary>
    public static Avalonia.DirectProperty<Avalonia.Controls.NativeMenuItem,System.Boolean> NativeMenuItemIsChecked => Avalonia.Controls.NativeMenuItem.IsCheckedProperty;

    /// <summary>
    /// The <see cref="Avalonia.Controls.NativeMenuItem.ToggleTypeProperty"/> property defined in <see cref="Avalonia.Controls.NativeMenuItem"/> class.
    /// </summary>
    public static Avalonia.DirectProperty<Avalonia.Controls.NativeMenuItem,Avalonia.Controls.NativeMenuItemToggleType> NativeMenuItemToggleType => Avalonia.Controls.NativeMenuItem.ToggleTypeProperty;

    /// <summary>
    /// The <see cref="Avalonia.Controls.NativeMenuItem.CommandProperty"/> property defined in <see cref="Avalonia.Controls.NativeMenuItem"/> class.
    /// </summary>
    public static Avalonia.DirectProperty<Avalonia.Controls.NativeMenuItem,System.Windows.Input.ICommand> NativeMenuItemCommand => Avalonia.Controls.NativeMenuItem.CommandProperty;

    /// <summary>
    /// The <see cref="Avalonia.Controls.NativeMenuItem.IsEnabledProperty"/> property defined in <see cref="Avalonia.Controls.NativeMenuItem"/> class.
    /// </summary>
    public static Avalonia.DirectProperty<Avalonia.Controls.NativeMenuItem,System.Boolean> NativeMenuItemIsEnabled => Avalonia.Controls.NativeMenuItem.IsEnabledProperty;
}
