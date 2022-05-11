namespace MinimalAvalonia.Extensions;

public static partial class TextBoxExtensions
{
    //
    // AcceptsReturnProperty
    //

    public static T AcceptsReturn<T>(this T obj, bool value) where T : TextBox
    {
        obj[Avalonia.Controls.TextBox.AcceptsReturnProperty] = value;
        return obj;
    }

    public static T AcceptsReturn<T>(this T obj, IBinding binding, BindingMode mode = BindingMode.TwoWay) where T : TextBox
    {
        obj[Avalonia.Controls.TextBox.AcceptsReturnProperty.Bind().WithMode(mode)] = binding;
        return obj;
    }

    public static IBinding AcceptsReturn(this TextBox obj, BindingMode mode = BindingMode.TwoWay)
    {
        return obj[Avalonia.Controls.TextBox.AcceptsReturnProperty.Bind().WithMode(mode)];
    }

    //
    // AcceptsTabProperty
    //

    public static T AcceptsTab<T>(this T obj, bool value) where T : TextBox
    {
        obj[Avalonia.Controls.TextBox.AcceptsTabProperty] = value;
        return obj;
    }

    public static T AcceptsTab<T>(this T obj, IBinding binding, BindingMode mode = BindingMode.TwoWay) where T : TextBox
    {
        obj[Avalonia.Controls.TextBox.AcceptsTabProperty.Bind().WithMode(mode)] = binding;
        return obj;
    }

    public static IBinding AcceptsTab(this TextBox obj, BindingMode mode = BindingMode.TwoWay)
    {
        return obj[Avalonia.Controls.TextBox.AcceptsTabProperty.Bind().WithMode(mode)];
    }

    //
    // CaretIndexProperty
    //

    public static T CaretIndex<T>(this T obj, int value) where T : TextBox
    {
        obj[Avalonia.Controls.TextBox.CaretIndexProperty] = value;
        return obj;
    }

    public static T CaretIndex<T>(this T obj, IBinding binding, BindingMode mode = BindingMode.TwoWay) where T : TextBox
    {
        obj[Avalonia.Controls.TextBox.CaretIndexProperty.Bind().WithMode(mode)] = binding;
        return obj;
    }

    public static IBinding CaretIndex(this TextBox obj, BindingMode mode = BindingMode.TwoWay)
    {
        return obj[Avalonia.Controls.TextBox.CaretIndexProperty.Bind().WithMode(mode)];
    }

    //
    // IsReadOnlyProperty
    //

    public static T IsReadOnly<T>(this T obj, bool value) where T : TextBox
    {
        obj[Avalonia.Controls.TextBox.IsReadOnlyProperty] = value;
        return obj;
    }

    public static T IsReadOnly<T>(this T obj, IBinding binding, BindingMode mode = BindingMode.TwoWay) where T : TextBox
    {
        obj[Avalonia.Controls.TextBox.IsReadOnlyProperty.Bind().WithMode(mode)] = binding;
        return obj;
    }

    public static IBinding IsReadOnly(this TextBox obj, BindingMode mode = BindingMode.TwoWay)
    {
        return obj[Avalonia.Controls.TextBox.IsReadOnlyProperty.Bind().WithMode(mode)];
    }

    //
    // PasswordCharProperty
    //

    public static T PasswordChar<T>(this T obj, char value) where T : TextBox
    {
        obj[Avalonia.Controls.TextBox.PasswordCharProperty] = value;
        return obj;
    }

    public static T PasswordChar<T>(this T obj, IBinding binding, BindingMode mode = BindingMode.TwoWay) where T : TextBox
    {
        obj[Avalonia.Controls.TextBox.PasswordCharProperty.Bind().WithMode(mode)] = binding;
        return obj;
    }

    public static IBinding PasswordChar(this TextBox obj, BindingMode mode = BindingMode.TwoWay)
    {
        return obj[Avalonia.Controls.TextBox.PasswordCharProperty.Bind().WithMode(mode)];
    }

