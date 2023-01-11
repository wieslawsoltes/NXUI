namespace NXUI;

public sealed class Builder<T> : IBuilder
{
    public static implicit operator Builder<T>(T value) 
        => new () { Activator = () => value };

    public Func<T> Activator { get; set; }

    public List<Action<T>> Setters { get; set; } = new ();

    public object Build()
    {
        var obj = Activator();
        foreach (var setter in Setters)
        {
            setter(obj);
        }
        return obj;
    }
}
