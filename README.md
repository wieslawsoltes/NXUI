# NXUI (next-gen UI)

[![NuGet](https://img.shields.io/nuget/v/NXUI.svg)](https://www.nuget.org/packages/NXUI)
[![NuGet](https://img.shields.io/nuget/dt/NXUI.svg)](https://www.nuget.org/packages/NXUI)

Creating minimal [Avalonia](https://avaloniaui.net/) next generation (NXUI, next-gen UI) application using C# 10 and .NET 8

https://user-images.githubusercontent.com/2297442/132313187-32f18c4b-e894-46db-9a9d-9de02f30835e.mp4

# Requisites

### NXUI

```xml
<PackageReference Include="NXUI" Version="11.3.0" />
```

Additionally, depending on the application type:

### Desktop

For Desktop extensions:
```xml
<PackageReference Include="NXUI.Desktop" Version="11.3.0" />
```
or using plain Avalonia:
```xml
<PackageReference Include="Avalonia.Desktop" Version="11.3.0" />
```

### Browser

```xml
<PackageReference Include="Avalonia.Browser" Version="11.3.0" />
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
#:package NXUI.Desktop@11.3.0
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
#:package NXUI.Desktop@11.3.0

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

## F# Support

From F# 9.0 and above the compiler resolves [extension methods instead of instrinsic properties](https://github.com/dotnet/fsharp/pull/16032) so, there's no need for a separate F# package or any additional changes to your project files.

Extension methods provided by the main package `NXUI`

```fsharp
open Avalonia
open Avalonia.Controls

open NXUI.Extensions
open NXUI.Desktop
open type NXUI.Builders

let Build () =
    let mutable count = 0
    let mutable window = Unchecked.defaultof<Window>
    let mutable button = Unchecked.defaultof<Button>
    let mutable tb1 = Unchecked.defaultof<TextBox>

    Window(window)
        .Title("NXUI")
        .Width(400)
        .Height(300)
        .Content(
            StackPanel()
                .Children(
                    Button(button).Content("Welcome to Avalonia, please click me!"),
                    TextBox(tb1).Text("NXUI"),
                    TextBox().Text(window.BindTitle()),
                    Label()
                        .Content(
                            button.ObserveOnClick()
                            |> Observable.map (fun _ ->
                                count <- count + 1
                                count)
                            |> Observable.map (fun x -> $"You clicked {x} times.")
                            |> _.ToBinding()
                        )
                )
        )
        .Title(tb1.ObserveText())

[<EntryPoint>]
let Main argv = NXUI.Run(Build, "NXUI", argv)
```

> ### F# 8.0 Support
>
> The compiler feature is available in the .NET9 SDK and above so even if you target a lower dotnet version you don't need to change your project files.
>
> However, if you must to use the .NET8 SDK you only need to set the language version to preview
> In your \*.fsproj project and you'll get the same benefits.
>
> ```xml
> <PropertyGroup>
>     <TargetFramework>net8.0</TargetFramework>
>     <LangVersion>preview</LangVersion>
> </PropertyGroup>
> ```

## Extensions

NXUI ships with a rich set of extension methods and builder helpers so that all
UI composition can be expressed in C#.  The code generator produces most of
these members for every Avalonia control and property.

### Builders

`NXUI.Builders` exposes factory methods for every control type.  Each method
creates the control instance and overloads let you capture it via `out var` for
later use.

### Property helpers

For each Avalonia property the following methods are generated:

* **`<Name>(value)`** – set the property value.
* **`<Name>(IBinding, mode, priority)`** – bind with an Avalonia binding.
* **`<Name>(IObservable<T>, mode, priority)`** – bind from an observable.
* **`Bind<Name>(mode, priority)`** – create a binding descriptor.
* **`Observe<Name>()`** – observable of property values.
* **`On<Name>(handler)`** – pass the observable to a handler.
* **`ObserveBinding<Name>()`** – observe binding values including errors.
* **`OnBinding<Name>(handler)`** – receive the binding observable.
* **`Observe<Name>Changed()`** – observe full change events.
* **`On<Name>Changed(handler)`** – handler for change observable.

Enum properties get convenience methods for each enum value, e.g.
`HorizontalAlignmentCenter()`.

### Event helpers

For routed and CLR events:

* **`ObserveOn<EventName>(routes)`** – returns an `IObservable` sequence.
* **`On<EventName>(handler, routes)`** – handler receiving the observable.
* **`On<EventName>Handler(action, routes)`** – attach a simple callback.

### Style setters

`Set<ClassName><PropertyName>` methods on `Style` and `KeyFrame` let you define
style values using constants, bindings or observables.

### Core runtime helpers

`NXUI.Extensions.AvaloniaObjectExtensions` provides `BindOneWay` and
`BindTwoWay` to link properties or observables without verbose binding code.

`NXUI.Extensions.ReactiveObservableExtensions` adds utilities for reactive
workflows:

- `ObserveOnUiThread` / `SubscribeOnUiThread`
- `TakeUntilDetachedFromVisualTree` / `SubscribeUntilDetached`
- `DisposeWith`
- `DataTemplate<T>`
- `WhenAnyValue` (single or multiple expressions)

Together these extensions enable complex, reactive UIs built entirely in code
while managing resources with minimal overhead.

## Hot Reload

### Enable NXUI Hot Reload

1. **Opt in via MSBuild** – add `<EnableNXUIHotReload>true</EnableNXUIHotReload>` to the project or `Directory.Build.props`. Debug builds keep the flag on; disable it explicitly in Release if you do not want the runtime shipped.
2. **Run through the host** – wrap your entry point with `HotReloadHost.Run` so NXUI can register the component and reconcile live instances:

   ```csharp
   using NXUI.HotReload;

   object Build() =>
       Window()
           .Title("NXUI Hot Reload")
           .Content(Label().Content("Edit a file and save to trigger hot reload."));

   return HotReloadHost.Run(Build, "SampleApp", args);
   ```

3. **Use `dotnet watch` or IDE hot reload** – the runtime listens for metadata updates and calls `NodeRenderer.Reconcile` with the previous node snapshot. The window stays mounted and control state (e.g., `TextBox.Text`) survives.
4. **Turn on diagnostics when needed** – set `NXUI_HOTRELOAD_DIAGNOSTICS=1` to see per-reconciliation summaries, including counts for property sets, child add/remove/move operations, and replacements.

### Troubleshooting

- **No updates apply** – ensure the assembly was built with `EnableNXUIHotReload` and that you are returning an `ElementNode` tree (not `.Mount()`ed controls) from the delegate passed to `HotReloadHost.Run`.
- **State resets on list changes** – provide explicit `.Key("stable-id")` for repeating builders or wrap complex containers with `.HotReloadBoundary()` so the diff engine can reason about reuse. See `docs/hot-reload-best-practices.md` for patterns.
- **Bindings/events stop firing** – check analyzer warnings (see `NXUI.Analyzers`) and confirm you are not instantiating Avalonia controls manually when the hot reload flag is enabled.
- **Layout thrash during updates** – enable diagnostics to ensure excessive replacements are not happening; large replace counts often mean missing keys or boundaries.

### Release Builds

- Release builds can keep `<EnableNXUIHotReload>false</EnableNXUIHotReload>` and rely on trimming: `NXUI` ships `ILLink` descriptors that only root `NXUI.HotReload.*` namespaces when the flag is `true`, so `dotnet publish -c Release -p:PublishTrimmed=true` removes the runtime automatically.
- When you need hot reload in a trimmed build (e.g., diagnostic channels), set the property to `true` before publishing so the `RuntimeHostConfigurationOption` injected by `NXUI.props` keeps the runtime reachable.

### Further Reading

- `docs/hot-reload-architecture.md` – end-to-end design.
- `docs/hot-reload-implementation-plan.md` – milestone tracking.
- `docs/hot-reload-best-practices.md` – guidance for `Key()` and `HotReloadBoundary()` usage.
