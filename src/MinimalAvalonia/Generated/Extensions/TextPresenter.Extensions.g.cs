// <auto-generated />
namespace MinimalAvalonia.Extensions;

public static partial class TextPresenterExtensions
{
    // CaretIndexProperty

    public static T CaretIndex<T>(this T obj, System.Int32 value) where T : Avalonia.Controls.Presenters.TextPresenter
    {
        obj[Avalonia.Controls.Presenters.TextPresenter.CaretIndexProperty] = value;
        return obj;
    }

    public static T CaretIndex<T>(this T obj, Avalonia.Data.IBinding binding, Avalonia.Data.BindingMode mode = Avalonia.Data.BindingMode.TwoWay) where T : Avalonia.Controls.Presenters.TextPresenter
    {
        obj[Avalonia.Controls.Presenters.TextPresenter.CaretIndexProperty.Bind().WithMode(mode)] = binding;
        return obj;
    }

    public static T CaretIndex<T>(this T obj, IObservable<System.Int32> observable, Avalonia.Data.BindingMode mode = Avalonia.Data.BindingMode.TwoWay) where T : Avalonia.Controls.Presenters.TextPresenter
    {
        obj[Avalonia.Controls.Presenters.TextPresenter.CaretIndexProperty.Bind().WithMode(mode)] = observable.ToBinding();
        return obj;
    }

    public static Avalonia.Data.IBinding BindCaretIndex(this Avalonia.Controls.Presenters.TextPresenter obj, Avalonia.Data.BindingMode mode = Avalonia.Data.BindingMode.TwoWay)
    {
        return obj[Avalonia.Controls.Presenters.TextPresenter.CaretIndexProperty.Bind().WithMode(mode)];
    }

    public static IObservable<System.Int32> ObserveCaretIndex(this Avalonia.Controls.Presenters.TextPresenter obj)
    {
        return obj.GetObservable(Avalonia.Controls.Presenters.TextPresenter.CaretIndexProperty);
    }

    public static T OnCaretIndex<T>(this T obj, Action<IObservable<System.Int32>> handler) where T : Avalonia.Controls.Presenters.TextPresenter
    {
        var observable = obj.GetObservable(Avalonia.Controls.Presenters.TextPresenter.CaretIndexProperty);
        handler(observable);
        return obj;
    }

    // RevealPasswordProperty

    public static T RevealPassword<T>(this T obj, System.Boolean value) where T : Avalonia.Controls.Presenters.TextPresenter
    {
        obj[Avalonia.Controls.Presenters.TextPresenter.RevealPasswordProperty] = value;
        return obj;
    }

    public static T RevealPassword<T>(this T obj, Avalonia.Data.IBinding binding, Avalonia.Data.BindingMode mode = Avalonia.Data.BindingMode.TwoWay) where T : Avalonia.Controls.Presenters.TextPresenter
    {
        obj[Avalonia.Controls.Presenters.TextPresenter.RevealPasswordProperty.Bind().WithMode(mode)] = binding;
        return obj;
    }

    public static T RevealPassword<T>(this T obj, IObservable<System.Boolean> observable, Avalonia.Data.BindingMode mode = Avalonia.Data.BindingMode.TwoWay) where T : Avalonia.Controls.Presenters.TextPresenter
    {
        obj[Avalonia.Controls.Presenters.TextPresenter.RevealPasswordProperty.Bind().WithMode(mode)] = observable.ToBinding();
        return obj;
    }

    public static Avalonia.Data.IBinding BindRevealPassword(this Avalonia.Controls.Presenters.TextPresenter obj, Avalonia.Data.BindingMode mode = Avalonia.Data.BindingMode.TwoWay)
    {
        return obj[Avalonia.Controls.Presenters.TextPresenter.RevealPasswordProperty.Bind().WithMode(mode)];
    }

    public static IObservable<System.Boolean> ObserveRevealPassword(this Avalonia.Controls.Presenters.TextPresenter obj)
    {
        return obj.GetObservable(Avalonia.Controls.Presenters.TextPresenter.RevealPasswordProperty);
    }

    public static T OnRevealPassword<T>(this T obj, Action<IObservable<System.Boolean>> handler) where T : Avalonia.Controls.Presenters.TextPresenter
    {
        var observable = obj.GetObservable(Avalonia.Controls.Presenters.TextPresenter.RevealPasswordProperty);
        handler(observable);
        return obj;
    }

    // PasswordCharProperty

    public static T PasswordChar<T>(this T obj, System.Char value) where T : Avalonia.Controls.Presenters.TextPresenter
    {
        obj[Avalonia.Controls.Presenters.TextPresenter.PasswordCharProperty] = value;
        return obj;
    }

