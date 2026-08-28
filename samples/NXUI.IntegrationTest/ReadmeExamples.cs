internal static class ReadmeExamples
{
    public static int Run(string[] args)
    {
        var sampleName = args.FirstOrDefault()?.ToLowerInvariant();
        var sampleArgs = args.Skip(1).ToArray();

        return sampleName switch
        {
            "reactive" => RunReactive(sampleArgs),
            "mounted" => RunMounted(sampleArgs),
            "minimalistic" => RunMinimalistic(sampleArgs),
            "file-app" => RunFileApp(sampleArgs),
            "file-app-reactive" => RunReactive(sampleArgs),
            "hot-reload" => RunHotReload(sampleArgs),
            _ => RunMinimal(args),
        };
    }

    private static int RunMinimal(string[] args)
    {
        object Build() =>
            Window()
                .Title("NXUI")
                .Content(Label().Content("NXUI"));

        return HotReloadHost.Run(Build, "NXUI", args);
    }

    private static int RunReactive(string[] args)
    {
        var count = 0;

        object Build()
            => Window(out var window)
                .Title("NXUI").Width(400).Height(300)
                .Content(
                    StackPanel()
                        .Children(
                            Button(out var button)
                                .Content("Welcome to Avalonia, please click me!"),
                            TextBox(out var tb1)
                                .Text("NXUI"),
                            TextBox()
                                .Text(window.ObserveTitle()),
                            Label()
                                .Content(
                                    button
                                        .ObserveEvent(Avalonia.Controls.Button.ClickEvent)
                                        .Select(_ => ++count)
                                        .Select(x => $"You clicked {x} times."))))
                .Title(tb1.ObserveText().Select(x => x?.ToUpper()));

        return HotReloadHost.Run(Build, "NXUI", args);
    }

    private static int RunMounted(string[] args)
    {
        Window Build()
            => Window()
                .Title("NXUI")
                .Content(Label().Content("NXUI"))
                .Mount();

        return AppBuilder.Configure<Application>()
            .UsePlatformDetect()
            .UseFluentTheme()
            .StartWithClassicDesktopLifetime(Build, args);
    }

    private static int RunMinimalistic(string[] args)
    {
        return HotReloadHost.Run(
            () => Window().Content(Label().Content("NXUI")),
            "NXUI",
            args,
            ThemeVariant.Dark);
    }

    private static int RunFileApp(string[] args)
    {
        return HotReloadHost.Run(
            () => Window().Content(Label().Content("NXUI")),
            "NXUI",
            args,
            ThemeVariant.Dark,
            ShutdownMode.OnLastWindowClose);
    }

    private static int RunHotReload(string[] args)
    {
        object Build() =>
            Window()
                .Title("NXUI Hot Reload")
                .Content(Label().Content("Edit a file and save to trigger hot reload."));

        return HotReloadHost.Run(Build, "SampleApp", args);
    }
}
