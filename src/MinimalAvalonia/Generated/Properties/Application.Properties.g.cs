namespace MinimalAvalonia;

[System.Diagnostics.CodeAnalysis.SuppressMessage("ReSharper", "InconsistentNaming")]
[System.Diagnostics.CodeAnalysis.SuppressMessage("ReSharper", "RedundantNameQualifier")]
public static partial class MinimalAvaloniaProperties
{
    public static Avalonia.StyledProperty<System.Object> ApplicationDataContext => Avalonia.Application.DataContextProperty;

    public static Avalonia.DirectProperty<Avalonia.Application,System.String> ApplicationName => Avalonia.Application.NameProperty;
}
