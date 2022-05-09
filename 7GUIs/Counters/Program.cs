AppBuilder.Configure<Application>()
    .UsePlatformDetect()
    .UseFluentTheme()
    .StartWithClassicDesktopLifetime(desktop => {
        var counters = Enumerable.Range(0, 5).Select(i => new BehaviorSubject<int>(i));
        ItemsControl()
            .ItemTemplate(new FuncDataTemplate<BehaviorSubject<int>>((count, _) => {
                Button()
                    .OnClick(o => o.Subscribe(_ => count.OnNext(count.Value + 1)))
                    .Content("Count").Ref(out var button);
                Label()
                    .HorizontalAlignmentCenter().VerticalAlignmentCenter().MinWidth(24)
                    .Content(count.ToBinding()).Ref(out var label);
                return StackPanel()
                    .OrientationHorizontal().Spacing(12)
                    .HorizontalAlignmentCenter().VerticalAlignmentCenter()
                    .Children(label, button);
            }, true))
            .Items(counters)
            .Ref(out var itemsControl);
        Window()
            .Title("Counters")
            .Padding(12).SizeToContentManual().Width(300).Height(300)
            .Content(itemsControl).Ref(out var window);
        desktop.MainWindow = window;
    }, args);
