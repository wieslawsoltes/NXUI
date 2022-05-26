const string format = "dd.MM.yyyy";
var start = new BehaviorSubject<string>(DateTime.Now.ToString(format));
var end = new BehaviorSubject<string>(DateTime.Now.ToString(format));
var selected = new BehaviorSubject<int>(0);
var startResult = start.Select(x => {
    var valid = DateTime.TryParseExact(x, format, CultureInfo.InvariantCulture, DateTimeStyles.None, out var date);
    return (valid, date);
});
var endResult = end.Select(x => {
    var valid = DateTime.TryParseExact(x, format, CultureInfo.InvariantCulture, DateTimeStyles.None, out var date);
    return (valid, date);
});
var isBookEnabled = Observable
    .CombineLatest(startResult, endResult)
    .Select(x => x.Count == 2 && x[0].valid && x[1].valid && x[0].date <= x[1].date);
var startErrors = startResult.Select(x => x.valid ? Enumerable.Empty<string>() : new[] {"Invalid date."});
var endErrors = endResult.Select(x => x.valid ? Enumerable.Empty<string>() : new[] {"Invalid date."});
var isEndEnabled = selected.Select(x => x == 1);
var showMessageDialog = new BehaviorSubject<bool>(false);
var bookMessage = new BehaviorSubject<string>("");

Window Build() 
    => Window()
        .Title("Book Flight").Padding(12).Width(500).Height(200)
        .Content(
            Panel().Children(
                StackPanel()
                    .OrientationVertical().Spacing(12).HorizontalAlignmentCenter().VerticalAlignmentCenter()
                    .Children(
                        ComboBox()
                            .Items(new [] { "one-way flight", "return flight" })
                            .SelectedIndex(selected.Value)
                            .OnSelectedIndex((_, o) => o.Subscribe(x => selected.OnNext(x))),
                        TextBox()
                            .Text(start)
                            .Errors(startErrors)
                            .OnText((_, o) => o.Subscribe(x => start.OnNext(x))),
                        TextBox()
                            .Text(end)
                            .IsEnabled(isEndEnabled)
                            .Errors(endErrors)
                            .OnText((_, o) => o.Subscribe(x => end.OnNext(x))),
                        Button()
                            .Content("Book")
                            .HorizontalAlignmentStretch()
                            .IsEnabled(isBookEnabled)
                            .OnClick((_, o) => o.Subscribe(_ => {
                                bookMessage.OnNext(selected.Value == 0
                                    ? $"You have booked a one-way flight for {start.Value}"
                                    : $"You have booked a return flight from {start.Value} to {end.Value}");
                                showMessageDialog.OnNext(true);
                            }))
                        ),
                Border()
                    .IsVisible(showMessageDialog)
                    .Background(Brushes.White)
                    .BorderBrush(Brushes.Black)
                    .BorderThickness(1)
                    .HorizontalAlignmentCenter().VerticalAlignmentCenter()
                    .Child(
                        StackPanel()
                            .OrientationVertical()
                            .Margin(12)
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

AppBuilder.Configure<Application>()
    .UsePlatformDetect()
    .UseFluentTheme()
    .WithApplicationName("FlightBooker")
    .StartWithClassicDesktopLifetime(Build, args);
