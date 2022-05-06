﻿AppBuilder.Configure<Application>()
    .UsePlatformDetect()
    .UseFluentTheme()
    .StartWithClassicDesktopLifetime(desktop => {
        var count = 0;
        new Button()
            .Content("Count")
            .OnClick(o => o.Subscribe(_ => Debug.WriteLine($"Click {count}")))
            .Ref(out var button);
        new Label()
            .Content(count)
            .Content(button.OnClick().Select(_ => ++count).ToBinding())
            .HorizontalAlignmentCenter()
            .VerticalAlignmentCenter()
            .Ref(out var label);
        new StackPanel()
            .Children(label, button)
            .OrientationHorizontal()
            .Spacing(12)
            .HorizontalAlignmentCenter()
            .VerticalAlignmentCenter().Ref(out var stackPanel);
        new Window()
            .Content(stackPanel)
            .Title("Counter")
            .Padding(12)
            .SizeToContentManual()
            .Width(300)
            .Height(200)
            .Ref(out var window);
        desktop.MainWindow = window;
    }, args);