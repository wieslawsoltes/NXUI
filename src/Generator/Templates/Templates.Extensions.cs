using System.Diagnostics.CodeAnalysis;

// ReSharper disable once CheckNamespace
namespace Generator;

[SuppressMessage("ReSharper", "InconsistentNaming")]
public static partial class Templates
{
    public static string PropertyMethodsHotReloadTemplate = """
#if NXUI_HOTRELOAD

    /// <summary>
    /// Records a <see cref="%ClassType%.%Name%Property"/> literal value for hot reload builds.
    /// </summary>
    /// <param name="builder">The target builder.</param>
    /// <param name="value">The value.</param>
    /// <typeparam name="T">The owner type for the builder.</typeparam>
    /// <returns>The builder instance.</returns>
    public static %BuilderType% %MethodName%%BuilderGeneric%(this %BuilderType% builder, %ValueType% value)%BuilderConstraint%
    {
        return builder.WithValue(PropertyMetadata.%PropertyId%, %ClassType%.%Name%Property, value);
    }

    /// <summary>
    /// Records a binding to <see cref="%ClassType%.%Name%Property"/> for hot reload builds.
    /// </summary>
    /// <param name="builder">The target builder.</param>
    /// <param name="binding">The source binding.</param>
    /// <param name="mode">The target binding mode.</param>
    /// <param name="priority">The target binding priority.</param>
    /// <typeparam name="T">The owner type for the builder.</typeparam>
    /// <returns>The builder instance.</returns>
    public static %BuilderType% %MethodName%%BuilderGeneric%(
        this %BuilderType% builder,
        Avalonia.Data.IBinding binding,
        Avalonia.Data.BindingMode mode = Avalonia.Data.BindingMode.TwoWay,
        Avalonia.Data.BindingPriority priority = Avalonia.Data.BindingPriority.LocalValue)%BuilderConstraint%
    {
        return builder.WithBinding(PropertyMetadata.%PropertyId%, %ClassType%.%Name%Property, binding, mode, priority);
    }

    /// <summary>
    /// Records an observable binding to <see cref="%ClassType%.%Name%Property"/> for hot reload builds.
    /// </summary>
    /// <param name="builder">The target builder.</param>
    /// <param name="observable">The source observable.</param>
    /// <param name="mode">The target binding mode.</param>
    /// <param name="priority">The target binding priority.</param>
    /// <typeparam name="T">The owner type for the builder.</typeparam>
    /// <returns>The builder instance.</returns>
    public static %BuilderType% %MethodName%%BuilderGeneric%(
        this %BuilderType% builder,
        IObservable<%ValueType%> observable,
        Avalonia.Data.BindingMode mode = Avalonia.Data.BindingMode.TwoWay,
        Avalonia.Data.BindingPriority priority = Avalonia.Data.BindingPriority.LocalValue)%BuilderConstraint%
    {
        return builder.WithBinding(PropertyMetadata.%PropertyId%, %ClassType%.%Name%Property, observable.ToBinding(), mode, priority);
    }

#endif
""";

    public static string PropertyMethodEnumHotReloadTemplate = """
#if NXUI_HOTRELOAD

    /// <summary>
    /// Records a <see cref="%ClassType%.%Name%Property"/> enum value for hot reload builds.
    /// </summary>
    /// <param name="builder">The target builder.</param>
    /// <typeparam name="T">The owner type for the builder.</typeparam>
    /// <returns>The builder instance.</returns>
    public static %BuilderType% %Name%%EnumValue%%BuilderGeneric%(this %BuilderType% builder)%BuilderConstraint%
    {
        return builder.WithValue(PropertyMetadata.%PropertyId%, %ClassType%.%Name%Property, %ValueType%.%EnumValue%);
    }

#endif
""";

    public static string PropertyMethodEnumTemplate = """

    /// <summary>
    /// Sets a <see cref="%ClassType%.%Name%Property"/> property value to <see cref="%ValueType%.%EnumValue%"/>.
    /// </summary>
    /// <param name="obj">The target object.</param>
    /// <typeparam name="T">The type of the target object.</typeparam>
    /// <returns>The target object reference.</returns>
    public static T %Name%%EnumValue%<T>(this T obj) where T : %OwnerType%
    {
        obj[%ClassType%.%Name%Property] = %ValueType%.%EnumValue%;
        return obj;
    }
""";

