namespace MinimalAvalonia;

/// <summary>
/// The minimal avalonia properties.
/// </summary>
[System.Diagnostics.CodeAnalysis.SuppressMessage("ReSharper", "InconsistentNaming")]
[System.Diagnostics.CodeAnalysis.SuppressMessage("ReSharper", "RedundantNameQualifier")]
public static partial class MinimalAvaloniaProperties
{
    public static Avalonia.DirectProperty<Avalonia.Controls.TimePickerPresenter,System.Int32> TimePickerPresenterMinuteIncrement => Avalonia.Controls.TimePickerPresenter.MinuteIncrementProperty;

    public static Avalonia.DirectProperty<Avalonia.Controls.TimePickerPresenter,System.String> TimePickerPresenterClockIdentifier => Avalonia.Controls.TimePickerPresenter.ClockIdentifierProperty;

    public static Avalonia.DirectProperty<Avalonia.Controls.TimePickerPresenter,System.TimeSpan> TimePickerPresenterTime => Avalonia.Controls.TimePickerPresenter.TimeProperty;
}
