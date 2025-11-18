var clickCount = new BehaviorSubject<int>(0);

object Build() =>
  Window()
    .Title("NXUI Hot Reload").Width(400).Height(300).Content(
      Border().Padding(24)
        .Child(
          StackPanel().Spacing(12)
            .Children(
              TextBlock()
                .FontSize(18)
                .Text("Welcome to Avalonia + NXUI"),
              TextBox()
                .Text("Edit me and save to trigger hot reload."),
              Button()
                .Content("Click Me")
                .OnClickHandler((_, _) => clickCount.OnNext(clickCount.Value + 1)),
              TextBlock()
                .FontSize(16)
                .Text(clickCount.Select(count => $"You clicked {count} times.")))));

return HotReloadHost.Run(Build, "NXUI", args);
