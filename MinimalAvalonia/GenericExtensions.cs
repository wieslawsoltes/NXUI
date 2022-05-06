namespace MinimalAvalonia;

public static class GenericExtensions
{
    public static T Ref<T>(this T obj, out T @ref)
    {
        @ref = obj;
        return obj;
    }
}
