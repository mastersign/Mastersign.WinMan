$thisDir = Split-Path $MyInvocation.MyCommand.Path -Parent

$target = Resolve-Path "$thisDir\..\bin\Release\WinManGui.exe"

if (!(Test-Path $target)) {
    Write-Error "Target WinManGui.exe not found."
    exit 1
}

Read-Host "Deactivate Realtime Antivirus to allow modifying the EXE without interruptions and press ENTER"

& "$thisDir\InsertIcons.exe" $target "$thisDir\icons.txt"

Read-Host "Reactivate Realtime Antivirus again! And press ENTER"
