using System;
using Avalonia.Animation;
using Avalonia.Controls;
using Avalonia.Data;
using Avalonia.Media;
using Avalonia.Styling;
using NXUI.Extensions;
using Xunit;
using static NXUI.Builders;

namespace NXUI.HotReload.Tests;

[Collection("HeadlessTests")]
public class StyleSetterBuilderTests
{
    [Fact]
    public void Style_Builder_Adds_Value_Setter()
    {
        var styleBuilder = Style()
            .SetBorderBackground(Brushes.Blue);

        var style = styleBuilder.Mount();
        var setter = Assert.IsType<Setter>(Assert.Single(style.Setters));

        Assert.Equal(Avalonia.Controls.Border.BackgroundProperty, setter.Property);
        Assert.Equal(Brushes.Blue, setter.Value);
    }

    [Fact]
    public void Style_Builder_Adds_Binding_Setter()
    {
        var binding = new Binding("Tag");

        var styleBuilder = Style()
            .SetBorderBackground(binding);

        var style = styleBuilder.Mount();
        var setter = Assert.IsType<Setter>(Assert.Single(style.Setters));

        Assert.Equal(Avalonia.Controls.Border.BackgroundProperty, setter.Property);
        Assert.Same(binding, setter.Value);
    }

    [Fact]
    public void KeyFrame_Builder_Adds_Value_Setter()
    {
        var keyFrameBuilder = KeyFrame()
            .SetBorderBackground(Brushes.Green);

        var keyFrame = keyFrameBuilder.Mount();
        var setter = Assert.IsType<Setter>(Assert.Single(keyFrame.Setters));

        Assert.Equal(Avalonia.Controls.Border.BackgroundProperty, setter.Property);
        Assert.Equal(Brushes.Green, setter.Value);
    }

    [Fact]
    public void KeyFrame_Builder_Adds_Binding_Setter()
    {
        var binding = new Binding("Content");

        var keyFrameBuilder = KeyFrame()
            .SetBorderBackground(binding);

        var keyFrame = keyFrameBuilder.Mount();
        var setter = Assert.IsType<Setter>(Assert.Single(keyFrame.Setters));

        Assert.Equal(Avalonia.Controls.Border.BackgroundProperty, setter.Property);
        Assert.Same(binding, setter.Value);
    }

    [Fact]
    public void Style_Builder_Adds_Observable_Setter()
    {
        var observable = new SingleValueObservable<IBrush>(Brushes.OrangeRed);

        var styleBuilder = Style()
            .SetBorderBackground(observable);

        var style = styleBuilder.Mount();
        var setter = Assert.IsType<Setter>(Assert.Single(style.Setters));

        Assert.Equal(Avalonia.Controls.Border.BackgroundProperty, setter.Property);
        Assert.IsAssignableFrom<IBinding>(setter.Value);
    }

    private sealed class SingleValueObservable<T> : IObservable<T>
    {
        private readonly T _value;

        public SingleValueObservable(T value)
        {
            _value = value;
        }

        public IDisposable Subscribe(IObserver<T> observer)
        {
            ArgumentNullException.ThrowIfNull(observer);
            observer.OnNext(_value);
            observer.OnCompleted();
            return Disposable.Instance;
        }

        private sealed class Disposable : IDisposable
        {
            public static readonly Disposable Instance = new();
            public void Dispose()
            {
            }
        }
    }
}
