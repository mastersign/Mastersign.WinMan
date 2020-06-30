$thisDir = Split-Path $MyInvocation.MyCommand.Path -Parent

$targetDir = Resolve-Path "$thisDir\..\bin\Release"
Push-Location $targetDir -ErrorAction Stop

Copy-Item "..\..\LICENSE.md" "."
Remove-Item "*.pdb"
Remove-Item "*.xml"

Pop-Location
