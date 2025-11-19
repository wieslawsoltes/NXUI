using Avalonia.Animation;
using Avalonia.Controls;
using Avalonia.Media;
using Avalonia.Styling;
using System.Globalization;
using NXUI.Extensions;
using Xunit;
using static NXUI.Builders;

namespace NXUI.HotReload.Tests;

[Collection("HeadlessTests")]
public class AnimationKeyFrameBuilderExtensionsTests
{
    [Fact]
    public void Animation_Builder_Sets_IterationCount_Infinite()
    {
        var animation = Animation()
            .IterationCountInfinite()
            .Mount();

        var iterationCount = animation.GetValue(Avalonia.Animation.Animation.IterationCountProperty);

        Assert.Equal(IterationCount.Infinite, iterationCount);
    }

    [Fact]
    public void Animation_Builder_Adds_KeyFrames_From_Builders()
    {
        var animation = Animation()
            .KeyFrames(
                KeyFrame().Cue(0.0),
                KeyFrame().Cue(1.0))
            .Mount();

        Assert.Equal(2, animation.Children.Count);
        Assert.Equal(new Cue(0.0), animation.Children[0].Cue);
        Assert.Equal(new Cue(1.0), animation.Children[1].Cue);
    }

    [Fact]
    public void Animation_Builder_Adds_KeyFrame_Instances()
    {
        var keyFrame = new KeyFrame { Cue = new Cue(0.5) };

        var animation = Animation()
            .KeyFrames(keyFrame)
            .Mount();

        Assert.Same(keyFrame, Assert.Single(animation.Children));
    }

    [Fact]
    public void KeyFrame_Builder_Sets_Cue_From_String()
    {
        const string cueValue = "0.25";

        var keyFrame = KeyFrame()
            .Cue(cueValue)
            .Mount();

        var expected = Cue.Parse(cueValue, CultureInfo.InvariantCulture);
        Assert.Equal(expected, keyFrame.Cue);
    }

    [Fact]
    public void KeyFrame_Builder_Adds_Setters()
    {
        var setter = new Setter(Avalonia.Controls.Border.BackgroundProperty, Brushes.Red);

        var keyFrame = KeyFrame()
            .Setters(setter)
            .Mount();

        Assert.Same(setter, Assert.Single(keyFrame.Setters));
    }

    [Fact]
    public void KeyFrame_Builder_Creates_Setter_From_Property_Value()
    {
        var keyFrame = KeyFrame()
            .Setter(Avalonia.Controls.Border.BackgroundProperty, Brushes.Blue)
            .Mount();

        var setter = Assert.IsType<Setter>(Assert.Single(keyFrame.Setters));
        Assert.Equal(Avalonia.Controls.Border.BackgroundProperty, setter.Property);
        Assert.Equal(Brushes.Blue, setter.Value);
    }

    [Fact]
    public void Animation_Builder_Preserves_KeyFrame_Setters()
    {
        var animation = Animation()
            .KeyFrames(
                KeyFrame()
                    .Cue(0.25)
                    .SetBorderBackground(Brushes.Orange))
            .Mount();

        var keyFrame = Assert.Single(animation.Children);
        var setter = Assert.IsType<Setter>(Assert.Single(keyFrame.Setters));

        Assert.Equal(new Cue(0.25), keyFrame.Cue);
        Assert.Equal(Avalonia.Controls.Border.BackgroundProperty, setter.Property);
        Assert.Equal(Brushes.Orange, setter.Value);
    }
}
