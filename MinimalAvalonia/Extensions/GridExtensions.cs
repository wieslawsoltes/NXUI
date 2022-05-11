namespace MinimalAvalonia.Extensions;

public static class GridExtensions
{
    public static T ShowGridLines<T>(this T grid, bool showGridLines) where T : Grid
    {
        grid[Avalonia.Controls.Grid.ShowGridLinesProperty] = showGridLines;
        return grid;
    }

    public static T Column<T>(this T control, int column) where T : Control
    {
        control[Avalonia.Controls.Grid.ColumnProperty] = column;
        return control;
    }

    public static T Row<T>(this T control, int row) where T : Control
    {
        control[Avalonia.Controls.Grid.RowProperty] = row;
        return control;
    }

    public static T ColumnSpan<T>(this T grid, int columnSpan) where T : Control
    {
        grid[Avalonia.Controls.Grid.ColumnSpanProperty] = columnSpan;
        return grid;
    }

    public static T RowSpan<T>(this T control, int rowSpan) where T : Control
    {
        control[Avalonia.Controls.Grid.RowSpanProperty] = rowSpan;
        return control;
    }

    public static T IsSharedSizeScope<T>(this T control, bool isSharedSizeScopeProperty) where T : Control
    {
        control[Avalonia.Controls.Grid.IsSharedSizeScopeProperty] = isSharedSizeScopeProperty;
        return control;
    }
}
