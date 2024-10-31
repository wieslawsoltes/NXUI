// <auto-generated />
namespace NXUI.Extensions;

/// <summary>
/// The avalonia <see cref="Avalonia.Controls.TimePicker"/> class property extension methods.
/// </summary>
public static partial class TimePickerExtensions
{
    // Avalonia.Controls.TimePicker.MinuteIncrementProperty

    /// <summary>
    /// Sets a <see cref="Avalonia.Controls.TimePicker.MinuteIncrementProperty"/> value.
    /// </summary>
    /// <param name="obj">The target object.</param>
    /// <param name="value">The value.</param>
    /// <typeparam name="T">The type of the target object.</typeparam>
    /// <returns>The target object reference.</returns>
    public static T MinuteIncrement<T>(this T obj, System.Int32 value) where T : Avalonia.Controls.TimePicker
    {
        obj[Avalonia.Controls.TimePicker.MinuteIncrementProperty] = value;
        return obj;
    }

    /// <summary>
    /// Sets a binding to <see cref="Avalonia.Controls.TimePicker.MinuteIncrementProperty"/> with binding source value.
    /// </summary>
    /// <param name="obj">The target object.</param>
    /// <param name="binding">The source binding.</param>
    /// <param name="mode">The target binding mode.</param>
    /// <param name="priority">The target binding priority.</param>
    /// <typeparam name="T">The type of the target object.</typeparam>
    /// <returns>The target object reference.</returns>
    public static T MinuteIncrement<T>(
        this T obj,
        Avalonia.Data.IBinding binding,
        Avalonia.Data.BindingMode mode = Avalonia.Data.BindingMode.TwoWay,
        Avalonia.Data.BindingPriority priority = Avalonia.Data.BindingPriority.LocalValue) where T : Avalonia.Controls.TimePicker
    {
        var descriptor = Avalonia.Controls.TimePicker.MinuteIncrementProperty.Bind().WithMode(mode).WithPriority(priority);
        obj[descriptor] = binding;
        return obj;
    }

    /// <summary>
    /// Sets a binding to <see cref="Avalonia.Controls.TimePicker.MinuteIncrementProperty"/> with observable source value.
    /// </summary>
    /// <param name="obj">The target object.</param>
    /// <param name="observable">The source observable.</param>
    /// <param name="mode">The target binding mode.</param>
    /// <param name="priority">The target binding priority.</param>
    /// <typeparam name="T">The type of the target object.</typeparam>
    /// <returns>The target object reference.</returns>
    public static T MinuteIncrement<T>(
        this T obj,
        IObservable<System.Int32> observable,
        Avalonia.Data.BindingMode mode = Avalonia.Data.BindingMode.TwoWay,
        Avalonia.Data.BindingPriority priority = Avalonia.Data.BindingPriority.LocalValue) where T : Avalonia.Controls.TimePicker
    {
        var descriptor = Avalonia.Controls.TimePicker.MinuteIncrementProperty.Bind().WithMode(mode).WithPriority(priority);
        obj[descriptor] = observable.ToBinding();
        return obj;
    }

    /// <summary>
    /// Makes a <see cref="Avalonia.Controls.TimePicker.MinuteIncrementProperty"/> binding.
    /// </summary>
    /// <param name="obj">The target object.</param>
    /// <param name="mode">The target binding mode.</param>
    /// <param name="priority">The target binding priority.</param>
    /// <returns>A <see cref="Avalonia.Controls.TimePicker.MinuteIncrementProperty"/> binding.</returns>
    public static Avalonia.Data.IBinding BindMinuteIncrement(
        this Avalonia.Controls.TimePicker obj,
        Avalonia.Data.BindingMode mode = Avalonia.Data.BindingMode.TwoWay,
        Avalonia.Data.BindingPriority priority = Avalonia.Data.BindingPriority.LocalValue)
    {
        var descriptor = Avalonia.Controls.TimePicker.MinuteIncrementProperty.Bind().WithMode(mode).WithPriority(priority);
        return obj[descriptor];
    }

