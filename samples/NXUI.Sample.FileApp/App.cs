#!/usr/local/share/dotnet/dotnet run
#:package NXUI.Desktop@12.0.0
using Avalonia.Controls;
using Avalonia.Styling;
using NXUI.HotReload;
using static NXUI.Builders;

return HotReloadHost.Run(
    () => Window().Content(Label().Content("NXUI")),
    "NXUI",
    args,
    ThemeVariant.Dark,
    ShutdownMode.OnLastWindowClose);
