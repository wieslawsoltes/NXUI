using System;
using Avalonia;
using Avalonia.Controls;
using Avalonia.Controls.ApplicationLifetimes;
using Avalonia.Headless.XUnit;
using NXUI.HotReload;
using NXUI.HotReload.Nodes;
using Xunit;

namespace NXUI.HotReload.Tests;

[Collection("HeadlessTests")]
public sealed class ClassicDesktopComponentHostTests
{
    [AvaloniaFact]
    public void RootReplacementDoesNotDisposeHandle()
    {
        ReplacementWindow.ClosedCount = 0;
        AnotherReplacementWindow.ClosedCount = 0;

        var lifetime = new TestDesktopLifetime();
        var host = new ClassicDesktopComponentHost(lifetime);
        var factory = new TestComponentFactory();
        var handle = new ComponentHandle("TestComponent", factory.CreateNode, host, null);

        var initialSnapshot = factory.CreateNode();
        var initialWindow = (Window)handle.Attach(initialSnapshot);

        Assert.Same(initialWindow, lifetime.MainWindow);

        factory.CurrentType = typeof(ReplacementWindow);
        handle.TryRefresh("FirstUpdate");

        var replacementWindow = Assert.IsType<ReplacementWindow>(lifetime.MainWindow);

        factory.CurrentType = typeof(AnotherReplacementWindow);
        Exception? secondRefreshError = null;
        secondRefreshError = Record.Exception(() => handle.TryRefresh("SecondUpdate"));
        Assert.Null(secondRefreshError);
        var secondWindow = Assert.IsType<AnotherReplacementWindow>(lifetime.MainWindow);
        Assert.Equal(1, ReplacementWindow.ClosedCount);
        Assert.Equal(0, AnotherReplacementWindow.ClosedCount);

        handle.Dispose();
        Assert.Equal(1, ReplacementWindow.ClosedCount);
        Assert.Equal(1, AnotherReplacementWindow.ClosedCount);

        lifetime.Dispose();
    }

    private sealed class TestComponentFactory
    {
        public Type CurrentType { get; set; } = typeof(Window);

        public ElementNode CreateNode()
        {
            var type = CurrentType;
            return new ElementNode(type, 0, () => (AvaloniaObject)Activator.CreateInstance(type)!);
        }
    }

    private sealed class TestDesktopLifetime : ClassicDesktopStyleApplicationLifetime
    {
        public TestDesktopLifetime()
        {
            ShutdownMode = ShutdownMode.OnExplicitShutdown;
        }

        public void RaiseExit(int exitCode = 0)
        {
            Shutdown(exitCode);
        }
    }

    private sealed class ReplacementWindow : Window
    {
        public static int ClosedCount;

        public ReplacementWindow()
        {
            Closed += (_, _) => ClosedCount++;
        }
    }

    private sealed class AnotherReplacementWindow : Window
    {
        public static int ClosedCount;

        public AnotherReplacementWindow()
        {
            Closed += (_, _) => ClosedCount++;
        }
    }
}
