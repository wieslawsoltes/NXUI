using System.Diagnostics.CodeAnalysis;

// ReSharper disable once CheckNamespace
namespace Generator;

[SuppressMessage("ReSharper", "InconsistentNaming")]
internal static partial class Templates
{
    public static string PropertyMethodEnumTemplate = @"
    /// <summary>
    /// Sets a <see cref=""%ClassType%.%Name%Property""/> property value to <see cref=""%ValueType%.%EnumValue%""/>.
    /// </summary>
    /// <param name=""obj"">The target object.</param>
    /// <typeparam name=""T"">The type of the target object.</typeparam>
    /// <returns>The target object reference.</returns>
    public static T %Name%%EnumValue%<T>(this T obj) where T : %OwnerType%
    {
        obj[%ClassType%.%Name%Property] = %ValueType%.%EnumValue%;
        return obj;
    }";

    public static string PropertyMethodEnumSealedTemplate = @"
    /// <summary>
    /// Sets a <see cref=""%ClassType%.%Name%Property""/> property value to <see cref=""%ValueType%.%EnumValue%""/>.
    /// </summary>
    /// <param name=""obj"">The target object.</param>
    /// <returns>The target object reference.</returns>
    public static %OwnerType% %Name%%EnumValue%(this %OwnerType% obj)
    {
        obj[%ClassType%.%Name%Property] = %ValueType%.%EnumValue%;
        return obj;
    }";

    public static string PropertyMethodsTemplate = @"    // %ClassType%.%Name%Property

    /// <summary>
    /// Sets a <see cref=""%ClassType%.%Name%Property""/> value.
    /// </summary>
    /// <param name=""obj"">The target object.</param>
    /// <param name=""value"">The value.</param>
    /// <typeparam name=""T"">The type of the target object.</typeparam>
    /// <returns>The target object reference.</returns>
    public static T %Name%<T>(this T obj, %ValueType% value) where T : %OwnerType%
    {
        obj[%ClassType%.%Name%Property] = value;
        return obj;
    }

    /// <summary>
    /// Sets a binding to <see cref=""%ClassType%.%Name%Property""/> with binding source value.
    /// </summary>
    /// <param name=""obj"">The target object.</param>
    /// <param name=""binding"">The source binding.</param>
    /// <param name=""mode"">The target binding mode.</param>
    /// <param name=""priority"">The target binding priority.</param>
    /// <typeparam name=""T"">The type of the target object.</typeparam>
    /// <returns>The target object reference.</returns>
    public static T %Name%<T>(
        this T obj,
        Avalonia.Data.IBinding binding,
        Avalonia.Data.BindingMode mode = Avalonia.Data.BindingMode.TwoWay,
        Avalonia.Data.BindingPriority priority = Avalonia.Data.BindingPriority.LocalValue) where T : %OwnerType%
    {
        var descriptor = %ClassType%.%Name%Property.Bind().WithMode(mode).WithPriority(priority);
        obj[descriptor] = binding;
        return obj;
    }

    /// <summary>
    /// Sets a binding to <see cref=""%ClassType%.%Name%Property""/> with observable source value.
    /// </summary>
    /// <param name=""obj"">The target object.</param>
    /// <param name=""observable"">The source observable.</param>
    /// <param name=""mode"">The target binding mode.</param>
    /// <param name=""priority"">The target binding priority.</param>
    /// <typeparam name=""T"">The type of the target object.</typeparam>
    /// <returns>The target object reference.</returns>
    public static T %Name%<T>(
        this T obj,
        IObservable<%ValueType%> observable,
        Avalonia.Data.BindingMode mode = Avalonia.Data.BindingMode.TwoWay,
        Avalonia.Data.BindingPriority priority = Avalonia.Data.BindingPriority.LocalValue) where T : %OwnerType%
    {
        var descriptor = %ClassType%.%Name%Property.Bind().WithMode(mode).WithPriority(priority);
        obj[descriptor] = observable.ToBinding();
        return obj;
    }

