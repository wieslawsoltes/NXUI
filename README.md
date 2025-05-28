# NXUI (next-gen UI)

[![NuGet](https://img.shields.io/nuget/v/NXUI.svg)](https://www.nuget.org/packages/NXUI)
[![NuGet](https://img.shields.io/nuget/dt/NXUI.svg)](https://www.nuget.org/packages/NXUI)

Creating minimal [Avalonia](https://avaloniaui.net/) next generation (NXUI, next-gen UI) application using C# 10 and .NET 8

https://user-images.githubusercontent.com/2297442/132313187-32f18c4b-e894-46db-9a9d-9de02f30835e.mp4

# Requisites

### NXUI

```xml
<PackageReference Include="NXUI" Version="11.1.0" />
```

or for F# support:

```xml
<PackageReference Include="NXUI.FSharp" Version="11.1.0" />
```

Additionally, depending on the application type:

### Desktop

For Desktop extensions:
```xml
<PackageReference Include="NXUI.Desktop" Version="11.1.0" />
```
or using plain Avalonia:
```xml
<PackageReference Include="Avalonia.Desktop" Version="11.1.0" />
```

### Browser

```xml
<PackageReference Include="Avalonia.Browser" Version="11.0.0" />
```

```
dotnet workload install wasm-tools
```

# Usage

```csharp
Window Build() => Window().Content(Label().Content("NXUI"));

AppBuilder.Configure<Application>()
  .UsePlatformDetect()
  .UseFluentTheme()
  .StartWithClassicDesktopLifetime(Build, args);
```

```csharp
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
            .Text("NXUI"),
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

Minimalistic Desktop app:
```csharp
Run(
  () => Window().Content(Label().Content("NXUI")), 
  "NXUI", 
  args, 
  ThemeVariant.Dark);
```

# Generate

C#
```bash
cd src/Generator
dotnet run -- ../NXUI/Generated
```

F#
```bash
cd src/Generator
dotnet run -- ../NXUI.FSharp/Generated -fsharp
```

# dotnet run app.cs

Using .NET 10 you can run GUI apps using scripts: https://devblogs.microsoft.com/dotnet/announcing-dotnet-run-app/#using-shebang-lines-for-shell-scripts

Note: You might need to adjust shebang line to `#!/usr/bin/dotnet run`

App.cs
```csharp
#!/usr/local/share/dotnet/dotnet run
#:package NXUI.Desktop@11.1.0.1
NXUI.Desktop.NXUI.Run(
    () => Window().Content(Label().Content("NXUI")), 
    "NXUI", 
    args, 
    ThemeVariant.Dark,
    ShutdownMode.OnLastWindowClose);
```

```bash
chmod +x App.cs
./App.cs
```

![image](https://github.com/user-attachments/assets/33f7f915-13a2-4c45-b9e3-ecd5dfdfd353)

More complex app:

```csharp
#!/usr/local/share/dotnet/dotnet run
#:package NXUI.Desktop@11.1.0.1

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
                        .Text("NXUI"),
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

![image](https://github.com/user-attachments/assets/6dfea182-9725-4904-a201-b9c48aea2915)

