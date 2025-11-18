using System.Collections.Generic;
using System.Linq;
using System.Runtime.CompilerServices;
using Avalonia.Controls;
using Avalonia.Controls.Presenters;
using Avalonia.Interactivity;
using Avalonia.Media;
using ButtonControl = Avalonia.Controls.Button;
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

    [Fact]
    public void Reconcile_EventHandlers_Do_Not_Accumulate()
    {
        var invocationCount = 0;

        ElementNode Build(int iteration)
            => Window()
                .Title("Event Harness")
                .Content(
                    Button()
                        .Content($"Iteration {iteration}")
                        .OnClickHandler((button, _) => invocationCount++))
                .Node;

        var current = Build(iteration: 0);
        var window = (Window)NodeRenderer.Instance.Build(current);
        var button = Assert.IsType<Button>(window.Content);

        void RaiseClick()
            => button.RaiseEvent(new RoutedEventArgs(ButtonControl.ClickEvent));

        RaiseClick();
        Assert.Equal(1, invocationCount);

        for (var iteration = 1; iteration <= 5; iteration++)
        {
            var next = Build(iteration);
            var result = NodeRenderer.Instance.Reconcile(current, next);

            Assert.False(result.ReplacedRoot);
            Assert.Same(window, result.RootInstance);
            Assert.Same(button, window.Content);

            RaiseClick();
            Assert.Equal(iteration + 1, invocationCount);

            current = next;
        }
    }

    [Fact]
    public void Reconcile_ContentPresenter_Content_Updates()
    {
        var previous = BuildContentPresenterWindow("Initial");
        var window = (Window)NodeRenderer.Instance.Build(previous);
        var presenter = Assert.IsType<ContentPresenter>(window.Content);

        var next = BuildContentPresenterWindow("Updated");
        var result = NodeRenderer.Instance.Reconcile(previous, next);

        Assert.False(result.ReplacedRoot);
        Assert.Same(window, result.RootInstance);
        var textBlock = Assert.IsType<TextBlock>(presenter.Content);
        Assert.Equal("Updated", textBlock.Text);
    }

    [Fact]
    public void Reconcile_ItemsControl_Items_Are_Patched()
    {
        var previous = BuildItemsWindow(itemCount: 2);
        var window = (Window)NodeRenderer.Instance.Build(previous);
        var listBox = Assert.IsType<ListBox>(window.Content);

        var next = BuildItemsWindow(itemCount: 3);
        var result = NodeRenderer.Instance.Reconcile(previous, next);

        Assert.False(result.ReplacedRoot);
        Assert.Same(window, result.RootInstance);
        Assert.Equal(3, listBox.ItemCount);
        var items = listBox.Items.Cast<object>().OfType<TextBlock>().ToArray();
        Assert.Equal("Item 2", items[^1].Text);
    }

    [Fact]
    public void Reconcile_Boundary_Preserves_Subtree_State()
    {
        var current = BuildBoundaryWindow("Initial");
        var window = (Window)NodeRenderer.Instance.Build(current);
        var panel = Assert.IsType<StackPanel>(window.Content);
        var textBox = Assert.IsType<TextBox>(panel.Children[0]);

        const string userState = "user-state";
        textBox.Text = userState;

        var next = BuildBoundaryWindow("Updated");
        var result = NodeRenderer.Instance.Reconcile(current, next);

        Assert.False(result.HasChanges);
        Assert.Equal(userState, textBox.Text);
    }

    [Fact]
    public void Reconcile_Nested_Boundaries_ShortCircuit()
    {
        var current = BuildNestedBoundaryWindow("Left", "Right");
        var window = (Window)NodeRenderer.Instance.Build(current);
        var border = Assert.IsType<Border>(window.Content);
        var stack = Assert.IsType<StackPanel>(border.Child);
        var left = Assert.IsType<TextBlock>(stack.Children[0]);
        var right = Assert.IsType<TextBlock>(stack.Children[1]);

        var next = BuildNestedBoundaryWindow("ChangedLeft", "ChangedRight");
        var result = NodeRenderer.Instance.Reconcile(current, next);

        Assert.False(result.HasChanges);
        Assert.Equal("Left", left.Text);
        Assert.Equal("Right", right.Text);
    }

    [Fact]
    public void Reconcile_SolidColorBrush_With_Same_Color_Does_Not_Set_Property()
    {
        var current = BuildBrushWindow(Colors.Red, opacity: 0.5);
        var window = (Window)NodeRenderer.Instance.Build(current);
        var border = Assert.IsType<Border>(window.Content);
        var originalBrush = Assert.IsType<SolidColorBrush>(border.Background);

        var next = BuildBrushWindow(Colors.Red, opacity: 0.5);
        var result = NodeRenderer.Instance.Reconcile(current, next);

        Assert.False(result.HasChanges);
        Assert.Same(originalBrush, border.Background);
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

    private static ElementNode BuildContentPresenterWindow(string text)
        => Window()
            .Title("Presenter Harness")
            .Content(
                ContentPresenter()
                    .Content(
                        TextBlock()
                            .Text(text)))
            .Node;

    private static ElementNode BuildItemsWindow(int itemCount)
    {
        var builders = Enumerable.Range(0, itemCount)
            .Select(i => ControlBuilder(TextBlock().Text($"Item {i}")))
            .ToArray();

        return Window()
            .Title("Items Harness")
            .Content(
                ListBox()
                    .ItemsSource(builders))
            .Node;
    }

    private static ElementNode BuildBoundaryWindow(string text)
        => Window()
            .Title("Boundary Harness")
            .Content(
                StackPanel()
                    .Children(
                        ControlBuilder(
                                TextBox()
                                    .Text(text)
                                    .HotReloadBoundary()),
                        ControlBuilder(TextBlock().Text("Static Info"))))
            .Node;

    private static ElementNode BuildNestedBoundaryWindow(string left, string right)
        => Window()
            .Title("Nested Boundary Harness")
            .Content(
                Border()
                    .HotReloadBoundary()
                    .Child(
                        StackPanel()
                            .HotReloadBoundary()
                            .Children(
                                ControlBuilder(TextBlock().Text(left)),
                                ControlBuilder(TextBlock().Text(right)))))
            .Node;

    private static ElementNode BuildBrushWindow(Color color, double opacity)
        => Window()
            .Title("Brush Harness")
            .Content(
                Border()
                    .Padding(new Avalonia.Thickness(8))
                    .Background(new SolidColorBrush(color) { Opacity = opacity }))
            .Node;

    private static ElementBuilder<Control> ControlBuilder<TControl>(ElementBuilder<TControl> builder)
        where TControl : Control
    {
        return Unsafe.As<ElementBuilder<TControl>, ElementBuilder<Control>>(ref builder);
    }
}
