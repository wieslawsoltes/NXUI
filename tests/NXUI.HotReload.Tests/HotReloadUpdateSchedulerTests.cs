using System;
using System.Threading.Tasks;
using Avalonia.Headless.XUnit;
using NXUI.HotReload;
using Xunit;

namespace NXUI.HotReload.Tests;

[Collection("HeadlessTests")]
public sealed class HotReloadUpdateSchedulerTests
{
    [AvaloniaFact]
    public async Task AggregatesMultipleNotifications()
    {
        var registry = new ComponentRegistry();
        var firstCompletion = new TaskCompletionSource<(Type[]? Types, string Source)>(TaskCreationOptions.RunContinuationsAsynchronously);
        var secondCompletion = new TaskCompletionSource<(Type[]? Types, string Source)>(TaskCreationOptions.RunContinuationsAsynchronously);
        var gate = new object();
        var invocationCount = 0;

        var scheduler = new HotReloadUpdateScheduler(
            registry,
            TimeSpan.FromMilliseconds(5),
            (types, source) =>
            {
                int current;
                lock (gate)
                {
                    current = ++invocationCount;
                }

                if (current == 1)
                {
                    firstCompletion.TrySetResult((types, source));
                }
                else if (current == 2)
                {
                    secondCompletion.TrySetResult((types, source));
                }
            });

        scheduler.RequestRefresh(new[] { typeof(string) }, "First");
        scheduler.RequestRefresh(new[] { typeof(int) }, "Second");

        var first = await firstCompletion.Task.WaitAsync(TimeSpan.FromSeconds(1));
        Assert.NotNull(first.Types);
        Assert.Equal(2, first.Types!.Length);
        Assert.Contains(typeof(string), first.Types);
        Assert.Contains(typeof(int), first.Types);
        Assert.Equal("First, Second", first.Source);

        scheduler.RequestRefresh(new[] { typeof(double) }, "Third");

        var second = await secondCompletion.Task.WaitAsync(TimeSpan.FromSeconds(1));
        Assert.NotNull(second.Types);
        Assert.Single(second.Types!);
        Assert.Equal(typeof(double), second.Types![0]);
        Assert.Equal("Third", second.Source);
    }

    [AvaloniaFact]
    public async Task PrefersGlobalRefreshWhenAnyNotificationRequestsFullRefresh()
    {
        var registry = new ComponentRegistry();
        var completion = new TaskCompletionSource<(Type[]? Types, string Source)>(TaskCreationOptions.RunContinuationsAsynchronously);

        var scheduler = new HotReloadUpdateScheduler(
            registry,
            TimeSpan.FromMilliseconds(5),
            (types, source) => completion.TrySetResult((types, source)));

        scheduler.RequestRefresh(null, "ClearCache");
        scheduler.RequestRefresh(new[] { typeof(string) }, "UpdateApplication");

        var result = await completion.Task.WaitAsync(TimeSpan.FromSeconds(1));
        Assert.Null(result.Types);
        Assert.Equal("ClearCache, UpdateApplication", result.Source);
    }
}
