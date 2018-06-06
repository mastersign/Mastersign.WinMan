param (
    $Version = $null,
    $RootDir = $null,
    $NamePattern = "AssemblyInfo.cs"
)

$myDir = [IO.Path]::GetDirectoryName($MyInvocation.MyCommand.Definition)

if (!$RootDir) {
    $RootDir = Resolve-Path "$myDir\..\src"
}

$files = Get-ChildItem -Path $RootDir -Directory -Recurse | Get-ChildItem -File -Filter $NamePattern

$versionPattern = "^\s*\[assembly: (?<type>Assembly(?:File)?Version)\(`"(?<version>.+?)`"\)\]\s*`$"
$versionRegex = New-Object System.Text.RegularExpressions.Regex($versionPattern, [System.Text.RegularExpressions.RegexOptions]::Multiline)

function Show-Version() {
    process {
        $code = Get-Content -Path $_.FullName -Encoding UTF8 | Out-String
        "$($_.FullName):"
        $matches = $versionRegex.Matches($code)
        foreach ($m in $matches) {
            "  - $($m.Groups["type"]): $($m.Groups["version"])"
        }
    }
}

function Replace-Version($newVersion) {
    process {
        $code = Get-Content -Path $_.FullName -Encoding UTF8 | Out-String
        $code = $versionRegex.Replace($code, "[assembly: `$1(`"$newVersion`")]")
        $code | Set-Content -Path $_.FullName -Encoding UTF8
    }
}

echo "Existing Versions"
echo ""
$files | Show-Version | Out-Default
echo ""
$newVersion = Read-Host "New Version"

$files | Replace-Version $newVersion
