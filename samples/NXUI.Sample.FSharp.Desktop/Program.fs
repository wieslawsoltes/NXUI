open System.Reactive.Subjects

open Avalonia
open Avalonia.Controls
open Avalonia.Controls.Presenters
open Avalonia.Data
open Avalonia.Media
open Avalonia.Styling

open NXUI.Extensions
open NXUI.FSharp.Extensions

let buttons(counter: BehaviorSubject<int>) =
    
    let increment =
        Button()
            .width(75.)
            .content("Increment")
            .HorizontalAlignmentCenter()
            .OnClick(fun _ observable ->
                observable |> Observable.add(fun _ -> counter.OnNext(counter.Value + 1))
            )

    let reset =
        Button()
            .width(75.)
            .content("Reset")
            .HorizontalAlignmentCenter()
            .OnClick(fun _ observable ->
                observable |> Observable.add(fun _ -> counter.OnNext 0)
            )
    
    let decrement =
        Button()
            .content("Decrement")
            .HorizontalAlignmentCenter()
            .OnClick(fun _ observable ->
                observable |> Observable.add(fun _ -> counter.OnNext(counter.Value - 1))
            )

    increment, reset, decrement

let counter() =
    let counter = new BehaviorSubject<int>(0)
    
    let counterText = counter |> Observable.map(fun value -> $"Count: {value}")

    let increment, reset, decrement = buttons counter

    DockPanel()
        .HorizontalAlignmentCenter()
        .VerticalAlignmentCenter()
        .children(
            TextBlock()
                .text(counterText, BindingMode.OneWay)
                .DockTop(),
            decrement.DockBottom(),
            reset.DockBottom(),
            increment.DockBottom()
        )

let Build () =
    Window()
        .title("Hello NXUI From F#")
        .height(400)
        .width(400)
        .fontFamily("Fira Code,Cascadia Code,Consolas,Monospace")
        .content(counter())

[<EntryPoint>]
let main argv = 
    AppBuilder.Configure<Application>()
      .UsePlatformDetect()
      .UseFluentTheme(ThemeVariant.Dark)
      .WithApplicationName("NXUI F# Demo")
      .StartWithClassicDesktopLifetime(Build, argv);