    /// <summary>
    /// Makes a <see cref=""%ClassType%.%Name%Property""/> binding.
    /// </summary>
    /// <param name=""obj"">The target object.</param>
    /// <param name=""mode"">The target binding mode.</param>
    /// <param name=""priority"">The target binding priority.</param>
    /// <returns>A <see cref=""%ClassType%.%Name%Property""/> binding.</returns>
    public static Avalonia.Data.IBinding Bind%Name%(
        this %OwnerType% obj,
        Avalonia.Data.BindingMode mode = Avalonia.Data.BindingMode.TwoWay,
        Avalonia.Data.BindingPriority priority = Avalonia.Data.BindingPriority.LocalValue)
    {
        var descriptor = %ClassType%.%Name%Property.Bind().WithMode(mode).WithPriority(priority);
        return obj[descriptor];
    }

    /// <summary>
    /// Gets an observable for an <see cref=""%ClassType%.%Name%Property""/>.
    /// </summary>
    /// <param name=""obj"">The target object.</param>
    /// <returns>
    /// An observable which fires immediately with the current value of the property on the
    /// object and subsequently each time the property value changes.
    /// </returns>
    public static IObservable<%ValueType%> Observe%Name%(this %OwnerType% obj)
    {
        return obj.GetObservable(%ClassType%.%Name%Property);
    }

    /// <summary>
    /// Sets a handler with an observable for an <see cref=""%ClassType%.%Name%Property""/>.
    /// </summary>
    /// <param name=""obj"">The target object.</param>
    /// <param name=""handler"">The handler with target object and observable with the current value of the property.</param>
    /// <typeparam name=""T"">The type of the target object.</typeparam>
    /// <returns>The target object reference.</returns>
    public static T On%Name%<T>(this T obj, Action<%OwnerType%, IObservable<%ValueType%>> handler) where T : %OwnerType%
    {
        var observable = obj.GetObservable(%ClassType%.%Name%Property);
        handler(obj, observable);
        return obj;
    }";

    public static string PropertyMethodsTemplateSealed = @"    // %ClassType%.%Name%Property

    /// <summary>
    /// 
    /// </summary>
    /// <param name=""obj""></param>
    /// <param name=""value""></param>
    /// <returns></returns>
    public static %OwnerType% %Name%(this %OwnerType% obj, %ValueType% value)
    {
        obj[%ClassType%.%Name%Property] = value;
        return obj;
    }

    /// <summary>
    /// 
    /// </summary>
    /// <param name=""obj""></param>
    /// <param name=""binding""></param>
    /// <param name=""mode""></param>
    /// <param name=""priority""></param>
    /// <returns></returns>
    public static %OwnerType% %Name%(
        this %OwnerType% obj,
        Avalonia.Data.IBinding binding,
        Avalonia.Data.BindingMode mode = Avalonia.Data.BindingMode.TwoWay,
        Avalonia.Data.BindingPriority priority = Avalonia.Data.BindingPriority.LocalValue)
    {
        var descriptor = %ClassType%.%Name%Property.Bind().WithMode(mode).WithPriority(priority);
        obj[descriptor] = binding;
        return obj;
    }

    /// <summary>
    /// 
    /// </summary>
    /// <param name=""obj""></param>
    /// <param name=""observable""></param>
    /// <param name=""mode""></param>
    /// <param name=""priority""></param>
    /// <returns></returns>
    public static %OwnerType% %Name%(
        this %OwnerType% obj,
        IObservable<%ValueType%> observable,
        Avalonia.Data.BindingMode mode = Avalonia.Data.BindingMode.TwoWay,
        Avalonia.Data.BindingPriority priority = Avalonia.Data.BindingPriority.LocalValue)
    {
        var descriptor = %ClassType%.%Name%Property.Bind().WithMode(mode).WithPriority(priority);
        obj[descriptor] = observable.ToBinding();
        return obj;
    }

    /// <summary>
    /// 
    /// </summary>
    /// <param name=""obj""></param>
    /// <param name=""mode""></param>
    /// <param name=""priority""></param>
    /// <returns></returns>
    public static Avalonia.Data.IBinding Bind%Name%(
        this %OwnerType% obj,
        Avalonia.Data.BindingMode mode = Avalonia.Data.BindingMode.TwoWay,
        Avalonia.Data.BindingPriority priority = Avalonia.Data.BindingPriority.LocalValue)
    {
        var descriptor = %ClassType%.%Name%Property.Bind().WithMode(mode).WithPriority(priority);
        return obj[descriptor];
    }

