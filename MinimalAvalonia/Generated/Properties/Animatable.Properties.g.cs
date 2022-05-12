namespace MinimalAvalonia;

[System.Diagnostics.CodeAnalysis.SuppressMessage("ReSharper", "InconsistentNaming")]
[System.Diagnostics.CodeAnalysis.SuppressMessage("ReSharper", "RedundantNameQualifier")]
public static partial class MinimalAvaloniaProperties
{
    public static Avalonia.StyledProperty<Avalonia.Animation.IClock> AnimatableClock => Avalonia.Animation.Animatable.ClockProperty;

    public static Avalonia.StyledProperty<Avalonia.Animation.Transitions> AnimatableTransitions => Avalonia.Animation.Animatable.TransitionsProperty;
}
