Window Build() => Window().Content(Label().Content("Minimal Avalonia"));

AppBuilder.Configure<Application>()
          .UsePlatformDetect()
          .UseFluentTheme()
          .StartWithClassicDesktopLifetime(Build, args);
