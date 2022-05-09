namespace MinimalAvalonia.Controls;

public static class LabelExtensions
{
    public static T Target<T>(this T contentControl, IInputElement target) where T : Label
    {
        contentControl[Avalonia.Controls.Label.TargetProperty] = target;
        return contentControl;
    }
}
