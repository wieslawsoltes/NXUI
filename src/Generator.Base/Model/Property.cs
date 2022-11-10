namespace Generator.Model;

public record Property(
    string Name, 
    string OwnerType, 
    string ValueType, 
    string PropertyType, 
    bool AlreadyExists, 
    bool IsReadOnly = false, 
    bool IsEnum = false, 
    string[]? EnumNames = null);