    public static T PasswordChar<T>(this T obj, Avalonia.Data.IBinding binding, Avalonia.Data.BindingMode mode = Avalonia.Data.BindingMode.TwoWay) where T : Avalonia.Controls.Presenters.TextPresenter
    {
        obj[Avalonia.Controls.Presenters.TextPresenter.PasswordCharProperty.Bind().WithMode(mode)] = binding;
        return obj;
    }

    public static T PasswordChar<T>(this T obj, IObservable<System.Char> observable, Avalonia.Data.BindingMode mode = Avalonia.Data.BindingMode.TwoWay) where T : Avalonia.Controls.Presenters.TextPresenter
    {
        obj[Avalonia.Controls.Presenters.TextPresenter.PasswordCharProperty.Bind().WithMode(mode)] = observable.ToBinding();
        return obj;
    }

    public static Avalonia.Data.IBinding BindPasswordChar(this Avalonia.Controls.Presenters.TextPresenter obj, Avalonia.Data.BindingMode mode = Avalonia.Data.BindingMode.TwoWay)
    {
        return obj[Avalonia.Controls.Presenters.TextPresenter.PasswordCharProperty.Bind().WithMode(mode)];
    }

    public static IObservable<System.Char> ObservePasswordChar(this Avalonia.Controls.Presenters.TextPresenter obj)
    {
        return obj.GetObservable(Avalonia.Controls.Presenters.TextPresenter.PasswordCharProperty);
    }

    public static T OnPasswordChar<T>(this T obj, Action<IObservable<System.Char>> handler) where T : Avalonia.Controls.Presenters.TextPresenter
    {
        var observable = obj.GetObservable(Avalonia.Controls.Presenters.TextPresenter.PasswordCharProperty);
        handler(observable);
        return obj;
    }

    // SelectionBrushProperty

    public static T SelectionBrush<T>(this T obj, Avalonia.Media.IBrush value) where T : Avalonia.Controls.Presenters.TextPresenter
    {
        obj[Avalonia.Controls.Presenters.TextPresenter.SelectionBrushProperty] = value;
        return obj;
    }

    public static T SelectionBrush<T>(this T obj, Avalonia.Data.IBinding binding, Avalonia.Data.BindingMode mode = Avalonia.Data.BindingMode.TwoWay) where T : Avalonia.Controls.Presenters.TextPresenter
    {
        obj[Avalonia.Controls.Presenters.TextPresenter.SelectionBrushProperty.Bind().WithMode(mode)] = binding;
        return obj;
    }

    public static T SelectionBrush<T>(this T obj, IObservable<Avalonia.Media.IBrush> observable, Avalonia.Data.BindingMode mode = Avalonia.Data.BindingMode.TwoWay) where T : Avalonia.Controls.Presenters.TextPresenter
    {
        obj[Avalonia.Controls.Presenters.TextPresenter.SelectionBrushProperty.Bind().WithMode(mode)] = observable.ToBinding();
        return obj;
    }

    public static Avalonia.Data.IBinding BindSelectionBrush(this Avalonia.Controls.Presenters.TextPresenter obj, Avalonia.Data.BindingMode mode = Avalonia.Data.BindingMode.TwoWay)
    {
        return obj[Avalonia.Controls.Presenters.TextPresenter.SelectionBrushProperty.Bind().WithMode(mode)];
    }

    public static IObservable<Avalonia.Media.IBrush> ObserveSelectionBrush(this Avalonia.Controls.Presenters.TextPresenter obj)
    {
        return obj.GetObservable(Avalonia.Controls.Presenters.TextPresenter.SelectionBrushProperty);
    }

    public static T OnSelectionBrush<T>(this T obj, Action<IObservable<Avalonia.Media.IBrush>> handler) where T : Avalonia.Controls.Presenters.TextPresenter
    {
        var observable = obj.GetObservable(Avalonia.Controls.Presenters.TextPresenter.SelectionBrushProperty);
        handler(observable);
        return obj;
    }

    // SelectionForegroundBrushProperty

    public static T SelectionForegroundBrush<T>(this T obj, Avalonia.Media.IBrush value) where T : Avalonia.Controls.Presenters.TextPresenter
    {
        obj[Avalonia.Controls.Presenters.TextPresenter.SelectionForegroundBrushProperty] = value;
        return obj;
    }

    public static T SelectionForegroundBrush<T>(this T obj, Avalonia.Data.IBinding binding, Avalonia.Data.BindingMode mode = Avalonia.Data.BindingMode.TwoWay) where T : Avalonia.Controls.Presenters.TextPresenter
    {
        obj[Avalonia.Controls.Presenters.TextPresenter.SelectionForegroundBrushProperty.Bind().WithMode(mode)] = binding;
        return obj;
    }

