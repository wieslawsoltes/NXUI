Window Build() {
    Border()
        .Background(Brushes.WhiteSmoke)
        .BorderBrush(Brushes.Black)
        .BorderThickness(2)
        .CornerRadius(4)
        .Ref(out var border);

    Button()
        .OnClick(o => o.Subscribe(_ => Debug.WriteLine("Click")))
        .Content("Button")
        .Ref(out var button);

    ContentControl()
        .Content("Content")
        .Ref(out var contentControl);

    Decorator()
        .Ref(out var decorator);

    HeaderedContentControl()
        .Ref(out var headeredContentControl);

    ItemsControl()
        .Ref(out var itemsControl);

    Label()
        .Classes("animation")
        .HorizontalAlignmentCenter().VerticalAlignmentCenter()
        .Content("Label")
        .Ref(out var label);

    Layoutable()
        .Ref(out var layoutable);

    Panel()
        .Styles(RotateAnimation(TimeSpan.FromSeconds(5), 180d, 360d))
        .Width(200).Height(200)
        .Background(Brushes.WhiteSmoke)
        .Ref(out var panel);

    StackPanel()
        .Ref(out var stackPanel);

    TabControl()
        .Items(
            TabItem().Header("TabItem1").Content("TabItem1"),
            TabItem().Header("TabItem2").Content("TabItem2"),
            TabItem().Header("TabItem3").Content("TabItem3"))
        .Ref(out var tabControl);

    TemplatedControl()
        .Ref(out var templatedControl);

    TextBlock()
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
        .TextDecorations(new TextDecorationCollection())
        .Ref(out var textBlock);

    TextBox()
        .AcceptsReturn(true)
        .AcceptsTab(true)
        .CaretIndex(0)
        .IsReadOnly(false)
        .Text("TextBox")
        .Ref(out var textBox);

    TabControl()
        .ItemsPanel(new FuncTemplate<IPanel>(StackPanel))
        .TabStripPlacementLeft()
        .Items(
            TabItem().Header("Border").Content(border),
            TabItem().Header("Button").Content(button),
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
            TabItem().Header("TextBox").Content(textBox))
        .Ref(out var controls);

    Window()
        .SizeToContentManual()
        .Title("ControlCatalog")
        .Width(800).Height(700)
        .Content(controls).Ref(out var window);

    Style()
        .Selector(x => x.OfType<Button>().Class(":pointerover").Template().OfType<ContentPresenter>().Name("PART_ContentPresenter"))
        .Setter(TemplatedControlBackground, Brushes.Red)
        .Ref(out var style1);

    Style()
        .Selector(x => x.OfType<Label>().Class("animation"))
        .Animations(
            Animation()
                .Duration(TimeSpan.FromSeconds(5))
                .IterationCountInfinite()
                .KeyFrames(
                    KeyFrame().Cue(0.0).Setter(RotateTransform.AngleProperty, 0d),
                    KeyFrame().Cue(1.0).Setter(RotateTransform.AngleProperty, 360d)))
        .Ref(out var style2);

    window.Styles(style1, style2);

#if DEBUG
    window.AttachDevTools();
#endif
    return window;
}

Style RotateAnimation(TimeSpan duration, double startAngle, double endAngle) =>
    Style()
        .Selector(x => x.Is<Control>())
        .Setter(VisualClipToBounds, false)
        .Animations(
            Animation()
                .Duration(duration)
                .IterationCountInfinite()
                .PlaybackDirectionAlternateReverse()
                .KeyFrames(
                    KeyFrame().Cue(0.0).Setter(RotateTransform.AngleProperty, startAngle),
                    KeyFrame().Cue(1.0).Setter(RotateTransform.AngleProperty, endAngle)));

AppBuilder.Configure<Application>()
    .UsePlatformDetect()
    .UseFluentTheme()
    .WithApplicationName("ControlCatalog")
    .StartWithClassicDesktopLifetime(Build, args);