    public static string PropertyMethodEnumSealedTemplate = """

    /// <summary>
    /// Sets a <see cref="%ClassType%.%Name%Property"/> property value to <see cref="%ValueType%.%EnumValue%"/>.
    /// </summary>
    /// <param name="obj">The target object.</param>
    /// <returns>The target object reference.</returns>
    public static %OwnerType% %Name%%EnumValue%(this %OwnerType% obj)
    {
        obj[%ClassType%.%Name%Property] = %ValueType%.%EnumValue%;
        return obj;
    }
""";

    public static string PropertyMethodsTemplate = """  
    // %ClassType%.%Name%Property

    /// <summary>
    /// Sets a <see cref="%ClassType%.%Name%Property"/> value.
    /// </summary>
    /// <param name="obj">The target object.</param>
    /// <param name="value">The value.</param>
    /// <typeparam name="T">The type of the target object.</typeparam>
    /// <returns>The target object reference.</returns>
    public static T %MethodName%<T>(this T obj, %ValueType% value) where T : %OwnerType%
    {
        obj[%ClassType%.%Name%Property] = value;
        return obj;
    }

    /// <summary>
    /// Sets a binding to <see cref="%ClassType%.%Name%Property"/> with binding source value.
    /// </summary>
    /// <param name="obj">The target object.</param>
    /// <param name="binding">The source binding.</param>
    /// <param name="mode">The target binding mode.</param>
    /// <param name="priority">The target binding priority.</param>
    /// <typeparam name="T">The type of the target object.</typeparam>
    /// <returns>The target object reference.</returns>
    public static T %MethodName%<T>(
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
    /// Sets a binding to <see cref="%ClassType%.%Name%Property"/> with observable source value.
    /// </summary>
    /// <param name="obj">The target object.</param>
    /// <param name="observable">The source observable.</param>
    /// <param name="mode">The target binding mode.</param>
    /// <param name="priority">The target binding priority.</param>
    /// <typeparam name="T">The type of the target object.</typeparam>
    /// <returns>The target object reference.</returns>
    public static T %MethodName%<T>(
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
    /// Makes a <see cref="%ClassType%.%Name%Property"/> binding.
    /// </summary>
    /// <param name="obj">The target object.</param>
    /// <param name="mode">The target binding mode.</param>
    /// <param name="priority">The target binding priority.</param>
    /// <returns>A <see cref="%ClassType%.%Name%Property"/> binding.</returns>
    public static Avalonia.Data.IBinding Bind%Name%(
        this %OwnerType% obj,
        Avalonia.Data.BindingMode mode = Avalonia.Data.BindingMode.TwoWay,
        Avalonia.Data.BindingPriority priority = Avalonia.Data.BindingPriority.LocalValue)
    {
        var descriptor = %ClassType%.%Name%Property.Bind().WithMode(mode).WithPriority(priority);
        return obj[descriptor];
    }

    /// <summary>
    /// Gets an observable for an <see cref="%ClassType%.%Name%Property"/>.
    /// </summary>
    /// <param name="obj">The target object.</param>
    /// <returns>
    /// An observable which fires immediately with the current value of the property on the
    /// object and subsequently each time the property value changes.
    /// </returns>
    public static IObservable<%ValueType%> Observe%Name%(this %OwnerType% obj)
    {
        return obj.GetObservable(%ClassType%.%Name%Property);
    }

    /// <summary>
    /// Sets a handler with an observable for an <see cref="%ClassType%.%Name%Property"/>.
    /// </summary>
    /// <param name="obj">The target object.</param>
    /// <param name="handler">The handler with target object and observable with the current value of the property.</param>
    /// <typeparam name="T">The type of the target object.</typeparam>
    /// <returns>The target object reference.</returns>
    public static T On%Name%<T>(this T obj, Action<%OwnerType%, IObservable<%ValueType%>> handler) where T : %OwnerType%
    {
        var observable = obj.GetObservable(%ClassType%.%Name%Property);
        handler(obj, observable);
        return obj;
    }

    /// <summary>
    /// Gets a binding observable for <see cref="%ClassType%.%Name%Property"/>.
    /// </summary>
    /// <param name="obj">The target object.</param>
    /// <returns>An observable including binding errors.</returns>
    public static IObservable<BindingValue<%ValueType%>> ObserveBinding%Name%(this %OwnerType% obj)
    {
        return obj.GetBindingObservable(%ClassType%.%Name%Property);
    }

    /// <summary>
    /// Sets a handler with a binding observable for <see cref="%ClassType%.%Name%Property"/>.
    /// </summary>
    /// <param name="obj">The target object.</param>
    /// <param name="handler">The handler with target object and binding observable.</param>
    /// <typeparam name="T">The type of the target object.</typeparam>
    /// <returns>The target object reference.</returns>
    public static T OnBinding%Name%<T>(this T obj, Action<%OwnerType%, IObservable<BindingValue<%ValueType%>>> handler) where T : %OwnerType%
    {
        var observable = obj.GetBindingObservable(%ClassType%.%Name%Property);
        handler(obj, observable);
        return obj;
    }

    /// <summary>
    /// Gets a property change observable for <see cref="%ClassType%.%Name%Property"/>.
    /// </summary>
    /// <param name="obj">The target object.</param>
    /// <returns>An observable with property change details.</returns>
    public static IObservable<AvaloniaPropertyChangedEventArgs> Observe%Name%Changed(this %OwnerType% obj)
    {
        return obj.GetPropertyChangedObservable(%ClassType%.%Name%Property);
    }

    /// <summary>
    /// Sets a handler with property change observable for <see cref="%ClassType%.%Name%Property"/>.
    /// </summary>
    /// <param name="obj">The target object.</param>
    /// <param name="handler">The handler with target object and property change observable.</param>
    /// <typeparam name="T">The type of the target object.</typeparam>
    /// <returns>The target object reference.</returns>
    public static T On%Name%Changed<T>(this T obj, Action<%OwnerType%, IObservable<AvaloniaPropertyChangedEventArgs>> handler) where T : %OwnerType%
    {
        var observable = obj.GetPropertyChangedObservable(%ClassType%.%Name%Property);
        handler(obj, observable);
        return obj;
    }
""";

