using System;
using Avalonia.Controls;
using Avalonia.Styling;
using Xunit;

namespace NXUI.HotReload.Tests;

public sealed class HotReloadHostApiTests
{
    [Fact]
    public void HotReloadHost_Is_Public_In_Expected_Namespace()
    {
        var type = typeof(HotReloadHost);

        Assert.Equal("NXUI.HotReload.HotReloadHost", type.FullName);
        Assert.True(type.IsPublic);
        Assert.True(type.IsAbstract);
        Assert.True(type.IsSealed);
    }

    [Fact]
    public void Run_Exposes_File_Based_App_Signature()
    {
        Func<Func<object>, string, string[], ThemeVariant?, ShutdownMode, int> run = HotReloadHost.Run;

        Assert.NotNull(run);
    }
}
