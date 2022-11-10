namespace Generator.Model;

public record Class(
    string Name, 
    string Type, 
    Property[] Properties, 
    Event[] Events,
    bool IsSealed = false, 
    bool PublicCtor = true, 
    bool IsAbstract = false);
