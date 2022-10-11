namespace MinimalAvalonia.Extensions;

public static partial class AnimatableExtensions
{
    // Transitions

    /// <summary>
    /// 
    /// </summary>
    /// <param name="animatable"></param>
    /// <param name="transitions"></param>
    /// <typeparam name="T"></typeparam>
    /// <returns></returns>
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
