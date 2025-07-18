using Avalonia;
using Avalonia.Controls;
using Avalonia.Media;
using Avalonia.Rendering;

namespace NXUI.Sample.CustomControls;

public class ColoredBox : Control
{
    public static readonly StyledProperty<IBrush?> BoxFillProperty =
        AvaloniaProperty.Register<ColoredBox, IBrush?>(nameof(BoxFill));

    public IBrush? BoxFill
    {
        get => GetValue(BoxFillProperty);
        set => SetValue(BoxFillProperty, value);
    }

    static ColoredBox()
    {
        AffectsRender<ColoredBox>(BoxFillProperty);
    }

    public override void Render(DrawingContext context)
    {
        base.Render(context);
        if (BoxFill is { } fill)
        {
            context.FillRectangle(fill, new Rect(Bounds.Size));
        }
    }
}
