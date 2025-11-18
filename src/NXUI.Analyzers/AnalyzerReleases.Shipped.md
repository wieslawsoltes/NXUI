## Release 0.1.0

### New Rules

Rule ID | Category | Severity | Notes
--------|----------|----------|------
NXH001 | HotReload | Warning | Flags manual Avalonia control instantiation when `NXUI_HOTRELOAD` is defined.
NXH002 | HotReload | Info | Warns when ItemsControl.ItemsSource entries lack `.Key()` reminders for hot reload diffs.
