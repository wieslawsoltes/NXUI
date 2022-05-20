namespace MinimalAvalonia;

/// <summary>
/// The minimal avalonia properties.
/// </summary>
[System.Diagnostics.CodeAnalysis.SuppressMessage("ReSharper", "InconsistentNaming")]
[System.Diagnostics.CodeAnalysis.SuppressMessage("ReSharper", "RedundantNameQualifier")]
public static partial class MinimalAvaloniaProperties
{
    public static Avalonia.DirectProperty<Avalonia.Controls.Presenters.ItemsPresenterBase,System.Collections.IEnumerable> ItemsPresenterBaseItems => Avalonia.Controls.Presenters.ItemsPresenterBase.ItemsProperty;

    public static Avalonia.StyledProperty<Avalonia.Controls.ITemplate<Avalonia.Controls.IPanel>> ItemsPresenterBaseItemsPanel => Avalonia.Controls.Presenters.ItemsPresenterBase.ItemsPanelProperty;

    public static Avalonia.StyledProperty<Avalonia.Controls.Templates.IDataTemplate> ItemsPresenterBaseItemTemplate => Avalonia.Controls.Presenters.ItemsPresenterBase.ItemTemplateProperty;
}
