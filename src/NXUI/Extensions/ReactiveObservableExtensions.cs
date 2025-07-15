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

namespace NXUI.Extensions;

public static class ReactiveObservableExtensions
{
    public static IObservable<T> ObserveOnUiThread<T>(this IObservable<T> source)
    {
        return Observable.Create<T>(observer =>
            source.Subscribe(
                x => Avalonia.Threading.Dispatcher.UIThread.Post(() => observer.OnNext(x)),
                ex => Avalonia.Threading.Dispatcher.UIThread.Post(() => observer.OnError(ex)),
                () => Avalonia.Threading.Dispatcher.UIThread.Post(observer.OnCompleted)));
    }

    public static IDisposable SubscribeOnUiThread<T>(this IObservable<T> source, Action<T> onNext)
    {
        return source.ObserveOnUiThread().Subscribe(onNext);
    }

    public static IObservable<T> TakeUntilDetachedFromVisualTree<T>(this IObservable<T> source, Visual visual)
    {
        return source.TakeUntil(visual.OnDetachedFromVisualTree());
    }

    public static IDisposable SubscribeUntilDetached<T>(this IObservable<T> source, Visual visual, Action<T> onNext)
    {
        return source
            .TakeUntilDetachedFromVisualTree(visual)
            .Subscribe(onNext);
    }

    public static IDisposable DisposeWith(this IDisposable disposable, CompositeDisposable composite)
    {
        composite.Add(disposable);
        return disposable;
    }

    public static FuncDataTemplate<T> DataTemplate<T>(Func<T, Control?> build, bool supportsRecycling = false) where T : class
    {
        return new FuncDataTemplate<T>((item, _) => build(item), supportsRecycling);
    }


    public static IObservable<TResult> WhenAnyValue<T, TResult>(this T source,
        Expression<Func<T, TResult>> selector) where T : AvaloniaObject
    {
        var field = typeof(T).GetField(selector.GetMemberName() + "Property", BindingFlags.Public | BindingFlags.Static | BindingFlags.FlattenHierarchy);
        var prop = (AvaloniaProperty<TResult>)field!.GetValue(null)!;
        return source.GetObservable(prop);
    }

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
