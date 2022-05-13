namespace MinimalAvalonia.Extensions;

public static partial class ControlExtensions
{
    // DataTemplates

    public static T DataTemplates<T>(this T control, params IDataTemplate[] dataTemplates) where T : Control
    {
        control.DataTemplates.AddRange(dataTemplates);
        return control;
    }
}
