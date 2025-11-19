# NXUI Hot Reload Architecture

## Motivation
NXUI already offers a terse fluent syntax over Avalonia, but today each fluent call immediately instantiates controls. IDE and `dotnet watch` hot reload therefore need to tear down and rebuild entire windows, losing state and flickering. This document proposes an architecture that virtualizes the fluent syntax, introduces a generated builder, and adds a diff/patch runtime so hot reload can preserve state and reuse most of the UI tree.

## Goals
- Support both IDE hot reload (VS/Rider/VS Code) and `dotnet watch` without code changes in apps.
- Keep authoring experience in fluent syntax. Builders must stay discoverable/intellisense-friendly.
- Generate a UI description ("fluent tree") that can be diffed and turned into a patch plan instead of rebuilding controls.
- Preserve control instances and mutable state whenever type/key alignment allows it.
- Work in Debug by default, but let Release builds trim hot reload code via `ILLink` and conditional compilation.

## Non-Goals
- Re-implement Avalonia templating or layout: NXUI still relies on Avalonia controls.
- Provide general-purpose reconciler for non-NXUI trees. The diff engine is internal to NXUI.
- Change runtime behavior of existing fluent code in Release builds; the new pipeline must be opt-in or backwards compatible.

## High-Level Overview
1. **Node Recording:** Generated builder methods no longer instantiate controls immediately. They return `ElementNode<TControl>` objects that record control type, key, property setters, bindings, resources, and child nodes.
2. **Tree Materialization:** A runtime `NodeRenderer` can turn a node tree into actual Avalonia controls (`Build()`). Existing code keeps working through implicit conversion or compatibility helper methods.
3. **Diff + Patch:** Given two node trees, `TreeDiffer` produces a sequence of `PatchOp` instructions (set property, add/remove child, replace sub-tree, rebind template, etc.). `TreePatcher` applies these ops against the live control tree.
4. **Hot Reload Integration:** `HotReloadManager` listens for metadata updates (IDE) and `dotnet watch` updates. When a component delegate changes it re-evaluates the fluent function, generates a new node tree, diffs it with the existing instance, and applies patches on the UI thread.
5. **State Preservation:** Controls keep existing instances unless type or key changed. Bindings and event handlers are refreshed without resetting control-local state (e.g., `TextBox.Text`).

## Fluent Tree Model
### Node Types
- `ElementNode<TControl>` – records Avalonia control type, optional `Key`, child nodes, property mutations, event hooks, resources, templates.
- `ContentNode`/`DataTemplateNode` – wrap inline templates, recorded as lambda references plus metadata for re-evaluation.
- `BindingNode` – describes `IBinding` creation or the reactive pipeline used in fluent syntax.
- `DirectiveNode` – captures special instructions (e.g., `Name`, `x:Key`, `HotReloadBoundary`).

Each node carries:
- `TypeId` (int) resolved from generator for fast comparisons.
- `Key` (string or int) derived from explicit `Key()` fluent call, `Name()`, or positional index fallback.
- `Properties`: list of `{PropertyId, ValueProvider}` where `ValueProvider` can be literal, binding, or expression delegate.
- `Events`: list of event subscriptions with stable `Token` for detach/attach.
- `Children`: ordered list of child nodes. Panels with `Items` use a secondary child list keyed to item source.

### Fluent Syntax Adjustments
- Builders now return `ElementNode<TControl>`; a new `ElementBuilder<TControl>` struct wraps the node reference and fluent extension methods mutate the node.
- New helper `Mount()` (or implicit conversion) instantiates the control tree for existing code to avoid breaking changes.
- Optional `.Key("MyButton")` and `.HotReloadBoundary()` fluent extensions are generated for every builder to aid diff alignment.
- Property/child extension methods append mutations to the node rather than immediately mutating a live control.

### Builder Extension Coverage
- Several fluent helpers are authored manually instead of coming from the generator (e.g., animations, control collections, binding shims, `ObjectExtensions`, and routed event helpers). Each of these now exposes a `*.HotReload.cs` partial that mirrors the runtime behavior on `ElementBuilder<T>` using `WithAction`, `WithRef`, or `ElementNode.RegisterAttachment`.
- This guarantees that DSL calls such as `.Transitions(...)`, `.DataTemplates(...)`, `.ItemsSource(object[])`, `.BindOneWay(...)`, `.Self(...)`, and `.AddDisposableHandler(...)` behave identically inside the always-on hot reload pipeline.
- Regression coverage for these helpers lives in `tests/NXUI.HotReload.Tests/BuilderExtensionIntegrationTests.cs`. New helpers must add both a hot reload partial and an integration test before landing; otherwise hot reload builds regress silently when codegen changes.
- Prefer augmenting the generator for property/event helpers when possible. Manual partials are reserved for higher-level behaviors (collection manipulation, event bridge wiring, `ElementRef` plumbing) that the generator cannot infer automatically.