    /// <summary>
    /// Gets an observable for an <see cref="Avalonia.Controls.TimePicker.MinuteIncrementProperty"/>.
    /// </summary>
    /// <param name="obj">The target object.</param>
    /// <returns>
    /// An observable which fires immediately with the current value of the property on the
    /// object and subsequently each time the property value changes.
    /// </returns>
    public static IObservable<System.Int32> ObserveMinuteIncrement(this Avalonia.Controls.TimePicker obj)
    {
        return obj.GetObservable(Avalonia.Controls.TimePicker.MinuteIncrementProperty);
    }

    /// <summary>
    /// Sets a handler with an observable for an <see cref="Avalonia.Controls.TimePicker.MinuteIncrementProperty"/>.
    /// </summary>
    /// <param name="obj">The target object.</param>
    /// <param name="handler">The handler with target object and observable with the current value of the property.</param>
    /// <typeparam name="T">The type of the target object.</typeparam>
    /// <returns>The target object reference.</returns>
    public static T OnMinuteIncrement<T>(this T obj, Action<Avalonia.Controls.TimePicker, IObservable<System.Int32>> handler) where T : Avalonia.Controls.TimePicker
    {
        var observable = obj.GetObservable(Avalonia.Controls.TimePicker.MinuteIncrementProperty);
        handler(obj, observable);
        return obj;
    }

    // Avalonia.Controls.TimePicker.SecondIncrementProperty

    /// <summary>
    /// Sets a <see cref="Avalonia.Controls.TimePicker.SecondIncrementProperty"/> value.
    /// </summary>
    /// <param name="obj">The target object.</param>
    /// <param name="value">The value.</param>
    /// <typeparam name="T">The type of the target object.</typeparam>
    /// <returns>The target object reference.</returns>
    public static T SecondIncrement<T>(this T obj, System.Int32 value) where T : Avalonia.Controls.TimePicker
    {
        obj[Avalonia.Controls.TimePicker.SecondIncrementProperty] = value;
        return obj;
    }

    /// <summary>
    /// Sets a binding to <see cref="Avalonia.Controls.TimePicker.SecondIncrementProperty"/> with binding source value.
    /// </summary>
    /// <param name="obj">The target object.</param>
    /// <param name="binding">The source binding.</param>
    /// <param name="mode">The target binding mode.</param>
    /// <param name="priority">The target binding priority.</param>
    /// <typeparam name="T">The type of the target object.</typeparam>
    /// <returns>The target object reference.</returns>
    public static T SecondIncrement<T>(
        this T obj,
        Avalonia.Data.IBinding binding,
        Avalonia.Data.BindingMode mode = Avalonia.Data.BindingMode.TwoWay,
        Avalonia.Data.BindingPriority priority = Avalonia.Data.BindingPriority.LocalValue) where T : Avalonia.Controls.TimePicker
    {
        var descriptor = Avalonia.Controls.TimePicker.SecondIncrementProperty.Bind().WithMode(mode).WithPriority(priority);
        obj[descriptor] = binding;
        return obj;
    }

    /// <summary>
    /// Sets a binding to <see cref="Avalonia.Controls.TimePicker.SecondIncrementProperty"/> with observable source value.
    /// </summary>
    /// <param name="obj">The target object.</param>
    /// <param name="observable">The source observable.</param>
    /// <param name="mode">The target binding mode.</param>
    /// <param name="priority">The target binding priority.</param>
    /// <typeparam name="T">The type of the target object.</typeparam>
    /// <returns>The target object reference.</returns>
    public static T SecondIncrement<T>(
        this T obj,
        IObservable<System.Int32> observable,
        Avalonia.Data.BindingMode mode = Avalonia.Data.BindingMode.TwoWay,
        Avalonia.Data.BindingPriority priority = Avalonia.Data.BindingPriority.LocalValue) where T : Avalonia.Controls.TimePicker
    {
        var descriptor = Avalonia.Controls.TimePicker.SecondIncrementProperty.Bind().WithMode(mode).WithPriority(priority);
        obj[descriptor] = observable.ToBinding();
        return obj;
    }

