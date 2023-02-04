Window Build() => Window().Content(Label().Content("NXUI"));

AppBuilder.Configure<Application>()
  .UsePlatformDetect()
  .UseFluentTheme(ThemeVariant.Dark)
  .StartWithClassicDesktopLifetime(Build, args);
