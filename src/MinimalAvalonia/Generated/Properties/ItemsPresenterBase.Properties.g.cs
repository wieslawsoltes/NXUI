namespace MinimalAvalonia;

/// <summary>
/// The minimal avalonia properties.
/// </summary>
[System.Diagnostics.CodeAnalysis.SuppressMessage("ReSharper", "InconsistentNaming")]
[System.Diagnostics.CodeAnalysis.SuppressMessage("ReSharper", "RedundantNameQualifier")]
public static partial class MinimalAvaloniaProperties
{
    /// <summary>
    /// The <see cref="Avalonia.Controls.Presenters.ItemsPresenterBase.ItemsProperty"/> property defined in <see cref="Avalonia.Controls.Presenters.ItemsPresenterBase"/> class.
    /// </summary>
    public static Avalonia.DirectProperty<Avalonia.Controls.Presenters.ItemsPresenterBase,System.Collections.IEnumerable> ItemsPresenterBaseItems => Avalonia.Controls.Presenters.ItemsPresenterBase.ItemsProperty;

    /// <summary>
    /// The <see cref="Avalonia.Controls.Presenters.ItemsPresenterBase.ItemsPanelProperty"/> property defined in <see cref="Avalonia.Controls.Presenters.ItemsPresenterBase"/> class.
    /// </summary>
    public static Avalonia.StyledProperty<Avalonia.Controls.ITemplate<Avalonia.Controls.IPanel>> ItemsPresenterBaseItemsPanel => Avalonia.Controls.Presenters.ItemsPresenterBase.ItemsPanelProperty;

    /// <summary>
    /// The <see cref="Avalonia.Controls.Presenters.ItemsPresenterBase.ItemTemplateProperty"/> property defined in <see cref="Avalonia.Controls.Presenters.ItemsPresenterBase"/> class.
    /// </summary>
    public static Avalonia.StyledProperty<Avalonia.Controls.Templates.IDataTemplate> ItemsPresenterBaseItemTemplate => Avalonia.Controls.Presenters.ItemsPresenterBase.ItemTemplateProperty;
}
