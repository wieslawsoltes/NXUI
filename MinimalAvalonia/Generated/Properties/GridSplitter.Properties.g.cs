namespace MinimalAvalonia;

[System.Diagnostics.CodeAnalysis.SuppressMessage("ReSharper", "InconsistentNaming")]
[System.Diagnostics.CodeAnalysis.SuppressMessage("ReSharper", "RedundantNameQualifier")]
public static partial class MinimalAvaloniaProperties
{
    public static Avalonia.StyledProperty<Avalonia.Controls.GridResizeDirection> GridSplitterResizeDirection => Avalonia.Controls.GridSplitter.ResizeDirectionProperty;

    public static Avalonia.StyledProperty<Avalonia.Controls.GridResizeBehavior> GridSplitterResizeBehavior => Avalonia.Controls.GridSplitter.ResizeBehaviorProperty;

    public static Avalonia.StyledProperty<System.Boolean> GridSplitterShowsPreview => Avalonia.Controls.GridSplitter.ShowsPreviewProperty;

    public static Avalonia.StyledProperty<System.Double> GridSplitterKeyboardIncrement => Avalonia.Controls.GridSplitter.KeyboardIncrementProperty;

    public static Avalonia.StyledProperty<System.Double> GridSplitterDragIncrement => Avalonia.Controls.GridSplitter.DragIncrementProperty;

    public static Avalonia.StyledProperty<Avalonia.Controls.ITemplate<Avalonia.Controls.IControl>> GridSplitterPreviewContent => Avalonia.Controls.GridSplitter.PreviewContentProperty;
}
