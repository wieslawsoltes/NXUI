open System.Reactive.Subjects
open Avalonia
open Avalonia.Controls
open Avalonia.Media
open Avalonia.Styling
open NXUI.Extensions
open NXUI.HotReload

let buttons(counter: BehaviorSubject<int>) =
    
    let increment =
        Button()
            .Content("Increment")
            .HorizontalAlignmentCenter()
            .OnClick(fun _ observable ->
                observable |> Observable.add(fun _ -> counter.OnNext(counter.Value + 1))
            )

    let reset =
        Button()
            .Content("Reset")
            .HorizontalAlignmentCenter()
            .OnClick(fun _ observable ->
                observable |> Observable.add(fun _ -> counter.OnNext 0)
            )
    
    let decrement =
        Button()
            .Content("Decrement")
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
        .Children(
            TextBlock()
                .TextWrapping(TextWrapping.Wrap)
                .Text("Run `dotnet watch --project samples/NXUI.Sample.FSharp.Desktop` to see hot reload in action. Missing updates typically mean the project was built without EnableNXUIHotReload set to true.")
                .DockTop(),
            TextBlock()
                .Text(counterText |> _.ToBinding())
                .DockTop(),
            decrement.DockBottom(),
            reset.DockBottom(),
            increment.DockBottom()
        )

let Build () : obj =
    Window()
        .Title("Hello NXUI From F#")
        .Height(400)
        .Width(400)
        .FontFamily("Fira Code,Cascadia Code,Consolas,Monospace")
        .Content(counter())
    |> box

[<EntryPoint>]
let main argv =
    HotReloadHost.Run(Build, "NXUI F# Demo", argv, ThemeVariant.Dark)
