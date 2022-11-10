# NXUI (next-gen UI)

[![NuGet](https://img.shields.io/nuget/v/NXUI.svg)](https://www.nuget.org/packages/NXUI)
[![NuGet](https://img.shields.io/nuget/dt/NXUI.svg)](https://www.nuget.org/packages/NXUI)

Creating minimal [Avalonia](https://avaloniaui.net/) next generation (NXUI, next-gen UI) application using C# 10 and .NET 6 and 7

https://user-images.githubusercontent.com/2297442/132313187-32f18c4b-e894-46db-9a9d-9de02f30835e.mp4

# Usage

```xml
<PackageReference Include="NXUI" Version="11.0.0-preview3" />
```

```C#
Window Build() => Window().Content(Label().Content("Minimal Avalonia"));

AppBuilder.Configure<Application>()
  .UsePlatformDetect()
  .UseFluentTheme()
  .StartWithClassicDesktopLifetime(Build, args);
```

```C#
var count = 0;

Window Build()
  => Window(out var window)
    .Title("NXUI").Width(400).Height(300)
    .Content(
      StackPanel()
        .Children(
          Button(out var button)
            .Content("Welcome to Avalonia, please click me!"),
          TextBox(out var tb1)
            .Text("Minimal Avalonia"),
          TextBox()
            .Text(window.BindTitle()),
          Label()
            .Content(button.ObserveOnClick().Select(_ => ++count).Select(x => $"You clicked {x} times."))))
    .Title(tb1.ObserveText().Select(x => x?.ToUpper()));

AppBuilder.Configure<Application>()
  .UsePlatformDetect()
  .UseFluentTheme()
  .WithApplicationName("NXUI")
  .StartWithClassicDesktopLifetime(Build, args);
```

# Generate

```
cd src/Generator
dotnet run -- ../NXUI/Generated
```
