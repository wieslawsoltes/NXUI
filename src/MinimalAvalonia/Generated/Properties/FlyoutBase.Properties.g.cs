namespace MinimalAvalonia;

[System.Diagnostics.CodeAnalysis.SuppressMessage("ReSharper", "InconsistentNaming")]
[System.Diagnostics.CodeAnalysis.SuppressMessage("ReSharper", "RedundantNameQualifier")]
public static partial class MinimalAvaloniaProperties
{
    public static Avalonia.DirectProperty<Avalonia.Controls.Primitives.FlyoutBase,System.Boolean> FlyoutBaseIsOpen => Avalonia.Controls.Primitives.FlyoutBase.IsOpenProperty;

    public static Avalonia.DirectProperty<Avalonia.Controls.Primitives.FlyoutBase,Avalonia.Controls.Control> FlyoutBaseTarget => Avalonia.Controls.Primitives.FlyoutBase.TargetProperty;

    public static Avalonia.StyledProperty<Avalonia.Controls.FlyoutPlacementMode> FlyoutBasePlacement => Avalonia.Controls.Primitives.FlyoutBase.PlacementProperty;

    public static Avalonia.DirectProperty<Avalonia.Controls.Primitives.FlyoutBase,Avalonia.Controls.FlyoutShowMode> FlyoutBaseShowMode => Avalonia.Controls.Primitives.FlyoutBase.ShowModeProperty;

    public static Avalonia.AttachedProperty<Avalonia.Controls.Primitives.FlyoutBase> FlyoutBaseAttachedFlyout => Avalonia.Controls.Primitives.FlyoutBase.AttachedFlyoutProperty;
}
