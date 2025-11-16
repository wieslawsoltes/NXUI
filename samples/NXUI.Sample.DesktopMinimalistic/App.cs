using Avalonia.Styling;
using NXUI.HotReload;

// Minimal hot reload template:
// - Run `dotnet watch --project samples/NXUI.Sample.DesktopMinimalistic`.
// - Keep returning ElementBuilder nodes (avoid calling .Mount()) so diff/patch can reuse controls.
// - Export NXUI_HOTRELOAD_DIAGNOSTICS=1 to inspect reconciliation summaries when troubleshooting.

object Build() =>
    Window()
        .Title("NXUI Minimal")
        .Width(300)
        .Height(200)
        .Content(
            Label()
                .HorizontalAlignmentCenter()
                .VerticalAlignmentCenter()
                .Content("NXUI"));

return HotReloadHost.Run(Build, "NXUI", args, ThemeVariant.Dark);
