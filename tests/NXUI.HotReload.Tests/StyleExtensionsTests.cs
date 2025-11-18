using Avalonia.Styling;
using NXUI.Extensions;
using Xunit;
using static NXUI.Builders;

namespace NXUI.HotReload.Tests;

[Collection("HeadlessTests")]
public class StyleExtensionsTests
{
    [Fact]
    public void StyleBuilder_Can_Use_ResourceDictionary_Builder()
    {
        var style = Style()
            .Resources(
                ResourceDictionary()
                    .WithAction(dictionary => dictionary["Key"] = "Value"))
            .Mount();

        Assert.Equal("Value", style.Resources["Key"]);
    }
}
