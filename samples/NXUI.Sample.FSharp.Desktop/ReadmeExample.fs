module ReadmeExample

open Avalonia
open Avalonia.Controls
open NXUI.Extensions
open NXUI.HotReload
open NXUI.HotReload.Nodes
open type NXUI.Builders

let Run argv =
    let mutable count = 0
    let mutable window = Unchecked.defaultof<ElementRef<Window>>
    let mutable button = Unchecked.defaultof<ElementRef<Button>>
    let mutable tb1 = Unchecked.defaultof<ElementRef<TextBox>>

    let Build () : obj =
        Window(&window)
            .Title("NXUI")
            .Width(400)
            .Height(300)
            .Content(
                StackPanel()
                    .Children(
                        Button(&button).Content("Welcome to Avalonia, please click me!"),
                        TextBox(&tb1).Text("NXUI"),
                        TextBox().Text(window.ObserveTitle()),
                        Label()
                            .Content(
                                button.ObserveEvent(Button.ClickEvent)
                                |> Observable.map (fun _ ->
                                    count <- count + 1
                                    count)
                                |> Observable.map (fun x -> $"You clicked {x} times.")
                                |> _.ToBinding()
                            )
                    )
            )
            .Title(tb1.ObserveText())
        |> box

    HotReloadHost.Run(Build, "NXUI", argv)
