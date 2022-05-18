namespace MinimalAvalonia;

[System.Diagnostics.CodeAnalysis.SuppressMessage("ReSharper", "InconsistentNaming")]
[System.Diagnostics.CodeAnalysis.SuppressMessage("ReSharper", "RedundantNameQualifier")]
public static partial class MinimalAvaloniaEvents
{
    public static Avalonia.Interactivity.RoutedEvent WindowWindowClosed => Avalonia.Controls.Window.WindowClosedEvent;

    public static Avalonia.Interactivity.RoutedEvent WindowWindowOpened => Avalonia.Controls.Window.WindowOpenedEvent;
}
