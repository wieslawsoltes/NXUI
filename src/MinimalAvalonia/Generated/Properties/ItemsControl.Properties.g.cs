namespace MinimalAvalonia;

/// <summary>
/// The minimal avalonia properties.
/// </summary>
[System.Diagnostics.CodeAnalysis.SuppressMessage("ReSharper", "InconsistentNaming")]
[System.Diagnostics.CodeAnalysis.SuppressMessage("ReSharper", "RedundantNameQualifier")]
public static partial class MinimalAvaloniaProperties
{
    public static Avalonia.DirectProperty<Avalonia.Controls.ItemsControl,System.Collections.IEnumerable> ItemsControlItems => Avalonia.Controls.ItemsControl.ItemsProperty;

    public static Avalonia.StyledProperty<Avalonia.Styling.ControlTheme> ItemsControlItemContainerTheme => Avalonia.Controls.ItemsControl.ItemContainerThemeProperty;

    public static Avalonia.DirectProperty<Avalonia.Controls.ItemsControl,System.Int32> ItemsControlItemCount => Avalonia.Controls.ItemsControl.ItemCountProperty;

    public static Avalonia.StyledProperty<Avalonia.Controls.ITemplate<Avalonia.Controls.IPanel>> ItemsControlItemsPanel => Avalonia.Controls.ItemsControl.ItemsPanelProperty;

    public static Avalonia.StyledProperty<Avalonia.Controls.Templates.IDataTemplate> ItemsControlItemTemplate => Avalonia.Controls.ItemsControl.ItemTemplateProperty;
}
