#!/usr/local/share/dotnet/dotnet run
#:package NXUI.Desktop@12.0.0
using NXUI.HotReload;
using static NXUI.Builders;

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
