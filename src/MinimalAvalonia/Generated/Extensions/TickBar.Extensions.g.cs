// <auto-generated />
namespace MinimalAvalonia.Extensions;

public static partial class TickBarExtensions
{
    // FillProperty

    public static T Fill<T>(this T obj, Avalonia.Media.IBrush value) where T : Avalonia.Controls.TickBar
    {
        obj[Avalonia.Controls.TickBar.FillProperty] = value;
        return obj;
    }

    public static T Fill<T>(this T obj, Avalonia.Data.IBinding binding, Avalonia.Data.BindingMode mode = Avalonia.Data.BindingMode.TwoWay) where T : Avalonia.Controls.TickBar
    {
        obj[Avalonia.Controls.TickBar.FillProperty.Bind().WithMode(mode)] = binding;
        return obj;
    }

    public static T Fill<T>(this T obj, IObservable<Avalonia.Media.IBrush> observable, Avalonia.Data.BindingMode mode = Avalonia.Data.BindingMode.TwoWay) where T : Avalonia.Controls.TickBar
    {
        obj[Avalonia.Controls.TickBar.FillProperty.Bind().WithMode(mode)] = observable.ToBinding();
        return obj;
    }

    public static Avalonia.Data.IBinding BindFill(this Avalonia.Controls.TickBar obj, Avalonia.Data.BindingMode mode = Avalonia.Data.BindingMode.TwoWay)
    {
        return obj[Avalonia.Controls.TickBar.FillProperty.Bind().WithMode(mode)];
    }

    public static IObservable<Avalonia.Media.IBrush> ObserveFill(this Avalonia.Controls.TickBar obj)
    {
        return obj.GetObservable(Avalonia.Controls.TickBar.FillProperty);
    }

    public static T OnFill<T>(this T obj, Action<IObservable<Avalonia.Media.IBrush>> handler) where T : Avalonia.Controls.TickBar
    {
        var observable = obj.GetObservable(Avalonia.Controls.TickBar.FillProperty);
        handler(observable);
        return obj;
    }

    // MinimumProperty

    public static T Minimum<T>(this T obj, System.Double value) where T : Avalonia.Controls.TickBar
    {
        obj[Avalonia.Controls.TickBar.MinimumProperty] = value;
        return obj;
    }

    public static T Minimum<T>(this T obj, Avalonia.Data.IBinding binding, Avalonia.Data.BindingMode mode = Avalonia.Data.BindingMode.TwoWay) where T : Avalonia.Controls.TickBar
    {
        obj[Avalonia.Controls.TickBar.MinimumProperty.Bind().WithMode(mode)] = binding;
        return obj;
    }

    public static T Minimum<T>(this T obj, IObservable<System.Double> observable, Avalonia.Data.BindingMode mode = Avalonia.Data.BindingMode.TwoWay) where T : Avalonia.Controls.TickBar
    {
        obj[Avalonia.Controls.TickBar.MinimumProperty.Bind().WithMode(mode)] = observable.ToBinding();
        return obj;
    }

    public static Avalonia.Data.IBinding BindMinimum(this Avalonia.Controls.TickBar obj, Avalonia.Data.BindingMode mode = Avalonia.Data.BindingMode.TwoWay)
    {
        return obj[Avalonia.Controls.TickBar.MinimumProperty.Bind().WithMode(mode)];
    }

    public static IObservable<System.Double> ObserveMinimum(this Avalonia.Controls.TickBar obj)
    {
        return obj.GetObservable(Avalonia.Controls.TickBar.MinimumProperty);
    }

    public static T OnMinimum<T>(this T obj, Action<IObservable<System.Double>> handler) where T : Avalonia.Controls.TickBar
    {
        var observable = obj.GetObservable(Avalonia.Controls.TickBar.MinimumProperty);
        handler(observable);
        return obj;
    }

    // MaximumProperty

    public static T Maximum<T>(this T obj, System.Double value) where T : Avalonia.Controls.TickBar
    {
        obj[Avalonia.Controls.TickBar.MaximumProperty] = value;
        return obj;
    }

    public static T Maximum<T>(this T obj, Avalonia.Data.IBinding binding, Avalonia.Data.BindingMode mode = Avalonia.Data.BindingMode.TwoWay) where T : Avalonia.Controls.TickBar
    {
        obj[Avalonia.Controls.TickBar.MaximumProperty.Bind().WithMode(mode)] = binding;
        return obj;
    }

    public static T Maximum<T>(this T obj, IObservable<System.Double> observable, Avalonia.Data.BindingMode mode = Avalonia.Data.BindingMode.TwoWay) where T : Avalonia.Controls.TickBar
    {
        obj[Avalonia.Controls.TickBar.MaximumProperty.Bind().WithMode(mode)] = observable.ToBinding();
        return obj;
    }

