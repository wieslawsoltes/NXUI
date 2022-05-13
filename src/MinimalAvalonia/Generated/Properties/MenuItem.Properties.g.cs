namespace MinimalAvalonia;

[System.Diagnostics.CodeAnalysis.SuppressMessage("ReSharper", "InconsistentNaming")]
[System.Diagnostics.CodeAnalysis.SuppressMessage("ReSharper", "RedundantNameQualifier")]
public static partial class MinimalAvaloniaProperties
{
    public static Avalonia.DirectProperty<Avalonia.Controls.MenuItem,System.Windows.Input.ICommand> MenuItemCommand => Avalonia.Controls.MenuItem.CommandProperty;

    public static Avalonia.StyledProperty<Avalonia.Input.KeyGesture> MenuItemHotKey => Avalonia.Controls.MenuItem.HotKeyProperty;

    public static Avalonia.StyledProperty<System.Object> MenuItemCommandParameter => Avalonia.Controls.MenuItem.CommandParameterProperty;

    public static Avalonia.StyledProperty<System.Object> MenuItemIcon => Avalonia.Controls.MenuItem.IconProperty;

    public static Avalonia.StyledProperty<Avalonia.Input.KeyGesture> MenuItemInputGesture => Avalonia.Controls.MenuItem.InputGestureProperty;

    public static Avalonia.StyledProperty<System.Boolean> MenuItemIsSelected => Avalonia.Controls.MenuItem.IsSelectedProperty;

    public static Avalonia.StyledProperty<System.Boolean> MenuItemIsSubMenuOpen => Avalonia.Controls.MenuItem.IsSubMenuOpenProperty;

    public static Avalonia.StyledProperty<System.Boolean> MenuItemStaysOpenOnClick => Avalonia.Controls.MenuItem.StaysOpenOnClickProperty;
}
