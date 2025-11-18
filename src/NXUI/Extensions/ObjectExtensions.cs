namespace NXUI.Extensions;

/// <summary>
/// 
/// </summary>
public static partial class ObjectExtensions
{
    /// <summary>
    /// 
    /// </summary>
    /// <param name="obj"></param>
    /// <param name="ref"></param>
    /// <typeparam name="T"></typeparam>
    /// <returns></returns>
    public static T Ref<T>(this T obj, out T @ref)
    {
        @ref = obj;
        return obj;
    }

    /// <summary>
    /// 
    /// </summary>
    /// <param name="obj"></param>
    /// <param name="callback"></param>
    /// <typeparam name="T"></typeparam>
    /// <returns></returns>
    public static T Self<T>(this T obj, Action<T>? callback)
    {
        callback?.Invoke(obj);
        return obj;
    }

    /// <summary>
    /// 
    /// </summary>
    /// <param name="obj"></param>
    /// <param name="value"></param>
    /// <param name="ref"></param>
    /// <typeparam name="T"></typeparam>
    /// <typeparam name="TU"></typeparam>
    /// <returns></returns>
    public static T Var<T, TU>(this T obj, TU value, out TU @ref)
    {
        @ref = value;
        return obj;
    }
}
