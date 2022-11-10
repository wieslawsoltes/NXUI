namespace Generator.Model;

public record Event(
    string Name, 
    string OwnerType, 
    string? ArgsType, 
    string? EventType, 
    string? RoutingStrategies);
