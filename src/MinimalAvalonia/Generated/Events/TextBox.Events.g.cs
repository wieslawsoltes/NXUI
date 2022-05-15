namespace MinimalAvalonia;

[System.Diagnostics.CodeAnalysis.SuppressMessage("ReSharper", "InconsistentNaming")]
[System.Diagnostics.CodeAnalysis.SuppressMessage("ReSharper", "RedundantNameQualifier")]
public static partial class MinimalAvaloniaEvents
{
    public static Avalonia.Interactivity.RoutedEvent<Avalonia.Interactivity.RoutedEventArgs> TextBoxCopyingToClipboard => Avalonia.Controls.TextBox.CopyingToClipboardEvent;

    public static Avalonia.Interactivity.RoutedEvent<Avalonia.Interactivity.RoutedEventArgs> TextBoxCuttingToClipboard => Avalonia.Controls.TextBox.CuttingToClipboardEvent;

    public static Avalonia.Interactivity.RoutedEvent<Avalonia.Interactivity.RoutedEventArgs> TextBoxPastingFromClipboard => Avalonia.Controls.TextBox.PastingFromClipboardEvent;
}
