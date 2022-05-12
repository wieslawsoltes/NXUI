// <auto-generated />
namespace MinimalAvalonia.Extensions;

public static partial class GridExtensions
{
    // ShowGridLinesProperty

    public static T ShowGridLines<T>(this T obj, System.Boolean value) where T : Avalonia.Controls.Grid
    {
        obj[Avalonia.Controls.Grid.ShowGridLinesProperty] = value;
        return obj;
    }

    public static T ShowGridLines<T>(this T obj, Avalonia.Data.IBinding binding, Avalonia.Data.BindingMode mode = Avalonia.Data.BindingMode.TwoWay) where T : Avalonia.Controls.Grid
    {
        obj[Avalonia.Controls.Grid.ShowGridLinesProperty.Bind().WithMode(mode)] = binding;
        return obj;
    }

    public static Avalonia.Data.IBinding ShowGridLines(this Avalonia.Controls.Grid obj, Avalonia.Data.BindingMode mode = Avalonia.Data.BindingMode.TwoWay)
    {
        return obj[Avalonia.Controls.Grid.ShowGridLinesProperty.Bind().WithMode(mode)];
    }

    // ColumnProperty

    public static T Column<T>(this T obj, System.Int32 value) where T : Avalonia.Controls.Control
    {
        obj[Avalonia.Controls.Grid.ColumnProperty] = value;
        return obj;
    }

    public static T Column<T>(this T obj, Avalonia.Data.IBinding binding, Avalonia.Data.BindingMode mode = Avalonia.Data.BindingMode.TwoWay) where T : Avalonia.Controls.Control
    {
        obj[Avalonia.Controls.Grid.ColumnProperty.Bind().WithMode(mode)] = binding;
        return obj;
    }

    public static Avalonia.Data.IBinding Column(this Avalonia.Controls.Control obj, Avalonia.Data.BindingMode mode = Avalonia.Data.BindingMode.TwoWay)
    {
        return obj[Avalonia.Controls.Grid.ColumnProperty.Bind().WithMode(mode)];
    }

    // RowProperty

    public static T Row<T>(this T obj, System.Int32 value) where T : Avalonia.Controls.Control
    {
        obj[Avalonia.Controls.Grid.RowProperty] = value;
        return obj;
    }

    public static T Row<T>(this T obj, Avalonia.Data.IBinding binding, Avalonia.Data.BindingMode mode = Avalonia.Data.BindingMode.TwoWay) where T : Avalonia.Controls.Control
    {
        obj[Avalonia.Controls.Grid.RowProperty.Bind().WithMode(mode)] = binding;
        return obj;
    }

    public static Avalonia.Data.IBinding Row(this Avalonia.Controls.Control obj, Avalonia.Data.BindingMode mode = Avalonia.Data.BindingMode.TwoWay)
    {
        return obj[Avalonia.Controls.Grid.RowProperty.Bind().WithMode(mode)];
    }

    // ColumnSpanProperty

    public static T ColumnSpan<T>(this T obj, System.Int32 value) where T : Avalonia.Controls.Control
    {
        obj[Avalonia.Controls.Grid.ColumnSpanProperty] = value;
        return obj;
    }

    public static T ColumnSpan<T>(this T obj, Avalonia.Data.IBinding binding, Avalonia.Data.BindingMode mode = Avalonia.Data.BindingMode.TwoWay) where T : Avalonia.Controls.Control
    {
        obj[Avalonia.Controls.Grid.ColumnSpanProperty.Bind().WithMode(mode)] = binding;
        return obj;
    }

    public static Avalonia.Data.IBinding ColumnSpan(this Avalonia.Controls.Control obj, Avalonia.Data.BindingMode mode = Avalonia.Data.BindingMode.TwoWay)
    {
        return obj[Avalonia.Controls.Grid.ColumnSpanProperty.Bind().WithMode(mode)];
    }

    // RowSpanProperty

    public static T RowSpan<T>(this T obj, System.Int32 value) where T : Avalonia.Controls.Control
    {
        obj[Avalonia.Controls.Grid.RowSpanProperty] = value;
        return obj;
    }

    public static T RowSpan<T>(this T obj, Avalonia.Data.IBinding binding, Avalonia.Data.BindingMode mode = Avalonia.Data.BindingMode.TwoWay) where T : Avalonia.Controls.Control
    {
        obj[Avalonia.Controls.Grid.RowSpanProperty.Bind().WithMode(mode)] = binding;
        return obj;
    }

    public static Avalonia.Data.IBinding RowSpan(this Avalonia.Controls.Control obj, Avalonia.Data.BindingMode mode = Avalonia.Data.BindingMode.TwoWay)
    {
        return obj[Avalonia.Controls.Grid.RowSpanProperty.Bind().WithMode(mode)];
    }

    // IsSharedSizeScopeProperty

    public static T IsSharedSizeScope<T>(this T obj, System.Boolean value) where T : Avalonia.Controls.Control
    {
        obj[Avalonia.Controls.Grid.IsSharedSizeScopeProperty] = value;
        return obj;
    }

    public static T IsSharedSizeScope<T>(this T obj, Avalonia.Data.IBinding binding, Avalonia.Data.BindingMode mode = Avalonia.Data.BindingMode.TwoWay) where T : Avalonia.Controls.Control
    {
        obj[Avalonia.Controls.Grid.IsSharedSizeScopeProperty.Bind().WithMode(mode)] = binding;
        return obj;
    }

    public static Avalonia.Data.IBinding IsSharedSizeScope(this Avalonia.Controls.Control obj, Avalonia.Data.BindingMode mode = Avalonia.Data.BindingMode.TwoWay)
    {
        return obj[Avalonia.Controls.Grid.IsSharedSizeScopeProperty.Bind().WithMode(mode)];
    }
}