    public static Avalonia.Data.IBinding BindMaximum(this Avalonia.Controls.TickBar obj, Avalonia.Data.BindingMode mode = Avalonia.Data.BindingMode.TwoWay)
    {
        return obj[Avalonia.Controls.TickBar.MaximumProperty.Bind().WithMode(mode)];
    }

    public static IObservable<System.Double> ObserveMaximum(this Avalonia.Controls.TickBar obj)
    {
        return obj.GetObservable(Avalonia.Controls.TickBar.MaximumProperty);
    }

    public static T OnMaximum<T>(this T obj, Action<IObservable<System.Double>> handler) where T : Avalonia.Controls.TickBar
    {
        var observable = obj.GetObservable(Avalonia.Controls.TickBar.MaximumProperty);
        handler(observable);
        return obj;
    }

    // TickFrequencyProperty

    public static T TickFrequency<T>(this T obj, System.Double value) where T : Avalonia.Controls.TickBar
    {
        obj[Avalonia.Controls.TickBar.TickFrequencyProperty] = value;
        return obj;
    }

    public static T TickFrequency<T>(this T obj, Avalonia.Data.IBinding binding, Avalonia.Data.BindingMode mode = Avalonia.Data.BindingMode.TwoWay) where T : Avalonia.Controls.TickBar
    {
        obj[Avalonia.Controls.TickBar.TickFrequencyProperty.Bind().WithMode(mode)] = binding;
        return obj;
    }

    public static T TickFrequency<T>(this T obj, IObservable<System.Double> observable, Avalonia.Data.BindingMode mode = Avalonia.Data.BindingMode.TwoWay) where T : Avalonia.Controls.TickBar
    {
        obj[Avalonia.Controls.TickBar.TickFrequencyProperty.Bind().WithMode(mode)] = observable.ToBinding();
        return obj;
    }

    public static Avalonia.Data.IBinding BindTickFrequency(this Avalonia.Controls.TickBar obj, Avalonia.Data.BindingMode mode = Avalonia.Data.BindingMode.TwoWay)
    {
        return obj[Avalonia.Controls.TickBar.TickFrequencyProperty.Bind().WithMode(mode)];
    }

    public static IObservable<System.Double> ObserveTickFrequency(this Avalonia.Controls.TickBar obj)
    {
        return obj.GetObservable(Avalonia.Controls.TickBar.TickFrequencyProperty);
    }

    public static T OnTickFrequency<T>(this T obj, Action<IObservable<System.Double>> handler) where T : Avalonia.Controls.TickBar
    {
        var observable = obj.GetObservable(Avalonia.Controls.TickBar.TickFrequencyProperty);
        handler(observable);
        return obj;
    }

    // OrientationProperty

    public static T Orientation<T>(this T obj, Avalonia.Layout.Orientation value) where T : Avalonia.Controls.TickBar
    {
        obj[Avalonia.Controls.TickBar.OrientationProperty] = value;
        return obj;
    }

    public static T Orientation<T>(this T obj, Avalonia.Data.IBinding binding, Avalonia.Data.BindingMode mode = Avalonia.Data.BindingMode.TwoWay) where T : Avalonia.Controls.TickBar
    {
        obj[Avalonia.Controls.TickBar.OrientationProperty.Bind().WithMode(mode)] = binding;
        return obj;
    }

    public static T Orientation<T>(this T obj, IObservable<Avalonia.Layout.Orientation> observable, Avalonia.Data.BindingMode mode = Avalonia.Data.BindingMode.TwoWay) where T : Avalonia.Controls.TickBar
    {
        obj[Avalonia.Controls.TickBar.OrientationProperty.Bind().WithMode(mode)] = observable.ToBinding();
        return obj;
    }

    public static Avalonia.Data.IBinding BindOrientation(this Avalonia.Controls.TickBar obj, Avalonia.Data.BindingMode mode = Avalonia.Data.BindingMode.TwoWay)
    {
        return obj[Avalonia.Controls.TickBar.OrientationProperty.Bind().WithMode(mode)];
    }

    public static IObservable<Avalonia.Layout.Orientation> ObserveOrientation(this Avalonia.Controls.TickBar obj)
    {
        return obj.GetObservable(Avalonia.Controls.TickBar.OrientationProperty);
    }

    public static T OnOrientation<T>(this T obj, Action<IObservable<Avalonia.Layout.Orientation>> handler) where T : Avalonia.Controls.TickBar
    {
        var observable = obj.GetObservable(Avalonia.Controls.TickBar.OrientationProperty);
        handler(observable);
        return obj;
    }

