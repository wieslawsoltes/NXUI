using System.Runtime.Versioning;
using Avalonia.Browser;

[assembly:SupportedOSPlatform("browser")]

namespace NXUI.Sample.Web;

/// <summary>
/// 
/// </summary>
public static class AppBuilderExtensions
{
  /// <summary>
  /// 
  /// </summary>
  /// <param name="builder"></param>
  /// <param name="callback"></param>
  /// <param name="mainDivId"></param>
  /// <returns></returns>
  public static AppBuilder SetupBrowserSingleViewLifetime(
    this AppBuilder builder, 
    Func<Control>? callback, 
    string mainDivId = "out")
  {
    var lifetime = new BrowserSingleViewLifetime();

    builder
      .UseBrowser()
      .AfterSetup(b =>
      {
        lifetime.View = new AvaloniaView(mainDivId);
      });

    builder.SetupWithLifetime(lifetime);

    lifetime.MainView = callback?.Invoke();

    return builder;
  }
}
