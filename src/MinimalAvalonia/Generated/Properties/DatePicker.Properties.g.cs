namespace MinimalAvalonia;

[System.Diagnostics.CodeAnalysis.SuppressMessage("ReSharper", "InconsistentNaming")]
[System.Diagnostics.CodeAnalysis.SuppressMessage("ReSharper", "RedundantNameQualifier")]
public static partial class MinimalAvaloniaProperties
{
    public static Avalonia.DirectProperty<Avalonia.Controls.DatePicker,System.String> DatePickerDayFormat => Avalonia.Controls.DatePicker.DayFormatProperty;

    public static Avalonia.DirectProperty<Avalonia.Controls.DatePicker,System.Boolean> DatePickerDayVisible => Avalonia.Controls.DatePicker.DayVisibleProperty;

    public static Avalonia.StyledProperty<System.Object> DatePickerHeader => Avalonia.Controls.DatePicker.HeaderProperty;

    public static Avalonia.StyledProperty<Avalonia.Controls.Templates.IDataTemplate> DatePickerHeaderTemplate => Avalonia.Controls.DatePicker.HeaderTemplateProperty;

    public static Avalonia.DirectProperty<Avalonia.Controls.DatePicker,System.DateTimeOffset> DatePickerMaxYear => Avalonia.Controls.DatePicker.MaxYearProperty;

    public static Avalonia.DirectProperty<Avalonia.Controls.DatePicker,System.DateTimeOffset> DatePickerMinYear => Avalonia.Controls.DatePicker.MinYearProperty;

    public static Avalonia.DirectProperty<Avalonia.Controls.DatePicker,System.String> DatePickerMonthFormat => Avalonia.Controls.DatePicker.MonthFormatProperty;

    public static Avalonia.DirectProperty<Avalonia.Controls.DatePicker,System.Boolean> DatePickerMonthVisible => Avalonia.Controls.DatePicker.MonthVisibleProperty;

    public static Avalonia.DirectProperty<Avalonia.Controls.DatePicker,System.String> DatePickerYearFormat => Avalonia.Controls.DatePicker.YearFormatProperty;

    public static Avalonia.DirectProperty<Avalonia.Controls.DatePicker,System.Boolean> DatePickerYearVisible => Avalonia.Controls.DatePicker.YearVisibleProperty;

    public static Avalonia.DirectProperty<Avalonia.Controls.DatePicker,System.Nullable<System.DateTimeOffset>> DatePickerSelectedDate => Avalonia.Controls.DatePicker.SelectedDateProperty;
}
