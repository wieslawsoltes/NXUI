namespace MinimalAvalonia;

[System.Diagnostics.CodeAnalysis.SuppressMessage("ReSharper", "InconsistentNaming")]
[System.Diagnostics.CodeAnalysis.SuppressMessage("ReSharper", "RedundantNameQualifier")]
public static partial class MinimalAvaloniaProperties
{
    public static Avalonia.AttachedProperty<System.Collections.Generic.IEnumerable<System.Object>> DataValidationErrorsErrors => Avalonia.Controls.DataValidationErrors.ErrorsProperty;

    public static Avalonia.AttachedProperty<System.Boolean> DataValidationErrorsHasErrors => Avalonia.Controls.DataValidationErrors.HasErrorsProperty;

    public static Avalonia.StyledProperty<Avalonia.Controls.Templates.IDataTemplate> DataValidationErrorsErrorTemplate => Avalonia.Controls.DataValidationErrors.ErrorTemplateProperty;

    public static Avalonia.DirectProperty<Avalonia.Controls.DataValidationErrors,Avalonia.Controls.Control> DataValidationErrorsOwner => Avalonia.Controls.DataValidationErrors.OwnerProperty;
}
