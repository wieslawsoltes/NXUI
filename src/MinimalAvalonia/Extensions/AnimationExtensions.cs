namespace MinimalAvalonia.Extensions;

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
    public static T IterationCount<T>(this T animation, ulong value, IterationType type) where T : Animation
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
    public static T IterationCountMany<T>(this T animation, ulong value) where T : Animation
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
    public static T IterationCountInfinite<T>(this T animation) where T : Animation
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
    public static T KeyFrames<T>(this T animation, KeyFrame keyFrame) where T : Animation
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
    public static T KeyFrames<T>(this T animation, params KeyFrame[] keyFrames) where T : Animation
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
    public static T Animator<T>(this T animationSetter, Type value) where T : IAnimationSetter
    {
        Avalonia.Animation.Animation.SetAnimator(animationSetter, value);
        return animationSetter;
    }
}
