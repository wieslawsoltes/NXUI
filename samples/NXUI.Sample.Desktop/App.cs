using System.Reactive.Linq;
using System.Reactive.Subjects;
using Avalonia.Media;
using NXUI.HotReload;

// Hot reload quickstart:
// 1. Run `dotnet watch --project samples/NXUI.Sample.Desktop` (or press your IDE's hot reload button).
// 2. Tweak the builder below and save. NXUI captures the ElementNode tree and diffs it against the live Window.
// Troubleshooting:
// - If updates do not apply, confirm <EnableNXUIHotReload>true</EnableNXUIHotReload> is set for Debug builds.
// - Set NXUI_HOTRELOAD_DIAGNOSTICS=1 to print reconciliation summaries with property/child counts.

var clickCount = new BehaviorSubject<int>(0);

object Build() =>
    Window()
        .Title("NXUI Hot Reload")
        .Width(400)
        .Height(300)
        .Content(
            Border()
                .Padding(24)
                .Child(
                    StackPanel()
                        .Spacing(12)
                        .Children(
                            StackPanel()
                                .Spacing(4)
                                .Children(
                                    TextBlock()
                                        .FontSize(16)
                                        .Text("Hot Reload Quickstart"),
                                    TextBlock()
                                        .TextWrapping(TextWrapping.Wrap)
                                        .Text("Run `dotnet watch --project samples/NXUI.Sample.Desktop` and keep this window open while editing the fluent tree."),
                                    TextBlock()
                                        .TextWrapping(TextWrapping.Wrap)
                                        .Text("The delegate passed to HotReloadHost.Run must return ElementNode builders (do not call .Mount()).")),
                            StackPanel()
                                .Spacing(4)
                                .Children(
                                    TextBlock()
                                        .FontSize(16)
                                        .Text("Troubleshooting"),
                                    TextBlock()
                                        .TextWrapping(TextWrapping.Wrap)
                                        .Text("Nothing updates? Make sure the Debug build defines EnableNXUIHotReload and that this file imports NXUI.HotReload."),
                                    TextBlock()
                                        .TextWrapping(TextWrapping.Wrap)
                                        .Text("State resets? Give repeating controls a stable .Key() and wrap complex regions with HotReloadBoundary once generated."),
                                    TextBlock()
                                        .TextWrapping(TextWrapping.Wrap)
                                        .Text("Need more detail? Export NXUI_HOTRELOAD_DIAGNOSTICS=1 before launching to print per-reconciliation summaries.")),
                            TextBlock()
                                .FontSize(18)
                                .Text("Welcome to Avalonia + NXUI"),
                            TextBox()
                                .Text("Edit me and save to trigger hot reload."),
                            Button()
                                .Content("Click me")
                                .OnClickHandler((_, _) => clickCount.OnNext(clickCount.Value + 1)),
                            TextBlock()
                                .FontSize(16)
                                .Text(clickCount.Select(count => $"You clicked {count} times.")))));

return HotReloadHost.Run(Build, "NXUI", args);
