
namespace NXUI
{
    public static partial class Builders
    {
        public static Builder<Avalonia.Controls.Window> Window1()
        {
            return new Builder<Avalonia.Controls.Window>() { Activator = () => new Avalonia.Controls.Window() };
        }
    }
}

namespace NXUI.Extensions
{
    public static partial class ContentControlExtensions
    {
        public static Builder<T> Content1<T>(this Builder<T> builder, Builder<System.Object> value)
            where T : Avalonia.Controls.ContentControl
        {
            void Setter(T obj)
                => obj[Avalonia.Controls.ContentControl.ContentProperty] = value.Build();

            builder.Setters.Add(Setter);

            return builder;
        }
    }

    public static partial class WindowExtensions
    {
        public static Builder<T> Title1<T>(this Builder<T> builder, Builder<System.String> value)
            where T : Avalonia.Controls.Window
        {
            void Setter(T obj)
                => obj[Avalonia.Controls.Window.TitleProperty] = value.Build();

            builder.Setters.Add(Setter);

            return builder;
        }
    }
}
