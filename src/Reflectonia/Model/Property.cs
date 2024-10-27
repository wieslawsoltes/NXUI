namespace Reflectonia.Model;

public record Property(
    string Name, 
    Type OwnerType, 
    Type ValueType, 
    Type PropertyType, 
    bool AlreadyExists, 
    bool IsReadOnly = false, 
    bool IsEnum = false, 
    string[]? EnumNames = null);
