namespace MinimalAvalonia.Extensions;

public static partial class AnimationExtensions
{
    // IterationCountProperty

    public static T IterationCount<T>(this T animation, ulong value, IterationType type) where T : Animation
    {
        animation[Avalonia.Animation.Animation.IterationCountProperty] = new IterationCount(value, type);
        return animation;
    }

    public static T IterationCountMany<T>(this T animation, ulong value) where T : Animation
    {
        animation[Avalonia.Animation.Animation.IterationCountProperty] = new IterationCount(value);
        return animation;
    }

    public static T IterationCountInfinite<T>(this T animation) where T : Animation
    {
        animation[Avalonia.Animation.Animation.IterationCountProperty] = Avalonia.Animation.IterationCount.Infinite;
        return animation;
    }

    // KeyFrames

    public static T KeyFrames<T>(this T animation, KeyFrame keyFrame) where T : Animation
    {
        animation.Children.Add(keyFrame);
        return animation;
    }

    public static T KeyFrames<T>(this T animation, params KeyFrame[] keyFrames) where T : Animation
    {
        animation.Children.AddRange(keyFrames);
        return animation;
    }

    // Animator

    public static T Animator<T>(this T animationSetter, Type value) where T : IAnimationSetter
    {
        Avalonia.Animation.Animation.SetAnimator(animationSetter, value);
        return animationSetter;
    }
}
