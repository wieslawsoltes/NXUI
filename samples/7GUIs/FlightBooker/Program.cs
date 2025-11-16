using System;
using System.Globalization;
using System.Reactive.Linq;
using System.Reactive.Subjects;
using NXUI.HotReload;

const string format = "dd.MM.yyyy";

var startValue = new BehaviorSubject<string>(DateTime.Now.ToString(format));
var startDate = startValue.Select(ParseDateTime);

var endValue = new BehaviorSubject<string>(DateTime.Now.ToString(format));
var endDate = endValue.Select(ParseDateTime);

var isBookEnabled = Observable
  .CombineLatest(startDate, endDate)
  .Select(x => x.Count == 2 && x[0].valid && x[1].valid && x[0].date <= x[1].date);

var startDateErrors = startDate.Select(x => x.valid ? Enumerable.Empty<string>() : new[] { "Invalid date." });
var endDateErrors = endDate.Select(x => x.valid ? Enumerable.Empty<string>() : new[] { "Invalid date." });

var selected = new BehaviorSubject<int>(0);
var isEndEnabled = selected.Select(x => x == 1);

var showMessageDialog = new BehaviorSubject<bool>(false);
var bookMessage = new BehaviorSubject<string>("");

object Build()
  => Window()
    .Title("Book Flight").Padding(12).Width(500).Height(200)
    .Content(
      Panel().Children(
        StackPanel()
          .OrientationVertical().Spacing(12).HorizontalAlignmentCenter().VerticalAlignmentCenter()
          .Children(
            ComboBox()
              .ItemsSource(new[] { "one-way flight", "return flight" })
              .SelectedIndex(selected.Value)
              .OnSelectedIndex((_, o) => o.Subscribe(x => selected.OnNext(x))),
            TextBox()
              .Text(startValue)
              .Errors(startDateErrors)
              .OnText((_, o) => o.Subscribe(x => startValue.OnNext(x))),
            TextBox()
              .Text(endValue)
              .IsEnabled(isEndEnabled)
              .Errors(endDateErrors)
              .OnText((_, o) => o.Subscribe(x => endValue.OnNext(x))),
            Button()
              .Content("Book")
              .HorizontalAlignmentStretch()
              .IsEnabled(isBookEnabled)
              .OnClick((_, o) => o.Subscribe(_ =>
              {
                bookMessage.OnNext(selected.Value == 0
                  ? $"You have booked a one-way flight for {startValue.Value}"
                  : $"You have booked a return flight from {startValue.Value} to {endValue.Value}");
                showMessageDialog.OnNext(true);
              }))
          ),
        Border()
          .IsVisible(showMessageDialog)
          .Background(Brushes.White).BorderBrush(Brushes.Black).BorderThickness(1)
          .HorizontalAlignmentCenter().VerticalAlignmentCenter()
          .Child(
            StackPanel()
              .OrientationVertical().Margin(12)
              .Children(
                TextBlock()
                  .Text(bookMessage),
                Button()
                  .HorizontalAlignmentRight().VerticalAlignmentBottom()
                  .Content("OK")
                  .OnClick((_, o) => o.Subscribe(_ => showMessageDialog.OnNext(false)))
              )
          )
      )
    );

(bool valid, DateTime date) ParseDateTime(string value)
{
  var valid = DateTime.TryParseExact(value, format, CultureInfo.InvariantCulture, DateTimeStyles.None, out var date);
  return (valid, date);
}

return HotReloadHost.Run(Build, "FlightBooker", args);