    public static string PropertyMethodsTemplateSealed = """
    // %ClassType%.%Name%Property

    /// <summary>
    /// Sets a <see cref="%ClassType%.%Name%Property"/> value on an object of type <see cref="%OwnerType%"/>.
    /// </summary>
    /// <param name="obj">The target object.</param>
    /// <param name="value">The value to set for the property.</param>
    /// <returns>The target object reference.</returns>
    public static %OwnerType% %MethodName%(this %OwnerType% obj, %ValueType% value)
    {
        obj[%ClassType%.%Name%Property] = value;
        return obj;
    }

    /// <summary>
    /// Sets a binding to <see cref="%ClassType%.%Name%Property"/> on an object of type <see cref="%OwnerType%"/> with a source binding specified as a parameter.
    /// </summary>
    /// <param name="obj">The target object.</param>
    /// <param name="binding">The source binding.</param>
    /// <param name="mode">The target binding mode.</param>
    /// <param name="priority">The target binding priority.</param>
    /// <returns>The target object reference.</returns>
    public static %OwnerType% %MethodName%(
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
    /// Sets a binding to <see cref="%ClassType%.%Name%Property"/> on an object of type <see cref="%OwnerType%"/> with a source binding specified as an observable.
    /// </summary>
    /// <param name="obj">The target object.</param>
    /// <param name="observable">The source observable.</param>
    /// <param name="mode">The target binding mode.</param>
    /// <param name="priority">The target binding priority.</param>
    /// <returns>The target object reference.</returns>
    public static %OwnerType% %MethodName%(
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
    /// Makes a <see cref="%ClassType%.%Name%Property"/> binding on an object of type <see cref="%OwnerType%"/>.
    /// </summary>
    /// <param name="obj">The target object.</param>
    /// <param name="mode">The target binding mode.</param>
    /// <param name="priority">The target binding priority.</param>
    /// <returns>A <see cref="%ClassType%.%Name%Property"/> binding.</returns>
    public static Avalonia.Data.IBinding Bind%Name%(
        this %OwnerType% obj,
        Avalonia.Data.BindingMode mode = Avalonia.Data.BindingMode.TwoWay,
        Avalonia.Data.BindingPriority priority = Avalonia.Data.BindingPriority.LocalValue)
    {
        var descriptor = %ClassType%.%Name%Property.Bind().WithMode(mode).WithPriority(priority);
        return obj[descriptor];
    }

    /// <summary>
    /// Gets an observable for an <see cref="%ClassType%.%Name%Property"/> on an object of type <see cref="%OwnerType%"/>.
    /// </summary>
    /// <param name="obj">The target object.</param>
    /// <returns>
    /// An observable which fires immediately with the current value of the property on the object, and thereafter whenever the property changes.
    /// </returns>
    public static IObservable<%ValueType%> Observe%Name%(this %OwnerType% obj)
    {
        return obj.GetObservable(%OwnerType%.%Name%Property);
    }

    /// <summary>
    /// Registers a handler for the <see cref="%ClassType%.%Name%Property"/> property on an object of type <see cref="%OwnerType%"/>.
    /// </summary>
    /// <param name="obj">The target object.</param>
    /// <param name="handler">The handler to be called when the property changes.</param>
    /// <returns>The target object.</returns>
    public static %OwnerType% On%Name%(this %OwnerType% obj, Action<%OwnerType%, IObservable<%ValueType%>> handler)
    {
        var observable = obj.GetObservable(%ClassType%.%Name%Property);
        handler(obj, observable);
        return obj;
    }

    /// <summary>
    /// Gets a binding observable for <see cref="%ClassType%.%Name%Property"/>.
    /// </summary>
    /// <param name="obj">The target object.</param>
    /// <returns>An observable including binding errors.</returns>
    public static IObservable<BindingValue<%ValueType%>> ObserveBinding%Name%(this %OwnerType% obj)
    {
        return obj.GetBindingObservable(%ClassType%.%Name%Property);
    }

    /// <summary>
    /// Sets a handler with a binding observable for <see cref="%ClassType%.%Name%Property"/>.
    /// </summary>
    /// <param name="obj">The target object.</param>
    /// <param name="handler">The handler with target object and binding observable.</param>
    /// <returns>The target object.</returns>
    public static %OwnerType% OnBinding%Name%(this %OwnerType% obj, Action<%OwnerType%, IObservable<BindingValue<%ValueType%>>> handler)
    {
        var observable = obj.GetBindingObservable(%ClassType%.%Name%Property);
        handler(obj, observable);
        return obj;
    }

    /// <summary>
    /// Gets a property change observable for <see cref="%ClassType%.%Name%Property"/>.
    /// </summary>
    /// <param name="obj">The target object.</param>
    /// <returns>An observable with property change details.</returns>
    public static IObservable<AvaloniaPropertyChangedEventArgs> Observe%Name%Changed(this %OwnerType% obj)
    {
        return obj.GetPropertyChangedObservable(%ClassType%.%Name%Property);
    }

    /// <summary>
    /// Sets a handler with property change observable for <see cref="%ClassType%.%Name%Property"/>.
    /// </summary>
    /// <param name="obj">The target object.</param>
    /// <param name="handler">The handler with target object and property change observable.</param>
    /// <returns>The target object.</returns>
    public static %OwnerType% On%Name%Changed(this %OwnerType% obj, Action<%OwnerType%, IObservable<AvaloniaPropertyChangedEventArgs>> handler)
    {
        var observable = obj.GetPropertyChangedObservable(%ClassType%.%Name%Property);
        handler(obj, observable);
        return obj;
    }
""";