    /// <summary>
    /// Makes a <see cref="Avalonia.Controls.TimePicker.SecondIncrementProperty"/> binding.
    /// </summary>
    /// <param name="obj">The target object.</param>
    /// <param name="mode">The target binding mode.</param>
    /// <param name="priority">The target binding priority.</param>
    /// <returns>A <see cref="Avalonia.Controls.TimePicker.SecondIncrementProperty"/> binding.</returns>
    public static Avalonia.Data.IBinding BindSecondIncrement(
        this Avalonia.Controls.TimePicker obj,
        Avalonia.Data.BindingMode mode = Avalonia.Data.BindingMode.TwoWay,
        Avalonia.Data.BindingPriority priority = Avalonia.Data.BindingPriority.LocalValue)
    {
        var descriptor = Avalonia.Controls.TimePicker.SecondIncrementProperty.Bind().WithMode(mode).WithPriority(priority);
        return obj[descriptor];
    }

    /// <summary>
    /// Gets an observable for an <see cref="Avalonia.Controls.TimePicker.SecondIncrementProperty"/>.
    /// </summary>
    /// <param name="obj">The target object.</param>
    /// <returns>
    /// An observable which fires immediately with the current value of the property on the
    /// object and subsequently each time the property value changes.
    /// </returns>
    public static IObservable<System.Int32> ObserveSecondIncrement(this Avalonia.Controls.TimePicker obj)
    {
        return obj.GetObservable(Avalonia.Controls.TimePicker.SecondIncrementProperty);
    }

    /// <summary>
    /// Sets a handler with an observable for an <see cref="Avalonia.Controls.TimePicker.SecondIncrementProperty"/>.
    /// </summary>
    /// <param name="obj">The target object.</param>
    /// <param name="handler">The handler with target object and observable with the current value of the property.</param>
    /// <typeparam name="T">The type of the target object.</typeparam>
    /// <returns>The target object reference.</returns>
    public static T OnSecondIncrement<T>(this T obj, Action<Avalonia.Controls.TimePicker, IObservable<System.Int32>> handler) where T : Avalonia.Controls.TimePicker
    {
        var observable = obj.GetObservable(Avalonia.Controls.TimePicker.SecondIncrementProperty);
        handler(obj, observable);
        return obj;
    }

    // Avalonia.Controls.TimePicker.ClockIdentifierProperty

    /// <summary>
    /// Sets a <see cref="Avalonia.Controls.TimePicker.ClockIdentifierProperty"/> value.
    /// </summary>
    /// <param name="obj">The target object.</param>
    /// <param name="value">The value.</param>
    /// <typeparam name="T">The type of the target object.</typeparam>
    /// <returns>The target object reference.</returns>
    public static T ClockIdentifier<T>(this T obj, System.String value) where T : Avalonia.Controls.TimePicker
    {
        obj[Avalonia.Controls.TimePicker.ClockIdentifierProperty] = value;
        return obj;
    }

    /// <summary>
    /// Sets a binding to <see cref="Avalonia.Controls.TimePicker.ClockIdentifierProperty"/> with binding source value.
    /// </summary>
    /// <param name="obj">The target object.</param>
    /// <param name="binding">The source binding.</param>
    /// <param name="mode">The target binding mode.</param>
    /// <param name="priority">The target binding priority.</param>
    /// <typeparam name="T">The type of the target object.</typeparam>
    /// <returns>The target object reference.</returns>
    public static T ClockIdentifier<T>(
        this T obj,
        Avalonia.Data.IBinding binding,
        Avalonia.Data.BindingMode mode = Avalonia.Data.BindingMode.TwoWay,
        Avalonia.Data.BindingPriority priority = Avalonia.Data.BindingPriority.LocalValue) where T : Avalonia.Controls.TimePicker
    {
        var descriptor = Avalonia.Controls.TimePicker.ClockIdentifierProperty.Bind().WithMode(mode).WithPriority(priority);
        obj[descriptor] = binding;
        return obj;
    }

    /// <summary>
    /// Sets a binding to <see cref="Avalonia.Controls.TimePicker.ClockIdentifierProperty"/> with observable source value.
    /// </summary>
    /// <param name="obj">The target object.</param>
    /// <param name="observable">The source observable.</param>
    /// <param name="mode">The target binding mode.</param>
    /// <param name="priority">The target binding priority.</param>
    /// <typeparam name="T">The type of the target object.</typeparam>
    /// <returns>The target object reference.</returns>
    public static T ClockIdentifier<T>(
        this T obj,
        IObservable<System.String> observable,
        Avalonia.Data.BindingMode mode = Avalonia.Data.BindingMode.TwoWay,
        Avalonia.Data.BindingPriority priority = Avalonia.Data.BindingPriority.LocalValue) where T : Avalonia.Controls.TimePicker
    {
        var descriptor = Avalonia.Controls.TimePicker.ClockIdentifierProperty.Bind().WithMode(mode).WithPriority(priority);
        obj[descriptor] = observable.ToBinding();
        return obj;
    }

