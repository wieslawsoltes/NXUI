namespace MinimalAvalonia;

/// <summary>
/// The minimal avalonia properties.
/// </summary>
[System.Diagnostics.CodeAnalysis.SuppressMessage("ReSharper", "InconsistentNaming")]
[System.Diagnostics.CodeAnalysis.SuppressMessage("ReSharper", "RedundantNameQualifier")]
public static partial class MinimalAvaloniaProperties
{
    public static Avalonia.StyledProperty<System.Double> ColumnDefinitionMaxWidth => Avalonia.Controls.ColumnDefinition.MaxWidthProperty;

    public static Avalonia.StyledProperty<System.Double> ColumnDefinitionMinWidth => Avalonia.Controls.ColumnDefinition.MinWidthProperty;

    public static Avalonia.StyledProperty<Avalonia.Controls.GridLength> ColumnDefinitionWidth => Avalonia.Controls.ColumnDefinition.WidthProperty;
}