    //
    // SelectionBrushProperty
    //

    public static T SelectionBrush<T>(this T obj, IBrush value) where T : TextBox
    {
        obj[Avalonia.Controls.TextBox.SelectionBrushProperty] = value;
        return obj;
    }

    public static T SelectionBrush<T>(this T obj, IBinding binding, BindingMode mode = BindingMode.TwoWay) where T : TextBox
    {
        obj[Avalonia.Controls.TextBox.SelectionBrushProperty.Bind().WithMode(mode)] = binding;
        return obj;
    }

    public static IBinding SelectionBrush(this TextBox obj, BindingMode mode = BindingMode.TwoWay)
    {
        return obj[Avalonia.Controls.TextBox.SelectionBrushProperty.Bind().WithMode(mode)];
    }

    //
    // SelectionForegroundBrushProperty
    //

    public static T SelectionForegroundBrush<T>(this T obj, IBrush value) where T : TextBox
    {
        obj[Avalonia.Controls.TextBox.SelectionForegroundBrushProperty] = value;
        return obj;
    }

    public static T SelectionForegroundBrush<T>(this T obj, IBinding binding, BindingMode mode = BindingMode.TwoWay) where T : TextBox
    {
        obj[Avalonia.Controls.TextBox.SelectionForegroundBrushProperty.Bind().WithMode(mode)] = binding;
        return obj;
    }

    public static IBinding SelectionForegroundBrush(this TextBox obj, BindingMode mode = BindingMode.TwoWay)
    {
        return obj[Avalonia.Controls.TextBox.SelectionForegroundBrushProperty.Bind().WithMode(mode)];
    }

    //
    // CaretBrushProperty
    //

    public static T CaretBrush<T>(this T obj, IBrush value) where T : TextBox
    {
        obj[Avalonia.Controls.TextBox.CaretBrushProperty] = value;
        return obj;
    }

    public static T CaretBrush<T>(this T obj, IBinding binding, BindingMode mode = BindingMode.TwoWay) where T : TextBox
    {
        obj[Avalonia.Controls.TextBox.CaretBrushProperty.Bind().WithMode(mode)] = binding;
        return obj;
    }

    public static IBinding CaretBrush(this TextBox obj, BindingMode mode = BindingMode.TwoWay)
    {
        return obj[Avalonia.Controls.TextBox.CaretBrushProperty.Bind().WithMode(mode)];
    }

    //
    // SelectionStartProperty
    //

    public static T SelectionStart<T>(this T obj, int value) where T : TextBox
    {
        obj[Avalonia.Controls.TextBox.SelectionStartProperty] = value;
        return obj;
    }

    public static T SelectionStart<T>(this T obj, IBinding binding, BindingMode mode = BindingMode.TwoWay) where T : TextBox
    {
        obj[Avalonia.Controls.TextBox.SelectionStartProperty.Bind().WithMode(mode)] = binding;
        return obj;
    }

    public static IBinding SelectionStart(this TextBox obj, BindingMode mode = BindingMode.TwoWay)
    {
        return obj[Avalonia.Controls.TextBox.SelectionStartProperty.Bind().WithMode(mode)];
    }

    //
    // SelectionEndProperty
    //

    public static T SelectionEnd<T>(this T obj, int value) where T : TextBox
    {
        obj[Avalonia.Controls.TextBox.SelectionEndProperty] = value;
        return obj;
    }

    public static T SelectionEnd<T>(this T obj, IBinding binding, BindingMode mode = BindingMode.TwoWay) where T : TextBox
    {
        obj[Avalonia.Controls.TextBox.SelectionEndProperty.Bind().WithMode(mode)] = binding;
        return obj;
    }

    public static IBinding SelectionEnd(this TextBox obj, BindingMode mode = BindingMode.TwoWay)
    {
        return obj[Avalonia.Controls.TextBox.SelectionEndProperty.Bind().WithMode(mode)];
    }