    public static string PropertyMethodsTemplateReadOnly = """
    // %ClassType%.%Name%Property

    /// <summary>
    /// Makes a <see cref="%ClassType%.%Name%Property"/> binding.
    /// </summary>
    /// <param name="obj">The target object.</param>
    /// <param name="mode">The target binding mode.</param>
    /// <param name="priority">The target binding priority.</param>
    /// <returns>A <see cref="%ClassType%.%Name%Property"/> binding.</returns>
    public static Avalonia.Data.IBinding Bind%Name%(
        this %OwnerType% obj,
        Avalonia.Data.BindingMode mode = Avalonia.Data.BindingMode.OneWay,
        Avalonia.Data.BindingPriority priority = Avalonia.Data.BindingPriority.LocalValue)
    {
        var descriptor = %ClassType%.%Name%Property.Bind().WithMode(mode).WithPriority(priority);
        return obj[descriptor];
    }

    /// <summary>
    /// Gets an observable for an <see cref="%ClassType%.%Name%Property"/>.
    /// </summary>
    /// <param name="obj">The target object.</param>
    /// <returns>
    /// An observable which fires immediately with the current value of the property on the
    /// object and subsequently each time the property value changes.
    /// </returns>
    public static IObservable<%ValueType%> Observe%Name%(this %OwnerType% obj)
    {
        return obj.GetObservable(%ClassType%.%Name%Property);
    }

    /// <summary>
    /// Sets a handler with an observable for an <see cref="%ClassType%.%Name%Property"/>.
    /// </summary>
    /// <param name="obj">The target object.</param>
    /// <param name="handler">The handler with target object and observable with the current value of the property.</param>
    /// <returns>The target object reference.</returns>
    public static %OwnerType% On%Name%(this %OwnerType% obj, Action<%OwnerType%, IObservable<%ValueType%>> handler)
    {
        var observable = obj.GetObservable(%ClassType%.%Name%Property);
        handler(obj, observable);
        return obj;
    }

    /// <summary>
    /// Gets a binding observable for <see cref="%ClassType%.%Name%Property"/>.
    /// </summary>
    /// <param name="obj">The target object.</param>
    /// <returns>An observable including binding errors.</returns>
    public static IObservable<BindingValue<%ValueType%>> ObserveBinding%Name%(this %OwnerType% obj)
    {
        return obj.GetBindingObservable(%ClassType%.%Name%Property);
    }

    /// <summary>
    /// Sets a handler with a binding observable for <see cref="%ClassType%.%Name%Property"/>.
    /// </summary>
    /// <param name="obj">The target object.</param>
    /// <param name="handler">The handler with target object and binding observable.</param>
    /// <returns>The target object reference.</returns>
    public static %OwnerType% OnBinding%Name%(this %OwnerType% obj, Action<%OwnerType%, IObservable<BindingValue<%ValueType%>>> handler)
    {
        var observable = obj.GetBindingObservable(%ClassType%.%Name%Property);
        handler(obj, observable);
        return obj;
    }

    /// <summary>
    /// Gets a property change observable for <see cref="%ClassType%.%Name%Property"/>.
    /// </summary>
    /// <param name="obj">The target object.</param>
    /// <returns>An observable with property change details.</returns>
    public static IObservable<AvaloniaPropertyChangedEventArgs> Observe%Name%Changed(this %OwnerType% obj)
    {
        return obj.GetPropertyChangedObservable(%ClassType%.%Name%Property);
    }

    /// <summary>
    /// Sets a handler with property change observable for <see cref="%ClassType%.%Name%Property"/>.
    /// </summary>
    /// <param name="obj">The target object.</param>
    /// <param name="handler">The handler with target object and property change observable.</param>
    /// <returns>The target object reference.</returns>
    public static %OwnerType% On%Name%Changed(this %OwnerType% obj, Action<%OwnerType%, IObservable<AvaloniaPropertyChangedEventArgs>> handler)
    {
        var observable = obj.GetPropertyChangedObservable(%ClassType%.%Name%Property);
        handler(obj, observable);
        return obj;
    }
""";

