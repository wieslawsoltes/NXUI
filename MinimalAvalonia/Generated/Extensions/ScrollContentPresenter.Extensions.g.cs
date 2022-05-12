// <auto-generated />
namespace MinimalAvalonia.Extensions;

public static partial class ScrollContentPresenterExtensions
{
    // CanHorizontallyScrollProperty

    public static T CanHorizontallyScroll<T>(this T obj, System.Boolean value) where T : Avalonia.Controls.Presenters.ScrollContentPresenter
    {
        obj[Avalonia.Controls.Presenters.ScrollContentPresenter.CanHorizontallyScrollProperty] = value;
        return obj;
    }

    public static T CanHorizontallyScroll<T>(this T obj, Avalonia.Data.IBinding binding, Avalonia.Data.BindingMode mode = Avalonia.Data.BindingMode.TwoWay) where T : Avalonia.Controls.Presenters.ScrollContentPresenter
    {
        obj[Avalonia.Controls.Presenters.ScrollContentPresenter.CanHorizontallyScrollProperty.Bind().WithMode(mode)] = binding;
        return obj;
    }

    public static Avalonia.Data.IBinding CanHorizontallyScroll(this Avalonia.Controls.Presenters.ScrollContentPresenter obj, Avalonia.Data.BindingMode mode = Avalonia.Data.BindingMode.TwoWay)
    {
        return obj[Avalonia.Controls.Presenters.ScrollContentPresenter.CanHorizontallyScrollProperty.Bind().WithMode(mode)];
    }

    // CanVerticallyScrollProperty

    public static T CanVerticallyScroll<T>(this T obj, System.Boolean value) where T : Avalonia.Controls.Presenters.ScrollContentPresenter
    {
        obj[Avalonia.Controls.Presenters.ScrollContentPresenter.CanVerticallyScrollProperty] = value;
        return obj;
    }

    public static T CanVerticallyScroll<T>(this T obj, Avalonia.Data.IBinding binding, Avalonia.Data.BindingMode mode = Avalonia.Data.BindingMode.TwoWay) where T : Avalonia.Controls.Presenters.ScrollContentPresenter
    {
        obj[Avalonia.Controls.Presenters.ScrollContentPresenter.CanVerticallyScrollProperty.Bind().WithMode(mode)] = binding;
        return obj;
    }

    public static Avalonia.Data.IBinding CanVerticallyScroll(this Avalonia.Controls.Presenters.ScrollContentPresenter obj, Avalonia.Data.BindingMode mode = Avalonia.Data.BindingMode.TwoWay)
    {
        return obj[Avalonia.Controls.Presenters.ScrollContentPresenter.CanVerticallyScrollProperty.Bind().WithMode(mode)];
    }

    // ExtentProperty

    public static T Extent<T>(this T obj, Avalonia.Size value) where T : Avalonia.Controls.Presenters.ScrollContentPresenter
    {
        obj[Avalonia.Controls.Presenters.ScrollContentPresenter.ExtentProperty] = value;
        return obj;
    }

    public static T Extent<T>(this T obj, Avalonia.Data.IBinding binding, Avalonia.Data.BindingMode mode = Avalonia.Data.BindingMode.TwoWay) where T : Avalonia.Controls.Presenters.ScrollContentPresenter
    {
        obj[Avalonia.Controls.Presenters.ScrollContentPresenter.ExtentProperty.Bind().WithMode(mode)] = binding;
        return obj;
    }

    public static Avalonia.Data.IBinding Extent(this Avalonia.Controls.Presenters.ScrollContentPresenter obj, Avalonia.Data.BindingMode mode = Avalonia.Data.BindingMode.TwoWay)
    {
        return obj[Avalonia.Controls.Presenters.ScrollContentPresenter.ExtentProperty.Bind().WithMode(mode)];
    }

    // OffsetProperty

    public static T Offset<T>(this T obj, Avalonia.Vector value) where T : Avalonia.Controls.Presenters.ScrollContentPresenter
    {
        obj[Avalonia.Controls.Presenters.ScrollContentPresenter.OffsetProperty] = value;
        return obj;
    }

    public static T Offset<T>(this T obj, Avalonia.Data.IBinding binding, Avalonia.Data.BindingMode mode = Avalonia.Data.BindingMode.TwoWay) where T : Avalonia.Controls.Presenters.ScrollContentPresenter
    {
        obj[Avalonia.Controls.Presenters.ScrollContentPresenter.OffsetProperty.Bind().WithMode(mode)] = binding;
        return obj;
    }

    public static Avalonia.Data.IBinding Offset(this Avalonia.Controls.Presenters.ScrollContentPresenter obj, Avalonia.Data.BindingMode mode = Avalonia.Data.BindingMode.TwoWay)
    {
        return obj[Avalonia.Controls.Presenters.ScrollContentPresenter.OffsetProperty.Bind().WithMode(mode)];
    }

    // ViewportProperty

    public static T Viewport<T>(this T obj, Avalonia.Size value) where T : Avalonia.Controls.Presenters.ScrollContentPresenter
    {
        obj[Avalonia.Controls.Presenters.ScrollContentPresenter.ViewportProperty] = value;
        return obj;
    }

    public static T Viewport<T>(this T obj, Avalonia.Data.IBinding binding, Avalonia.Data.BindingMode mode = Avalonia.Data.BindingMode.TwoWay) where T : Avalonia.Controls.Presenters.ScrollContentPresenter
    {
        obj[Avalonia.Controls.Presenters.ScrollContentPresenter.ViewportProperty.Bind().WithMode(mode)] = binding;
        return obj;
    }

    public static Avalonia.Data.IBinding Viewport(this Avalonia.Controls.Presenters.ScrollContentPresenter obj, Avalonia.Data.BindingMode mode = Avalonia.Data.BindingMode.TwoWay)
    {
        return obj[Avalonia.Controls.Presenters.ScrollContentPresenter.ViewportProperty.Bind().WithMode(mode)];
    }
}