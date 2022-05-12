namespace MinimalAvalonia;

[System.Diagnostics.CodeAnalysis.SuppressMessage("ReSharper", "InconsistentNaming")]
[System.Diagnostics.CodeAnalysis.SuppressMessage("ReSharper", "RedundantNameQualifier")]
public static partial class MinimalAvaloniaProperties
{
    public static Avalonia.StyledProperty<Avalonia.Controls.Templates.IControlTemplate> TemplatedControlTemplate => Avalonia.Controls.Primitives.TemplatedControl.TemplateProperty;

    public static Avalonia.AttachedProperty<System.Boolean> TemplatedControlIsTemplateFocusTarget => Avalonia.Controls.Primitives.TemplatedControl.IsTemplateFocusTargetProperty;
}