    public static string RoutedEventMethodsHotReloadTemplate = """
#if NXUI_HOTRELOAD

    /// <summary>
    /// Records a routed event handler for hot reload builds.
    /// </summary>
    /// <param name="builder">The target builder.</param>
    /// <param name="action">The action to run when the event fires.</param>
    /// <param name="routes">The routing strategies for the event.</param>
    /// <typeparam name="T">The owner type for the builder.</typeparam>
    /// <returns>The builder instance.</returns>
    public static %BuilderType% On%Name%Handler%BuilderGeneric%(
        this %BuilderType% builder,
        Action<%HandlerType%, %ArgsType%> action,
        Avalonia.Interactivity.RoutingStrategies routes = %RoutingStrategies%)%BuilderConstraint%
    {
        return builder.WithEvent(new EventMutation(target =>
        {
            var typed = (%OwnerType%)target;
            typed.AddHandler(%OwnerType%.%Name%Event, (_, args) => action(%HandlerInvocation%, args), routes);
        }));
    }

    /// <summary>
    /// Records a routed event observable handler for hot reload builds.
    /// </summary>
    /// <param name="builder">The target builder.</param>
    /// <param name="handler">The handler receiving the observable.</param>
    /// <param name="routes">The routing strategies for the event.</param>
    /// <typeparam name="T">The owner type for the builder.</typeparam>
    /// <returns>The builder instance.</returns>
    public static %BuilderType% On%Name%%BuilderGeneric%(
        this %BuilderType% builder,
        Action<%HandlerType%, IObservable<%ArgsType%>> handler,
        Avalonia.Interactivity.RoutingStrategies routes = %RoutingStrategies%)%BuilderConstraint%
    {
        return builder.WithEvent(new EventMutation(target =>
        {
            var typed = (%OwnerType%)target;
            var observable = typed.GetObservable(%OwnerType%.%Name%Event, routes);
            handler(%HandlerInvocation%, observable);
        }));
    }

#endif
""";

