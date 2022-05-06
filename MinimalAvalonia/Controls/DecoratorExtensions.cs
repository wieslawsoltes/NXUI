namespace MinimalAvalonia.Controls;

public static class DecoratorExtensions
{
    public static T Child<T>(this T decorator, IControl child) where T : Decorator
    {
        decorator[Decorator.ChildProperty] = child;
        return decorator;
    }

    public static T Padding<T>(this T decorator, double uniformLength) where T : Decorator
    {
        decorator[Decorator.PaddingProperty] = new Thickness(uniformLength);
        return decorator;
    }

    public static T Padding<T>(this T decorator, double horizontal, double vertical) where T : Decorator
    {
        decorator[Decorator.PaddingProperty] = new Thickness(horizontal, vertical);
        return decorator;
    }

    public static T Padding<T>(this T decorator, double left, double top, double right, double bottom) where T : Decorator
    {
        decorator[Decorator.PaddingProperty] = new Thickness(left, top, right, bottom);
        return decorator;
    }
}
