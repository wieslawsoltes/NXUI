using Avalonia;
using Avalonia.Media;
using NXUI.Extensions;
using Xunit;
using static NXUI.Builders;

namespace NXUI.HotReload.Tests;

[Collection("HeadlessTests")]
public class VisualBuilderExtensionsTests
{
    [Fact]
    public void RenderTransform_Records_Builder_Value()
    {
        var control = Border()
            .RenderTransform(RotateTransform().Angle(45))
            .Mount();

        var transform = Assert.IsType<RotateTransform>(control.RenderTransform);
        Assert.Equal(45, transform.Angle);
    }

    [Fact]
    public void RenderTransform_Records_Factory_Value()
    {
        var invoked = false;

        var control = Border()
            .RenderTransform(() =>
            {
                invoked = true;
                return new RotateTransform(90);
            })
            .Mount();

        Assert.True(invoked);
        var transform = Assert.IsType<RotateTransform>(control.RenderTransform);
        Assert.Equal(90, transform.Angle);
    }

    [Fact]
    public void RenderTransformOrigin_Records_Factory_Value()
    {
        var origin = new RelativePoint(0.25, 0.75, RelativeUnit.Relative);

        var control = Border()
            .RenderTransformOrigin(() => origin)
            .Mount();

        Assert.Equal(origin, control.RenderTransformOrigin);
    }
}
