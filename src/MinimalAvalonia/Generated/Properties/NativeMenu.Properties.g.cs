namespace MinimalAvalonia;

/// <summary>
/// The minimal avalonia properties.
/// </summary>
[System.Diagnostics.CodeAnalysis.SuppressMessage("ReSharper", "InconsistentNaming")]
[System.Diagnostics.CodeAnalysis.SuppressMessage("ReSharper", "RedundantNameQualifier")]
public static partial class MinimalAvaloniaProperties
{
    public static Avalonia.DirectProperty<Avalonia.Controls.NativeMenu,Avalonia.Controls.NativeMenuItem> NativeMenuParent => Avalonia.Controls.NativeMenu.ParentProperty;

    public static Avalonia.AttachedProperty<System.Boolean> NativeMenuIsNativeMenuExported => Avalonia.Controls.NativeMenu.IsNativeMenuExportedProperty;

    public static Avalonia.AttachedProperty<Avalonia.Controls.NativeMenu> NativeMenuMenu => Avalonia.Controls.NativeMenu.MenuProperty;
}
