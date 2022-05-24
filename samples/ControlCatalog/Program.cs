Window Build() {
    Border(out var border)
        .Background(Brushes.WhiteSmoke)
        .BorderBrush(Brushes.Black)
        .BorderThickness(2)
        .CornerRadius(4);

    Button(out var button)
        .OnClick((_, o) => o.Subscribe(_ => Debug.WriteLine("Click")))
        .Content("Button");

    Canvas(out var canvas)
        .Background(Brushes.WhiteSmoke)
        .Children(
            Rectangle().Fill(Brushes.Blue).Width(50).Height(50).Left(50).Top(50),
            Ellipse().Fill(Brushes.Red).Width(50).Height(50).Left(150).Top(50));

    ContentControl(out var contentControl)
        .Content("Content");

    Decorator(out var decorator)
        .Child(
            TextBox().Text("Child"))
        .Padding(4);

    HeaderedContentControl()
        .Ref(out var headeredContentControl);

    ItemsControl()
        .Ref(out var itemsControl);

    Label(out var label)
        .Classes("animation")
        .HorizontalAlignmentCenter().VerticalAlignmentCenter()
        .Content("Label");

    Layoutable()
        .Ref(out var layoutable);

    Panel(out var panel)
        .Styles(RotateAnimation(TimeSpan.FromSeconds(5), 180d, 360d))
        .Width(200).Height(200)
        .Background(Brushes.WhiteSmoke);

    StackPanel(out var stackPanel)
        .Spacing(4)
        .OrientationVertical()
        .Children(
            TextBlock().Text("Child 1"),
            TextBlock().Text("Child 2"),
            TextBlock().Text("Child 3"));

    TabControl(out var tabControl)
        .Items(
            TabItem().Header("TabItem1").Content("TabItem1"),
            TabItem().Header("TabItem2").Content("TabItem2"),
            TabItem().Header("TabItem3").Content("TabItem3"));

    TemplatedControl()
        .Ref(out var templatedControl);

    TextBlock(out var textBlock)
        .Background(Brushes.WhiteSmoke)
        .Padding(4)
        .FontFamily(FontFamily.Default)
        .FontSize(12)
        .FontStyle(FontStyle.Normal)
        .FontWeight(FontWeight.Normal)
        .Foreground(Brushes.Black)
        .LineHeight(double.NaN)
        .MaxLines(0)
        .Text("TextBlock")
        .TextAlignment(TextAlignment.Left)
        .TextWrapping(TextWrapping.NoWrap)
        .TextTrimming(TextTrimming.None)
        .TextDecorations(new TextDecorationCollection());

    TextBox(out var textBox)
        .AcceptsReturn(true)
        .AcceptsTab(true)
        .CaretIndex(0)
        .IsReadOnly(false)
        .FontFamily(FontFamily.Default)
        .FontSize(12)
        .FontStyle(FontStyle.Normal)
        .FontWeight(FontWeight.Normal)
        .Foreground(Brushes.Black)
        .Text("TextBox");

    Style(out var tabControlStyle)
        .Selector(x => x.OfType<TabControl>().Class("tabControl"))
        .SetTemplatedControlTemplate<TabControl>((parent, scope) => 
            Border()
                .BorderBrush(parent.BindBorderBrush())
                .BorderThickness(parent.BindBorderThickness())
                .CornerRadius(parent.BindCornerRadius())
                .Background(parent.BindBackground())
                .HorizontalAlignment(parent.BindHorizontalAlignment())
                .VerticalAlignment(parent.BindVerticalAlignment())
                .Child(
                    DockPanel().Children(
                        ScrollViewer().Content(
                            ItemsPresenter().Name("PART_ItemsPresenter", scope)
                                .Items(parent.BindItems())
                                .ItemsPanel(parent.BindItemsPanel())
                                .ItemTemplate(parent.BindItemTemplate())
                                .Dock(parent.BindTabStripPlacement())
                            ),
                        ContentPresenter().Name("PART_SelectedContentHost", scope)
                            .Margin(parent.BindPadding())
                            .HorizontalContentAlignment(parent.BindHorizontalContentAlignment())
                            .VerticalContentAlignment(parent.BindVerticalContentAlignment())
                            .Content(parent.BindSelectedContent())
                            .ContentTemplate(parent.BindSelectedContentTemplate())
                        )
                    )
            );

    TabControl(out var controls)
        .ItemsPanel(new FuncTemplate<IPanel>(StackPanel))
        .TabStripPlacementLeft()
        .Classes("tabControl")
        .Items(
            TabItem().Header("Border").Content(border),
            TabItem().Header("Button").Content(button),
            TabItem().Header("Canvas").Content(canvas),
            TabItem().Header("ContentControl").Content(contentControl),
            TabItem().Header("Decorator").Content(decorator),
            TabItem().Header("HeaderedContentControl").Content(headeredContentControl),
            TabItem().Header("ItemsControl").Content(itemsControl),
            TabItem().Header("Label").Content(label),
            TabItem().Header("Layoutable").Content(layoutable),
            TabItem().Header("Panel").Content(panel),
            TabItem().Header("StackPanel").Content(stackPanel),
            TabItem().Header("TabControl").Content(tabControl),
            TabItem().Header("TemplatedControl").Content(templatedControl),
            TabItem().Header("TextBlock").Content(textBlock),
            TabItem().Header("TextBox").Content(textBox));

    Window(out var window)
        .SizeToContentManual()
        .Title("ControlCatalog")
        .Width(800).Height(700)
        .Content(controls);

    Style(out var style1)
        .Selector(x => x.OfType<Button>().Class(":pointerover").Template().OfType<ContentPresenter>().Name("PART_ContentPresenter"))
        .SetTemplatedControlBackground(Brushes.Red);

    Style(out var style2)
        .Selector(x => x.OfType<Label>().Class("animation"))
        .Animations(
            Animation()
                .Duration(TimeSpan.FromSeconds(5))
                .IterationCountInfinite()
                .KeyFrames(
                    KeyFrame().Cue(0.0).SetRotateTransformAngle(0d),
                    KeyFrame().Cue(1.0).SetRotateTransformAngle(360d)));

    window.Styles(tabControlStyle, style1, style2, InteractionStyle());

#if DEBUG
    window.AttachDevTools();
#endif
    return window;
}

