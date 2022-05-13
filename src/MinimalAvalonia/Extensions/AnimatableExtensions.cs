namespace MinimalAvalonia.Extensions;

public static partial class AnimatableExtensions
{
    // Transitions

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
