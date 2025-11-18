using System.Linq;
using AssemblyToProcess;
using NXUI.Cli;
using Xunit;

namespace NXUI.Cli.Tests;

public class BoundaryInspectorTests
{
    private static readonly string AssemblyPath = typeof(DerivedTextBox).Assembly.Location;

    private static readonly string[] Manifest =
    [
        "Avalonia.Controls.TextBox"
    ];

    [Fact]
    public void ReportsManifestMatches()
    {
        var infos = BoundaryInspector.Inspect(AssemblyPath, Manifest);
        Assert.Contains(infos, info => info.TypeName.EndsWith("DerivedTextBox") && info.ManifestMatch);
    }

    [Fact]
    public void ReportsCandidateAttributes()
    {
        var infos = BoundaryInspector.Inspect(AssemblyPath, Manifest);
        Assert.Contains(infos, info => info.TypeName.EndsWith("CandidateBoundaryControl") && info.HasCandidateAttribute);
    }

    [Fact]
    public void FlagsStateAdapterTypes()
    {
        var infos = BoundaryInspector.Inspect(AssemblyPath, Manifest);
        Assert.Contains(infos, info => info.TypeName.EndsWith("StateAdapterControl") && info.ImplementsStateAdapter);
    }
}