    /// <summary>
    /// Makes a <see cref="Avalonia.Controls.TimePicker.ClockIdentifierProperty"/> binding.
    /// </summary>
    /// <param name="obj">The target object.</param>
    /// <param name="mode">The target binding mode.</param>
    /// <param name="priority">The target binding priority.</param>
    /// <returns>A <see cref="Avalonia.Controls.TimePicker.ClockIdentifierProperty"/> binding.</returns>
    public static Avalonia.Data.IBinding BindClockIdentifier(
        this Avalonia.Controls.TimePicker obj,
        Avalonia.Data.BindingMode mode = Avalonia.Data.BindingMode.TwoWay,
        Avalonia.Data.BindingPriority priority = Avalonia.Data.BindingPriority.LocalValue)
    {
        var descriptor = Avalonia.Controls.TimePicker.ClockIdentifierProperty.Bind().WithMode(mode).WithPriority(priority);
        return obj[descriptor];
    }

    /// <summary>
    /// Gets an observable for an <see cref="Avalonia.Controls.TimePicker.ClockIdentifierProperty"/>.
    /// </summary>
    /// <param name="obj">The target object.</param>
    /// <returns>
    /// An observable which fires immediately with the current value of the property on the
    /// object and subsequently each time the property value changes.
    /// </returns>
    public static IObservable<System.String> ObserveClockIdentifier(this Avalonia.Controls.TimePicker obj)
    {
        return obj.GetObservable(Avalonia.Controls.TimePicker.ClockIdentifierProperty);
    }

    /// <summary>
    /// Sets a handler with an observable for an <see cref="Avalonia.Controls.TimePicker.ClockIdentifierProperty"/>.
    /// </summary>
    /// <param name="obj">The target object.</param>
    /// <param name="handler">The handler with target object and observable with the current value of the property.</param>
    /// <typeparam name="T">The type of the target object.</typeparam>
    /// <returns>The target object reference.</returns>
    public static T OnClockIdentifier<T>(this T obj, Action<Avalonia.Controls.TimePicker, IObservable<System.String>> handler) where T : Avalonia.Controls.TimePicker
    {
        var observable = obj.GetObservable(Avalonia.Controls.TimePicker.ClockIdentifierProperty);
        handler(obj, observable);
        return obj;
    }

    // Avalonia.Controls.TimePicker.UseSecondsProperty

    /// <summary>
    /// Sets a <see cref="Avalonia.Controls.TimePicker.UseSecondsProperty"/> value.
    /// </summary>
    /// <param name="obj">The target object.</param>
    /// <param name="value">The value.</param>
    /// <typeparam name="T">The type of the target object.</typeparam>
    /// <returns>The target object reference.</returns>
    public static T UseSeconds<T>(this T obj, System.Boolean value) where T : Avalonia.Controls.TimePicker
    {
        obj[Avalonia.Controls.TimePicker.UseSecondsProperty] = value;
        return obj;
    }

    /// <summary>
    /// Sets a binding to <see cref="Avalonia.Controls.TimePicker.UseSecondsProperty"/> with binding source value.
    /// </summary>
    /// <param name="obj">The target object.</param>
    /// <param name="binding">The source binding.</param>
    /// <param name="mode">The target binding mode.</param>
    /// <param name="priority">The target binding priority.</param>
    /// <typeparam name="T">The type of the target object.</typeparam>
    /// <returns>The target object reference.</returns>
    public static T UseSeconds<T>(
        this T obj,
        Avalonia.Data.IBinding binding,
        Avalonia.Data.BindingMode mode = Avalonia.Data.BindingMode.TwoWay,
        Avalonia.Data.BindingPriority priority = Avalonia.Data.BindingPriority.LocalValue) where T : Avalonia.Controls.TimePicker
    {
        var descriptor = Avalonia.Controls.TimePicker.UseSecondsProperty.Bind().WithMode(mode).WithPriority(priority);
        obj[descriptor] = binding;
        return obj;
    }

