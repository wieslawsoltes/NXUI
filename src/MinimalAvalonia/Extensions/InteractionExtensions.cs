namespace MinimalAvalonia.Extensions;

public static partial class InteractionExtensions
{
    // Interaction.BehaviorProperty

    public static Style SetInteractionBehavior<T>(this Style style) where T : Behavior, new()
    {
        var setter = new Setter(Interaction.BehaviorProperty, BehaviorTemplate.Create<T>());
        style.Setters.Add(setter);
        return style;
    }

    public static Style SetInteractionBehavior(this Style style, params Behavior[] behaviors)
    {
        var behaviorTemplate = BehaviorTemplate.Create(
            () => new CompositeBehavior 
            {
                Behaviors = new AvaloniaList<Behavior>(behaviors)
            });
        var setter = new Setter(Interaction.BehaviorProperty, behaviorTemplate);
        style.Setters.Add(setter);
        return style;
    }
}