    public static T OrientationHorizontal<T>(this T obj) where T : Avalonia.Controls.TickBar
    {
        obj[Avalonia.Controls.TickBar.OrientationProperty] = Avalonia.Layout.Orientation.Horizontal;
        return obj;
    }

    public static T OrientationVertical<T>(this T obj) where T : Avalonia.Controls.TickBar
    {
        obj[Avalonia.Controls.TickBar.OrientationProperty] = Avalonia.Layout.Orientation.Vertical;
        return obj;
    }

    // TicksProperty

    public static T Ticks<T>(this T obj, Avalonia.Collections.AvaloniaList<System.Double> value) where T : Avalonia.Controls.TickBar
    {
        obj[Avalonia.Controls.TickBar.TicksProperty] = value;
        return obj;
    }

    public static T Ticks<T>(this T obj, Avalonia.Data.IBinding binding, Avalonia.Data.BindingMode mode = Avalonia.Data.BindingMode.TwoWay) where T : Avalonia.Controls.TickBar
    {
        obj[Avalonia.Controls.TickBar.TicksProperty.Bind().WithMode(mode)] = binding;
        return obj;
    }

    public static T Ticks<T>(this T obj, IObservable<Avalonia.Collections.AvaloniaList<System.Double>> observable, Avalonia.Data.BindingMode mode = Avalonia.Data.BindingMode.TwoWay) where T : Avalonia.Controls.TickBar
    {
        obj[Avalonia.Controls.TickBar.TicksProperty.Bind().WithMode(mode)] = observable.ToBinding();
        return obj;
    }

    public static Avalonia.Data.IBinding BindTicks(this Avalonia.Controls.TickBar obj, Avalonia.Data.BindingMode mode = Avalonia.Data.BindingMode.TwoWay)
    {
        return obj[Avalonia.Controls.TickBar.TicksProperty.Bind().WithMode(mode)];
    }

    public static IObservable<Avalonia.Collections.AvaloniaList<System.Double>> ObserveTicks(this Avalonia.Controls.TickBar obj)
    {
        return obj.GetObservable(Avalonia.Controls.TickBar.TicksProperty);
    }

    public static T OnTicks<T>(this T obj, Action<IObservable<Avalonia.Collections.AvaloniaList<System.Double>>> handler) where T : Avalonia.Controls.TickBar
    {
        var observable = obj.GetObservable(Avalonia.Controls.TickBar.TicksProperty);
        handler(observable);
        return obj;
    }

    // IsDirectionReversedProperty

    public static T IsDirectionReversed<T>(this T obj, System.Boolean value) where T : Avalonia.Controls.TickBar
    {
        obj[Avalonia.Controls.TickBar.IsDirectionReversedProperty] = value;
        return obj;
    }

    public static T IsDirectionReversed<T>(this T obj, Avalonia.Data.IBinding binding, Avalonia.Data.BindingMode mode = Avalonia.Data.BindingMode.TwoWay) where T : Avalonia.Controls.TickBar
    {
        obj[Avalonia.Controls.TickBar.IsDirectionReversedProperty.Bind().WithMode(mode)] = binding;
        return obj;
    }

    public static T IsDirectionReversed<T>(this T obj, IObservable<System.Boolean> observable, Avalonia.Data.BindingMode mode = Avalonia.Data.BindingMode.TwoWay) where T : Avalonia.Controls.TickBar
    {
        obj[Avalonia.Controls.TickBar.IsDirectionReversedProperty.Bind().WithMode(mode)] = observable.ToBinding();
        return obj;
    }

    public static Avalonia.Data.IBinding BindIsDirectionReversed(this Avalonia.Controls.TickBar obj, Avalonia.Data.BindingMode mode = Avalonia.Data.BindingMode.TwoWay)
    {
        return obj[Avalonia.Controls.TickBar.IsDirectionReversedProperty.Bind().WithMode(mode)];
    }

    public static IObservable<System.Boolean> ObserveIsDirectionReversed(this Avalonia.Controls.TickBar obj)
    {
        return obj.GetObservable(Avalonia.Controls.TickBar.IsDirectionReversedProperty);
    }

    public static T OnIsDirectionReversed<T>(this T obj, Action<IObservable<System.Boolean>> handler) where T : Avalonia.Controls.TickBar
    {
        var observable = obj.GetObservable(Avalonia.Controls.TickBar.IsDirectionReversedProperty);
        handler(observable);
        return obj;
    }

    // PlacementProperty

    public static T Placement<T>(this T obj, Avalonia.Controls.TickBarPlacement value) where T : Avalonia.Controls.TickBar
    {
        obj[Avalonia.Controls.TickBar.PlacementProperty] = value;
        return obj;
    }

