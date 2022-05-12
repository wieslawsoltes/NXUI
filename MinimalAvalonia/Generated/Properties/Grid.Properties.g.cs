namespace MinimalAvalonia;

[System.Diagnostics.CodeAnalysis.SuppressMessage("ReSharper", "InconsistentNaming")]
[System.Diagnostics.CodeAnalysis.SuppressMessage("ReSharper", "RedundantNameQualifier")]
public static partial class MinimalAvaloniaProperties
{
    public static Avalonia.StyledProperty<System.Boolean> GridShowGridLines => Avalonia.Controls.Grid.ShowGridLinesProperty;

    public static Avalonia.AttachedProperty<System.Int32> GridColumn => Avalonia.Controls.Grid.ColumnProperty;

    public static Avalonia.AttachedProperty<System.Int32> GridRow => Avalonia.Controls.Grid.RowProperty;

    public static Avalonia.AttachedProperty<System.Int32> GridColumnSpan => Avalonia.Controls.Grid.ColumnSpanProperty;

    public static Avalonia.AttachedProperty<System.Int32> GridRowSpan => Avalonia.Controls.Grid.RowSpanProperty;

    public static Avalonia.AttachedProperty<System.Boolean> GridIsSharedSizeScope => Avalonia.Controls.Grid.IsSharedSizeScopeProperty;
}
