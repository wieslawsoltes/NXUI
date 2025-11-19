using System.Linq;
using Avalonia.Controls;
using Avalonia.Media;
using Avalonia.Styling;
using NXUI.Extensions;
using NXUI.HotReload.Nodes;
using Xunit;
using static NXUI.Builders;

namespace NXUI.HotReload.Tests;

[Collection("HeadlessTests")]
public class NodeRendererTests
{
    [Fact]
    public void ContentControl_Records_Builder_Content()
    {
        var builder = ContentControl()
            .Content(
                TextBlock().Text("Hello"));

        var control = builder.Mount();

        var content = Assert.IsType<TextBlock>(control.Content);
        Assert.Equal("Hello", content.Text);
    }

    [Fact]
    public void ItemsControl_Records_ItemsSource_Builders()
    {
        var builder = TabControl()
            .ItemsSource(
                TabItem().Header("One").Content(TextBlock().Text("First")),
                TabItem().Header("Two").Content(TextBlock().Text("Second")));

        var control = builder.Mount();
        var items = control.Items.Cast<TabItem>().ToArray();

        Assert.Equal(2, items.Length);
        Assert.Equal("One", items[0].Header);
        Assert.Equal("Two", items[1].Header);
    }

    [Fact]
    public void StyledElement_Styles_From_Builders()
    {
        var styleBuilder = ElementBuilder.Create(() =>
        {
            var style = new Style(x => x.OfType<Avalonia.Controls.Border>());
            style.Setters.Add(new Setter(Avalonia.Controls.Border.BackgroundProperty, Brushes.Red));
            return style;
        });

        var builder = Border()
            .Styles(styleBuilder);

        var border = builder.Mount();

        Assert.Single(border.Styles);
        Assert.IsType<Style>(border.Styles[0]);
    }

    [Fact]
    public void StyledElement_Resources_From_Builder()
    {
        var resourceBuilder = ElementBuilder.Create(() =>
        {
            var dictionary = new ResourceDictionary();
            dictionary["Greeting"] = "Hello";
            return dictionary;
        });

        var builder = Border()
            .Resources(resourceBuilder);

        var border = builder.Mount();

        Assert.Equal("Hello", border.Resources["Greeting"]);
    }

    [Fact]
    public void WithAction_Invokes_Delegate_Exactly_Once()
    {
        var invocationCount = 0;

        var builder = Border()
            .WithAction(border =>
            {
                invocationCount++;
                border.Width = 123;
            });

        var border = builder.Mount();

        Assert.Equal(1, invocationCount);
        Assert.Equal(123, border.Width);
    }

    [Fact]
    public void WithAction_Receives_Control_Instance()
    {
        Border? captured = null;

        var builder = Border()
            .WithAction(border => captured = border);

        var border = builder.Mount();

        Assert.NotNull(captured);
        Assert.Same(border, captured);
    }
}
