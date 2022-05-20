namespace MinimalAvalonia;

/// <summary>
/// The minimal avalonia properties.
/// </summary>
[System.Diagnostics.CodeAnalysis.SuppressMessage("ReSharper", "InconsistentNaming")]
[System.Diagnostics.CodeAnalysis.SuppressMessage("ReSharper", "RedundantNameQualifier")]
public static partial class MinimalAvaloniaProperties
{
    public static Avalonia.StyledProperty<System.Int32> UniformGridRows => Avalonia.Controls.Primitives.UniformGrid.RowsProperty;

    public static Avalonia.StyledProperty<System.Int32> UniformGridColumns => Avalonia.Controls.Primitives.UniformGrid.ColumnsProperty;

    public static Avalonia.StyledProperty<System.Int32> UniformGridFirstColumn => Avalonia.Controls.Primitives.UniformGrid.FirstColumnProperty;
}
