namespace Reflectonia.Model;

using System.Reflection;

public record Property(
    string Name, 
    Type OwnerType, 
    Type ValueType, 
    Type PropertyType, 
    bool AlreadyExists, 
    bool IsReadOnly = false, 
    bool IsEnum = false, 
    string[]? EnumNames = null,
    NullabilityInfo? ValueNullability = null);
