namespace MinimalAvalonia;

[System.Diagnostics.CodeAnalysis.SuppressMessage("ReSharper", "InconsistentNaming")]
[System.Diagnostics.CodeAnalysis.SuppressMessage("ReSharper", "RedundantNameQualifier")]
public static partial class MinimalAvaloniaProperties
{
    public static Avalonia.StyledProperty<System.Object> StyledElementDataContext => Avalonia.StyledElement.DataContextProperty;

    public static Avalonia.DirectProperty<Avalonia.StyledElement,System.String> StyledElementName => Avalonia.StyledElement.NameProperty;

    public static Avalonia.DirectProperty<Avalonia.StyledElement,Avalonia.IStyledElement> StyledElementParent => Avalonia.StyledElement.ParentProperty;

    public static Avalonia.DirectProperty<Avalonia.StyledElement,Avalonia.Styling.ITemplatedControl> StyledElementTemplatedParent => Avalonia.StyledElement.TemplatedParentProperty;
}