    public static string RoutedEventMethodsTemplate = """
    // %OwnerType%.%Name%Event

    /// <summary>
    /// Registers a handler for the <see cref="%ClassType%.%Name%Event"/> event on an object of type <see cref="%OwnerType%"/>.
    /// </summary>
    /// <param name="obj">The target object.</param>
    /// <param name="action">The action to be performed when the event is raised.</param>
    /// <param name="routes">The routing strategies for the event.</param>
    /// <typeparam name="T">The type of the target object.</typeparam>
    /// <returns>The target object.</returns>
    public static T On%Name%Handler<T>(
        this T obj,
        Action<T, %ArgsType%> action,
        Avalonia.Interactivity.RoutingStrategies routes = %RoutingStrategies%) where T : %OwnerType%
    {
        obj.AddHandler(%OwnerType%.%Name%Event, (_, args) => action(obj, args), routes);
        return obj;
    }

    /// <summary>
    /// Registers a handler for the <see cref="%ClassType%.%Name%Event"/> event on an object of type <see cref="%OwnerType%"/> and returns an observable for the event.
    /// </summary>
    /// <param name="obj">The target object.</param>
    /// <param name="handler">The handler to be called when the event is raised.</param>
    /// <param name="routes">The routing strategies for the event.</param>
    /// <typeparam name="T">The type of the target object.</typeparam>
    /// <returns>The target object.</returns>
    public static T On%Name%<T>(
        this T obj, Action<T, IObservable<%ArgsType%>> handler,
        Avalonia.Interactivity.RoutingStrategies routes = %RoutingStrategies%) where T : %OwnerType%
    {
        var observable = obj.GetObservable(%OwnerType%.%Name%Event, routes);
        handler(obj, observable);
        return obj;
    }

    /// <summary>
    /// Gets an observable for the <see cref="%ClassType%.%Name%Event"/> event on an object of type <see cref="%OwnerType%"/>.
    /// </summary>
    /// <param name="obj">The target object.</param>
    /// <param name="routes">The routing strategies for the event.</param>
    /// <returns>An observable for the event.</returns>
    public static IObservable<%ArgsType%> ObserveOn%Name%(
        this %OwnerType% obj,
        Avalonia.Interactivity.RoutingStrategies routes = %RoutingStrategies%)
    {
        return obj.GetObservable(%OwnerType%.%Name%Event, routes);
    }
""";

    public static string RoutedEventMethodsHotReloadTemplateNonGeneric = """
#if NXUI_HOTRELOAD

    /// <summary>
    /// Records a routed event handler for hot reload builds.
    /// </summary>
    /// <param name="builder">The target builder.</param>
    /// <param name="action">The action executed when the event fires.</param>
    /// <param name="routes">The routing strategies for the event.</param>
    /// <typeparam name="T">The owner type for the builder.</typeparam>
    /// <returns>The builder instance.</returns>
    public static %BuilderType% On%Name%Handler%BuilderGeneric%(
        this %BuilderType% builder,
        Action<%HandlerType%, %ArgsType%> action,
        Avalonia.Interactivity.RoutingStrategies routes = %RoutingStrategies%)%BuilderConstraint%
    {
        return builder.WithEvent(new EventMutation(target =>
        {
            var typed = (%OwnerType%)target;
            typed.AddHandler(%OwnerType%.%Name%Event, (object _, %ArgsType% args) => action(%HandlerInvocation%, args), routes);
        }));
    }

    /// <summary>
    /// Records a routed event observable handler for hot reload builds.
    /// </summary>
    /// <param name="builder">The target builder.</param>
    /// <param name="handler">The handler receiving the observable.</param>
    /// <param name="routes">The routing strategies for the event.</param>
    /// <typeparam name="T">The owner type for the builder.</typeparam>
    /// <returns>The builder instance.</returns>
    public static %BuilderType% On%Name%%BuilderGeneric%(
        this %BuilderType% builder,
        Action<%HandlerType%, IObservable<%ArgsType%>> handler,
        Avalonia.Interactivity.RoutingStrategies routes = %RoutingStrategies%)%BuilderConstraint%
    {
        return builder.WithEvent(new EventMutation(target =>
        {
            var typed = (%OwnerType%)target;
            var observable = typed.GetObservable<%ArgsType%>(%OwnerType%.%Name%Event, routes);
            handler(%HandlerInvocation%, observable);
        }));
    }

#endif
""";

