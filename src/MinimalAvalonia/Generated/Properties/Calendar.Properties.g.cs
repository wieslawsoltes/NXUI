namespace MinimalAvalonia;

/// <summary>
/// The minimal avalonia properties.
/// </summary>
[System.Diagnostics.CodeAnalysis.SuppressMessage("ReSharper", "InconsistentNaming")]
[System.Diagnostics.CodeAnalysis.SuppressMessage("ReSharper", "RedundantNameQualifier")]
public static partial class MinimalAvaloniaProperties
{
    public static Avalonia.StyledProperty<System.DayOfWeek> CalendarFirstDayOfWeek => Avalonia.Controls.Calendar.FirstDayOfWeekProperty;

    public static Avalonia.StyledProperty<System.Boolean> CalendarIsTodayHighlighted => Avalonia.Controls.Calendar.IsTodayHighlightedProperty;

    public static Avalonia.StyledProperty<Avalonia.Media.IBrush> CalendarHeaderBackground => Avalonia.Controls.Calendar.HeaderBackgroundProperty;

    public static Avalonia.StyledProperty<Avalonia.Controls.CalendarMode> CalendarDisplayMode => Avalonia.Controls.Calendar.DisplayModeProperty;

    public static Avalonia.StyledProperty<Avalonia.Controls.CalendarSelectionMode> CalendarSelectionMode => Avalonia.Controls.Calendar.SelectionModeProperty;

    public static Avalonia.DirectProperty<Avalonia.Controls.Calendar,System.Nullable<System.DateTime>> CalendarSelectedDate => Avalonia.Controls.Calendar.SelectedDateProperty;

    public static Avalonia.DirectProperty<Avalonia.Controls.Calendar,System.DateTime> CalendarDisplayDate => Avalonia.Controls.Calendar.DisplayDateProperty;

    public static Avalonia.DirectProperty<Avalonia.Controls.Calendar,System.Nullable<System.DateTime>> CalendarDisplayDateStart => Avalonia.Controls.Calendar.DisplayDateStartProperty;

    public static Avalonia.DirectProperty<Avalonia.Controls.Calendar,System.Nullable<System.DateTime>> CalendarDisplayDateEnd => Avalonia.Controls.Calendar.DisplayDateEndProperty;
}
