param (
    $Version = $null,
    $RootDir = $null,
    $NamePattern = "AssemblyInfo.cs"
)

if (!$RootDir) {
    $RootDir = Resolve-Path "$PSScriptRoot\..\src"
}

$files = Get-ChildItem -Path $RootDir -Directory -Recurse | Get-ChildItem -File -Filter $NamePattern

$versionPattern = "^\s*\[assembly: (?<type>AssemblyFileVersion)\(`"(?<version>.+?)`"\)\]\s*`$"
$versionRegex = New-Object System.Text.RegularExpressions.Regex($versionPattern, [System.Text.RegularExpressions.RegexOptions]::Multiline)

function Get-AssemblyFileVersion() {
    process {
        $code = Get-Content -Path $_.FullName -Encoding UTF8 | Out-String
        $project = $_.Directory.Parent.Name
        $match = $versionRegex.Match($code)
        if ($match.Success) {
            [PSCustomObject]@{
                "Project" = $project
                "Version" = $match.Groups["version"]
            }
        }
    }
}

$files | Get-AssemblyFileVersion
