using System;
using System.Linq;
using System.Reactive.Linq;
using System.Reactive.Subjects;
using NXUI.HotReload;

var celsius = new Subject<double?>();
var fahrenheit = new Subject<double?>();

object Build()
  => Window()
    .Title("TempConv").Padding(12).Width(450).Height(200)
    .Content(
      StackPanel()
        .OrientationHorizontal().Spacing(12).HorizontalAlignmentCenter().VerticalAlignmentCenter()
        .Children(
          TextBox()
            .Text(celsius.Select(x => x.ToString()))
            .OnTextChanged((tc, o) => o
              .Select(_ => tc.Text ?? string.Empty)
              .Subscribe(x => OnNextValue(tc, x, fahrenheit, ToFahrenheit))),
          Label()
            .HorizontalAlignmentCenter().VerticalAlignmentCenter()
            .Content("Celsius = "),
          TextBox()
            .Text(fahrenheit.Select(x => x.ToString()))
            .OnTextChanged((tf, o) => o
              .Select(_ => tf.Text ?? string.Empty)
              .Subscribe(x => OnNextValue(tf, x, celsius, ToCelsius))),
          Label()
            .HorizontalAlignmentCenter().VerticalAlignmentCenter()
            .Content("Fahrenheit")));

return HotReloadHost.Run(Build, "TempConv", args);

static void OnNextValue(TextBox textBox, string s, IObserver<double?> subject, Func<double, double> conv)
{
  textBox.Errors(Enumerable.Empty<string>());
  if (string.IsNullOrWhiteSpace(s)) return;
  if (!double.TryParse(s, out var value))
  {
    textBox.Errors(new[] { "Invalid number." });
    return;
  }

  subject.OnNext(conv(value));
}

static double ToFahrenheit(double c) => Math.Round(c * (9d / 5d) + 32d);

static double ToCelsius(double f) => Math.Round((f - 32d) * (5d / 9d));
