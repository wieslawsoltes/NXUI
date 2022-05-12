AppBuilder.Configure<Application>()
    .UsePlatformDetect()
    .UseFluentTheme()
    .StartWithClassicDesktopLifetime(desktop => {
        var counters = Enumerable.Range(0, 5).Select(i => new BehaviorSubject<int>(i));
        Window(out var window)
            .Title("Counters")
            .Padding(12).SizeToContentManual().Width(300).Height(300)
            .Content(
                ItemsControl()
                    .ItemTemplate(new FuncDataTemplate<BehaviorSubject<int>>((count, _) => {
                        Button(out var button)
                            .OnClick(o => o.Subscribe(_ => count.OnNext(count.Value + 1)))
                            .Content("Count");
                        Label(out var label)
                            .HorizontalAlignmentCenter().VerticalAlignmentCenter().MinWidth(24)
                            .Content(count.ToBinding());
                        return StackPanel()
                            .OrientationHorizontal().Spacing(12)
                            .HorizontalAlignmentCenter().VerticalAlignmentCenter()
                            .Children(label, button);
                    }, true))
                    .Items(counters));
        desktop.MainWindow = window;
    }, args);
