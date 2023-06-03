namespace NXUI.Extensions;

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
    /// <returns></returns>
    public static Animation IterationCount(this Animation animation, ulong value, IterationType type)
    {
        animation[Avalonia.Animation.Animation.IterationCountProperty] = new IterationCount(value, type);
        return animation;
    }

    /// <summary>
    /// 
    /// </summary>
    /// <param name="animation"></param>
    /// <param name="value"></param>
    /// <returns></returns>
    public static Animation IterationCountMany(this Animation animation, ulong value)
    {
        animation[Avalonia.Animation.Animation.IterationCountProperty] = new IterationCount(value);
        return animation;
    }

    /// <summary>
    /// 
    /// </summary>
    /// <param name="animation"></param>
    /// <returns></returns>
    public static Animation IterationCountInfinite(this Animation animation)
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
    /// <returns></returns>
    public static Animation KeyFrames(this Animation animation, KeyFrame keyFrame)
    {
        animation.Children.Add(keyFrame);
        return animation;
    }

    /// <summary>
    /// 
    /// </summary>
    /// <param name="animation"></param>
    /// <param name="keyFrames"></param>
    /// <returns></returns>
    public static Animation KeyFrames(this Animation animation, params KeyFrame[] keyFrames)
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
    /// <returns></returns>
    public static T Animator<T>(this T animationSetter, CustomAnimatorBase value) where T : IAnimationSetter
    {
        Avalonia.Animation.Animation.SetAnimator(animationSetter, value);
        return animationSetter;
    }
}
