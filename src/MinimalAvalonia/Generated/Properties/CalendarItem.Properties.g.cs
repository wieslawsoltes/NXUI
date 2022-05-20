namespace MinimalAvalonia;

/// <summary>
/// The minimal avalonia properties.
/// </summary>
[System.Diagnostics.CodeAnalysis.SuppressMessage("ReSharper", "InconsistentNaming")]
[System.Diagnostics.CodeAnalysis.SuppressMessage("ReSharper", "RedundantNameQualifier")]
public static partial class MinimalAvaloniaProperties
{
    public static Avalonia.StyledProperty<Avalonia.Media.IBrush> CalendarItemHeaderBackground => Avalonia.Controls.Primitives.CalendarItem.HeaderBackgroundProperty;

    public static Avalonia.DirectProperty<Avalonia.Controls.Primitives.CalendarItem,Avalonia.Controls.ITemplate<Avalonia.Controls.IControl>> CalendarItemDayTitleTemplate => Avalonia.Controls.Primitives.CalendarItem.DayTitleTemplateProperty;
}
