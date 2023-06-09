$targetDir = Resolve-Path "$PSScriptRoot\..\bin\Release"
$version = & "$PSScriptRoot\Get-ProjectVersions.ps1" `
    | Where-Object Project -EQ "WinMan" `
    | ForEach-Object { $_.Version }

Push-Location $targetDir -ErrorAction Stop

Copy-Item "..\..\LICENSE.md" "."
Remove-Item "*.pdb"
Remove-Item "*.xml"

Compress-Archive -Path "*" -DestinationPath "..\..\releases\WinMan_v${version}.zip" `
    -CompressionLevel Optimal `
    -Force

Pop-Location
