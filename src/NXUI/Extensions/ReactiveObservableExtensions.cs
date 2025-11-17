using System;
using System.Linq.Expressions;
using System.Reactive.Disposables;
using System.Reactive.Linq;
using Avalonia;
using Avalonia.Animation;
using Avalonia.Animation.Animators;
using Avalonia.Controls;
using Avalonia.Controls.Templates;
using Avalonia.Threading;
using System.Reflection;
#if NXUI_HOTRELOAD
using NXUI.HotReload.Nodes;
#endif

namespace NXUI.Extensions;

/// <summary>
/// Provides helper extensions for working with reactive pipelines on the Avalonia UI thread.
/// </summary>
public static class ReactiveObservableExtensions
{
    /// <summary>
    /// Ensures that observer callbacks are invoked on the Avalonia UI thread.
    /// </summary>
    /// <typeparam name="T">The value type emitted by the observable.</typeparam>
    /// <param name="source">The source observable.</param>
    /// <returns>An observable that marshals notifications to the UI thread.</returns>
    public static IObservable<T> ObserveOnUiThread<T>(this IObservable<T> source)
    {
        return Observable.Create<T>(observer =>
            source.Subscribe(
                x => Avalonia.Threading.Dispatcher.UIThread.Post(() => observer.OnNext(x)),
                ex => Avalonia.Threading.Dispatcher.UIThread.Post(() => observer.OnError(ex)),
                () => Avalonia.Threading.Dispatcher.UIThread.Post(observer.OnCompleted)));
    }

    /// <summary>
    /// Subscribes to the observable and forwards values on the UI thread.
    /// </summary>
    /// <typeparam name="T">The value type emitted by the observable.</typeparam>
    /// <param name="source">The source observable.</param>
    /// <param name="onNext">The handler invoked for each element.</param>
    /// <returns>A disposable subscription.</returns>
    public static IDisposable SubscribeOnUiThread<T>(this IObservable<T> source, Action<T> onNext)
    {
        return source.ObserveOnUiThread().Subscribe(onNext);
    }

    /// <summary>
    /// Completes the observable when the specified visual is detached from the visual tree.
    /// </summary>
    /// <typeparam name="T">The value type emitted by the observable.</typeparam>
    /// <param name="source">The source observable.</param>
    /// <param name="visual">The visual whose lifecycle controls the subscription.</param>
    /// <returns>An observable that terminates on visual detachment.</returns>
    public static IObservable<T> TakeUntilDetachedFromVisualTree<T>(this IObservable<T> source, Visual visual)
    {
        return source.TakeUntil(visual.OnDetachedFromVisualTree());
    }

    /// <summary>
    /// Subscribes to the observable and disposes the subscription when the visual detaches.
    /// </summary>
    /// <typeparam name="T">The value type emitted by the observable.</typeparam>
    /// <param name="source">The source observable.</param>
    /// <param name="visual">The visual whose lifecycle governs the subscription.</param>
    /// <param name="onNext">The handler invoked for each element.</param>
    /// <returns>A disposable subscription.</returns>
    public static IDisposable SubscribeUntilDetached<T>(this IObservable<T> source, Visual visual, Action<T> onNext)
    {
        return source
            .TakeUntilDetachedFromVisualTree(visual)
            .Subscribe(onNext);
    }

    /// <summary>
    /// Adds the disposable to the provided <see cref="CompositeDisposable"/>.
    /// </summary>
    /// <param name="disposable">The disposable to track.</param>
    /// <param name="composite">The target composite.</param>
    /// <returns>The original disposable for fluent usage.</returns>
    public static IDisposable DisposeWith(this IDisposable disposable, CompositeDisposable composite)
    {
        composite.Add(disposable);
        return disposable;
    }

    /// <summary>
    /// Creates a data template from a synchronous control factory.
    /// </summary>
    /// <typeparam name="T">The data context type.</typeparam>
    /// <param name="build">The control factory.</param>
    /// <param name="supportsRecycling">Whether the template supports recycling.</param>
    /// <returns>A configured <see cref="FuncDataTemplate{T}"/>.</returns>
    public static FuncDataTemplate<T> DataTemplate<T>(Func<T, Control?> build, bool supportsRecycling = false) where T : class
    {
        return new FuncDataTemplate<T>((item, _) => build(item), supportsRecycling);
    }

#if NXUI_HOTRELOAD
    /// <summary>
    /// Creates a hot-reload friendly data template from an element builder.
    /// </summary>
    /// <typeparam name="T">The data context type.</typeparam>
    /// <typeparam name="TControl">The control type produced by the builder.</typeparam>
    /// <param name="build">The element builder factory.</param>
    /// <param name="supportsRecycling">Whether the template supports recycling.</param>
    /// <returns>A configured <see cref="FuncDataTemplate{T}"/>.</returns>
    public static FuncDataTemplate<T> DataTemplate<T, TControl>(Func<T, ElementBuilder<TControl>> build, bool supportsRecycling = false)
        where T : class
        where TControl : Control
    {
        ArgumentNullException.ThrowIfNull(build);
        return new FuncDataTemplate<T>((item, _) => build(item).Mount(), supportsRecycling);
    }
#endif

    /// <summary>
    /// Observes changes to the specified property.
    /// </summary>
    /// <typeparam name="T">The target object type.</typeparam>
    /// <typeparam name="TResult">The property value type.</typeparam>
    /// <param name="source">The source object.</param>
    /// <param name="selector">The property selector expression.</param>
    /// <returns>An observable that produces the property values.</returns>
    public static IObservable<TResult> WhenAnyValue<T, TResult>(this T source,
        Expression<Func<T, TResult>> selector) where T : AvaloniaObject
    {
        var field = typeof(T).GetField(selector.GetMemberName() + "Property", BindingFlags.Public | BindingFlags.Static | BindingFlags.FlattenHierarchy);
        var prop = (AvaloniaProperty<TResult>)field!.GetValue(null)!;
        return source.GetObservable(prop);
    }

    /// <summary>
    /// Observes changes to a pair of properties and combines the latest values.
    /// </summary>
    /// <typeparam name="T">The target object type.</typeparam>
    /// <typeparam name="T1">The first property value type.</typeparam>
    /// <typeparam name="T2">The second property value type.</typeparam>
    /// <param name="source">The source object.</param>
    /// <param name="selector1">Selector for the first property.</param>
    /// <param name="selector2">Selector for the second property.</param>
    /// <returns>An observable combining the latest values from both properties.</returns>
    public static IObservable<(T1, T2)> WhenAnyValue<T, T1, T2>(this T source,
        Expression<Func<T, T1>> selector1, Expression<Func<T, T2>> selector2) where T : AvaloniaObject
    {
        return Observable.CombineLatest(
            source.WhenAnyValue(selector1),
            source.WhenAnyValue(selector2),
            (v1, v2) => (v1, v2));
    }
}

internal static class ExpressionExtensions
{
    public static string GetMemberName(this LambdaExpression expression)
    {
        if (expression.Body is MemberExpression member)
            return member.Member.Name;
        throw new ArgumentException("Invalid expression", nameof(expression));
    }
}
