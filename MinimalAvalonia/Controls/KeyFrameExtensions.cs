namespace MinimalAvalonia.Controls;

public static class KeyFrameExtensions
{
    public static T KeyTime<T>(this T keyFrame, TimeSpan keyTime) where T : KeyFrame
    {
        keyFrame.KeyTime = keyTime;
        return keyFrame;
    }

    public static T Cue<T>(this T keyFrame, Cue cue) where T : KeyFrame
    {
        keyFrame.Cue = cue;
        return keyFrame;
    }

    public static T Cue<T>(this T keyFrame, double cue) where T : KeyFrame
    {
        keyFrame.Cue = new Cue(cue);
        return keyFrame;
    }

    public static T Cue<T>(this T keyFrame, string cue) where T : KeyFrame
    {
        keyFrame.Cue = Avalonia.Animation.Cue.Parse(cue, System.Globalization.CultureInfo.InvariantCulture);
        return keyFrame;
    }

    public static T KeySpline<T>(this T keyFrame, KeySpline keySpline) where T : KeyFrame
    {
        keyFrame.KeySpline = keySpline;
        return keyFrame;
    }

    public static T KeySpline<T>(this T keyFrame, double x1, double y1, double x2, double y2) where T : KeyFrame
    {
        keyFrame.KeySpline = new KeySpline(x1, y1, x2, y2);
        return keyFrame;
    }

    public static T KeySpline<T>(this T keyFrame, string keySpline) where T : KeyFrame
    {
        keyFrame.KeySpline = Avalonia.Animation.KeySpline.Parse(keySpline, System.Globalization.CultureInfo.InvariantCulture);;
        return keyFrame;
    }

    public static T Setters<T>(this T style, params IAnimationSetter[] setters) where T : KeyFrame
    {
        foreach (var setter in setters)
        {
            style.Setters.Add(setter);
        }
        return style;
    }

    public static T Setter<T>(this T style, AvaloniaProperty property, object value) where T : KeyFrame
    {
        style.Setters.Add(new Setter(property, value));
        return style;
    }
}
