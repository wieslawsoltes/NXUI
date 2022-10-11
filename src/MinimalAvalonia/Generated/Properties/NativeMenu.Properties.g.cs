namespace MinimalAvalonia;

/// <summary>
/// The minimal avalonia properties.
/// </summary>
[System.Diagnostics.CodeAnalysis.SuppressMessage("ReSharper", "InconsistentNaming")]
[System.Diagnostics.CodeAnalysis.SuppressMessage("ReSharper", "RedundantNameQualifier")]
public static partial class MinimalAvaloniaProperties
{
    /// <summary>
    /// The <see cref="Avalonia.Controls.NativeMenu.ParentProperty"/> property defined in <see cref="Avalonia.Controls.NativeMenu"/> class.
    /// </summary>
    public static Avalonia.DirectProperty<Avalonia.Controls.NativeMenu,Avalonia.Controls.NativeMenuItem> NativeMenuParent => Avalonia.Controls.NativeMenu.ParentProperty;

    /// <summary>
    /// The <see cref="Avalonia.Controls.NativeMenu.IsNativeMenuExportedProperty"/> property defined in <see cref="Avalonia.Controls.NativeMenu"/> class.
    /// </summary>
    public static Avalonia.AttachedProperty<System.Boolean> NativeMenuIsNativeMenuExported => Avalonia.Controls.NativeMenu.IsNativeMenuExportedProperty;

    /// <summary>
    /// The <see cref="Avalonia.Controls.NativeMenu.MenuProperty"/> property defined in <see cref="Avalonia.Controls.NativeMenu"/> class.
    /// </summary>
    public static Avalonia.AttachedProperty<Avalonia.Controls.NativeMenu> NativeMenuMenu => Avalonia.Controls.NativeMenu.MenuProperty;
}
