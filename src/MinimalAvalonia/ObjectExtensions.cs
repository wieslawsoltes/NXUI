namespace MinimalAvalonia;

public static class ObjectExtensions
{
    public static T Ref<T>(this T obj, out T @ref)
    {
        @ref = obj;
        return obj;
    }

    public static T Self<T>(this T obj, Action<T>? callback)
    {
        callback?.Invoke(obj);
        return obj;
    }

    public static T Var<T, TU>(this T obj, TU value, out TU @ref)
    {
        @ref = value;
        return obj;
    }
}