    /// <summary>
    /// Sets a binding to <see cref="Avalonia.Controls.TimePicker.UseSecondsProperty"/> with observable source value.
    /// </summary>
    /// <param name="obj">The target object.</param>
    /// <param name="observable">The source observable.</param>
    /// <param name="mode">The target binding mode.</param>
    /// <param name="priority">The target binding priority.</param>
    /// <typeparam name="T">The type of the target object.</typeparam>
    /// <returns>The target object reference.</returns>
    public static T UseSeconds<T>(
        this T obj,
        IObservable<System.Boolean> observable,
        Avalonia.Data.BindingMode mode = Avalonia.Data.BindingMode.TwoWay,
        Avalonia.Data.BindingPriority priority = Avalonia.Data.BindingPriority.LocalValue) where T : Avalonia.Controls.TimePicker
    {
        var descriptor = Avalonia.Controls.TimePicker.UseSecondsProperty.Bind().WithMode(mode).WithPriority(priority);
        obj[descriptor] = observable.ToBinding();
        return obj;
    }

    /// <summary>
    /// Makes a <see cref="Avalonia.Controls.TimePicker.UseSecondsProperty"/> binding.
    /// </summary>
    /// <param name="obj">The target object.</param>
    /// <param name="mode">The target binding mode.</param>
    /// <param name="priority">The target binding priority.</param>
    /// <returns>A <see cref="Avalonia.Controls.TimePicker.UseSecondsProperty"/> binding.</returns>
    public static Avalonia.Data.IBinding BindUseSeconds(
        this Avalonia.Controls.TimePicker obj,
        Avalonia.Data.BindingMode mode = Avalonia.Data.BindingMode.TwoWay,
        Avalonia.Data.BindingPriority priority = Avalonia.Data.BindingPriority.LocalValue)
    {
        var descriptor = Avalonia.Controls.TimePicker.UseSecondsProperty.Bind().WithMode(mode).WithPriority(priority);
        return obj[descriptor];
    }

    /// <summary>
    /// Gets an observable for an <see cref="Avalonia.Controls.TimePicker.UseSecondsProperty"/>.
    /// </summary>
    /// <param name="obj">The target object.</param>
    /// <returns>
    /// An observable which fires immediately with the current value of the property on the
    /// object and subsequently each time the property value changes.
    /// </returns>
    public static IObservable<System.Boolean> ObserveUseSeconds(this Avalonia.Controls.TimePicker obj)
    {
        return obj.GetObservable(Avalonia.Controls.TimePicker.UseSecondsProperty);
    }

    /// <summary>
    /// Sets a handler with an observable for an <see cref="Avalonia.Controls.TimePicker.UseSecondsProperty"/>.
    /// </summary>
    /// <param name="obj">The target object.</param>
    /// <param name="handler">The handler with target object and observable with the current value of the property.</param>
    /// <typeparam name="T">The type of the target object.</typeparam>
    /// <returns>The target object reference.</returns>
    public static T OnUseSeconds<T>(this T obj, Action<Avalonia.Controls.TimePicker, IObservable<System.Boolean>> handler) where T : Avalonia.Controls.TimePicker
    {
        var observable = obj.GetObservable(Avalonia.Controls.TimePicker.UseSecondsProperty);
        handler(obj, observable);
        return obj;
    }

    // Avalonia.Controls.TimePicker.SelectedTimeProperty

    /// <summary>
    /// Sets a <see cref="Avalonia.Controls.TimePicker.SelectedTimeProperty"/> value.
    /// </summary>
    /// <param name="obj">The target object.</param>
    /// <param name="value">The value.</param>
    /// <typeparam name="T">The type of the target object.</typeparam>
    /// <returns>The target object reference.</returns>
    public static T SelectedTime<T>(this T obj, System.Nullable<System.TimeSpan> value) where T : Avalonia.Controls.TimePicker
    {
        obj[Avalonia.Controls.TimePicker.SelectedTimeProperty] = value;
        return obj;
    }