Style InteractionStyle() {
    return Style()
        .Selector(x => x.Is<IControl>())
#if true
        .SetInteractionBehavior<CustomBehavior>();
#else
        .SetInteractionBehavior(() => new CustomBehavior(), () => new CustomBehavior());
#endif
}

Style RotateAnimation(TimeSpan duration, double startAngle, double endAngle) =>
    Style()
        .Selector(x => x.Is<Control>())
        .SetVisualClipToBounds(false)
        .Animations(
            Animation()
                .Duration(duration)
                .IterationCountInfinite()
                .PlaybackDirectionAlternateReverse()
                .KeyFrames(
                    KeyFrame().Cue(0.0).SetRotateTransformAngle(startAngle),
                    KeyFrame().Cue(1.0).SetRotateTransformAngle(endAngle)));

AppBuilder.Configure<Application>()
    .UsePlatformDetect()
    .UseFluentTheme()
    .WithApplicationName("ControlCatalog")
    .StartWithClassicDesktopLifetime(Build, args);

internal class CustomBehavior : Behavior
{
    protected override void OnAttached() => Debug.WriteLine($"OnAttached() {AssociatedObject}");
    protected override void OnDetaching() => Debug.WriteLine($"OnDetaching() {AssociatedObject}");
    protected override void OnAttachedToVisualTree() => Debug.WriteLine($"OnAttachedToVisualTree() {AssociatedObject}");
    protected override void OnDetachedFromVisualTree() => Debug.WriteLine($"OnDetachedFromVisualTree() {AssociatedObject}");
}
