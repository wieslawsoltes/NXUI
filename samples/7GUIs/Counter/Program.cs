using System.Reactive.Subjects;
using NXUI.HotReload;

var count = new BehaviorSubject<int>(0);

object Build()
  => Window()
    .Title("Counter").Padding(12).Width(300).Height(200)
    .Content(
      StackPanel()
        .OrientationHorizontal().Spacing(12).HorizontalAlignmentCenter().VerticalAlignmentCenter()
        .Children(
          Label()
            .HorizontalAlignmentCenter().VerticalAlignmentCenter()
            .Content(count.ToBinding()),
          Button()
            .OnClick((_, o) => o.Subscribe(_ => count.OnNext(count.Value + 1)))
            .Content("Count")));

return HotReloadHost.Run(Build, "Counter", args);
