namespace MinimalAvalonia;

public static class ButtonExtensions
{
    public static Button Ref(this Button button, out Button @ref)
    {
        @ref = button;
        return button;
    }

    public static Button OnClick(this Button button, Action<IObservable<RoutedEventArgs>> handler)
    {
        var observable = Observable
            .FromEventPattern<EventHandler<RoutedEventArgs>, RoutedEventArgs>(h => button.Click += h, h => button.Click -= h)
            .Select(x => x.EventArgs);
        handler(observable);
        return button;
    }

    public static IObservable<RoutedEventArgs> OnClick(this Button button)
    {
        return Observable
            .FromEventPattern<EventHandler<RoutedEventArgs>, RoutedEventArgs>(h => button.Click += h, h => button.Click -= h)
            .Select(x => x.EventArgs);
    }

    // TODO:
    // ClickModeProperty
    // CommandProperty
    // HotKeyProperty
    // CommandParameterProperty
    // IsDefaultProperty
    // IsCancelProperty
    // ClickEvent
    // IsPressedProperty
    // FlyoutProperty
}