    public static string RoutedEventMethodsTemplateNonGeneric = """
    // %OwnerType%.%Name%Event

    /// <summary>
    /// Registers a handler for the <see cref="%ClassType%.%Name%Event"/> event on an object of type <see cref="%OwnerType%"/>.
    /// </summary>
    /// <param name="obj">The target object.</param>
    /// <param name="action">The action to be performed when the event is raised.</param>
    /// <param name="routes">The routing strategies for the event.</param>
    /// <typeparam name="T">The type of the target object.</typeparam>
    /// <returns>The target object.</returns>
    public static T On%Name%Handler<T>(
        this T obj,
        Action<T, %ArgsType%> action,
        Avalonia.Interactivity.RoutingStrategies routes = %RoutingStrategies%) where T : %OwnerType%
    {
        obj.AddHandler(%OwnerType%.%Name%Event, (object _, %ArgsType% args) => action(obj, args), routes);
        return obj;
    }

    /// <summary>
    /// Registers a handler for the <see cref="%ClassType%.%Name%Event"/> event on an object of type <see cref="%OwnerType%"/> and returns an observable for the event.
    /// </summary>
    /// <param name="obj">The target object.</param>
    /// <param name="handler">The handler to be called when the event is raised.</param>
    /// <param name="routes">The routing strategies for the event.</param>
    /// <typeparam name="T">The type of the target object.</typeparam>
    /// <returns>The target object.</returns>
    public static T On%Name%<T>(
        this T obj, Action<T, IObservable<%ArgsType%>> handler,
        Avalonia.Interactivity.RoutingStrategies routes = %RoutingStrategies%) where T : %OwnerType%
    {
        var observable = obj.GetObservable<%ArgsType%>(%OwnerType%.%Name%Event, routes);
        handler(obj, observable);
        return obj;
    }

    /// <summary>
    /// Gets an observable for the <see cref="%ClassType%.%Name%Event"/> event on an object of type <see cref="%OwnerType%"/>.
    /// </summary>
    /// <param name="obj">The target object.</param>
    /// <param name="routes">The routing strategies for the event.</param>
    /// <returns>An observable for the event.</returns>
    public static IObservable<%ArgsType%> ObserveOn%Name%(
        this %OwnerType% obj,
        Avalonia.Interactivity.RoutingStrategies routes = %RoutingStrategies%)
    {
        return obj.GetObservable<%ArgsType%>(%OwnerType%.%Name%Event, routes);
    }
""";

    public static string RoutedEventMethodsTemplateSealed = """
    // %OwnerType%.%Name%Event

    /// <summary>
    /// Registers a handler for the <see cref="%ClassType%.%Name%Event"/> event on an object of type <see cref="%OwnerType%"/>.
    /// </summary>
    /// <param name="obj">The target object.</param>
    /// <param name="handler">The handler to be called when the event is raised.</param>
    /// <param name="routes">The routing strategies for the event.</param>
    /// <returns>The target object.</returns>
    public static %OwnerType% On%Name%Handler(
        this %OwnerType% obj, Action<%OwnerType%, %ArgsType%> action,
        Avalonia.Interactivity.RoutingStrategies routes = %RoutingStrategies%)
    {
        obj.AddHandler(%OwnerType%.%Name%Event, (_, args) => action(obj, args), routes);
        return obj;
    }

    /// <summary>
    /// Registers a handler for the <see cref="%ClassType%.%Name%Event"/> event on an object of type <see cref="%OwnerType%"/> and returns an observable for the event.
    /// </summary>
    /// <param name="obj">The target object.</param>
    /// <param name="handler">The handler to be called when the event is raised.</param>
    /// <param name="routes">The routing strategies for the event.</param>
    /// <returns>The target object.</returns>
    public static %OwnerType% On%Name%(
        this %OwnerType% obj,
        Action<%OwnerType%, IObservable<%ArgsType%>> handler,
        Avalonia.Interactivity.RoutingStrategies routes = %RoutingStrategies%)
    {
        var observable = obj.GetObservable(%OwnerType%.%Name%Event, routes);
        handler(obj, observable);
        return obj;
    }

    /// <summary>
    /// Gets an observable for the <see cref="%ClassType%.%Name%Event"/> event on an object of type <see cref="%OwnerType%"/>.
    /// </summary>
    /// <param name="obj">The target object.</param>
    /// <returns>An observable for the event.</returns>
    public static IObservable<%ArgsType%> ObserveOn%Name%(
        this %OwnerType% obj,
        Avalonia.Interactivity.RoutingStrategies routes = %RoutingStrategies%)
    {
        return obj.GetObservable(%OwnerType%.%Name%Event, routes);
    }
""";

