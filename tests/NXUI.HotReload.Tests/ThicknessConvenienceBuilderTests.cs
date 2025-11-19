using Avalonia;
using Avalonia.Controls;
using NXUI.Extensions;
using Xunit;
using static NXUI.Builders;

namespace NXUI.HotReload.Tests;

[Collection("HeadlessTests")]
public class ThicknessConvenienceBuilderTests
{
    [Fact]
    public void Window_Builder_Uses_Uniform_Padding_Overload()
    {
        var window = Window()
            .Padding(12)
            .Mount();

        Assert.Equal(new Thickness(12), window.Padding);
    }

    [Fact]
    public void Border_Builder_Uses_Horizontal_Vertical_Padding_Overload()
    {
        var border = Border()
            .Padding(6, 10)
            .Mount();

        Assert.Equal(new Thickness(6, 10), border.Padding);
    }

    [Fact]
    public void Border_Builder_Uses_All_Sides_BorderThickness_Overload()
    {
        var border = Border()
            .BorderThickness(1, 2, 3, 4)
            .Mount();

        Assert.Equal(new Thickness(1, 2, 3, 4), border.BorderThickness);
    }
}