    //
    // MaxLengthProperty
    //

    public static T MaxLength<T>(this T obj, int value) where T : TextBox
    {
        obj[Avalonia.Controls.TextBox.MaxLengthProperty] = value;
        return obj;
    }

    public static T MaxLength<T>(this T obj, IBinding binding, BindingMode mode = BindingMode.TwoWay) where T : TextBox
    {
        obj[Avalonia.Controls.TextBox.MaxLengthProperty.Bind().WithMode(mode)] = binding;
        return obj;
    }

    public static IBinding MaxLength(this TextBox obj, BindingMode mode = BindingMode.TwoWay)
    {
        return obj[Avalonia.Controls.TextBox.MaxLengthProperty.Bind().WithMode(mode)];
    }

    //
    // TextProperty
    //

    public static T Text<T>(this T obj, string value) where T : TextBox
    {
        obj[Avalonia.Controls.TextBox.TextProperty] = value;
        return obj;
    }

    public static T Text<T>(this T obj, IBinding binding, BindingMode mode = BindingMode.TwoWay) where T : TextBox
    {
        obj[Avalonia.Controls.TextBox.TextProperty.Bind().WithMode(mode)] = binding;
        return obj;
    }

    public static IBinding Text(this TextBox obj, BindingMode mode = BindingMode.TwoWay)
    {
        return obj[Avalonia.Controls.TextBox.TextProperty.Bind().WithMode(mode)];
    }

    //
    // TextAlignmentProperty
    //

    public static T TextAlignment<T>(this T obj, TextAlignment value) where T : TextBox
    {
        obj[Avalonia.Controls.TextBox.TextAlignmentProperty] = value;
        return obj;
    }

    public static T TextAlignment<T>(this T obj, IBinding binding, BindingMode mode = BindingMode.TwoWay) where T : TextBox
    {
        obj[Avalonia.Controls.TextBox.TextAlignmentProperty.Bind().WithMode(mode)] = binding;
        return obj;
    }

    public static IBinding TextAlignment(this TextBox obj, BindingMode mode = BindingMode.TwoWay)
    {
        return obj[Avalonia.Controls.TextBox.TextAlignmentProperty.Bind().WithMode(mode)];
    }

    //
    // HorizontalContentAlignmentProperty
    //

    public static T HorizontalContentAlignment<T>(this T obj, HorizontalAlignment value) where T : TextBox
    {
        obj[Avalonia.Controls.TextBox.HorizontalContentAlignmentProperty] = value;
        return obj;
    }

    public static T HorizontalContentAlignment<T>(this T obj, IBinding binding, BindingMode mode = BindingMode.TwoWay) where T : TextBox
    {
        obj[Avalonia.Controls.TextBox.HorizontalContentAlignmentProperty.Bind().WithMode(mode)] = binding;
        return obj;
    }

    public static IBinding HorizontalContentAlignment(this TextBox obj, BindingMode mode = BindingMode.TwoWay)
    {
        return obj[Avalonia.Controls.TextBox.HorizontalContentAlignmentProperty.Bind().WithMode(mode)];
    }

    //
    // VerticalContentAlignmentProperty
    //

    public static T VerticalContentAlignment<T>(this T obj, VerticalAlignment value) where T : TextBox
    {
        obj[Avalonia.Controls.TextBox.VerticalContentAlignmentProperty] = value;
        return obj;
    }

    public static T VerticalContentAlignment<T>(this T obj, IBinding binding, BindingMode mode = BindingMode.TwoWay) where T : TextBox
    {
        obj[Avalonia.Controls.TextBox.VerticalContentAlignmentProperty.Bind().WithMode(mode)] = binding;
        return obj;
    }

    public static IBinding VerticalContentAlignment(this TextBox obj, BindingMode mode = BindingMode.TwoWay)
    {
        return obj[Avalonia.Controls.TextBox.VerticalContentAlignmentProperty.Bind().WithMode(mode)];
    }

