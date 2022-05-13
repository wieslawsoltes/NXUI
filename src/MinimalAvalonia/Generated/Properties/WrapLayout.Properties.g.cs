namespace MinimalAvalonia;

[System.Diagnostics.CodeAnalysis.SuppressMessage("ReSharper", "InconsistentNaming")]
[System.Diagnostics.CodeAnalysis.SuppressMessage("ReSharper", "RedundantNameQualifier")]
public static partial class MinimalAvaloniaProperties
{
    public static Avalonia.StyledProperty<System.Double> WrapLayoutHorizontalSpacing => Avalonia.Layout.WrapLayout.HorizontalSpacingProperty;

    public static Avalonia.StyledProperty<System.Double> WrapLayoutVerticalSpacing => Avalonia.Layout.WrapLayout.VerticalSpacingProperty;

    public static Avalonia.StyledProperty<Avalonia.Layout.Orientation> WrapLayoutOrientation => Avalonia.Layout.WrapLayout.OrientationProperty;
}
