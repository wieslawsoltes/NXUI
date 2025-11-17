using Avalonia.Controls;
using NXUI.Extensions;
using NXUI.HotReload;
#if NXUI_HOTRELOAD
using NXUI.HotReload.Nodes;
using StyleBuilder = NXUI.HotReload.Nodes.ElementBuilder<Avalonia.Styling.Style>;
#else
using StyleBuilder = Avalonia.Styling.Style;
#endif

object Build()
{
  var border = Border()
    .Background(Brushes.WhiteSmoke)
    .BorderBrush(Brushes.Black)
    .BorderThickness(2)
    .CornerRadius(4);

  var button = Button()
    .OnClick((_, o) => o.Subscribe(_ => Debug.WriteLine("Click")))
    .Content("Button1");

  var canvas = Canvas()
    .Background(Brushes.WhiteSmoke)
    .Children(
      Rectangle().Fill(Brushes.Blue).Width(50).Height(50).Left(50).Top(50),
      Ellipse().Fill(Brushes.Red).Width(50).Height(50).Left(150).Top(50));

  var contentControl = ContentControl()
    .Content("Content");

  var decorator = Decorator()
    .Child(
      TextBox().Text("Child"))
    .Padding(4);

  var headeredContentControl = HeaderedContentControl();

  var itemsControl = ItemsControl();

  var label = Label()
    .Classes("animation")
    .HorizontalAlignmentCenter().VerticalAlignmentCenter()
    .Content("Label");

  var layoutable = Layoutable();

  var panel = Panel()
    .Styles(RotateAnimation(TimeSpan.FromSeconds(5), 180d, 360d))
    .Width(200).Height(200)
    .Background(Brushes.WhiteSmoke);

  var stackPanel = StackPanel()
    .Spacing(4)
    .OrientationVertical()
    .Children(
      TextBlock().Text("Child 1"),
      TextBlock().Text("Child 2"),
      TextBlock().Text("Child 3"));

  var tabControl = TabControl()
    .ItemsSource(
      TabItem().Header("TabItem1").Content("TabItem1"),
      TabItem().Header("TabItem2").Content("TabItem2"),
      TabItem().Header("TabItem3").Content("TabItem3"));

  var templatedControl = TemplatedControl();

  var textBlock = TextBlock()
    .Background(Brushes.WhiteSmoke)
    .Padding(4)
    .FontFamily(FontFamily.Default)
    .FontSize(12)
    .FontStyle(FontStyle.Normal)
    .FontWeight(FontWeight.Normal)
    .Foreground(Brushes.Black)
    .LineHeight(double.NaN)
    .MaxLines(0)
    .Text("TextBlock")
    .TextAlignment(TextAlignment.Left)
    .TextWrapping(TextWrapping.NoWrap)
    .TextTrimming(TextTrimming.None)
    .TextDecorations(new TextDecorationCollection());

  var textBox = TextBox()
    .AcceptsReturn(true)
    .AcceptsTab(true)
    .CaretIndex(0)
    .IsReadOnly(false)
    .FontFamily(FontFamily.Default)
    .FontSize(12)
    .FontStyle(FontStyle.Normal)
    .FontWeight(FontWeight.Normal)
    .Foreground(Brushes.Black)
    .Text("TextBox");

  var controls = TabControl()
    .ItemsPanel(FuncTemplate<Panel, StackPanel>(StackPanel))
    .TabStripPlacementLeft()
    .Classes("tabControl")
    .ItemsSource(
      TabItem().Header("Border").Content(border),
      TabItem().Header("Button").Content(button),
      TabItem().Header("Canvas").Content(canvas),
      TabItem().Header("ContentControl").Content(contentControl),
      TabItem().Header("Decorator").Content(decorator),
      TabItem().Header("HeaderedContentControl").Content(headeredContentControl),
      TabItem().Header("ItemsControl").Content(itemsControl),
      TabItem().Header("Label").Content(label),
      TabItem().Header("Layoutable").Content(layoutable),
      TabItem().Header("Panel").Content(panel),
      TabItem().Header("StackPanel").Content(stackPanel),
      TabItem().Header("TabControl").Content(tabControl),
      TabItem().Header("TemplatedControl").Content(templatedControl),
      TabItem().Header("TextBlock").Content(textBlock),
      TabItem().Header("TextBox").Content(textBox));

  var window = Window()
    .SizeToContentManual()
    .Title("ControlCatalog")
    .Width(800).Height(700)
    .Content(controls);

  var buttonStyle = Style()
    .Selector(x => x.OfType<Button>().Class(":pointerover").Template().OfType<ContentPresenter>()
      .Name("PART_ContentPresenter"))
    .SetTemplatedControlBackground(Brushes.Red);

