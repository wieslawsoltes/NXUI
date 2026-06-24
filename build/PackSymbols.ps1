[CmdletBinding()]
param(
    [string] $Configuration = "Release",
    [string] $OutputPath = "artifacts/packages",
    [string] $Version = "",
    [switch] $ContinuousIntegrationBuild
)

Set-StrictMode -Version Latest
$ErrorActionPreference = "Stop"

$repoRoot = Split-Path -Parent $PSScriptRoot
$resolvedOutputPath = if ([System.IO.Path]::IsPathRooted($OutputPath)) {
    $OutputPath
} else {
    Join-Path $repoRoot $OutputPath
}

New-Item -ItemType Directory -Force -Path $resolvedOutputPath | Out-Null

$symbolProjects = @(
    "src/NXUI/NXUI.csproj",
    "src/NXUI.Desktop/NXUI.Desktop.csproj",
    "src/NXUI.Cli/NXUI.Cli.csproj",
    "src/NXUI.Fody/BoundaryWeaver/BoundaryWeaver.csproj",
    "src/Reflectonia/Reflectonia.csproj"
)

foreach ($project in $symbolProjects) {
    $projectPath = Join-Path $repoRoot $project
    $packArgs = @(
        "pack",
        $projectPath,
        "-c",
        $Configuration,
        "--no-build",
        "-o",
        $resolvedOutputPath,
        "-p:IncludeSymbols=true",
        "-p:SymbolPackageFormat=snupkg"
    )

    if ($Version) {
        $packArgs += "-p:Version=$Version"
    }

    if ($ContinuousIntegrationBuild) {
        $packArgs += "-p:ContinuousIntegrationBuild=true"
    }

    Write-Host "Packing symbols for $project"
    & dotnet @packArgs
    if ($LASTEXITCODE -ne 0) {
        throw "dotnet pack failed for $project with exit code $LASTEXITCODE."
    }
}
