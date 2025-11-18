#if NXUI_HOTRELOAD
namespace NXUI.HotReload.Metadata;

using System;
using System.Collections.Generic;
using Avalonia;
using Avalonia.Media;

/// <summary>
/// Provides specialized equality comparers for common Avalonia property types.
/// </summary>
internal static class PropertyComparerRegistry
{
    private static readonly Dictionary<Type, PropertyValueComparer> s_typeComparers = new()
    {
        { typeof(Thickness), CompareThickness },
        { typeof(CornerRadius), CompareCornerRadius },
        { typeof(Point), ComparePoint },
        { typeof(Vector), CompareVector },
        { typeof(Size), CompareSize },
        { typeof(Rect), CompareRect },
        { typeof(RelativePoint), CompareRelativePoint },
        { typeof(RelativeRect), CompareRelativeRect },
        { typeof(Matrix), CompareMatrix },
        { typeof(Color), CompareColor },
    };

    private static readonly Type s_nullableType = typeof(Nullable<>);

    internal static PropertyValueComparer? Resolve(AvaloniaProperty? property)
    {
        if (property is null)
        {
            return null;
        }

        var type = property.PropertyType;
        if (type is null)
        {
            return null;
        }

        if (type.IsGenericType && type.GetGenericTypeDefinition() == s_nullableType)
        {
            type = Nullable.GetUnderlyingType(type) ?? type;
        }

        if (typeof(IBrush).IsAssignableFrom(type))
        {
            return BrushComparer;
        }

        if (s_typeComparers.TryGetValue(type, out var comparer))
        {
            return comparer;
        }

        return null;
    }

    private static bool CompareThickness(object? left, object? right)
        => CompareStruct<Thickness>(left, right);

    private static bool CompareCornerRadius(object? left, object? right)
        => CompareStruct<CornerRadius>(left, right);

    private static bool ComparePoint(object? left, object? right)
        => CompareStruct<Point>(left, right);

    private static bool CompareVector(object? left, object? right)
        => CompareStruct<Vector>(left, right);

    private static bool CompareSize(object? left, object? right)
        => CompareStruct<Size>(left, right);

    private static bool CompareRect(object? left, object? right)
        => CompareStruct<Rect>(left, right);

    private static bool CompareRelativePoint(object? left, object? right)
        => CompareStruct<RelativePoint>(left, right);

    private static bool CompareRelativeRect(object? left, object? right)
        => CompareStruct<RelativeRect>(left, right);

    private static bool CompareMatrix(object? left, object? right)
        => CompareStruct<Matrix>(left, right);

    private static bool CompareColor(object? left, object? right)
        => CompareStruct<Color>(left, right);

    private static bool BrushComparer(object? left, object? right)
    {
        if (ReferenceEquals(left, right))
        {
            return true;
        }

        if (left is null || right is null)
        {
            return false;
        }

        if (left is ISolidColorBrush solidLeft && right is ISolidColorBrush solidRight)
        {
            return solidLeft.Color == solidRight.Color
                && NearlyEquals(solidLeft.Opacity, solidRight.Opacity);
        }

        return Equals(left, right);
    }

    private static bool CompareStruct<T>(object? left, object? right)
        where T : struct, IEquatable<T>
    {
        if (left is null || right is null)
        {
            return left is null && right is null;
        }

        if (left is T leftValue && right is T rightValue)
        {
            return leftValue.Equals(rightValue);
        }

        return Equals(left, right);
    }

    private static bool NearlyEquals(double left, double right)
        => Math.Abs(left - right) <= 0.0000001;
}
#endif