    public static T SelectionForegroundBrush<T>(this T obj, IObservable<Avalonia.Media.IBrush> observable, Avalonia.Data.BindingMode mode = Avalonia.Data.BindingMode.TwoWay) where T : Avalonia.Controls.Presenters.TextPresenter
    {
        obj[Avalonia.Controls.Presenters.TextPresenter.SelectionForegroundBrushProperty.Bind().WithMode(mode)] = observable.ToBinding();
        return obj;
    }

    public static Avalonia.Data.IBinding BindSelectionForegroundBrush(this Avalonia.Controls.Presenters.TextPresenter obj, Avalonia.Data.BindingMode mode = Avalonia.Data.BindingMode.TwoWay)
    {
        return obj[Avalonia.Controls.Presenters.TextPresenter.SelectionForegroundBrushProperty.Bind().WithMode(mode)];
    }

    public static IObservable<Avalonia.Media.IBrush> ObserveSelectionForegroundBrush(this Avalonia.Controls.Presenters.TextPresenter obj)
    {
        return obj.GetObservable(Avalonia.Controls.Presenters.TextPresenter.SelectionForegroundBrushProperty);
    }

    public static T OnSelectionForegroundBrush<T>(this T obj, Action<IObservable<Avalonia.Media.IBrush>> handler) where T : Avalonia.Controls.Presenters.TextPresenter
    {
        var observable = obj.GetObservable(Avalonia.Controls.Presenters.TextPresenter.SelectionForegroundBrushProperty);
        handler(observable);
        return obj;
    }

    // CaretBrushProperty

    public static T CaretBrush<T>(this T obj, Avalonia.Media.IBrush value) where T : Avalonia.Controls.Presenters.TextPresenter
    {
        obj[Avalonia.Controls.Presenters.TextPresenter.CaretBrushProperty] = value;
        return obj;
    }

    public static T CaretBrush<T>(this T obj, Avalonia.Data.IBinding binding, Avalonia.Data.BindingMode mode = Avalonia.Data.BindingMode.TwoWay) where T : Avalonia.Controls.Presenters.TextPresenter
    {
        obj[Avalonia.Controls.Presenters.TextPresenter.CaretBrushProperty.Bind().WithMode(mode)] = binding;
        return obj;
    }

    public static T CaretBrush<T>(this T obj, IObservable<Avalonia.Media.IBrush> observable, Avalonia.Data.BindingMode mode = Avalonia.Data.BindingMode.TwoWay) where T : Avalonia.Controls.Presenters.TextPresenter
    {
        obj[Avalonia.Controls.Presenters.TextPresenter.CaretBrushProperty.Bind().WithMode(mode)] = observable.ToBinding();
        return obj;
    }

    public static Avalonia.Data.IBinding BindCaretBrush(this Avalonia.Controls.Presenters.TextPresenter obj, Avalonia.Data.BindingMode mode = Avalonia.Data.BindingMode.TwoWay)
    {
        return obj[Avalonia.Controls.Presenters.TextPresenter.CaretBrushProperty.Bind().WithMode(mode)];
    }

    public static IObservable<Avalonia.Media.IBrush> ObserveCaretBrush(this Avalonia.Controls.Presenters.TextPresenter obj)
    {
        return obj.GetObservable(Avalonia.Controls.Presenters.TextPresenter.CaretBrushProperty);
    }

    public static T OnCaretBrush<T>(this T obj, Action<IObservable<Avalonia.Media.IBrush>> handler) where T : Avalonia.Controls.Presenters.TextPresenter
    {
        var observable = obj.GetObservable(Avalonia.Controls.Presenters.TextPresenter.CaretBrushProperty);
        handler(observable);
        return obj;
    }

    // SelectionStartProperty

    public static T SelectionStart<T>(this T obj, System.Int32 value) where T : Avalonia.Controls.Presenters.TextPresenter
    {
        obj[Avalonia.Controls.Presenters.TextPresenter.SelectionStartProperty] = value;
        return obj;
    }

    public static T SelectionStart<T>(this T obj, Avalonia.Data.IBinding binding, Avalonia.Data.BindingMode mode = Avalonia.Data.BindingMode.TwoWay) where T : Avalonia.Controls.Presenters.TextPresenter
    {
        obj[Avalonia.Controls.Presenters.TextPresenter.SelectionStartProperty.Bind().WithMode(mode)] = binding;
        return obj;
    }

    public static T SelectionStart<T>(this T obj, IObservable<System.Int32> observable, Avalonia.Data.BindingMode mode = Avalonia.Data.BindingMode.TwoWay) where T : Avalonia.Controls.Presenters.TextPresenter
    {
        obj[Avalonia.Controls.Presenters.TextPresenter.SelectionStartProperty.Bind().WithMode(mode)] = observable.ToBinding();
        return obj;
    }

