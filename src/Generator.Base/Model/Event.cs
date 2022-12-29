namespace Generator.Model;

public record Event(
    string Name, 
    Type OwnerType, 
    Type? ArgsType, 
    Type? EventType, 
    string? RoutingStrategies);
