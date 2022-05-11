# MinimalAvalonia

[![NuGet](https://img.shields.io/nuget/v/MinimalAvalonia.svg)](https://www.nuget.org/packages/MinimalAvalonia)
[![NuGet](https://img.shields.io/nuget/dt/MinimalAvalonia.svg)](https://www.nuget.org/packages/MinimalAvalonia)

Creating minimal [Avalonia](https://avaloniaui.net/) application using C# 10 and .NET 6

https://user-images.githubusercontent.com/2297442/132313187-32f18c4b-e894-46db-9a9d-9de02f30835e.mp4

# Usage

```xml
<PackageReference Include="MinimalAvalonia" Version="0.10.13-preview.4" />
```

```C#
AppBuilder.Configure<Application>()
          .UsePlatformDetect()
          .UseFluentTheme()
          .StartWithClassicDesktopLifetime(desktop => {
              desktop.MainWindow = new Window {
                  Content = new Label { Content = "Minimal Avalonia" }
              };
          }, args);
```

```C#
AppBuilder.Configure<Application>()
          .UsePlatformDetect()
          .UseFluentTheme()
          .StartWithClassicDesktopLifetime(desktop => {
              var window = new Window { Title = "Minimal Avalonia" };
              window.Content = new TextBox { [!!TextBlock.TextProperty] = window[!!Window.TitleProperty] };
              desktop.MainWindow = window;
          }, args);
```

# Generate

```
cd Generator
dotnet run > Extensions.g.cs
copy Extensions.g.cs ../MinimalAvalonia/Extensions/Extensions.g.cs
```

# Issues

```
https://github.com/AvaloniaUI/Avalonia/pull/8114
0.10.999-cibuild0020345-beta
```
