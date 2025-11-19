using System.Linq;
using System.Reactive.Subjects;
using NXUI.HotReload;

var counters = Enumerable.Range(0, 5).Select(i => new BehaviorSubject<int>(i));

object Build()
  => Window()
    .Title("Counters")
    .Padding(12).Width(300).Height(200)
    .Content(
      ItemsControl()
        .ItemTemplate(FuncDataTemplate<BehaviorSubject<int>, StackPanel>((count, _) =>
            StackPanel()
              .OrientationHorizontal().Spacing(12).HorizontalAlignmentCenter().VerticalAlignmentCenter()
              .Children(
                Label()
                  .HorizontalAlignmentCenter().VerticalAlignmentCenter().MinWidth(24)
                  .Content(count.ToBinding()),
                Button()
                  .OnClick((_, o) => o.Subscribe(_ => count.OnNext(count.Value + 1)))
                  .Content("Count")),
          true))
        .ItemsSource(counters));

return HotReloadHost.Run(Build, "Counters", args);
