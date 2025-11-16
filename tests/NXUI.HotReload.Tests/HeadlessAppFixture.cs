using System;
using Avalonia;
using Avalonia.Headless;
using Xunit;

namespace NXUI.HotReload.Tests;

/// <summary>
/// Bootstraps a headless Avalonia application so tests can interact with Dispatcher-bound APIs.
/// </summary>
public sealed class HeadlessAppFixture : IDisposable
{
    private static bool s_initialized;

    public HeadlessAppFixture()
    {
        if (s_initialized)
        {
            return;
        }

        AppBuilder.Configure<HeadlessTestApp>()
            .UseHeadless(new AvaloniaHeadlessPlatformOptions
            {
                UseHeadlessDrawing = true,
            })
            .SetupWithoutStarting();

        s_initialized = true;
    }

    public void Dispose()
    {
    }

    private sealed class HeadlessTestApp : Application
    {
    }
}

[CollectionDefinition("HeadlessTests")]
public sealed class HeadlessTestsCollection : ICollectionFixture<HeadlessAppFixture>
{
}
