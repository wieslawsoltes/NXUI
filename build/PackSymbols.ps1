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

function Invoke-SymbolPack {
    param(
        [string] $Project,
        [string] $PackOutputPath,
        [string[]] $ExtraProperties = @()
    )

    $projectPath = Join-Path $repoRoot $Project
    $packArgs = @(
        "pack",
        $projectPath,
        "-c",
        $Configuration,
        "--no-build",
        "-o",
        $PackOutputPath,
        "-p:IncludeSymbols=true",
        "-p:SymbolPackageFormat=snupkg"
    )

    $packArgs += $ExtraProperties

    if ($Version) {
        $packArgs += "-p:Version=$Version"
    }

    if ($ContinuousIntegrationBuild) {
        $packArgs += "-p:ContinuousIntegrationBuild=true"
    }

    Write-Host "Packing symbols for $Project"
    & dotnet @packArgs
    if ($LASTEXITCODE -ne 0) {
        throw "dotnet pack failed for $Project with exit code $LASTEXITCODE."
    }
}

foreach ($project in $symbolProjects) {
    Invoke-SymbolPack -Project $project -PackOutputPath $resolvedOutputPath
}

$analyzerSymbolProjects = @(
    "src/NXUI.Analyzers/NXUI.Analyzers.csproj"
)

$analyzerOutputPath = Join-Path ([System.IO.Path]::GetTempPath()) "nxui-analyzer-symbols-$([System.Guid]::NewGuid().ToString('N'))"

try {
    New-Item -ItemType Directory -Force -Path $analyzerOutputPath | Out-Null

    # Analyzer packages suppress regular build output, so produce their snupkg in
    # isolation and copy only the symbol package back to the release artifacts.
    foreach ($project in $analyzerSymbolProjects) {
        Invoke-SymbolPack `
            -Project $project `
            -PackOutputPath $analyzerOutputPath `
            -ExtraProperties @(
                "-p:IncludeBuildOutput=true",
                "-p:BuildOutputTargetFolder=analyzers/dotnet/cs"
            )
    }

    $analyzerSymbolPackages = @(Get-ChildItem -Path $analyzerOutputPath -Filter "*.snupkg")
    if ($analyzerSymbolPackages.Count -eq 0) {
        throw "No analyzer symbol packages were produced."
    }

    $analyzerSymbolPackages | Copy-Item -Destination $resolvedOutputPath -Force
}
finally {
    if (Test-Path $analyzerOutputPath) {
        Remove-Item -Recurse -Force $analyzerOutputPath
    }
}
