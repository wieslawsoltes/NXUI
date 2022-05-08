// using static MinimalAvalonia.MinimalAvalonia;

AppBuilder.Configure<Application>()
    .UsePlatformDetect()
    .UseFluentTheme()
    .WithApplicationName("ControlCatalog")
    .StartWithClassicDesktopLifetime(desktop =>
    {
        new Border()
            .Background(Brushes.WhiteSmoke)
            .BorderBrush(Brushes.Black)
            .BorderThickness(2)
            .CornerRadius(4)
            .Ref(out var border);

        new Button()
            .OnClick(o => o.Subscribe(_ => Debug.WriteLine("Click")))
            .Content("Button")
            .Ref(out var button);

        // button[Button.BackgroundProperty] = Brushes.Red;

        new ContentControl()
            .Content("Content")
            .Ref(out var contentControl);

        new Decorator()
            .Ref(out var decorator);

        new HeaderedContentControl()
            .Ref(out var headeredContentControl);

        new ItemsControl()
            .Ref(out var itemsControl);

        new Label()
            .Content("Label")
            .Ref(out var label);

        new Layoutable()
            .Ref(out var layoutable);

        new Panel()
            .Background(Brushes.WhiteSmoke)
            .Ref(out var panel);

        new StackPanel()
            .Ref(out var stackPanel);

        new TabControl()
            .Items(
                new TabItem().Header("TabItem1").Content("TabItem1"),
                new TabItem().Header("TabItem2").Content("TabItem2"),
                new TabItem().Header("TabItem3").Content("TabItem3"))
            .Ref(out var tabControl);

        new TemplatedControl()
            .Ref(out var templatedControl);

        new TextBlock()
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

        new TextBox()
            .AcceptsReturn(true)
            .AcceptsTab(true)
            .CaretIndex(0)
            .IsReadOnly(false)
            .Text("TextBox")
            .Ref(out var textBox);

        new TabControl()
            .ItemsPanel(new FuncTemplate<IPanel>(() => new StackPanel()))
            .TabStripPlacementLeft()
            .Items(
                new TabItem().Header("Border").Content(border),
                new TabItem().Header("Button").Content(button),
                new TabItem().Header("ContentControl").Content(contentControl),
                new TabItem().Header("Decorator").Content(decorator),
                new TabItem().Header("HeaderedContentControl").Content(headeredContentControl),
                new TabItem().Header("ItemsControl").Content(itemsControl),
                new TabItem().Header("Label").Content(label),
                new TabItem().Header("Layoutable").Content(layoutable),
                new TabItem().Header("Panel").Content(panel),
                new TabItem().Header("StackPanel").Content(stackPanel),
                new TabItem().Header("TabControl").Content(tabControl),
                new TabItem().Header("TemplatedControl").Content(templatedControl),
                new TabItem().Header("TextBlock").Content(textBlock),
                new TabItem().Header("TextBox").Content(textBox))
            .Ref(out var controls);

        new Window()
            .SizeToContentManual()
            .Title("ControlCatalog")
            .Width(800).Height(700)
            .Content(controls).Ref(out var window);

        new Style()
            .Selector(x => x.OfType<Button>().Class(":pointerover").Template().OfType<ContentPresenter>().Name("PART_ContentPresenter"))
            .Setter(TemplatedControl.BackgroundProperty, Brushes.Red)
            .Ref(out var style2);

        window.Styles.Add(style2);

        desktop.MainWindow = window;
    }, args);
