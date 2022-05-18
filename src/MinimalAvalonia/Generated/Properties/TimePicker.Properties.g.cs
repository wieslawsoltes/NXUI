namespace MinimalAvalonia;

[System.Diagnostics.CodeAnalysis.SuppressMessage("ReSharper", "InconsistentNaming")]
[System.Diagnostics.CodeAnalysis.SuppressMessage("ReSharper", "RedundantNameQualifier")]
public static partial class MinimalAvaloniaProperties
{
    public static Avalonia.DirectProperty<Avalonia.Controls.TimePicker,System.Int32> TimePickerMinuteIncrement => Avalonia.Controls.TimePicker.MinuteIncrementProperty;

    public static Avalonia.DirectProperty<Avalonia.Controls.TimePicker,System.String> TimePickerClockIdentifier => Avalonia.Controls.TimePicker.ClockIdentifierProperty;

    public static Avalonia.DirectProperty<Avalonia.Controls.TimePicker,System.Nullable<System.TimeSpan>> TimePickerSelectedTime => Avalonia.Controls.TimePicker.SelectedTimeProperty;
}