    /// <summary>
    /// Sets a binding to <see cref="Avalonia.Controls.TimePicker.SelectedTimeProperty"/> with binding source value.
    /// </summary>
    /// <param name="obj">The target object.</param>
    /// <param name="binding">The source binding.</param>
    /// <param name="mode">The target binding mode.</param>
    /// <param name="priority">The target binding priority.</param>
    /// <typeparam name="T">The type of the target object.</typeparam>
    /// <returns>The target object reference.</returns>
    public static T SelectedTime<T>(
        this T obj,
        Avalonia.Data.IBinding binding,
        Avalonia.Data.BindingMode mode = Avalonia.Data.BindingMode.TwoWay,
        Avalonia.Data.BindingPriority priority = Avalonia.Data.BindingPriority.LocalValue) where T : Avalonia.Controls.TimePicker
    {
        var descriptor = Avalonia.Controls.TimePicker.SelectedTimeProperty.Bind().WithMode(mode).WithPriority(priority);
        obj[descriptor] = binding;
        return obj;
    }

    /// <summary>
    /// Sets a binding to <see cref="Avalonia.Controls.TimePicker.SelectedTimeProperty"/> with observable source value.
    /// </summary>
    /// <param name="obj">The target object.</param>
    /// <param name="observable">The source observable.</param>
    /// <param name="mode">The target binding mode.</param>
    /// <param name="priority">The target binding priority.</param>
    /// <typeparam name="T">The type of the target object.</typeparam>
    /// <returns>The target object reference.</returns>
    public static T SelectedTime<T>(
        this T obj,
        IObservable<System.Nullable<System.TimeSpan>> observable,
        Avalonia.Data.BindingMode mode = Avalonia.Data.BindingMode.TwoWay,
        Avalonia.Data.BindingPriority priority = Avalonia.Data.BindingPriority.LocalValue) where T : Avalonia.Controls.TimePicker
    {
        var descriptor = Avalonia.Controls.TimePicker.SelectedTimeProperty.Bind().WithMode(mode).WithPriority(priority);
        obj[descriptor] = observable.ToBinding();
        return obj;
    }

    /// <summary>
    /// Makes a <see cref="Avalonia.Controls.TimePicker.SelectedTimeProperty"/> binding.
    /// </summary>
    /// <param name="obj">The target object.</param>
    /// <param name="mode">The target binding mode.</param>
    /// <param name="priority">The target binding priority.</param>
    /// <returns>A <see cref="Avalonia.Controls.TimePicker.SelectedTimeProperty"/> binding.</returns>
    public static Avalonia.Data.IBinding BindSelectedTime(
        this Avalonia.Controls.TimePicker obj,
        Avalonia.Data.BindingMode mode = Avalonia.Data.BindingMode.TwoWay,
        Avalonia.Data.BindingPriority priority = Avalonia.Data.BindingPriority.LocalValue)
    {
        var descriptor = Avalonia.Controls.TimePicker.SelectedTimeProperty.Bind().WithMode(mode).WithPriority(priority);
        return obj[descriptor];
    }

    /// <summary>
    /// Gets an observable for an <see cref="Avalonia.Controls.TimePicker.SelectedTimeProperty"/>.
    /// </summary>
    /// <param name="obj">The target object.</param>
    /// <returns>
    /// An observable which fires immediately with the current value of the property on the
    /// object and subsequently each time the property value changes.
    /// </returns>
    public static IObservable<System.Nullable<System.TimeSpan>> ObserveSelectedTime(this Avalonia.Controls.TimePicker obj)
    {
        return obj.GetObservable(Avalonia.Controls.TimePicker.SelectedTimeProperty);
    }

    /// <summary>
    /// Sets a handler with an observable for an <see cref="Avalonia.Controls.TimePicker.SelectedTimeProperty"/>.
    /// </summary>
    /// <param name="obj">The target object.</param>
    /// <param name="handler">The handler with target object and observable with the current value of the property.</param>
    /// <typeparam name="T">The type of the target object.</typeparam>
    /// <returns>The target object reference.</returns>
    public static T OnSelectedTime<T>(this T obj, Action<Avalonia.Controls.TimePicker, IObservable<System.Nullable<System.TimeSpan>>> handler) where T : Avalonia.Controls.TimePicker
    {
        var observable = obj.GetObservable(Avalonia.Controls.TimePicker.SelectedTimeProperty);
        handler(obj, observable);
        return obj;
    }
}
