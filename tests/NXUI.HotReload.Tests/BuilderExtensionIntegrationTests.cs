using System;
using System.Collections.Generic;
using Avalonia.Animation;
using Avalonia.Collections;
using Avalonia.Controls;
using Avalonia.Controls.Templates;
using Avalonia.Interactivity;
using NXUI.Extensions;
using NXUI.HotReload.Nodes;
using Xunit;

namespace NXUI.HotReload.Tests;

[Collection("HeadlessTests")]
public class BuilderExtensionIntegrationTests
{
    [Fact]
    public void AnimatableTransitions_Record_Mutations()
    {
        var transition = new DoubleTransition { Property = Border.WidthProperty };

        var border = Builders.Border()
            .Transitions(transition)
            .Mount();

        Assert.NotNull(border.Transitions);
        Assert.Contains(transition, border.Transitions);
    }

    [Fact]
    public void ControlDataTemplates_Record_Templates()
    {
        var template = new FuncDataTemplate<object>((_, _) => new TextBlock());

        var control = Builders.ContentControl()
            .DataTemplates(template)
            .Mount();

        Assert.Contains(template, control.DataTemplates);
    }

    [Fact]
    public void TabControlItemsSource_Populates_Objects()
    {
        var tabBuilder = Builders.TabControl();
        tabBuilder = NXUI.Extensions.TabControlExtensions.ItemsSource(tabBuilder, "One", "Two");
        var tabControl = tabBuilder.Mount();

        var items = Assert.IsType<AvaloniaList<object>>(tabControl.ItemsSource);
        Assert.Equal(new[] { "One", "Two" }, items);
    }

    [Fact]
    public void ItemsControlItemsSource_Populates_Objects()
    {
        var itemsBuilder = Builders.ItemsControl();
        itemsBuilder = NXUI.Extensions.ItemsControlExtensions.ItemsSource(itemsBuilder, 1, 2, 3);
        var itemsControl = itemsBuilder.Mount();

        var items = Assert.IsType<AvaloniaList<object>>(itemsControl.ItemsSource);
        Assert.Equal(new object[] { 1, 2, 3 }, items);
    }

    [Fact]
    public void BindOneWay_Builder_Tracks_Source()
    {
        var source = new TextBlock { Text = "initial" };

        var builder = Builders.TextBlock()
            .BindOneWay(Avalonia.Controls.TextBlock.TextProperty, source, Avalonia.Controls.TextBlock.TextProperty, out IDisposable? _);

        var textBlock = builder.Mount();

        Assert.Equal("initial", textBlock.Text);

        source.Text = "updated";
        Assert.Equal("updated", textBlock.Text);
    }

    [Fact]
    public void ObjectExtensions_Self_Runs_Action()
    {
        var invoked = false;

        var block = Builders.TextBlock()
            .Self(tb =>
            {
                invoked = true;
                tb.Text = "value";
            })
            .Mount();

        Assert.True(invoked);
        Assert.Equal("value", block.Text);
    }

    [Fact]
    public void ObjectExtensions_Ref_Exposes_ElementRef()
    {
        var builder = Builders.TextBlock()
            .Text("ref-value")
            .Ref(out ElementRef<TextBlock> textRef);

        var block = builder.Mount();

        Assert.NotNull(block);
        Assert.True(textRef.IsInitialized);

        string? observed = null;
        textRef.With(tb => observed = tb.Text);
        Assert.Equal("ref-value", observed);
    }

    [Fact]
    public void Interactive_AddDisposableHandler_Works()
    {
        var clicks = 0;

        var button = Builders.Button()
            .AddDisposableHandler<Button, RoutedEventArgs>(
                Button.ClickEvent,
                (_, _) => clicks++)
            .Mount();

        button.RaiseEvent(new RoutedEventArgs(Button.ClickEvent));

        Assert.Equal(1, clicks);
    }

    [Fact]
    public void Interactive_GetObservable_Emits_Events()
    {
        var builder = Builders.Button();
        var events = builder.GetObservable<Button, RoutedEventArgs>(Button.ClickEvent);
        var raised = new List<RoutedEventArgs>();

        using var subscription = events.Subscribe(raised.Add);
        var button = builder.Mount();

        button.RaiseEvent(new RoutedEventArgs(Button.ClickEvent));

        Assert.Single(raised);
    }
}
