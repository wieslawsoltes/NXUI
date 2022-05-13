namespace MinimalAvalonia;

[System.Diagnostics.CodeAnalysis.SuppressMessage("ReSharper", "InconsistentNaming")]
[System.Diagnostics.CodeAnalysis.SuppressMessage("ReSharper", "RedundantNameQualifier")]
public static partial class MinimalAvaloniaProperties
{
    public static Avalonia.StyledProperty<System.Double> ItemsRepeaterHorizontalCacheLength => Avalonia.Controls.ItemsRepeater.HorizontalCacheLengthProperty;

    public static Avalonia.StyledProperty<Avalonia.Controls.Templates.IDataTemplate> ItemsRepeaterItemTemplate => Avalonia.Controls.ItemsRepeater.ItemTemplateProperty;

    public static Avalonia.DirectProperty<Avalonia.Controls.ItemsRepeater,System.Collections.IEnumerable> ItemsRepeaterItems => Avalonia.Controls.ItemsRepeater.ItemsProperty;

    public static Avalonia.StyledProperty<Avalonia.Layout.AttachedLayout> ItemsRepeaterLayout => Avalonia.Controls.ItemsRepeater.LayoutProperty;

    public static Avalonia.StyledProperty<System.Double> ItemsRepeaterVerticalCacheLength => Avalonia.Controls.ItemsRepeater.VerticalCacheLengthProperty;
}
