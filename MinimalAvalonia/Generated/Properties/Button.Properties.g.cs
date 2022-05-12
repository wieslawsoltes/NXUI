namespace MinimalAvalonia;

[System.Diagnostics.CodeAnalysis.SuppressMessage("ReSharper", "InconsistentNaming")]
[System.Diagnostics.CodeAnalysis.SuppressMessage("ReSharper", "RedundantNameQualifier")]
public static partial class MinimalAvaloniaProperties
{
    public static Avalonia.StyledProperty<Avalonia.Controls.ClickMode> ButtonClickMode => Avalonia.Controls.Button.ClickModeProperty;

    public static Avalonia.DirectProperty<Avalonia.Controls.Button,System.Windows.Input.ICommand> ButtonCommand => Avalonia.Controls.Button.CommandProperty;

    public static Avalonia.StyledProperty<System.Object> ButtonCommandParameter => Avalonia.Controls.Button.CommandParameterProperty;

    public static Avalonia.StyledProperty<System.Boolean> ButtonIsDefault => Avalonia.Controls.Button.IsDefaultProperty;

    public static Avalonia.StyledProperty<System.Boolean> ButtonIsCancel => Avalonia.Controls.Button.IsCancelProperty;

    public static Avalonia.StyledProperty<System.Boolean> ButtonIsPressed => Avalonia.Controls.Button.IsPressedProperty;

    public static Avalonia.StyledProperty<Avalonia.Controls.Primitives.FlyoutBase> ButtonFlyout => Avalonia.Controls.Button.FlyoutProperty;
}
