// <auto-generated />
namespace MinimalAvalonia.Extensions;

public static partial class LabelSetters
{
    // TargetProperty

    public static Style SetLabelTarget(this Style style, Avalonia.Input.IInputElement value)
    {
        style.Setters.Add(new Setter(Avalonia.Controls.Label.TargetProperty, value));
        return style;
    }

    public static Style SetLabelTarget(this Style style, Avalonia.Data.IBinding binding)
    {
        style.Setters.Add(new Setter(Avalonia.Controls.Label.TargetProperty, binding));
        return style;
    }

    public static Style SetLabelTarget(this Style style, IObservable<Avalonia.Input.IInputElement> observable)
    {
        style.Setters.Add(new Setter(Avalonia.Controls.Label.TargetProperty, observable.ToBinding()));
        return style;
    }

    public static KeyFrame SetLabelTarget(this KeyFrame keyFrame, Avalonia.Input.IInputElement value)
    {
        keyFrame.Setters.Add(new Setter(Avalonia.Controls.Label.TargetProperty, value));
        return keyFrame;
    }

    public static KeyFrame SetLabelTarget(this KeyFrame keyFrame, Avalonia.Data.IBinding binding)
    {
        keyFrame.Setters.Add(new Setter(Avalonia.Controls.Label.TargetProperty, binding));
        return keyFrame;
    }

    public static KeyFrame SetLabelTarget(this KeyFrame keyFrame, IObservable<Avalonia.Input.IInputElement> observable)
    {
        keyFrame.Setters.Add(new Setter(Avalonia.Controls.Label.TargetProperty, observable.ToBinding()));
        return keyFrame;
    }
}