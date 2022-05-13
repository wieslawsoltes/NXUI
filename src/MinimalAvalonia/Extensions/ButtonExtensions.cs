namespace MinimalAvalonia.Extensions;

public static partial class ButtonExtensions
{
    // Click

    public static Button OnClick(this Button button, Action<IObservable<RoutedEventArgs>> handler)
    {
        var observable = Observable
            .FromEventPattern<EventHandler<RoutedEventArgs>, RoutedEventArgs>(
                h => button.Click += h, 
                h => button.Click -= h)
            .Select(x => x.EventArgs);
        handler(observable);
        return button;
    }

    public static IObservable<RoutedEventArgs> OnClick(this Button button)
    {
        return Observable
            .FromEventPattern<EventHandler<RoutedEventArgs>, RoutedEventArgs>(
                h => button.Click += h, 
                h => button.Click -= h)
            .Select(x => x.EventArgs);
    }
}