    public static Avalonia.Data.IBinding BindSelectionStart(this Avalonia.Controls.Presenters.TextPresenter obj, Avalonia.Data.BindingMode mode = Avalonia.Data.BindingMode.TwoWay)
    {
        return obj[Avalonia.Controls.Presenters.TextPresenter.SelectionStartProperty.Bind().WithMode(mode)];
    }

    public static IObservable<System.Int32> ObserveSelectionStart(this Avalonia.Controls.Presenters.TextPresenter obj)
    {
        return obj.GetObservable(Avalonia.Controls.Presenters.TextPresenter.SelectionStartProperty);
    }

    public static T OnSelectionStart<T>(this T obj, Action<IObservable<System.Int32>> handler) where T : Avalonia.Controls.Presenters.TextPresenter
    {
        var observable = obj.GetObservable(Avalonia.Controls.Presenters.TextPresenter.SelectionStartProperty);
        handler(observable);
        return obj;
    }

    // SelectionEndProperty

    public static T SelectionEnd<T>(this T obj, System.Int32 value) where T : Avalonia.Controls.Presenters.TextPresenter
    {
        obj[Avalonia.Controls.Presenters.TextPresenter.SelectionEndProperty] = value;
        return obj;
    }

    public static T SelectionEnd<T>(this T obj, Avalonia.Data.IBinding binding, Avalonia.Data.BindingMode mode = Avalonia.Data.BindingMode.TwoWay) where T : Avalonia.Controls.Presenters.TextPresenter
    {
        obj[Avalonia.Controls.Presenters.TextPresenter.SelectionEndProperty.Bind().WithMode(mode)] = binding;
        return obj;
    }

    public static T SelectionEnd<T>(this T obj, IObservable<System.Int32> observable, Avalonia.Data.BindingMode mode = Avalonia.Data.BindingMode.TwoWay) where T : Avalonia.Controls.Presenters.TextPresenter
    {
        obj[Avalonia.Controls.Presenters.TextPresenter.SelectionEndProperty.Bind().WithMode(mode)] = observable.ToBinding();
        return obj;
    }

    public static Avalonia.Data.IBinding BindSelectionEnd(this Avalonia.Controls.Presenters.TextPresenter obj, Avalonia.Data.BindingMode mode = Avalonia.Data.BindingMode.TwoWay)
    {
        return obj[Avalonia.Controls.Presenters.TextPresenter.SelectionEndProperty.Bind().WithMode(mode)];
    }

    public static IObservable<System.Int32> ObserveSelectionEnd(this Avalonia.Controls.Presenters.TextPresenter obj)
    {
        return obj.GetObservable(Avalonia.Controls.Presenters.TextPresenter.SelectionEndProperty);
    }

    public static T OnSelectionEnd<T>(this T obj, Action<IObservable<System.Int32>> handler) where T : Avalonia.Controls.Presenters.TextPresenter
    {
        var observable = obj.GetObservable(Avalonia.Controls.Presenters.TextPresenter.SelectionEndProperty);
        handler(observable);
        return obj;
    }

    // TextProperty

    public static T Text<T>(this T obj, System.String value) where T : Avalonia.Controls.Presenters.TextPresenter
    {
        obj[Avalonia.Controls.Presenters.TextPresenter.TextProperty] = value;
        return obj;
    }

    public static T Text<T>(this T obj, Avalonia.Data.IBinding binding, Avalonia.Data.BindingMode mode = Avalonia.Data.BindingMode.TwoWay) where T : Avalonia.Controls.Presenters.TextPresenter
    {
        obj[Avalonia.Controls.Presenters.TextPresenter.TextProperty.Bind().WithMode(mode)] = binding;
        return obj;
    }

    public static T Text<T>(this T obj, IObservable<System.String> observable, Avalonia.Data.BindingMode mode = Avalonia.Data.BindingMode.TwoWay) where T : Avalonia.Controls.Presenters.TextPresenter
    {
        obj[Avalonia.Controls.Presenters.TextPresenter.TextProperty.Bind().WithMode(mode)] = observable.ToBinding();
        return obj;
    }

    public static Avalonia.Data.IBinding BindText(this Avalonia.Controls.Presenters.TextPresenter obj, Avalonia.Data.BindingMode mode = Avalonia.Data.BindingMode.TwoWay)
    {
        return obj[Avalonia.Controls.Presenters.TextPresenter.TextProperty.Bind().WithMode(mode)];
    }

    public static IObservable<System.String> ObserveText(this Avalonia.Controls.Presenters.TextPresenter obj)
    {
        return obj.GetObservable(Avalonia.Controls.Presenters.TextPresenter.TextProperty);
    }

    public static T OnText<T>(this T obj, Action<IObservable<System.String>> handler) where T : Avalonia.Controls.Presenters.TextPresenter
    {
        var observable = obj.GetObservable(Avalonia.Controls.Presenters.TextPresenter.TextProperty);
        handler(observable);
        return obj;
    }
}