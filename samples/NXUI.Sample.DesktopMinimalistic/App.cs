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
