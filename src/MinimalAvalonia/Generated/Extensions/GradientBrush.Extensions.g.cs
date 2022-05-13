// <auto-generated />
namespace MinimalAvalonia.Extensions;

public static partial class GradientBrushExtensions
{
    // SpreadMethodProperty

    public static T SpreadMethod<T>(this T obj, Avalonia.Media.GradientSpreadMethod value) where T : Avalonia.Media.GradientBrush
    {
        obj[Avalonia.Media.GradientBrush.SpreadMethodProperty] = value;
        return obj;
    }

    public static T SpreadMethod<T>(this T obj, Avalonia.Data.IBinding binding, Avalonia.Data.BindingMode mode = Avalonia.Data.BindingMode.TwoWay) where T : Avalonia.Media.GradientBrush
    {
        obj[Avalonia.Media.GradientBrush.SpreadMethodProperty.Bind().WithMode(mode)] = binding;
        return obj;
    }

    public static T SpreadMethod<T>(this T obj, IObservable<Avalonia.Media.GradientSpreadMethod> observable, Avalonia.Data.BindingMode mode = Avalonia.Data.BindingMode.TwoWay) where T : Avalonia.Media.GradientBrush
    {
        obj[Avalonia.Media.GradientBrush.SpreadMethodProperty.Bind().WithMode(mode)] = observable.ToBinding();
        return obj;
    }

    public static Avalonia.Data.IBinding BindSpreadMethod(this Avalonia.Media.GradientBrush obj, Avalonia.Data.BindingMode mode = Avalonia.Data.BindingMode.TwoWay)
    {
        return obj[Avalonia.Media.GradientBrush.SpreadMethodProperty.Bind().WithMode(mode)];
    }

    public static IObservable<Avalonia.Media.GradientSpreadMethod> ObserveSpreadMethod(this Avalonia.Media.GradientBrush obj)
    {
        return obj.GetObservable(Avalonia.Media.GradientBrush.SpreadMethodProperty);
    }

    public static T OnSpreadMethod<T>(this T obj, Action<IObservable<Avalonia.Media.GradientSpreadMethod>> handler) where T : Avalonia.Media.GradientBrush
    {
        var observable = obj.GetObservable(Avalonia.Media.GradientBrush.SpreadMethodProperty);
        handler(observable);
        return obj;
    }

    public static T SpreadMethodPad<T>(this T obj) where T : Avalonia.Media.GradientBrush
    {
        obj[Avalonia.Media.GradientBrush.SpreadMethodProperty] = Avalonia.Media.GradientSpreadMethod.Pad;
        return obj;
    }

    public static T SpreadMethodReflect<T>(this T obj) where T : Avalonia.Media.GradientBrush
    {
        obj[Avalonia.Media.GradientBrush.SpreadMethodProperty] = Avalonia.Media.GradientSpreadMethod.Reflect;
        return obj;
    }

    public static T SpreadMethodRepeat<T>(this T obj) where T : Avalonia.Media.GradientBrush
    {
        obj[Avalonia.Media.GradientBrush.SpreadMethodProperty] = Avalonia.Media.GradientSpreadMethod.Repeat;
        return obj;
    }

    // GradientStopsProperty

    public static T GradientStops<T>(this T obj, Avalonia.Media.GradientStops value) where T : Avalonia.Media.GradientBrush
    {
        obj[Avalonia.Media.GradientBrush.GradientStopsProperty] = value;
        return obj;
    }

    public static T GradientStops<T>(this T obj, Avalonia.Data.IBinding binding, Avalonia.Data.BindingMode mode = Avalonia.Data.BindingMode.TwoWay) where T : Avalonia.Media.GradientBrush
    {
        obj[Avalonia.Media.GradientBrush.GradientStopsProperty.Bind().WithMode(mode)] = binding;
        return obj;
    }

    public static T GradientStops<T>(this T obj, IObservable<Avalonia.Media.GradientStops> observable, Avalonia.Data.BindingMode mode = Avalonia.Data.BindingMode.TwoWay) where T : Avalonia.Media.GradientBrush
    {
        obj[Avalonia.Media.GradientBrush.GradientStopsProperty.Bind().WithMode(mode)] = observable.ToBinding();
        return obj;
    }

    public static Avalonia.Data.IBinding BindGradientStops(this Avalonia.Media.GradientBrush obj, Avalonia.Data.BindingMode mode = Avalonia.Data.BindingMode.TwoWay)
    {
        return obj[Avalonia.Media.GradientBrush.GradientStopsProperty.Bind().WithMode(mode)];
    }

    public static IObservable<Avalonia.Media.GradientStops> ObserveGradientStops(this Avalonia.Media.GradientBrush obj)
    {
        return obj.GetObservable(Avalonia.Media.GradientBrush.GradientStopsProperty);
    }

    public static T OnGradientStops<T>(this T obj, Action<IObservable<Avalonia.Media.GradientStops>> handler) where T : Avalonia.Media.GradientBrush
    {
        var observable = obj.GetObservable(Avalonia.Media.GradientBrush.GradientStopsProperty);
        handler(observable);
        return obj;
    }
}
