AppBuilder.Configure<Application>()
    .UsePlatformDetect()
    .UseFluentTheme()
    .StartWithClassicDesktopLifetime(desktop => {
        var count = new BehaviorSubject<int>(0);
        new Button()
            .OnClick(o => o.Subscribe(_ => count.OnNext(count.Value + 1)))
            .Content("Count")
            .Ref(out var button);
        new Label()
            .HorizontalAlignmentCenter()
            .VerticalAlignmentCenter()
            .Content(count.ToBinding())
            .Ref(out var label);
        new StackPanel()
            .OrientationHorizontal()
            .Spacing(12)
            .HorizontalAlignmentCenter()
            .VerticalAlignmentCenter()
            .Children(label, button)
            .Ref(out var stackPanel);
        new Window()
            .Title("Counter")
            .Padding(12)
            .SizeToContentManual()
            .Width(300)
            .Height(200)
            .Content(stackPanel)
            .Ref(out var window);
        desktop.MainWindow = window;
    }, args);
