namespace MinimalAvalonia;

[System.Diagnostics.CodeAnalysis.SuppressMessage("ReSharper", "InconsistentNaming")]
[System.Diagnostics.CodeAnalysis.SuppressMessage("ReSharper", "RedundantNameQualifier")]
public static partial class MinimalAvaloniaProperties
{
    public static Avalonia.DirectProperty<Avalonia.Controls.Primitives.ToggleButton,System.Nullable<System.Boolean>> ToggleButtonIsChecked => Avalonia.Controls.Primitives.ToggleButton.IsCheckedProperty;

    public static Avalonia.StyledProperty<System.Boolean> ToggleButtonIsThreeState => Avalonia.Controls.Primitives.ToggleButton.IsThreeStateProperty;
}
