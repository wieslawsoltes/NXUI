namespace MinimalAvalonia;

public static class LabelExtensions
{
    public static T Target<T>(this T contentControl, IInputElement target) where T : Label
    {
        contentControl[Label.TargetProperty] = target;
        return contentControl;
    }
}
