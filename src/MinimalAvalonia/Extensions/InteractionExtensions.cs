namespace MinimalAvalonia.Extensions;

/// <summary>
/// 
/// </summary>
public static partial class InteractionExtensions
{
    // Interaction.BehaviorProperty

    /// <summary>
    /// 
    /// </summary>
    /// <param name="style"></param>
    /// <typeparam name="T"></typeparam>
    /// <returns></returns>
    public static Style SetInteractionBehavior<T>(this Style style) where T : Behavior, new()
    {
        var setter = new Setter(Interaction.BehaviorProperty, BehaviorTemplate.Create<T>());
        style.Setters.Add(setter);
        return style;
    }

    /// <summary>
    /// 
    /// </summary>
    /// <param name="style"></param>
    /// <param name="func"></param>
    /// <returns></returns>
    public static Style SetInteractionBehavior(this Style style, params Func<Behavior>[] func)
    {
        var behaviorTemplate = BehaviorTemplate.Create(() => 
        {
            if (func.Length == 1)
            {
                return func[0]();
            }

            var compositeBehavior = new CompositeBehavior();
            var behaviors = new AvaloniaList<Behavior>();

            foreach (var f in func)
            {
                behaviors.Add(f());
            }

            compositeBehavior.Behaviors = behaviors;

            return compositeBehavior;
        });
        var setter = new Setter(Interaction.BehaviorProperty, behaviorTemplate);
        style.Setters.Add(setter);
        return style;
    }
}
