using System.Collections.Generic;
using System.Linq;
using System.Runtime.CompilerServices;
using Avalonia.Controls;
using NXUI.Extensions;
using NXUI.HotReload.Nodes;
using Xunit;
using static NXUI.Builders;

namespace NXUI.HotReload.Tests;

[Collection("HeadlessTests")]
public class NodeRendererHeadlessTests
{
    [Fact]
    public void Reconcile_TextBlock_Text_Updates_InPlace()
    {
        var previous = BuildMessageWindow("Initial");
        var window = (Window)NodeRenderer.Instance.Build(previous);
        var textBlock = Assert.IsType<TextBlock>(window.Content);

        var next = BuildMessageWindow("Updated");
        var result = NodeRenderer.Instance.Reconcile(previous, next);

        Assert.False(result.ReplacedRoot);
        Assert.Equal(1, result.SetPropertyCount);
        Assert.Equal("Updated", textBlock.Text);
        Assert.Same(window, result.RootInstance);
    }

    [Fact]
    public void Reconcile_AddChild_Appends_To_Panel_Without_Replacing_Siblings()
    {
        var previous = BuildStackPanel(includeThirdChild: false);
        var window = (Window)NodeRenderer.Instance.Build(previous);
        var panel = Assert.IsType<StackPanel>(window.Content);
        var originalFirst = Assert.IsType<TextBlock>(panel.Children[0]);

        var next = BuildStackPanel(includeThirdChild: true);
        var result = NodeRenderer.Instance.Reconcile(previous, next);

        Assert.False(result.ReplacedRoot);
        Assert.Equal(1, result.AddChildCount);
        Assert.Equal(3, panel.Children.Count);
        Assert.Same(originalFirst, panel.Children[0]);
        Assert.Equal("Third", ((TextBlock)panel.Children[2]).Text);
    }

    [Fact]
    public void Reconcile_Soak_Retains_User_State_Across_Iterations()
    {
        var current = BuildSoakWindow(iteration: 0);
        var window = (Window)NodeRenderer.Instance.Build(current);
        var panel = Assert.IsType<StackPanel>(window.Content);
        var userTextBox = Assert.IsType<TextBox>(panel.Children[0]);

        const string userState = "user-state";
        userTextBox.Text = userState;

        for (var iteration = 1; iteration <= 32; iteration++)
        {
            var next = BuildSoakWindow(iteration);
            var result = NodeRenderer.Instance.Reconcile(current, next);

            Assert.False(result.ReplacedRoot);
            Assert.Same(window, result.RootInstance);
            Assert.Same(userTextBox, panel.Children[0]);
            Assert.Equal(userState, userTextBox.Text);
            Assert.True(result.HasChanges);

            current = next;
        }
    }

    private static ElementNode BuildMessageWindow(string text)
        => Window()
            .Title("Headless Harness")
            .Content(
                TextBlock()
                    .FontSize(16)
                    .Text(text))
            .Node;

    private static ElementNode BuildStackPanel(bool includeThirdChild)
    {
        var stack = StackPanel()
            .Spacing(2)
            .Children(
                ControlBuilder(TextBlock().Text("First")),
                ControlBuilder(TextBlock().Text("Second")));

        if (includeThirdChild)
        {
            stack = stack.Children(ControlBuilder(TextBlock().Text("Third")));
        }

        return Window()
            .Content(stack)
            .Node;
    }

    private static ElementNode BuildSoakWindow(int iteration)
    {
        var stack = StackPanel()
            .Spacing(4)
            .Children(
                ControlBuilder(TextBox()),
                ControlBuilder(TextBlock().Text($"Iteration {iteration}")),
                ControlBuilder(Button().Content(iteration % 2 == 0 ? "Even" : "Odd")));

        if (iteration % 3 == 0)
        {
            stack = stack.Children(ControlBuilder(TextBlock().Text("Modulo zero branch")));
        }
        else
        {
            stack = stack.Children(
                ControlBuilder(
                    Border()
                        .Width(120 + iteration)
                        .Height(32 + (iteration % 5))
                        .Child(
                            TextBlock()
                                .Text("Border payload"))));
        }

        return Window()
            .Title("Soak Harness")
            .Width(400)
            .Height(240)
            .Content(stack)
            .Node;
    }

    private static ElementBuilder<Control> ControlBuilder<TControl>(ElementBuilder<TControl> builder)
        where TControl : Control
    {
        return Unsafe.As<ElementBuilder<TControl>, ElementBuilder<Control>>(ref builder);
    }
}
