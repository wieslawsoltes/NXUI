namespace MinimalAvalonia;

/// <summary>
/// The minimal avalonia properties.
/// </summary>
[System.Diagnostics.CodeAnalysis.SuppressMessage("ReSharper", "InconsistentNaming")]
[System.Diagnostics.CodeAnalysis.SuppressMessage("ReSharper", "RedundantNameQualifier")]
public static partial class MinimalAvaloniaProperties
{
    public static Avalonia.StyledProperty<System.Windows.Input.ICommand> KeyBindingCommand => Avalonia.Input.KeyBinding.CommandProperty;

    public static Avalonia.StyledProperty<System.Object> KeyBindingCommandParameter => Avalonia.Input.KeyBinding.CommandParameterProperty;

    public static Avalonia.StyledProperty<Avalonia.Input.KeyGesture> KeyBindingGesture => Avalonia.Input.KeyBinding.GestureProperty;
}
