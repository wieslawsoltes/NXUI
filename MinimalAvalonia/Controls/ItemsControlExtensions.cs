namespace MinimalAvalonia.Controls;

public static class ItemsControlExtensions
{
    public static T Items<T>(this T itemsControl, IEnumerable items) where T : ItemsControl
    {
        itemsControl[Avalonia.Controls.ItemsControl.ItemsProperty] = items;
        return itemsControl;
    }

    public static T ItemsPanel<T>(this T itemsControl, ITemplate<IPanel> itemsPanel) where T : ItemsControl
    {
        itemsControl[Avalonia.Controls.ItemsControl.ItemsPanelProperty] = itemsPanel;
        return itemsControl;
    }

    public static T ItemTemplate<T>(this T itemsControl, IDataTemplate itemTemplate) where T : ItemsControl
    {
        itemsControl[Avalonia.Controls.ItemsControl.ItemTemplateProperty] = itemTemplate;
        return itemsControl;
    }
}
