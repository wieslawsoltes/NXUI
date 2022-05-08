namespace MinimalAvalonia.Controls;

public static class AnimationExtensions
{
    public static T Duration<T>(this T animation, TimeSpan duration) where T : Animation
    {
        animation[Animation.DurationProperty] = duration;
        return animation;
    }

    public static T IterationCount<T>(this T animation, IterationCount iterationCount) where T : Animation
    {
        animation[Animation.IterationCountProperty] = iterationCount;
        return animation;
    }

    public static T IterationCount<T>(this T animation, ulong value, IterationType type) where T : Animation
    {
        animation[Animation.IterationCountProperty] = new IterationCount(value, type);
        return animation;
    }

    public static T IterationCountMany<T>(this T animation, ulong value) where T : Animation
    {
        animation[Animation.IterationCountProperty] = new IterationCount(value);
        return animation;
    }

    public static T IterationCountInfinite<T>(this T animation) where T : Animation
    {
        animation[Animation.IterationCountProperty] = Avalonia.Animation.IterationCount.Infinite;
        return animation;
    }

    public static T PlaybackDirection<T>(this T animation, PlaybackDirection playbackDirection) where T : Animation
    {
        animation[Animation.PlaybackDirectionProperty] = playbackDirection;
        return animation;
    }

    public static T PlaybackDirectionNormal<T>(this T animation) where T : Animation
    {
        animation[Animation.PlaybackDirectionProperty] = Avalonia.Animation.PlaybackDirection.Normal;
        return animation;
    }

    public static T PlaybackDirectionReverse<T>(this T animation) where T : Animation
    {
        animation[Animation.PlaybackDirectionProperty] = Avalonia.Animation.PlaybackDirection.Reverse;
        return animation;
    }

    public static T PlaybackDirectionAlternate<T>(this T animation) where T : Animation
    {
        animation[Animation.PlaybackDirectionProperty] = Avalonia.Animation.PlaybackDirection.Alternate;
        return animation;
    }

    public static T PlaybackDirectionAlternateReverse<T>(this T animation) where T : Animation
    {
        animation[Animation.PlaybackDirectionProperty] = Avalonia.Animation.PlaybackDirection.AlternateReverse;
        return animation;
    }

    public static T FillMode<T>(this T animation, FillMode fillMode) where T : Animation
    {
        animation[Animation.FillModeProperty] = fillMode;
        return animation;
    }

    public static T FillModeNone<T>(this T animation) where T : Animation
    {
        animation[Animation.FillModeProperty] = Avalonia.Animation.FillMode.None;
        return animation;
    }

    public static T FillModeForward<T>(this T animation) where T : Animation
    {
        animation[Animation.FillModeProperty] = Avalonia.Animation.FillMode.Forward;
        return animation;
    }

    public static T FillModeBackward<T>(this T animation) where T : Animation
    {
        animation[Animation.FillModeProperty] = Avalonia.Animation.FillMode.Backward;
        return animation;
    }

    public static T FillModeBoth<T>(this T animation) where T : Animation
    {
        animation[Animation.FillModeProperty] = Avalonia.Animation.FillMode.Both;
        return animation;
    }

    public static T Easing<T>(this T animation, Easing easing) where T : Animation
    {
        animation[Animation.EasingProperty] = easing;
        return animation;
    }

    public static T Delay<T>(this T animation, TimeSpan delay) where T : Animation
    {
        animation[Animation.DelayProperty] = delay;
        return animation;
    }

    public static T DelayBetweenIterations<T>(this T animation, TimeSpan delayBetweenIterations) where T : Animation
    {
        animation[Animation.DelayBetweenIterationsProperty] = delayBetweenIterations;
        return animation;
    }

    public static T SpeedRatio<T>(this T animation, double speedRatio) where T : Animation
    {
        animation[Animation.SpeedRatioProperty] = speedRatio;
        return animation;
    }

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
}
