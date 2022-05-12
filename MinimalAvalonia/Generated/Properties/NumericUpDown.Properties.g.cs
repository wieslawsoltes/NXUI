namespace MinimalAvalonia;

[System.Diagnostics.CodeAnalysis.SuppressMessage("ReSharper", "InconsistentNaming")]
[System.Diagnostics.CodeAnalysis.SuppressMessage("ReSharper", "RedundantNameQualifier")]
public static partial class MinimalAvaloniaProperties
{
    public static Avalonia.DirectProperty<Avalonia.Controls.NumericUpDown,System.Boolean> NumericUpDownClipValueToMinMax => Avalonia.Controls.NumericUpDown.ClipValueToMinMaxProperty;

    public static Avalonia.DirectProperty<Avalonia.Controls.NumericUpDown,System.Globalization.NumberFormatInfo> NumericUpDownNumberFormat => Avalonia.Controls.NumericUpDown.NumberFormatProperty;

    public static Avalonia.StyledProperty<System.String> NumericUpDownFormatString => Avalonia.Controls.NumericUpDown.FormatStringProperty;

    public static Avalonia.StyledProperty<System.Decimal> NumericUpDownIncrement => Avalonia.Controls.NumericUpDown.IncrementProperty;

    public static Avalonia.StyledProperty<System.Boolean> NumericUpDownIsReadOnly => Avalonia.Controls.NumericUpDown.IsReadOnlyProperty;

    public static Avalonia.StyledProperty<System.Decimal> NumericUpDownMaximum => Avalonia.Controls.NumericUpDown.MaximumProperty;

    public static Avalonia.StyledProperty<System.Decimal> NumericUpDownMinimum => Avalonia.Controls.NumericUpDown.MinimumProperty;

    public static Avalonia.DirectProperty<Avalonia.Controls.NumericUpDown,System.Globalization.NumberStyles> NumericUpDownParsingNumberStyle => Avalonia.Controls.NumericUpDown.ParsingNumberStyleProperty;

    public static Avalonia.DirectProperty<Avalonia.Controls.NumericUpDown,System.String> NumericUpDownText => Avalonia.Controls.NumericUpDown.TextProperty;

    public static Avalonia.DirectProperty<Avalonia.Controls.NumericUpDown,System.Decimal> NumericUpDownValue => Avalonia.Controls.NumericUpDown.ValueProperty;

    public static Avalonia.StyledProperty<System.String> NumericUpDownWatermark => Avalonia.Controls.NumericUpDown.WatermarkProperty;
}
