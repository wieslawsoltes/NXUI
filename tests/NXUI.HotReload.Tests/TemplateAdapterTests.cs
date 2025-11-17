using Avalonia.Controls;
using Avalonia.Controls.Templates;
using Avalonia.Markup.Xaml;
using Avalonia.Styling;
using NXUI.Extensions;
using Xunit;
using static NXUI.Builders;

namespace NXUI.HotReload.Tests;

[Collection("HeadlessTests")]
public class TemplateAdapterTests
{
    [Fact]
    public void FuncTemplate_Adapter_Uses_Builder()
    {
        var template = FuncTemplate(StackPanel);
        var panel = template.Build();

        Assert.IsType<StackPanel>(panel);
    }

    [Fact]
    public void FuncDataTemplate_Adapter_Uses_Builder()
    {
        var template = FuncDataTemplate<object, StackPanel>((_, _) => StackPanel());

        var control = template.Build(new object(), null);

        Assert.IsType<StackPanel>(control);
    }

    [Fact]
    public void Style_Template_Builder_Records_Template()
    {
        var styleBuilder = Style()
            .SetTemplatedControlTemplate<TabControl, Border>((_, _) =>
                Border()
                    .Child(ContentPresenter()));

        var style = styleBuilder.Mount();
        var setter = Assert.IsType<Setter>(Assert.Single(style.Setters));
        var template = Assert.IsType<FuncControlTemplate>(setter.Value);
        var result = template.Build(new TabControl());
        var content = ExtractControl(result);

        Assert.IsType<Border>(content);
    }

    private static Control ExtractControl(object templateResult)
    {
        if (templateResult is Control control)
        {
            return control;
        }

        var type = templateResult.GetType();
        var property = type.GetProperty("Result") ?? type.GetProperty("Control");
        if (property is null)
        {
            throw new InvalidOperationException($"Unsupported template result '{type}'.");
        }

        return (Control)property.GetValue(templateResult)!;
    }
}
