namespace MinimalAvalonia;

/// <summary>
/// The minimal avalonia properties.
/// </summary>
[System.Diagnostics.CodeAnalysis.SuppressMessage("ReSharper", "InconsistentNaming")]
[System.Diagnostics.CodeAnalysis.SuppressMessage("ReSharper", "RedundantNameQualifier")]
public static partial class MinimalAvaloniaProperties
{
    public static Avalonia.StyledProperty<System.Int32> RepeatButtonInterval => Avalonia.Controls.RepeatButton.IntervalProperty;

    public static Avalonia.StyledProperty<System.Int32> RepeatButtonDelay => Avalonia.Controls.RepeatButton.DelayProperty;
}
