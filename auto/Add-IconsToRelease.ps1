$thisDir = Split-Path $MyInvocation.MyCommand.Path -Parent

$target = Resolve-Path "$thisDir\..\bin\Release\WinManGui.exe"

if (!(Test-Path $target)) {
    Write-Error "Target WinManGui.exe not found."
    exit 1
}

& "$thisDir\InsertIcons.exe" $target "$thisDir\icons.txt"
