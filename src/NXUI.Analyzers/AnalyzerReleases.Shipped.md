## Release 0.1.0

### New Rules

Rule ID | Category | Severity | Notes
--------|----------|----------|------
NXH001 | HotReload | Warning | Flags manual Avalonia control instantiation so patched trees remain compatible with NXUI hot reload.
NXH002 | HotReload | Info | Warns when ItemsControl.ItemsSource entries lack `.Key()` reminders for hot reload diffs.