### Source Generator Changes
- `src/Generator` is extended to emit:
  - `ElementBuilder<TControl>` partial structs per control with method-chaining returning `ref readonly ElementBuilder<TControl>` (for minimal allocations).
  - Central metadata table `GeneratedMetadata.g.cs` mapping `Type -> TypeId` and `AvaloniaProperty -> PropertyId` to enable compact diffs.
  - Overloads that return immediate controls do so by calling `.Mount()` internally; builder-first APIs no longer require compile-time guards.
- Analyzer ensures consuming projects reference `NXUI.HotReload` package when `PropertyGroup` enables hot reload.

## Runtime Composition
### NodeRenderer
- Accepts root `ElementNode` and optionally an existing control instance.
- Provides `Build()` (cold start) and `Reconcile()` (hot reload) methods.
- Ensures construction happens on `Dispatcher.UIThread`. For non-UI thread contexts it posts the work before returning a `Task`.

### TreeDiffer
- Performs depth-first diff with early exits:
  1. Compare `TypeId`; mismatch => `ReplaceNode` operation.
  2. Compare `Key`; mismatch => treat as remove+add to maintain state boundaries.
  3. Compare property mutation lists; emit `SetProperty` ops only where values differ. Literal comparisons use cached equality comparers; binding comparisons hash delegate target + method.
  4. Reconcile children via keyed diff (O(n)). Panels with virtualization respect `ItemsSource` semantics by deferring to Avalonia controls when `ItemsSource` is bound.
  5. Events: detach handlers whose delegate signature changed, attach new ones, but keep handler objects when unchanged.
- Emits a linear `PatchOp[]` containing operations such as `SetProperty`, `SetBinding`, `AddChild`, `RemoveChild`, `MoveChild`, `ReplaceSubtree`, `UpdateResource`, `UpdateTemplate`.

### TreePatcher
- Applies `PatchOp` sequences against live controls.
- Uses weak references to avoid leaks when nodes get dropped.
- Ensures `DataContext` mutation order: update resources first, then properties, then children to match Avalonia expectations.
- Wraps property changes with `BeginBatch/EndBatch` (Avalonia `Dispatcher.UIThread`) to minimize layout churn.

## Hot Reload Runtime
### HotReloadManager
- Hosted in `NXUI.HotReload` namespace.
- API surface:
  ```csharp
  public static class HotReloadManager
  {
      public static IDisposable RegisterComponent(string id, Func<ElementNode> factory, IControlHost host);
      public static void Initialize(AppBuilder builder);
  }
  ```
- `RegisterComponent` stores component metadata (factory delegate, current node tree, root control reference, dispatcher) and returns a disposable to deregister on shutdown.
- Hooks into `System.Reflection.Metadata.MetadataUpdater` (`MetadataUpdateHandlerAttribute`) to receive `OnClearCache(Type[] types)` callbacks in IDE scenarios.
- For `dotnet watch --hot-reload`, hosts `IDeltaApplier` by referencing `Microsoft.Extensions.HotReload` and wiring `HotReloadAgent.UpdateApplication`.
- Debounces updates (e.g., 250ms) to avoid multiple re-renders per compilation.

### Component Host Integration
- Provide `HotReloadApplication` helpers:
  - `AppBuilder.UseNXUIHotReload()` – registers manager, toggles `MetadataUpdater.IsSupported`, and ensures app lifetime knows how to refresh windows.
  - `FluentWindow.Run(BuildFunc build)` – wraps the user `Build` delegate in a component registration so every window gets a `ComponentHandle`.
- During hot reload, manager calls `ComponentHandle.Reconcile()` => evaluate new fluent tree -> diff -> patch.
- When diff says root replaced, manager closes the old window and shows the new one.

## State Preservation Strategy
- Controls keep their instance unless `TypeId` or `Key` changed.
- Dependency properties preserve values unless diff emits a change; we rely on Avalonia control state (e.g., scroll offsets) staying untouched.
- For local state embedded in closures (e.g., `var count = 0`), guidance is to store state in view models or `ReactiveCommand`. Documented in dev guide.
- Provide optional `StateSlot<T>` helper for NXUI to keep small amounts of state tied to node keys.

