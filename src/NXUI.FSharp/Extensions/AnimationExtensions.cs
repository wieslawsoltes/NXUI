// ReSharper disable InconsistentNaming
namespace NXUI.FSharp.Extensions;

/// <summary>
/// 
/// </summary>
public static partial class AnimationExtensions
{
    // IterationCountProperty

    /// <summary>
    /// 
    /// </summary>
    /// <param name="animation"></param>
    /// <param name="value"></param>
    /// <param name="type"></param>
    /// <typeparam name="T"></typeparam>
    /// <returns></returns>
    public static T iterationCount<T>(this T animation, ulong value, IterationType type) where T : Animation
    {
        animation[Avalonia.Animation.Animation.IterationCountProperty] = new IterationCount(value, type);
        return animation;
    }

    /// <summary>
    /// 
    /// </summary>
    /// <param name="animation"></param>
    /// <param name="value"></param>
    /// <typeparam name="T"></typeparam>
    /// <returns></returns>
    public static T iterationCountMany<T>(this T animation, ulong value) where T : Animation
    {
        animation[Avalonia.Animation.Animation.IterationCountProperty] = new IterationCount(value);
        return animation;
    }

    /// <summary>
    /// 
    /// </summary>
    /// <param name="animation"></param>
    /// <typeparam name="T"></typeparam>
    /// <returns></returns>
    public static T iterationCountInfinite<T>(this T animation) where T : Animation
    {
        animation[Avalonia.Animation.Animation.IterationCountProperty] = Avalonia.Animation.IterationCount.Infinite;
        return animation;
    }

    // KeyFrames

    /// <summary>
    /// 
    /// </summary>
    /// <param name="animation"></param>
    /// <param name="keyFrame"></param>
    /// <typeparam name="T"></typeparam>
    /// <returns></returns>
    public static T keyFrames<T>(this T animation, KeyFrame keyFrame) where T : Animation
    {
        animation.Children.Add(keyFrame);
        return animation;
    }

    /// <summary>
    /// 
    /// </summary>
    /// <param name="animation"></param>
    /// <param name="keyFrames"></param>
    /// <typeparam name="T"></typeparam>
    /// <returns></returns>
    public static T keyFrames<T>(this T animation, params KeyFrame[] keyFrames) where T : Animation
    {
        animation.Children.AddRange(keyFrames);
        return animation;
    }

    // Animator

    /// <summary>
    /// 
    /// </summary>
    /// <param name="animationSetter"></param>
    /// <param name="value"></param>
    /// <typeparam name="T"></typeparam>
    /// <returns></returns>
    public static T animator<T>(this T animationSetter, Type value) where T : IAnimationSetter
    {
        Avalonia.Animation.Animation.SetAnimator(animationSetter, value);
        return animationSetter;
    }
}
