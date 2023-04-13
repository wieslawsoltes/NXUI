using System;
using System.Diagnostics.CodeAnalysis;
using System.Runtime.Versioning;
using Avalonia;
using Avalonia.Browser;
using Avalonia.Controls;
using Avalonia.Controls.ApplicationLifetimes;

[assembly:SupportedOSPlatform("browser")]

namespace NXUI.Sample.Web;

/// <summary>
/// 
/// </summary>
public static class AppBuilderExtensions
{
  internal class BrowserSingleViewLifetime : ISingleViewApplicationLifetime
  {
    public AvaloniaView? View;

    public Control? MainView
    {
      get
      {
        EnsureView();
        return View.Content;
      }
      set
      {
        EnsureView();
        View.Content = value;
      }
    }

    [MemberNotNull(nameof(View))]
    private void EnsureView()
    {
      if (View is null)
      {
        throw new InvalidOperationException("Browser lifetime was not initialized. Make sure AppBuilder.StartBrowserApp was called.");
      }
    }
  }

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
