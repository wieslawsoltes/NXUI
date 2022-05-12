namespace MinimalAvalonia;

[System.Diagnostics.CodeAnalysis.SuppressMessage("ReSharper", "InconsistentNaming")]
[System.Diagnostics.CodeAnalysis.SuppressMessage("ReSharper", "RedundantNameQualifier")]
public static partial class MinimalAvaloniaProperties
{
    public static Avalonia.DirectProperty<Avalonia.Media.GeometryGroup,Avalonia.Media.GeometryCollection> GeometryGroupChildren => Avalonia.Media.GeometryGroup.ChildrenProperty;

    public static Avalonia.StyledProperty<Avalonia.Media.FillRule> GeometryGroupFillRule => Avalonia.Media.GeometryGroup.FillRuleProperty;
}
