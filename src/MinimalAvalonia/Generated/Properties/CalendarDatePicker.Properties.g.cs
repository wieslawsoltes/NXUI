namespace MinimalAvalonia;

[System.Diagnostics.CodeAnalysis.SuppressMessage("ReSharper", "InconsistentNaming")]
[System.Diagnostics.CodeAnalysis.SuppressMessage("ReSharper", "RedundantNameQualifier")]
public static partial class MinimalAvaloniaProperties
{
    public static Avalonia.DirectProperty<Avalonia.Controls.CalendarDatePicker,System.DateTime> CalendarDatePickerDisplayDate => Avalonia.Controls.CalendarDatePicker.DisplayDateProperty;

    public static Avalonia.DirectProperty<Avalonia.Controls.CalendarDatePicker,System.Nullable<System.DateTime>> CalendarDatePickerDisplayDateStart => Avalonia.Controls.CalendarDatePicker.DisplayDateStartProperty;

    public static Avalonia.DirectProperty<Avalonia.Controls.CalendarDatePicker,System.Nullable<System.DateTime>> CalendarDatePickerDisplayDateEnd => Avalonia.Controls.CalendarDatePicker.DisplayDateEndProperty;

    public static Avalonia.StyledProperty<System.DayOfWeek> CalendarDatePickerFirstDayOfWeek => Avalonia.Controls.CalendarDatePicker.FirstDayOfWeekProperty;

    public static Avalonia.DirectProperty<Avalonia.Controls.CalendarDatePicker,System.Boolean> CalendarDatePickerIsDropDownOpen => Avalonia.Controls.CalendarDatePicker.IsDropDownOpenProperty;

    public static Avalonia.StyledProperty<System.Boolean> CalendarDatePickerIsTodayHighlighted => Avalonia.Controls.CalendarDatePicker.IsTodayHighlightedProperty;

    public static Avalonia.DirectProperty<Avalonia.Controls.CalendarDatePicker,System.Nullable<System.DateTime>> CalendarDatePickerSelectedDate => Avalonia.Controls.CalendarDatePicker.SelectedDateProperty;

    public static Avalonia.StyledProperty<Avalonia.Controls.CalendarDatePickerFormat> CalendarDatePickerSelectedDateFormat => Avalonia.Controls.CalendarDatePicker.SelectedDateFormatProperty;

    public static Avalonia.StyledProperty<System.String> CalendarDatePickerCustomDateFormatString => Avalonia.Controls.CalendarDatePicker.CustomDateFormatStringProperty;

    public static Avalonia.DirectProperty<Avalonia.Controls.CalendarDatePicker,System.String> CalendarDatePickerText => Avalonia.Controls.CalendarDatePicker.TextProperty;

    public static Avalonia.StyledProperty<System.String> CalendarDatePickerWatermark => Avalonia.Controls.CalendarDatePicker.WatermarkProperty;

    public static Avalonia.StyledProperty<System.Boolean> CalendarDatePickerUseFloatingWatermark => Avalonia.Controls.CalendarDatePicker.UseFloatingWatermarkProperty;

    public static Avalonia.StyledProperty<Avalonia.Layout.HorizontalAlignment> CalendarDatePickerHorizontalContentAlignment => Avalonia.Controls.CalendarDatePicker.HorizontalContentAlignmentProperty;

    public static Avalonia.StyledProperty<Avalonia.Layout.VerticalAlignment> CalendarDatePickerVerticalContentAlignment => Avalonia.Controls.CalendarDatePicker.VerticalContentAlignmentProperty;
}
