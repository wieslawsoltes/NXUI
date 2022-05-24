namespace MinimalAvalonia.Interactivity;

public class BehaviorTemplate : ITemplate
{
    [Content]
    [TemplateContent(TemplateResultType = typeof(Behavior))]
    public object? Content { get; set; }

    object ITemplate.Build() => TemplateContent.Load<Behavior>(Content).Result;

    public static BehaviorTemplate Create<T>() where T : Behavior, new()
    {
        return new BehaviorTemplate
        {
            Content = new Func<IServiceProvider, object>(_ => new TemplateResult<Behavior>(new T(), null!))
        };
    }

    public static BehaviorTemplate Create(Func<Behavior> func)
    {
        return new BehaviorTemplate
        {
            Content = new Func<IServiceProvider, object>(_ => new TemplateResult<Behavior>(func(), null!))
        };
    }
}
