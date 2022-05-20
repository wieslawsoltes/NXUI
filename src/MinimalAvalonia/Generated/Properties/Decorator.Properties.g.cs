namespace MinimalAvalonia;

/// <summary>
/// The minimal avalonia properties.
/// </summary>
[System.Diagnostics.CodeAnalysis.SuppressMessage("ReSharper", "InconsistentNaming")]
[System.Diagnostics.CodeAnalysis.SuppressMessage("ReSharper", "RedundantNameQualifier")]
public static partial class MinimalAvaloniaProperties
{
    public static Avalonia.StyledProperty<Avalonia.Controls.IControl> DecoratorChild => Avalonia.Controls.Decorator.ChildProperty;

    public static Avalonia.StyledProperty<Avalonia.Thickness> DecoratorPadding => Avalonia.Controls.Decorator.PaddingProperty;
}