    /// <summary>
    /// 
    /// </summary>
    /// <param name=""obj""></param>
    /// <returns></returns>
    public static IObservable<%ValueType%> Observe%Name%(this %OwnerType% obj)
    {
        return obj.GetObservable(%OwnerType%.%Name%Property);
    }

    /// <summary>
    /// 
    /// </summary>
    /// <param name=""obj""></param>
    /// <param name=""handler""></param>
    /// <returns></returns>
    public static %OwnerType% On%Name%(this %OwnerType% obj, Action<%OwnerType%, IObservable<%ValueType%>> handler)
    {
        var observable = obj.GetObservable(%ClassType%.%Name%Property);
        handler(obj, observable);
        return obj;
    }";

    public static string PropertyMethodsTemplateReadOnly = @"    // %ClassType%.%Name%Property

    /// <summary>
    /// Makes a <see cref=""%ClassType%.%Name%Property""/> binding.
    /// </summary>
    /// <param name=""obj"">The target object.</param>
    /// <param name=""mode"">The target binding mode.</param>
    /// <param name=""priority"">The target binding priority.</param>
    /// <returns>A <see cref=""%ClassType%.%Name%Property""/> binding.</returns>
    public static Avalonia.Data.IBinding Bind%Name%(
        this %OwnerType% obj,
        Avalonia.Data.BindingMode mode = Avalonia.Data.BindingMode.OneWay,
        Avalonia.Data.BindingPriority priority = Avalonia.Data.BindingPriority.LocalValue)
    {
        var descriptor = %ClassType%.%Name%Property.Bind().WithMode(mode).WithPriority(priority);
        return obj[descriptor];
    }

    /// <summary>
    /// Gets an observable for an <see cref=""%ClassType%.%Name%Property""/>.
    /// </summary>
    /// <param name=""obj"">The target object.</param>
    /// <returns>
    /// An observable which fires immediately with the current value of the property on the
    /// object and subsequently each time the property value changes.
    /// </returns>
    public static IObservable<%ValueType%> Observe%Name%(this %OwnerType% obj)
    {
        return obj.GetObservable(%ClassType%.%Name%Property);
    }

    /// <summary>
    /// Sets a handler with an observable for an <see cref=""%ClassType%.%Name%Property""/>.
    /// </summary>
    /// <param name=""obj"">The target object.</param>
    /// <param name=""handler"">The handler with target object and observable with the current value of the property.</param>
    /// <returns>The target object reference.</returns>
    public static %OwnerType% On%Name%(this %OwnerType% obj, Action<%OwnerType%, IObservable<%ValueType%>> handler)
    {
        var observable = obj.GetObservable(%ClassType%.%Name%Property);
        handler(obj, observable);
        return obj;
    }";

    public static string RoutedEventMethodsTemplate = @"    // %OwnerType%.%Name%Event

    /// <summary>
    /// 
    /// </summary>
    /// <param name=""obj""></param>
    /// <param name=""action""></param>
    /// <param name=""routes""></param>
    /// <typeparam name=""T""></typeparam>
    /// <returns></returns>
    public static T On%Name%Handler<T>(
        this T obj,
        Action<T, %ArgsType%> action,
        Avalonia.Interactivity.RoutingStrategies routes = %RoutingStrategies%) where T : %OwnerType%
    {
        obj.AddHandler(%OwnerType%.%Name%Event, (_, args) => action(obj, args), routes);
        return obj;
    }

    /// <summary>
    /// 
    /// </summary>
    /// <param name=""obj""></param>
    /// <param name=""handler""></param>
    /// <param name=""routes""></param>
    /// <typeparam name=""T""></typeparam>
    /// <returns></returns>
    public static T On%Name%<T>(
        this T obj, Action<T, IObservable<%ArgsType%>> handler,
        Avalonia.Interactivity.RoutingStrategies routes = %RoutingStrategies%) where T : %OwnerType%
    {
        var observable = obj.GetObservable(%OwnerType%.%Name%Event, routes);
        handler(obj, observable);
        return obj;
    }

