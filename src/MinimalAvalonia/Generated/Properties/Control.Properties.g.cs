namespace MinimalAvalonia;

[System.Diagnostics.CodeAnalysis.SuppressMessage("ReSharper", "InconsistentNaming")]
[System.Diagnostics.CodeAnalysis.SuppressMessage("ReSharper", "RedundantNameQualifier")]
public static partial class MinimalAvaloniaProperties
{
    public static Avalonia.StyledProperty<Avalonia.Controls.ITemplate<Avalonia.Controls.IControl>> ControlFocusAdorner => Avalonia.Controls.Control.FocusAdornerProperty;

    public static Avalonia.StyledProperty<System.Object> ControlTag => Avalonia.Controls.Control.TagProperty;

    public static Avalonia.StyledProperty<Avalonia.Controls.ContextMenu> ControlContextMenu => Avalonia.Controls.Control.ContextMenuProperty;

    public static Avalonia.StyledProperty<Avalonia.Controls.Primitives.FlyoutBase> ControlContextFlyout => Avalonia.Controls.Control.ContextFlyoutProperty;
}
