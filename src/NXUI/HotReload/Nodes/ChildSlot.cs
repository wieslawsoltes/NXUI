#if NXUI_HOTRELOAD
namespace NXUI.HotReload.Nodes;

/// <summary>
/// Describes which surface of a parent control a child node should attach to.
/// </summary>
internal enum ChildSlot
{
    Unknown = 0,
    /// <summary>
    /// Children that occupy a single-content surface (ContentControl, ContentPresenter, Decorator, etc.).
    /// </summary>
    Content = 1,
    /// <summary>
    /// Children that belong to visual child collections (Panel.Children, Grid children, etc.).
    /// </summary>
    Visual = 2,
    /// <summary>
    /// Children that populate items collections (ItemsControl.Items/ItemsSource).
    /// </summary>
    Items = 3,
    /// <summary>
    /// Children that should be applied to logical-only collections (styles/templates/resources).
    /// </summary>
    Logical = 4,
    /// <summary>
    /// Children that represent template roots/hosts.
    /// </summary>
    Template = 5,
}
#endif
