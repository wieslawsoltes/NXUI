using Avalonia.Styling;
using NXUI.HotReload;

object Build() => Window().Content(Label().Content("NXUI"));

return HotReloadHost.Run(Build, "NXUI Integration Test", args, ThemeVariant.Dark);