  var labelStyle = Style()
    .Selector(x => x.OfType<Label>().Class("animation"))
    .Animations(
      Animation()
        .Duration(TimeSpan.FromSeconds(5))
        .IterationCountInfinite()
        .KeyFrames(
          KeyFrame().Cue(0.0).SetRotateTransformAngle(0d),
          KeyFrame().Cue(1.0).SetRotateTransformAngle(360d)));

  window.Styles(TabControlStyle(), buttonStyle, labelStyle, InteractionStyle());

#if DEBUG
#if NXUI_HOTRELOAD
  window = window.WithAction(w => w.AttachDevTools());
#else
  window.AttachDevTools();
#endif
#endif

  return window;
}

StyleBuilder InteractionStyle()
{
  return Style()
    .Selector(x => x.Is<Control>())
#if true
    .SetInteractionBehavior<CustomBehavior>();
#else
        .SetInteractionBehavior(() => new CustomBehavior(), () => new CustomBehavior());
#endif
}

StyleBuilder TabControlStyle()
{
  var style = Style()
    .Selector(x => x.OfType<TabControl>().Class("tabControl"));

#if NXUI_HOTRELOAD
  style = style.WithAction(s =>
      s.SetTemplatedControlTemplate<TabControl>((x, ns) => BuildTabControlTemplate(x, ns).Mount()));
#else
  style = style.SetTemplatedControlTemplate<TabControl>(BuildTabControlTemplate);
#endif

  return style;
}

#if NXUI_HOTRELOAD
ElementBuilder<Border> BuildTabControlTemplate(TabControl x, INameScope ns)
{
  return Border()
    .BorderBrush(x.BindBorderBrush())
    .BorderThickness(x.BindBorderThickness())
    .CornerRadius(x.BindCornerRadius())
    .Background(x.BindBackground())
    .HorizontalAlignment(x.BindHorizontalAlignment())
    .VerticalAlignment(x.BindVerticalAlignment())
    .Child(
      DockPanel().Children(
        ScrollViewer().Content(
          ItemsPresenter().Name("PART_ItemsPresenter", ns)
            .ItemsPanel(x.BindItemsPanel())
            .Dock(x.BindTabStripPlacement())),
        ContentPresenter().Name("PART_SelectedContentHost", ns)
          .Margin(x.BindPadding())
          .HorizontalContentAlignment(x.BindHorizontalContentAlignment())
          .VerticalContentAlignment(x.BindVerticalContentAlignment())
          .Content(x.BindSelectedContent())
          .ContentTemplate(x.BindSelectedContentTemplate())
      )
    );
}
#else
Border BuildTabControlTemplate(TabControl x, INameScope ns)
{
  return Border()
    .BorderBrush(x.BindBorderBrush())
    .BorderThickness(x.BindBorderThickness())
    .CornerRadius(x.BindCornerRadius())
    .Background(x.BindBackground())
    .HorizontalAlignment(x.BindHorizontalAlignment())
    .VerticalAlignment(x.BindVerticalAlignment())
    .Child(
      DockPanel().Children(
        ScrollViewer().Content(
          ItemsPresenter().Name("PART_ItemsPresenter", ns)
            .ItemsPanel(x.BindItemsPanel())
            .Dock(x.BindTabStripPlacement())),
        ContentPresenter().Name("PART_SelectedContentHost", ns)
          .Margin(x.BindPadding())
          .HorizontalContentAlignment(x.BindHorizontalContentAlignment())
          .VerticalContentAlignment(x.BindVerticalContentAlignment())
          .Content(x.BindSelectedContent())
          .ContentTemplate(x.BindSelectedContentTemplate())
      )
    );
}
#endif

StyleBuilder RotateAnimation(TimeSpan duration, double startAngle, double endAngle)
  => Style()
    .Selector(x => x.Is<Control>())
    .SetVisualClipToBounds(false)
    .Animations(
      Animation()
        .Duration(duration)
        .IterationCountInfinite()
        .PlaybackDirectionAlternateReverse()
        .KeyFrames(
          KeyFrame().Cue(0.0).SetRotateTransformAngle(startAngle),
          KeyFrame().Cue(1.0).SetRotateTransformAngle(endAngle)));

return HotReloadHost.Run(Build, "ControlCatalog", args);

internal class CustomBehavior : Behavior
{
  protected override void OnAttached() => Debug.WriteLine($"OnAttached() {AssociatedObject}");
  protected override void OnDetaching() => Debug.WriteLine($"OnDetaching() {AssociatedObject}");
  protected override void OnAttachedToVisualTree() => Debug.WriteLine($"OnAttachedToVisualTree() {AssociatedObject}");

  protected override void OnDetachedFromVisualTree() =>
    Debug.WriteLine($"OnDetachedFromVisualTree() {AssociatedObject}");
}
