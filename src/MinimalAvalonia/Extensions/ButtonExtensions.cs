namespace MinimalAvalonia.Extensions;

public static partial class ButtonExtensions
{
    // ClickEvent

    public static Button OnClickHandler(this Button obj, Action<Button, RoutedEventArgs> action, Avalonia.Interactivity.RoutingStrategies routes = Avalonia.Interactivity.RoutingStrategies.Bubble)
    {
        obj.AddHandler(Avalonia.Controls.Button.ClickEvent, (_, args) => action(obj, args), Avalonia.Interactivity.RoutingStrategies.Bubble);
        return obj;
    }

    public static Button OnClick(this Button obj, Action<Button, IObservable<RoutedEventArgs>> handler,  Avalonia.Interactivity.RoutingStrategies routes = Avalonia.Interactivity.RoutingStrategies.Bubble)
    {
        var observable = obj.GetObservable(Avalonia.Controls.Button.ClickEvent, routes);
        handler(obj, observable);
        return obj;
    }

    public static IObservable<RoutedEventArgs> ObserveOnClick(this Button obj)
    {
        return Observable
            .FromEventPattern<EventHandler<RoutedEventArgs>, RoutedEventArgs>(
                h => obj.Click += h, 
                h => obj.Click -= h)
            .Select(x => x.EventArgs);
    }
}
