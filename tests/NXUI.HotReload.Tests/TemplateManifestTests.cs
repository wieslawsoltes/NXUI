using Avalonia.Controls;
using Avalonia.Controls.Primitives;
using Avalonia.Controls.Templates;
using Avalonia.Styling;
using NXUI.Extensions;
using NXUI.HotReload.Templates;
using Xunit;
using static NXUI.Builders;

namespace NXUI.HotReload.Tests;

[Collection("HeadlessTests")]
public class TemplateManifestTests
{
    [Fact]
    public void TemplateBuilderRegistersManifestWithNamedParts()
    {
        var style = new Style(x => x.OfType<Button>());
        style.SetTemplatedControlTemplate<Button, Grid>((parent, scope) =>
            Grid()
                .Children(
                    Border()
                        .Name("PART_Border", scope)
                        .Child(
                            ContentPresenter()
                                .Name("PART_Content", scope))));

        var templateSetter = Assert.IsType<Setter>(Assert.Single(style.Setters));
        Assert.Equal(Avalonia.Controls.Primitives.TemplatedControl.TemplateProperty, templateSetter.Property);
        var template = Assert.IsType<FuncControlTemplate>(templateSetter.Value);

        template.Build(new Button());

        Assert.True(TemplateManifestRegistry.TryGetManifest(template, out var manifest));
        Assert.NotNull(manifest);

        var root = manifest!.Root;
        Assert.Equal(typeof(Grid), root.ControlType);
        var border = Assert.Single(root.Children);
        Assert.Equal(typeof(Border), border.ControlType);
        Assert.Equal("PART_Border", border.Name);
        var presenter = Assert.Single(border.Children);
        Assert.Equal(typeof(Avalonia.Controls.Presenters.ContentPresenter), presenter.ControlType);
        Assert.Equal("PART_Content", presenter.Name);
    }
}
