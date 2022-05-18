var count = 0;

Window Build()
    => Window(out var window)
        .Title("MinimalAvalonia")
        .Content(
            StackPanel()
                .Children(
                    Button(out var button)
                        .Content("Welcome to Avalonia, please click me!"),
                    TextBox(out var tb1)
                        .Text("Minimal Avalonia"),
                    TextBox()
                        .Text(window.BindTitle()),
                    TextBlock()
                        .Text(button.ObserveOnClick().Select(_ => ++count).Select(x => $"You clicked {x} times."))))
        .Title(tb1.ObserveText().Select(x => x?.ToUpper()));

ConsoloniaApp.Start(args, Build);
