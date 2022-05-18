using Consolonia.Core;
using Consolonia.Themes.TurboVision.Themes.TurboVisionDark;

namespace MinimalAvalonia;

public static class ConsoloniaApp
{
    public static void Start(string[] args, Func<Window> build)
    {
        App.Build = build;
        ApplicationStartup.StartConsolonia<App>(args);
    }

    private class App : Application
    {
        public static Func<Window>? Build;
        
        public App()
        {
            Styles.Add(new TurboVisionDarkTheme(new Uri($"avares://{System.Reflection.Assembly.GetExecutingAssembly().GetName()}")));
        }

        public override void OnFrameworkInitializationCompleted()
        {
            if (ApplicationLifetime is IClassicDesktopStyleApplicationLifetime desktop)
            {
                
                desktop.MainWindow = Build?.Invoke();
            }
            base.OnFrameworkInitializationCompleted();
        }
    }
}
