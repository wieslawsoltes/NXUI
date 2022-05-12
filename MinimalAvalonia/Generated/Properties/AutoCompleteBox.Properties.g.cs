namespace MinimalAvalonia;

[System.Diagnostics.CodeAnalysis.SuppressMessage("ReSharper", "InconsistentNaming")]
[System.Diagnostics.CodeAnalysis.SuppressMessage("ReSharper", "RedundantNameQualifier")]
public static partial class MinimalAvaloniaProperties
{
    public static Avalonia.StyledProperty<System.Int32> AutoCompleteBoxMinimumPrefixLength => Avalonia.Controls.AutoCompleteBox.MinimumPrefixLengthProperty;

    public static Avalonia.StyledProperty<System.TimeSpan> AutoCompleteBoxMinimumPopulateDelay => Avalonia.Controls.AutoCompleteBox.MinimumPopulateDelayProperty;

    public static Avalonia.StyledProperty<System.Double> AutoCompleteBoxMaxDropDownHeight => Avalonia.Controls.AutoCompleteBox.MaxDropDownHeightProperty;

    public static Avalonia.StyledProperty<System.Boolean> AutoCompleteBoxIsTextCompletionEnabled => Avalonia.Controls.AutoCompleteBox.IsTextCompletionEnabledProperty;

    public static Avalonia.StyledProperty<Avalonia.Controls.Templates.IDataTemplate> AutoCompleteBoxItemTemplate => Avalonia.Controls.AutoCompleteBox.ItemTemplateProperty;

    public static Avalonia.DirectProperty<Avalonia.Controls.AutoCompleteBox,System.Boolean> AutoCompleteBoxIsDropDownOpen => Avalonia.Controls.AutoCompleteBox.IsDropDownOpenProperty;

    public static Avalonia.DirectProperty<Avalonia.Controls.AutoCompleteBox,System.Object> AutoCompleteBoxSelectedItem => Avalonia.Controls.AutoCompleteBox.SelectedItemProperty;

    public static Avalonia.DirectProperty<Avalonia.Controls.AutoCompleteBox,System.String> AutoCompleteBoxText => Avalonia.Controls.AutoCompleteBox.TextProperty;

    public static Avalonia.DirectProperty<Avalonia.Controls.AutoCompleteBox,System.String> AutoCompleteBoxSearchText => Avalonia.Controls.AutoCompleteBox.SearchTextProperty;

    public static Avalonia.StyledProperty<Avalonia.Controls.AutoCompleteFilterMode> AutoCompleteBoxFilterMode => Avalonia.Controls.AutoCompleteBox.FilterModeProperty;

    public static Avalonia.DirectProperty<Avalonia.Controls.AutoCompleteBox,Avalonia.Controls.AutoCompleteFilterPredicate<System.Object>> AutoCompleteBoxItemFilter => Avalonia.Controls.AutoCompleteBox.ItemFilterProperty;

    public static Avalonia.DirectProperty<Avalonia.Controls.AutoCompleteBox,Avalonia.Controls.AutoCompleteFilterPredicate<System.String>> AutoCompleteBoxTextFilter => Avalonia.Controls.AutoCompleteBox.TextFilterProperty;

    public static Avalonia.DirectProperty<Avalonia.Controls.AutoCompleteBox,Avalonia.Controls.AutoCompleteSelector<System.Object>> AutoCompleteBoxItemSelector => Avalonia.Controls.AutoCompleteBox.ItemSelectorProperty;

    public static Avalonia.DirectProperty<Avalonia.Controls.AutoCompleteBox,Avalonia.Controls.AutoCompleteSelector<System.String>> AutoCompleteBoxTextSelector => Avalonia.Controls.AutoCompleteBox.TextSelectorProperty;

    public static Avalonia.DirectProperty<Avalonia.Controls.AutoCompleteBox,System.Collections.IEnumerable> AutoCompleteBoxItems => Avalonia.Controls.AutoCompleteBox.ItemsProperty;

    public static Avalonia.DirectProperty<Avalonia.Controls.AutoCompleteBox,System.Func<System.String,System.Threading.CancellationToken,System.Threading.Tasks.Task<System.Collections.Generic.IEnumerable<System.Object>>>> AutoCompleteBoxAsyncPopulator => Avalonia.Controls.AutoCompleteBox.AsyncPopulatorProperty;
}
