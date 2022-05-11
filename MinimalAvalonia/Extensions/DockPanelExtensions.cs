namespace MinimalAvalonia.Extensions;

public static class DockPanelExtensions
{
    public static T Dock<T>(this T control, Dock dock) where T : Control
    {
        control[Avalonia.Controls.DockPanel.DockProperty] = dock;
        return control;
    }    

    public static T DockLeft<T>(this T control) where T : Control
    {
        control[Avalonia.Controls.DockPanel.DockProperty] = Avalonia.Controls.Dock.Left;
        return control;
    }    

    public static T DockBottom<T>(this T control) where T : Control
    {
        control[Avalonia.Controls.DockPanel.DockProperty] = Avalonia.Controls.Dock.Bottom;
        return control;
    }    

    public static T DockRight<T>(this T control) where T : Control
    {
        control[Avalonia.Controls.DockPanel.DockProperty] = Avalonia.Controls.Dock.Right;
        return control;
    }    

    public static T DockTop<T>(this T control) where T : Control
    {
        control[Avalonia.Controls.DockPanel.DockProperty] = Avalonia.Controls.Dock.Top;
        return control;
    }    

    public static T LastChildFill<T>(this T dockPanel, bool lastChildFillProperty) where T : DockPanel
    {
        dockPanel[Avalonia.Controls.DockPanel.LastChildFillProperty] = lastChildFillProperty;
        return dockPanel;
    }
}
