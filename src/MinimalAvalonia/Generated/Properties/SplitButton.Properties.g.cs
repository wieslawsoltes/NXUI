namespace MinimalAvalonia;

/// <summary>
/// The minimal avalonia properties.
/// </summary>
[System.Diagnostics.CodeAnalysis.SuppressMessage("ReSharper", "InconsistentNaming")]
[System.Diagnostics.CodeAnalysis.SuppressMessage("ReSharper", "RedundantNameQualifier")]
public static partial class MinimalAvaloniaProperties
{
    public static Avalonia.DirectProperty<Avalonia.Controls.SplitButton,System.Windows.Input.ICommand> SplitButtonCommand => Avalonia.Controls.SplitButton.CommandProperty;

    public static Avalonia.StyledProperty<System.Object> SplitButtonCommandParameter => Avalonia.Controls.SplitButton.CommandParameterProperty;

    public static Avalonia.StyledProperty<Avalonia.Controls.Primitives.FlyoutBase> SplitButtonFlyout => Avalonia.Controls.SplitButton.FlyoutProperty;
}
