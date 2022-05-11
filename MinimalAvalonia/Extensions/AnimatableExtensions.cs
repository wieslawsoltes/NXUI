namespace MinimalAvalonia.Extensions;

public static class AnimatableExtensions
{
    public static T Clock<T>(this T animatable, IClock clock) where T : Animatable
    {
        animatable[Avalonia.Animation.Animatable.ClockProperty] = clock;
        return animatable;
    }

    public static T Transitions<T>(this T animatable, Transitions? transitions) where T : Animatable
    {
        animatable[Avalonia.Animation.Animatable.TransitionsProperty] = transitions;
        return animatable;
    }

    public static T Transitions<T>(this T animatable, params ITransition[] transitions) where T : Animatable
    {
        if (animatable.Transitions is { })
        {
            animatable.Transitions.AddRange(transitions);
        }
        else
        {
            animatable.Transitions = new Transitions();
            animatable.Transitions.AddRange(transitions);
        }
        return animatable;
    }
}
