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
$solutionPath = Join-Path $repoRoot "NXUI.sln"
$resolvedOutputPath = if ([System.IO.Path]::IsPathRooted($OutputPath)) {
    $OutputPath
} else {
    Join-Path $repoRoot $OutputPath
}

New-Item -ItemType Directory -Force -Path $resolvedOutputPath | Out-Null

$packArgs = @(
    "pack",
    $solutionPath,
    "-c",
    $Configuration,
    "--no-build",
    "-o",
    $resolvedOutputPath
)

if ($Version) {
    $packArgs += "-p:Version=$Version"
}

if ($ContinuousIntegrationBuild) {
    $packArgs += "-p:ContinuousIntegrationBuild=true"
}

Write-Host "Packing NuGet packages from $solutionPath"
& dotnet @packArgs
if ($LASTEXITCODE -ne 0) {
    throw "dotnet pack failed for $solutionPath with exit code $LASTEXITCODE."
}
