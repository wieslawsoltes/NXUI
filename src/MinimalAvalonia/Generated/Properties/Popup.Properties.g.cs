namespace MinimalAvalonia;

[System.Diagnostics.CodeAnalysis.SuppressMessage("ReSharper", "InconsistentNaming")]
[System.Diagnostics.CodeAnalysis.SuppressMessage("ReSharper", "RedundantNameQualifier")]
public static partial class MinimalAvaloniaProperties
{
    public static Avalonia.StyledProperty<Avalonia.Controls.Control> PopupChild => Avalonia.Controls.Primitives.Popup.ChildProperty;

    public static Avalonia.DirectProperty<Avalonia.Controls.Primitives.Popup,System.Boolean> PopupIsOpen => Avalonia.Controls.Primitives.Popup.IsOpenProperty;

    public static Avalonia.StyledProperty<Avalonia.Controls.Primitives.PopupPositioning.PopupAnchor> PopupPlacementAnchor => Avalonia.Controls.Primitives.Popup.PlacementAnchorProperty;

    public static Avalonia.StyledProperty<Avalonia.Controls.Primitives.PopupPositioning.PopupPositionerConstraintAdjustment> PopupPlacementConstraintAdjustment => Avalonia.Controls.Primitives.Popup.PlacementConstraintAdjustmentProperty;

    public static Avalonia.StyledProperty<Avalonia.Controls.Primitives.PopupPositioning.PopupGravity> PopupPlacementGravity => Avalonia.Controls.Primitives.Popup.PlacementGravityProperty;

    public static Avalonia.StyledProperty<Avalonia.Controls.PlacementMode> PopupPlacementMode => Avalonia.Controls.Primitives.Popup.PlacementModeProperty;

    public static Avalonia.StyledProperty<System.Nullable<Avalonia.Rect>> PopupPlacementRect => Avalonia.Controls.Primitives.Popup.PlacementRectProperty;

    public static Avalonia.StyledProperty<Avalonia.Controls.Control> PopupPlacementTarget => Avalonia.Controls.Primitives.Popup.PlacementTargetProperty;

    public static Avalonia.StyledProperty<System.Boolean> PopupObeyScreenEdges => Avalonia.Controls.Primitives.Popup.ObeyScreenEdgesProperty;

    public static Avalonia.StyledProperty<System.Boolean> PopupOverlayDismissEventPassThrough => Avalonia.Controls.Primitives.Popup.OverlayDismissEventPassThroughProperty;

    public static Avalonia.DirectProperty<Avalonia.Controls.Primitives.Popup,Avalonia.Input.IInputElement> PopupOverlayInputPassThroughElement => Avalonia.Controls.Primitives.Popup.OverlayInputPassThroughElementProperty;

    public static Avalonia.StyledProperty<System.Double> PopupHorizontalOffset => Avalonia.Controls.Primitives.Popup.HorizontalOffsetProperty;

    public static Avalonia.StyledProperty<System.Boolean> PopupIsLightDismissEnabled => Avalonia.Controls.Primitives.Popup.IsLightDismissEnabledProperty;

    public static Avalonia.StyledProperty<System.Double> PopupVerticalOffset => Avalonia.Controls.Primitives.Popup.VerticalOffsetProperty;

    public static Avalonia.StyledProperty<System.Boolean> PopupTopmost => Avalonia.Controls.Primitives.Popup.TopmostProperty;

    //public static Avalonia.StyledProperty<System.Nullable<Avalonia.Rect>> PopupPlacementRect => Avalonia.Controls.Primitives.Popup.PlacementRectProperty;
}