    //
    // TextWrappingProperty
    //

    public static T TextWrapping<T>(this T obj, TextWrapping value) where T : TextBox
    {
        obj[Avalonia.Controls.TextBox.TextWrappingProperty] = value;
        return obj;
    }

    public static T TextWrapping<T>(this T obj, IBinding binding, BindingMode mode = BindingMode.TwoWay) where T : TextBox
    {
        obj[Avalonia.Controls.TextBox.TextWrappingProperty.Bind().WithMode(mode)] = binding;
        return obj;
    }

    public static IBinding TextWrapping(this TextBox obj, BindingMode mode = BindingMode.TwoWay)
    {
        return obj[Avalonia.Controls.TextBox.TextWrappingProperty.Bind().WithMode(mode)];
    }

    //
    // WatermarkProperty
    //

    public static T Watermark<T>(this T obj, string value) where T : TextBox
    {
        obj[Avalonia.Controls.TextBox.WatermarkProperty] = value;
        return obj;
    }

    public static T Watermark<T>(this T obj, IBinding binding, BindingMode mode = BindingMode.TwoWay) where T : TextBox
    {
        obj[Avalonia.Controls.TextBox.WatermarkProperty.Bind().WithMode(mode)] = binding;
        return obj;
    }

    public static IBinding Watermark(this TextBox obj, BindingMode mode = BindingMode.TwoWay)
    {
        return obj[Avalonia.Controls.TextBox.WatermarkProperty.Bind().WithMode(mode)];
    }

    //
    // UseFloatingWatermarkProperty
    //

    public static T UseFloatingWatermark<T>(this T obj, bool value) where T : TextBox
    {
        obj[Avalonia.Controls.TextBox.UseFloatingWatermarkProperty] = value;
        return obj;
    }

    public static T UseFloatingWatermark<T>(this T obj, IBinding binding, BindingMode mode = BindingMode.TwoWay) where T : TextBox
    {
        obj[Avalonia.Controls.TextBox.UseFloatingWatermarkProperty.Bind().WithMode(mode)] = binding;
        return obj;
    }

    public static IBinding UseFloatingWatermark(this TextBox obj, BindingMode mode = BindingMode.TwoWay)
    {
        return obj[Avalonia.Controls.TextBox.UseFloatingWatermarkProperty.Bind().WithMode(mode)];
    }

    //
    // NewLineProperty
    //

    public static T NewLine<T>(this T obj, string value) where T : TextBox
    {
        obj[Avalonia.Controls.TextBox.NewLineProperty] = value;
        return obj;
    }

    public static T NewLine<T>(this T obj, IBinding binding, BindingMode mode = BindingMode.TwoWay) where T : TextBox
    {
        obj[Avalonia.Controls.TextBox.NewLineProperty.Bind().WithMode(mode)] = binding;
        return obj;
    }

    public static IBinding NewLine(this TextBox obj, BindingMode mode = BindingMode.TwoWay)
    {
        return obj[Avalonia.Controls.TextBox.NewLineProperty.Bind().WithMode(mode)];
    }

    //
    // InnerLeftContentProperty
    //

    public static T InnerLeftContent<T>(this T obj, object value) where T : TextBox
    {
        obj[Avalonia.Controls.TextBox.InnerLeftContentProperty] = value;
        return obj;
    }

    public static T InnerLeftContent<T>(this T obj, IBinding binding, BindingMode mode = BindingMode.TwoWay) where T : TextBox
    {
        obj[Avalonia.Controls.TextBox.InnerLeftContentProperty.Bind().WithMode(mode)] = binding;
        return obj;
    }

    public static IBinding InnerLeftContent(this TextBox obj, BindingMode mode = BindingMode.TwoWay)
    {
        return obj[Avalonia.Controls.TextBox.InnerLeftContentProperty.Bind().WithMode(mode)];
    }

