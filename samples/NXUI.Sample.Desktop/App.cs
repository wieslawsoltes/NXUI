var clickCount = new BehaviorSubject<int>(0);

return HotReloadHost.Run(BuildWindow, "NXUI", args);

object BuildWindow() =>
  Window()
    .Title("NXUI Hot Reload").Width(400).Height(340).Content(BuildView());

object BuildView() =>
  Border().Padding(24).Child(
    StackPanel().Spacing(12)
      .Children(
        TextBlock()
          .FontSize(18)
          .Text("Welcome to Avalonia + NXUI"),
        TextBox()
          .Text("Edit me and save to trigger hot reload."),
        Slider(out var slider)
          .Minimum(0)
          .Maximum(100)
          .Value(50),
        TextBox()
          .Text(slider.ObserveEvent(RangeBase.ValueChangedEvent).Select(args => $"Current value (event): {args.NewValue:F0}")),
        TextBox()
          .Text(slider.ObserveValue().Select(value => $"Current value (property): {value:F0}")),
        ProgressBar()
          .Minimum(0)
          .Maximum(100)
          .Value(slider.Bind(RangeBase.ValueProperty), BindingMode.OneWay),
        Button()
          .Content("Click Me")
          .OnClickHandler((_, _) => clickCount.OnNext(clickCount.Value + 1)),
        TextBlock()
          .FontSize(16)
          .Text(clickCount.Select(count => $"You clicked {count} times."))));
