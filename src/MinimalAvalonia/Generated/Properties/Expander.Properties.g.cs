namespace MinimalAvalonia;

/// <summary>
/// The minimal avalonia properties.
/// </summary>
[System.Diagnostics.CodeAnalysis.SuppressMessage("ReSharper", "InconsistentNaming")]
[System.Diagnostics.CodeAnalysis.SuppressMessage("ReSharper", "RedundantNameQualifier")]
public static partial class MinimalAvaloniaProperties
{
    public static Avalonia.StyledProperty<Avalonia.Animation.IPageTransition> ExpanderContentTransition => Avalonia.Controls.Expander.ContentTransitionProperty;

    public static Avalonia.StyledProperty<Avalonia.Controls.ExpandDirection> ExpanderExpandDirection => Avalonia.Controls.Expander.ExpandDirectionProperty;

    public static Avalonia.DirectProperty<Avalonia.Controls.Expander,System.Boolean> ExpanderIsExpanded => Avalonia.Controls.Expander.IsExpandedProperty;
}
