namespace MinimalAvalonia;

/// <summary>
/// The minimal avalonia properties.
/// </summary>
[System.Diagnostics.CodeAnalysis.SuppressMessage("ReSharper", "InconsistentNaming")]
[System.Diagnostics.CodeAnalysis.SuppressMessage("ReSharper", "RedundantNameQualifier")]
public static partial class MinimalAvaloniaProperties
{
    public static Avalonia.DirectProperty<Avalonia.Controls.NativeMenuItem,Avalonia.Controls.NativeMenu> NativeMenuItemMenu => Avalonia.Controls.NativeMenuItem.MenuProperty;

    public static Avalonia.DirectProperty<Avalonia.Controls.NativeMenuItem,Avalonia.Media.Imaging.IBitmap> NativeMenuItemIcon => Avalonia.Controls.NativeMenuItem.IconProperty;

    public static Avalonia.DirectProperty<Avalonia.Controls.NativeMenuItem,System.String> NativeMenuItemHeader => Avalonia.Controls.NativeMenuItem.HeaderProperty;

    public static Avalonia.DirectProperty<Avalonia.Controls.NativeMenuItem,Avalonia.Input.KeyGesture> NativeMenuItemGesture => Avalonia.Controls.NativeMenuItem.GestureProperty;

    public static Avalonia.DirectProperty<Avalonia.Controls.NativeMenuItem,System.Boolean> NativeMenuItemIsChecked => Avalonia.Controls.NativeMenuItem.IsCheckedProperty;

    public static Avalonia.DirectProperty<Avalonia.Controls.NativeMenuItem,Avalonia.Controls.NativeMenuItemToggleType> NativeMenuItemToggleType => Avalonia.Controls.NativeMenuItem.ToggleTypeProperty;

    public static Avalonia.DirectProperty<Avalonia.Controls.NativeMenuItem,System.Windows.Input.ICommand> NativeMenuItemCommand => Avalonia.Controls.NativeMenuItem.CommandProperty;

    public static Avalonia.DirectProperty<Avalonia.Controls.NativeMenuItem,System.Boolean> NativeMenuItemIsEnabled => Avalonia.Controls.NativeMenuItem.IsEnabledProperty;
}
