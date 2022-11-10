using System.Runtime.Versioning;
using Avalonia.Web;

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
  /// <typeparam name="T"></typeparam>
  /// <returns></returns>
  public static T SetupBrowserSingleViewLifetime<T>(
    this T builder, 
    Func<Control>? callback, 
    string mainDivId = "out") where T : AppBuilderBase<T>, new()
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
