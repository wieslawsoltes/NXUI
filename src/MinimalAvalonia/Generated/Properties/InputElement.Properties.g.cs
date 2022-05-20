namespace MinimalAvalonia;

/// <summary>
/// The minimal avalonia properties.
/// </summary>
[System.Diagnostics.CodeAnalysis.SuppressMessage("ReSharper", "InconsistentNaming")]
[System.Diagnostics.CodeAnalysis.SuppressMessage("ReSharper", "RedundantNameQualifier")]
public static partial class MinimalAvaloniaProperties
{
    public static Avalonia.StyledProperty<System.Boolean> InputElementFocusable => Avalonia.Input.InputElement.FocusableProperty;

    public static Avalonia.StyledProperty<System.Boolean> InputElementIsEnabled => Avalonia.Input.InputElement.IsEnabledProperty;

    public static Avalonia.DirectProperty<Avalonia.Input.InputElement,System.Boolean> InputElementIsEffectivelyEnabled => Avalonia.Input.InputElement.IsEffectivelyEnabledProperty;

    public static Avalonia.StyledProperty<Avalonia.Input.Cursor> InputElementCursor => Avalonia.Input.InputElement.CursorProperty;

    public static Avalonia.DirectProperty<Avalonia.Input.InputElement,System.Boolean> InputElementIsKeyboardFocusWithin => Avalonia.Input.InputElement.IsKeyboardFocusWithinProperty;

    public static Avalonia.DirectProperty<Avalonia.Input.InputElement,System.Boolean> InputElementIsFocused => Avalonia.Input.InputElement.IsFocusedProperty;

    public static Avalonia.StyledProperty<System.Boolean> InputElementIsHitTestVisible => Avalonia.Input.InputElement.IsHitTestVisibleProperty;

    public static Avalonia.DirectProperty<Avalonia.Input.InputElement,System.Boolean> InputElementIsPointerOver => Avalonia.Input.InputElement.IsPointerOverProperty;

    public static Avalonia.StyledProperty<System.Boolean> InputElementIsTabStop => Avalonia.Input.InputElement.IsTabStopProperty;

    public static Avalonia.StyledProperty<System.Int32> InputElementTabIndex => Avalonia.Input.InputElement.TabIndexProperty;
}
