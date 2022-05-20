namespace MinimalAvalonia;

/// <summary>
/// The minimal avalonia properties.
/// </summary>
[System.Diagnostics.CodeAnalysis.SuppressMessage("ReSharper", "InconsistentNaming")]
[System.Diagnostics.CodeAnalysis.SuppressMessage("ReSharper", "RedundantNameQualifier")]
public static partial class MinimalAvaloniaProperties
{
    public static Avalonia.StyledProperty<Avalonia.Media.ITransform> LayoutTransformControlLayoutTransform => Avalonia.Controls.LayoutTransformControl.LayoutTransformProperty;

    public static Avalonia.StyledProperty<System.Boolean> LayoutTransformControlUseRenderTransform => Avalonia.Controls.LayoutTransformControl.UseRenderTransformProperty;
}
