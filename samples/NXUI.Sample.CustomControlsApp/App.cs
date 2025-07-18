using Avalonia;
using Avalonia.Controls;
using Avalonia.Media;
using NXUI;
using NXUI.Extensions;
using NXUI.Sample.CustomControls;

var user = new MyUserControl();

Window Build() =>
    Window()
        .Title("Custom Controls")
        .Width(400)
        .Height(300)
        .Content(
            StackPanel()
                .Children(
                    new ColoredBox { BoxFill = Brushes.Blue },
                    user));

NXUI.Desktop.NXUI.Run(Build, "NXUI Custom Controls", args);
