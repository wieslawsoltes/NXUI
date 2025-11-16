# NXUI Hot Reload Best Practices

Hot reload keeps previously materialized Avalonia controls alive so long as the diff engine
can align nodes by type and key. The following practices help maximize reuse and keep patch
plans granular.

## Keys

- Call `.Key("stable-id")` on any repeating builder (items controls, lists of panels, tab
  items). Keys should be deterministic and based on the item's identity, not the index.
- Prefer string keys derived from your data model to make diagnostics easier to read. The
  diff engine treats keys as case-sensitive.
- Controls with implicit keys (e.g., `.Name()` or `x:Key`) still benefit from explicit keys.
  Adding `.Key()` removes ambiguity when the generator emits fallback positional keys.
- When you cannot provide stable identifiers, use `.HotReloadBoundary()` on the repeated
  container to confine replacements to that region.

## HotReloadBoundary

- Apply `.HotReloadBoundary()` to subtrees that are expensive to reconstruct or that
  deliberately mutate control state (text boxes, data grids, custom controls). Boundaries act
  like React's Suspense boundaries: they keep existing controls alive unless the boundary
  itself changes type or key.
- Do **not** blanket everything with boundaries. Each boundary introduces an adoption point
  in the renderer, so prefer them for stateful or high-churn sections.
- Nesting boundaries is supported. Inner boundaries isolate child scopes while still flowing
  through the parent reconciliation cycle.
- When diagnostics are enabled, NXUI identifies boundary scopes in the patch summary, so be
  intentional about where you place them to make logs actionable.

## Builder Guidelines

- Hot reload expects the delegate passed to `HotReloadHost.Run` to return the root
  `ElementNode`. Avoid calling `.Mount()` or otherwise instantiating controls manually.
- Reactive pipelines should be deterministic. If a node uses random keys or memoized
  delegates that change on each invocation, the diff engine treats them as replacements.
- Commands or handlers that capture mutable local state should live inside boundaries so the
  state is not reinitialized unexpectedly.
- When binding collections, prefer `ItemsControl().Items(data.Select(...).Key(...))` so each
  generated child inherits the parent key relationship.

## Diagnostics Workflow

1. Set `NXUI_HOTRELOAD_DIAGNOSTICS=1` before launching your app.
2. Trigger a few updates; the console prints `[HotReload]` summaries that include property,
   binding, child, and replace counts.
3. If replacements are higher than expected, inspect your keys/boundaries in the affected
   subtree and verify the analyzer is not flagging manual control instantiations.
4. Rerun the update after adjusting keys or boundaries to confirm replacement counts drop.

Following these guidelines keeps reconciliations predictable and ensures the hot reload
runtime only rebuilds the controls that truly changed.
