namespace NXUI.Interactivity;

/// <summary>
/// 
/// </summary>
public class BehaviorTemplate : ITemplate
{
    /// <summary>
    /// 
    /// </summary>
    [Content]
    [TemplateContent(TemplateResultType = typeof(Behavior))]
    public object? Content { get; set; }

    object? ITemplate.Build() => TemplateContent.Load<Behavior>(Content)?.Result;

    /// <summary>
    /// 
    /// </summary>
    /// <typeparam name="T"></typeparam>
    /// <returns></returns>
    public static BehaviorTemplate Create<T>() where T : Behavior, new()
    {
        return new BehaviorTemplate
        {
            Content = new Func<IServiceProvider, object>(_ => new TemplateResult<Behavior>(new T(), null!))
        };
    }

    /// <summary>
    /// 
    /// </summary>
    /// <param name="func"></param>
    /// <returns></returns>
    public static BehaviorTemplate Create(Func<Behavior> func)
    {
        return new BehaviorTemplate
        {
            Content = new Func<IServiceProvider, object>(_ => new TemplateResult<Behavior>(func(), null!))
        };
    }
}