    //
    // InnerRightContentProperty
    //

    public static T InnerRightContent<T>(this T obj, object value) where T : TextBox
    {
        obj[Avalonia.Controls.TextBox.InnerRightContentProperty] = value;
        return obj;
    }

    public static T InnerRightContent<T>(this T obj, IBinding binding, BindingMode mode = BindingMode.TwoWay) where T : TextBox
    {
        obj[Avalonia.Controls.TextBox.InnerRightContentProperty.Bind().WithMode(mode)] = binding;
        return obj;
    }

    public static IBinding InnerRightContent(this TextBox obj, BindingMode mode = BindingMode.TwoWay)
    {
        return obj[Avalonia.Controls.TextBox.InnerRightContentProperty.Bind().WithMode(mode)];
    }

    //
    // RevealPasswordProperty
    //

    public static T RevealPassword<T>(this T obj, bool value) where T : TextBox
    {
        obj[Avalonia.Controls.TextBox.RevealPasswordProperty] = value;
        return obj;
    }

    public static T RevealPassword<T>(this T obj, IBinding binding, BindingMode mode = BindingMode.TwoWay) where T : TextBox
    {
        obj[Avalonia.Controls.TextBox.RevealPasswordProperty.Bind().WithMode(mode)] = binding;
        return obj;
    }

    public static IBinding RevealPassword(this TextBox obj, BindingMode mode = BindingMode.TwoWay)
    {
        return obj[Avalonia.Controls.TextBox.RevealPasswordProperty.Bind().WithMode(mode)];
    }

    //
    // CanCutProperty
    //

    public static IBinding CanCut(this TextBox obj, BindingMode mode = BindingMode.OneWay)
    {
        return obj[Avalonia.Controls.TextBox.CanCutProperty.Bind().WithMode(mode)];
    }

    //
    // CanCopyProperty
    //

    public static IBinding CanCopy(this TextBox obj, BindingMode mode = BindingMode.OneWay)
    {
        return obj[Avalonia.Controls.TextBox.CanCopyProperty.Bind().WithMode(mode)];
    }

    //
    // CanPasteProperty
    //

    public static IBinding CanPaste(this TextBox obj, BindingMode mode = BindingMode.OneWay)
    {
        return obj[Avalonia.Controls.TextBox.CanPasteProperty.Bind().WithMode(mode)];
    }

    //
    // IsUndoEnabledProperty
    //

    public static T IsUndoEnabled<T>(this T obj, bool value) where T : TextBox
    {
        obj[Avalonia.Controls.TextBox.IsUndoEnabledProperty] = value;
        return obj;
    }

    public static T IsUndoEnabled<T>(this T obj, IBinding binding, BindingMode mode = BindingMode.TwoWay) where T : TextBox
    {
        obj[Avalonia.Controls.TextBox.IsUndoEnabledProperty.Bind().WithMode(mode)] = binding;
        return obj;
    }

    public static IBinding IsUndoEnabled(this TextBox obj, BindingMode mode = BindingMode.TwoWay)
    {
        return obj[Avalonia.Controls.TextBox.IsUndoEnabledProperty.Bind().WithMode(mode)];
    }

    //
    // UndoLimitProperty
    //

    public static T UndoLimit<T>(this T obj, int value) where T : TextBox
    {
        obj[Avalonia.Controls.TextBox.UndoLimitProperty] = value;
        return obj;
    }

    public static T UndoLimit<T>(this T obj, IBinding binding, BindingMode mode = BindingMode.TwoWay) where T : TextBox
    {
        obj[Avalonia.Controls.TextBox.UndoLimitProperty.Bind().WithMode(mode)] = binding;
        return obj;
    }

    public static IBinding UndoLimit(this TextBox obj, BindingMode mode = BindingMode.TwoWay)
    {
        return obj[Avalonia.Controls.TextBox.UndoLimitProperty.Bind().WithMode(mode)];
    }
}
