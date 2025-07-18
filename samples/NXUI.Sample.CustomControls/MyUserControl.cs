using Avalonia.Controls;
using Avalonia.Media;
using NXUI;
using NXUI.Extensions;

namespace NXUI.Sample.CustomControls;

public class MyUserControl : UserControl
{
    public MyUserControl()
    {
        var box = new ColoredBox { BoxFill = Brushes.Green };
        var button = Builders.Button();

        button.Content("Toggle Color")
            .OnClickHandler((_, __) =>
            {
                box.BoxFill = box.BoxFill == Brushes.Green ? Brushes.Red : Brushes.Green;
            });

        Content = Builders.StackPanel()
            .Children(box, button);
    }
}
