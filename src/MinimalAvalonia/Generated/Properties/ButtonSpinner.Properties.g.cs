namespace MinimalAvalonia;

/// <summary>
/// The minimal avalonia properties.
/// </summary>
[System.Diagnostics.CodeAnalysis.SuppressMessage("ReSharper", "InconsistentNaming")]
[System.Diagnostics.CodeAnalysis.SuppressMessage("ReSharper", "RedundantNameQualifier")]
public static partial class MinimalAvaloniaProperties
{
    public static Avalonia.StyledProperty<System.Boolean> ButtonSpinnerAllowSpin => Avalonia.Controls.ButtonSpinner.AllowSpinProperty;

    public static Avalonia.StyledProperty<System.Boolean> ButtonSpinnerShowButtonSpinner => Avalonia.Controls.ButtonSpinner.ShowButtonSpinnerProperty;

    public static Avalonia.StyledProperty<Avalonia.Controls.Location> ButtonSpinnerButtonSpinnerLocation => Avalonia.Controls.ButtonSpinner.ButtonSpinnerLocationProperty;
}