## IDE vs `dotnet watch` Hot Reload
| Aspect | IDE | `dotnet watch` |
| --- | --- | --- |
| Trigger | CLR `MetadataUpdateHandler` | `HotReloadAgent` delta stream | 
| Transport | In-process, just-in-time patching | File watcher, CLI, cross-process | 
| UX | Transparent when debugging | CLI output + manual `dotnet watch` | 
| NXUI Work | Attribute-based handler to refresh components | Hosted service listening to STDIN events or `Microsoft.DotNet.Watcher.Tools` contracts |

Implementation shares `ComponentRegistry` and `TreeDiffer`. Only the transport changes.

## Developer Experience
- Hot reload is always enabled; no MSBuild properties or preprocessor defines are required.
- Template updates: NXUI project templates updated to call `AppBuilder.Configure().UseNXUIHotReload().StartWithClassicDesktopLifetime(...)` when in Debug.
- Logging: `HotReloadDiagnostics` logger (wraps `ILogger`) prints patch summaries and warnings about replaced nodes. When richer insights are needed, enable `NXUI_HOTRELOAD_DIAGNOSTICS` and attach the `nxui hotreload trace` CLI (`dotnet run --project src/NXUI.Cli -- hotreload trace --pid <processId>`) to stream the `NXUI-HotReload` EventSource and visualize per-subtree counts.
- Snapshots: set `NXUI_HOTRELOAD_SNAPSHOT=1` to emit serialized `ElementNode` trees. Collect them via `nxui hotreload snapshot --pid <processId> [--output tree.json] [--watch]` for inspection or automated regressions.
- Boundaries: run `nxui hotreload boundaries [--manifest build/HotReloadBoundaries.json] [--assembly path]` to list manifest seeds and inspect compiled assemblies for `[HotReloadBoundary]`, `[HotReloadCandidateBoundary]`, or manifest-derived matches. Entries flagged as “state-adapter” indicate controls the weaver intentionally skips because they expose `IHotReloadStateAdapter`.
- State adapters: Phase 4.2 introduces `IHotReloadStateAdapter` + `HotReloadStateRegistry`. Controls such as `TextBox` keep caret/text selection even when the diff engine must recreate them. Future weavers will auto-register adapters for common controls, and projects can register their own via `HotReloadStateRegistry.RegisterAdapter`.
- Metadata handlers: the Fody add-in also injects `[assembly: MetadataUpdateHandler(typeof(NXUI.HotReload.HotReloadMetadataUpdateHandler))]` so IDEs/`dotnet watch` notify NXUI automatically—no need to copy the attribute into every app project.
- Diagnostics: when `NXUI_HOTRELOAD_DIAGNOSTICS` is enabled, state transfers emit trace lines identifying the adapter/control pair so developers can verify the preservation path is exercised during IL deltas.
- Template manifests: control template builders now register manifest graphs (control types + named parts) through `TemplateManifestRegistry`. This gives the diff/patch pipeline visibility into template content even before IL weaving starts recording manifests for compiled XAML resources.
- Analyzer warns when builder uses features unsupported by diff (e.g., raw `Control` instantiation outside NXUI DSL), offering code fix to wrap in `FluentHost.FromControl`.
- CLI support: `dotnet run --project src/NXUI.Cli -- gen component SampleComponent --output src/Sample` scaffolds a hot reload-ready entry point (keys, boundaries, diagnostics) so new apps start with best practices baked in.

## Risks & Mitigations
- **Risk:** Diff algorithm corrupts tree when developers mutate controls manually. *Mitigation:* Provide `HotReloadBoundary.SuppressDiff(Action<AvaloniaObject>)` to let devs perform imperative mutations safely; analyzer warns on manual property sets in fluent pipelines.
- **Risk:** Performance regressions from node allocations. *Mitigation:* Builders implemented as ref structs storing pooled arrays; release builds can trim hot reload via conditional define.
- **Risk:** Metadata update handler linking issues on non-Windows platforms. *Mitigation:* Keep transport optional and fallback to full rebuild when handler fails.
- **Risk:** Threading issues. *Mitigation:* All patch operations marshaled to `Dispatcher.UIThread`; runtime asserts thread access in Debug.

## Future Extensions
- Persisted layout snapshots for designer tools.
- Visualizer showing diff results.
- Support for remote hot reload (phone/tablet) via WebSocket transport using same diff payload.
