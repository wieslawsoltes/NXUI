namespace MinimalAvalonia;

/// <summary>
/// The minimal avalonia properties.
/// </summary>
[System.Diagnostics.CodeAnalysis.SuppressMessage("ReSharper", "InconsistentNaming")]
[System.Diagnostics.CodeAnalysis.SuppressMessage("ReSharper", "RedundantNameQualifier")]
public static partial class MinimalAvaloniaProperties
{
    public static Avalonia.DirectProperty<Avalonia.Controls.MenuFlyout,System.Collections.IEnumerable> MenuFlyoutItems => Avalonia.Controls.MenuFlyout.ItemsProperty;

    public static Avalonia.DirectProperty<Avalonia.Controls.MenuFlyout,Avalonia.Controls.Templates.IDataTemplate> MenuFlyoutItemTemplate => Avalonia.Controls.MenuFlyout.ItemTemplateProperty;
}
