namespace MinimalAvalonia;

[System.Diagnostics.CodeAnalysis.SuppressMessage("ReSharper", "InconsistentNaming")]
[System.Diagnostics.CodeAnalysis.SuppressMessage("ReSharper", "RedundantNameQualifier")]
public static partial class MinimalAvaloniaProperties
{
    public static Avalonia.DirectProperty<Avalonia.Controls.Notifications.NotificationCard,System.Boolean> NotificationCardIsClosing => Avalonia.Controls.Notifications.NotificationCard.IsClosingProperty;

    public static Avalonia.DirectProperty<Avalonia.Controls.Notifications.NotificationCard,System.Boolean> NotificationCardIsClosed => Avalonia.Controls.Notifications.NotificationCard.IsClosedProperty;

    public static Avalonia.AttachedProperty<System.Boolean> NotificationCardCloseOnClick => Avalonia.Controls.Notifications.NotificationCard.CloseOnClickProperty;
}
