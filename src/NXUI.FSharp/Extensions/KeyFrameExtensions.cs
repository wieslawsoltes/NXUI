// ReSharper disable InconsistentNaming
namespace NXUI.FSharp.Extensions;

/// <summary>
/// 
/// </summary>
public static partial class KeyFrameExtensions
{
    // KeyTime

    /// <summary>
    /// 
    /// </summary>
    /// <param name="keyFrame"></param>
    /// <param name="keyTime"></param>
    /// <returns></returns>
    public static KeyFrame keyTime(this KeyFrame keyFrame, TimeSpan keyTime)
    {
        keyFrame.KeyTime = keyTime;
        return keyFrame;
    }

    // Cue

    /// <summary>
    /// 
    /// </summary>
    /// <param name="keyFrame"></param>
    /// <param name="cue"></param>
    /// <returns></returns>
    public static KeyFrame cue(this KeyFrame keyFrame, Cue cue)
    {
        keyFrame.Cue = cue;
        return keyFrame;
    }

    /// <summary>
    /// 
    /// </summary>
    /// <param name="keyFrame"></param>
    /// <param name="cue"></param>
    /// <returns></returns>
    public static KeyFrame cue(this KeyFrame keyFrame, double cue)
    {
        keyFrame.Cue = new Cue(cue);
        return keyFrame;
    }

    /// <summary>
    /// 
    /// </summary>
    /// <param name="keyFrame"></param>
    /// <param name="cue"></param>
    /// <returns></returns>
    public static KeyFrame cue(this KeyFrame keyFrame, string cue)
    {
        keyFrame.Cue = Avalonia.Animation.Cue.Parse(cue, System.Globalization.CultureInfo.InvariantCulture);
        return keyFrame;
    }

    // KeySpline

    /// <summary>
    /// 
    /// </summary>
    /// <param name="keyFrame"></param>
    /// <param name="keySpline"></param>
    /// <returns></returns>
    public static KeyFrame keySpline(this KeyFrame keyFrame, KeySpline keySpline)
    {
        keyFrame.KeySpline = keySpline;
        return keyFrame;
    }

    /// <summary>
    /// 
    /// </summary>
    /// <param name="keyFrame"></param>
    /// <param name="x1"></param>
    /// <param name="y1"></param>
    /// <param name="x2"></param>
    /// <param name="y2"></param>
    /// <returns></returns>
    public static KeyFrame keySpline(this KeyFrame keyFrame, double x1, double y1, double x2, double y2)
    {
        keyFrame.KeySpline = new KeySpline(x1, y1, x2, y2);
        return keyFrame;
    }

    /// <summary>
    /// 
    /// </summary>
    /// <param name="keyFrame"></param>
    /// <param name="keySpline"></param>
    /// <returns></returns>
    public static KeyFrame keySpline(this KeyFrame keyFrame, string keySpline)
    {
        keyFrame.KeySpline = Avalonia.Animation.KeySpline.Parse(keySpline, System.Globalization.CultureInfo.InvariantCulture);;
        return keyFrame;
    }

    // Setters

    /// <summary>
    /// 
    /// </summary>
    /// <param name="keyFrame"></param>
    /// <param name="setters"></param>
    /// <returns></returns>
    public static KeyFrame setters(this KeyFrame keyFrame, params IAnimationSetter[] setters)
    {
        foreach (var setter in setters)
        {
            keyFrame.Setters.Add(setter);
        }
        return keyFrame;
    }

    // Setter

    /// <summary>
    /// 
    /// </summary>
    /// <param name="keyFrame"></param>
    /// <param name="property"></param>
    /// <param name="value"></param>
    /// <returns></returns>
    public static KeyFrame setters(this KeyFrame keyFrame, AvaloniaProperty property, object value)
    {
        keyFrame.Setters.Add(new Setter(property, value));
        return keyFrame;
    }
}