    /// <summary>
    /// 
    /// </summary>
    /// <param name=""obj""></param>
    /// <param name=""routes""></param>
    /// <returns></returns>
    public static IObservable<%ArgsType%> ObserveOn%Name%(
        this %OwnerType% obj,
        Avalonia.Interactivity.RoutingStrategies routes = %RoutingStrategies%)
    {
        return obj.GetObservable(%OwnerType%.%Name%Event, routes);
    }";

    public static string RoutedEventMethodsTemplateSealed = @"    // %OwnerType%.%Name%Event

    public static %OwnerType% On%Name%Handler(
        this %OwnerType% obj, Action<%OwnerType%, %ArgsType%> action,
        Avalonia.Interactivity.RoutingStrategies routes = %RoutingStrategies%)
    {
        obj.AddHandler(%OwnerType%.%Name%Event, (_, args) => action(obj, args), routes);
        return obj;
    }

    public static %OwnerType% On%Name%(
        this %OwnerType% obj,
        Action<%OwnerType%, IObservable<%ArgsType%>> handler,
        Avalonia.Interactivity.RoutingStrategies routes = %RoutingStrategies%)
    {
        var observable = obj.GetObservable(%OwnerType%.%Name%Event, routes);
        handler(obj, observable);
        return obj;
    }

    public static IObservable<%ArgsType%> ObserveOn%Name%(
        this %OwnerType% obj,
        Avalonia.Interactivity.RoutingStrategies routes = %RoutingStrategies%)
    {
        return obj.GetObservable(%OwnerType%.%Name%Event, routes);
    }";

    public static string EventMethodsTemplate = @"    // %OwnerType%.%Name%

    /// <summary>
    /// 
    /// </summary>
    /// <param name=""obj""></param>
    /// <param name=""handler""></param>
    /// <typeparam name=""T""></typeparam>
    /// <returns></returns>
    public static T On%Name%Event<T>(this T obj, Action<T, IObservable<%ArgsType%>> handler) where T : %OwnerType%
    {
        var observable = Observable
            .FromEventPattern<%EventHandler%, %ArgsType%>(
                h => obj.%Name% += h, 
                h => obj.%Name% -= h)
            .Select(x => x.EventArgs);
        handler(obj, observable);
        return obj;
    }

    /// <summary>
    /// 
    /// </summary>
    /// <param name=""obj""></param>
    /// <returns></returns>
    public static IObservable<%ArgsType%> ObserveOn%Name%Event(this %OwnerType% obj)
    {
        return Observable
            .FromEventPattern<%EventHandler%, %ArgsType%>(
                h => obj.%Name% += h, 
                h => obj.%Name% -= h)
            .Select(x => x.EventArgs);
    }";

    public static string EventMethodsTemplateSealed = @"    // %OwnerType%.%Name%

    /// <summary>
    /// 
    /// </summary>
    /// <param name=""obj""></param>
    /// <param name=""handler""></param>
    /// <typeparam name=""T""></typeparam>
    /// <returns></returns>
    public static %OwnerType% On%Name%Event(this %OwnerType% obj, Action<%OwnerType%, IObservable<%ArgsType%>> handler)
    {
        var observable = Observable
            .FromEventPattern<E%EventHandler%, %ArgsType%>(
                h => obj.%Name% += h, 
                h => obj.%Name% -= h)
            .Select(x => x.EventArgs);
        handler(obj, observable);
        return obj;
    }

    /// <summary>
    /// 
    /// </summary>
    /// <param name=""obj""></param>
    /// <returns></returns>
    public static IObservable<%ArgsType%> ObserveOn%Name%Event(this %OwnerType% obj)
    {
        return Observable
            .FromEventPattern<%EventHandler%, %ArgsType%>(
                h => obj.%Name% += h, 
                h => obj.%Name% -= h)
            .Select(x => x.EventArgs);
    }";
}
