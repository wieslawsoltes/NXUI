namespace MinimalAvalonia;

public static class ObjectExtensions
{
    public static T Ref<T>(this T obj, out T @ref)
    {
        @ref = obj;
        return obj;
    }
}