    public static string RoutedEventMethodsTemplateSealedNonGeneric = """
    // %OwnerType%.%Name%Event

    /// <summary>
    /// Registers a handler for the <see cref="%ClassType%.%Name%Event"/> event on an object of type <see cref="%OwnerType%"/>.
    /// </summary>
    /// <param name="obj">The target object.</param>
    /// <param name="handler">The handler to be called when the event is raised.</param>
    /// <param name="routes">The routing strategies for the event.</param>
    /// <returns>The target object.</returns>
    public static %OwnerType% On%Name%Handler(
        this %OwnerType% obj, Action<%OwnerType%, %ArgsType%> action,
        Avalonia.Interactivity.RoutingStrategies routes = %RoutingStrategies%)
    {
        obj.AddHandler(%OwnerType%.%Name%Event, (object _, %ArgsType% args) => action(obj, args), routes);
        return obj;
    }

    /// <summary>
    /// Registers a handler for the <see cref="%ClassType%.%Name%Event"/> event on an object of type <see cref="%OwnerType%"/> and returns an observable for the event.
    /// </summary>
    /// <param name="obj">The target object.</param>
    /// <param name="handler">The handler to be called when the event is raised.</param>
    /// <param name="routes">The routing strategies for the event.</param>
    /// <returns>The target object.</returns>
    public static %OwnerType% On%Name%(
        this %OwnerType% obj,
        Action<%OwnerType%, IObservable<%ArgsType%>> handler,
        Avalonia.Interactivity.RoutingStrategies routes = %RoutingStrategies%)
    {
        var observable = obj.GetObservable<%ArgsType%>(%OwnerType%.%Name%Event, routes);
        handler(obj, observable);
        return obj;
    }

    /// <summary>
    /// Gets an observable for the <see cref="%ClassType%.%Name%Event"/> event on an object of type <see cref="%OwnerType%"/>.
    /// </summary>
    /// <param name="obj">The target object.</param>
    /// <returns>An observable for the event.</returns>
    public static IObservable<%ArgsType%> ObserveOn%Name%(
        this %OwnerType% obj,
        Avalonia.Interactivity.RoutingStrategies routes = %RoutingStrategies%)
    {
        return obj.GetObservable<%ArgsType%>(%OwnerType%.%Name%Event, routes);
    }
""";

    public static string EventMethodsHotReloadTemplate = """
#if NXUI_HOTRELOAD

    /// <summary>
    /// Records a CLR event handler for hot reload builds.
    /// </summary>
    /// <param name="builder">The target builder.</param>
    /// <param name="handler">The handler receiving an observable.</param>
    /// <typeparam name="T">The owner type for the builder.</typeparam>
    /// <returns>The builder instance.</returns>
    public static %BuilderType% On%Name%Event%BuilderGeneric%(this %BuilderType% builder, Action<%HandlerType%, IObservable<%ArgsType%>> handler)%BuilderConstraint%
    {
        return builder.WithEvent(new EventMutation(target =>
        {
            var typed = (%OwnerType%)target;
            var observable = Observable
                .FromEventPattern<%EventHandler%, %ArgsType%>(
                    h => typed.%Name% += h,
                    h => typed.%Name% -= h)
                .Select(x => x.EventArgs);
            handler(%HandlerInvocation%, observable);
        }));
    }

#endif
""";

    public static string EventMethodsTemplate = """
    // %OwnerType%.%Name%

    /// <summary>
    /// Adds a handler to the `%Name%` event on the specified object.
    /// </summary>
    /// <param name="obj">The target object.</param>
    /// <param name="handler">The handler to be called when the event is raised.</param>
    /// <typeparam name="T">The type of the target object.</typeparam>
    /// <returns>The target object reference.</returns>
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
    /// Returns an observable for the `%Name%` event on the specified object.
    /// </summary>
    /// <param name="obj">The target object.</param>
    /// <returns>An observable for the `%Name%` event on the specified object.</returns>
    public static IObservable<%ArgsType%> ObserveOn%Name%Event(this %OwnerType% obj)
    {
        return Observable
            .FromEventPattern<%EventHandler%, %ArgsType%>(
                h => obj.%Name% += h, 
                h => obj.%Name% -= h)
            .Select(x => x.EventArgs);
    }
""";

    public static string EventMethodsTemplateSealed = """
    // %OwnerType%.%Name%

    /// <summary>
    /// Attaches an action to be executed when the %Name% event is raised on the given object.
    /// </summary>
    /// <param name="obj">The object on which the event is being registered.</param>
    /// <param name="handler">The action to be executed when the event is raised.</param>
    /// <typeparam name="T">The type of the object on which the event is being registered.</typeparam>
    /// <returns>The object on which the event is being registered, for method chaining.</returns>
    public static %OwnerType% On%Name%Event(this %OwnerType% obj, Action<%OwnerType%, IObservable<%ArgsType%>> handler)
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
    /// Returns an observable that produces the events raised by the %Name% event on the given object.
    /// </summary>
    /// <param name="obj">The object for which the events are being observed.</param>
    /// <returns>An observable that produces the events raised by the %Name% event on the given object.</returns>
    public static IObservable<%ArgsType%> ObserveOn%Name%Event(this %OwnerType% obj)
    {
        return Observable
            .FromEventPattern<%EventHandler%, %ArgsType%>(
                h => obj.%Name% += h, 
                h => obj.%Name% -= h)
            .Select(x => x.EventArgs);
    }
""";
}
