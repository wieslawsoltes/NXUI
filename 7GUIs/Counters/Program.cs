AppBuilder.Configure<Application>()
    .UsePlatformDetect()
    .UseFluentTheme()
    .StartWithClassicDesktopLifetime(desktop => {
        var counters = Enumerable.Range(0, 5).Select(i => new BehaviorSubject<int>(i));
        new ItemsControl()
            .ItemTemplate(new FuncDataTemplate<BehaviorSubject<int>>((count, _) => {
                new Button()
                    .OnClick(o => o.Subscribe(_ => count.OnNext(count.Value + 1)))
                    .Content("Count").Ref(out var button);
                new Label()
                    .HorizontalAlignmentCenter().VerticalAlignmentCenter()
                    .Content(count.ToBinding()).Ref(out var label);
                return new StackPanel()
                    .OrientationHorizontal().Spacing(12)
                    .HorizontalAlignmentCenter().VerticalAlignmentCenter()
                    .Children(label, button);
            }, true))
            .Items(counters)
            .Ref(out var itemsControl);
        new Window()
            .Title("Counter")
            .Padding(12).SizeToContentManual().Width(300).Height(300)
            .Content(itemsControl).Ref(out var window);
        desktop.MainWindow = window;
    }, args);