    public static T Placement<T>(this T obj, Avalonia.Data.IBinding binding, Avalonia.Data.BindingMode mode = Avalonia.Data.BindingMode.TwoWay) where T : Avalonia.Controls.TickBar
    {
        obj[Avalonia.Controls.TickBar.PlacementProperty.Bind().WithMode(mode)] = binding;
        return obj;
    }

    public static T Placement<T>(this T obj, IObservable<Avalonia.Controls.TickBarPlacement> observable, Avalonia.Data.BindingMode mode = Avalonia.Data.BindingMode.TwoWay) where T : Avalonia.Controls.TickBar
    {
        obj[Avalonia.Controls.TickBar.PlacementProperty.Bind().WithMode(mode)] = observable.ToBinding();
        return obj;
    }

    public static Avalonia.Data.IBinding BindPlacement(this Avalonia.Controls.TickBar obj, Avalonia.Data.BindingMode mode = Avalonia.Data.BindingMode.TwoWay)
    {
        return obj[Avalonia.Controls.TickBar.PlacementProperty.Bind().WithMode(mode)];
    }

    public static IObservable<Avalonia.Controls.TickBarPlacement> ObservePlacement(this Avalonia.Controls.TickBar obj)
    {
        return obj.GetObservable(Avalonia.Controls.TickBar.PlacementProperty);
    }

    public static T OnPlacement<T>(this T obj, Action<IObservable<Avalonia.Controls.TickBarPlacement>> handler) where T : Avalonia.Controls.TickBar
    {
        var observable = obj.GetObservable(Avalonia.Controls.TickBar.PlacementProperty);
        handler(observable);
        return obj;
    }

    public static T PlacementLeft<T>(this T obj) where T : Avalonia.Controls.TickBar
    {
        obj[Avalonia.Controls.TickBar.PlacementProperty] = Avalonia.Controls.TickBarPlacement.Left;
        return obj;
    }

    public static T PlacementTop<T>(this T obj) where T : Avalonia.Controls.TickBar
    {
        obj[Avalonia.Controls.TickBar.PlacementProperty] = Avalonia.Controls.TickBarPlacement.Top;
        return obj;
    }

    public static T PlacementRight<T>(this T obj) where T : Avalonia.Controls.TickBar
    {
        obj[Avalonia.Controls.TickBar.PlacementProperty] = Avalonia.Controls.TickBarPlacement.Right;
        return obj;
    }

    public static T PlacementBottom<T>(this T obj) where T : Avalonia.Controls.TickBar
    {
        obj[Avalonia.Controls.TickBar.PlacementProperty] = Avalonia.Controls.TickBarPlacement.Bottom;
        return obj;
    }

    // ReservedSpaceProperty

    public static T ReservedSpace<T>(this T obj, Avalonia.Rect value) where T : Avalonia.Controls.TickBar
    {
        obj[Avalonia.Controls.TickBar.ReservedSpaceProperty] = value;
        return obj;
    }

    public static T ReservedSpace<T>(this T obj, Avalonia.Data.IBinding binding, Avalonia.Data.BindingMode mode = Avalonia.Data.BindingMode.TwoWay) where T : Avalonia.Controls.TickBar
    {
        obj[Avalonia.Controls.TickBar.ReservedSpaceProperty.Bind().WithMode(mode)] = binding;
        return obj;
    }

    public static T ReservedSpace<T>(this T obj, IObservable<Avalonia.Rect> observable, Avalonia.Data.BindingMode mode = Avalonia.Data.BindingMode.TwoWay) where T : Avalonia.Controls.TickBar
    {
        obj[Avalonia.Controls.TickBar.ReservedSpaceProperty.Bind().WithMode(mode)] = observable.ToBinding();
        return obj;
    }

    public static Avalonia.Data.IBinding BindReservedSpace(this Avalonia.Controls.TickBar obj, Avalonia.Data.BindingMode mode = Avalonia.Data.BindingMode.TwoWay)
    {
        return obj[Avalonia.Controls.TickBar.ReservedSpaceProperty.Bind().WithMode(mode)];
    }

    public static IObservable<Avalonia.Rect> ObserveReservedSpace(this Avalonia.Controls.TickBar obj)
    {
        return obj.GetObservable(Avalonia.Controls.TickBar.ReservedSpaceProperty);
    }

    public static T OnReservedSpace<T>(this T obj, Action<IObservable<Avalonia.Rect>> handler) where T : Avalonia.Controls.TickBar
    {
        var observable = obj.GetObservable(Avalonia.Controls.TickBar.ReservedSpaceProperty);
        handler(observable);
        return obj;
    }
}