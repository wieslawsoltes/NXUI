namespace MinimalAvalonia;

/// <summary>
/// The minimal avalonia properties.
/// </summary>
[System.Diagnostics.CodeAnalysis.SuppressMessage("ReSharper", "InconsistentNaming")]
[System.Diagnostics.CodeAnalysis.SuppressMessage("ReSharper", "RedundantNameQualifier")]
public static partial class MinimalAvaloniaProperties
{
    public static Avalonia.StyledProperty<Avalonia.Controls.Notifications.NotificationPosition> WindowNotificationManagerPosition => Avalonia.Controls.Notifications.WindowNotificationManager.PositionProperty;

    public static Avalonia.StyledProperty<System.Int32> WindowNotificationManagerMaxItems => Avalonia.Controls.Notifications.WindowNotificationManager.MaxItemsProperty;
}
