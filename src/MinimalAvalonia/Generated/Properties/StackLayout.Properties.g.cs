namespace MinimalAvalonia;

/// <summary>
/// The minimal avalonia properties.
/// </summary>
[System.Diagnostics.CodeAnalysis.SuppressMessage("ReSharper", "InconsistentNaming")]
[System.Diagnostics.CodeAnalysis.SuppressMessage("ReSharper", "RedundantNameQualifier")]
public static partial class MinimalAvaloniaProperties
{
    public static Avalonia.StyledProperty<System.Boolean> StackLayoutDisableVirtualization => Avalonia.Layout.StackLayout.DisableVirtualizationProperty;

    public static Avalonia.StyledProperty<Avalonia.Layout.Orientation> StackLayoutOrientation => Avalonia.Layout.StackLayout.OrientationProperty;

    public static Avalonia.StyledProperty<System.Double> StackLayoutSpacing => Avalonia.Layout.StackLayout.SpacingProperty;
}
