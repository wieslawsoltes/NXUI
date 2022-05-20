namespace MinimalAvalonia;

/// <summary>
/// The minimal avalonia properties.
/// </summary>
[System.Diagnostics.CodeAnalysis.SuppressMessage("ReSharper", "InconsistentNaming")]
[System.Diagnostics.CodeAnalysis.SuppressMessage("ReSharper", "RedundantNameQualifier")]
public static partial class MinimalAvaloniaProperties
{
    public static Avalonia.DirectProperty<Avalonia.Controls.WindowBase,System.Boolean> WindowBaseIsActive => Avalonia.Controls.WindowBase.IsActiveProperty;

    public static Avalonia.DirectProperty<Avalonia.Controls.WindowBase,Avalonia.Controls.WindowBase> WindowBaseOwner => Avalonia.Controls.WindowBase.OwnerProperty;

    public static Avalonia.StyledProperty<System.Boolean> WindowBaseTopmost => Avalonia.Controls.WindowBase.TopmostProperty;
}
