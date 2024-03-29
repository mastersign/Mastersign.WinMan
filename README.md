Mastersign WinMan
=================

![](src/icon/winman_48.png)

> Manager for window layouts on Windows 10/11.

## Features

* Support for multiple display configurations / monitor setups
* Define multiple window layouts targeting only some or all of the display configurations
* Apply or kill window layouts via a graphical user interface or at the command line
* Support for modern apps

## Requirements

* Since v1.17.0 _WinMan_ is compatible with Windows 11
* Since v1.11.0 _WinMan_ requires **Microsoft .NET Framework 4.7.2** or higher
* Since v1.9.0 _WinMan_ requires **Windows 10 1809** or higher
* Since v1.5.0 _WinMan_ requires Windows 10 1803
* To use _WinMan_ on an earlier Windows 10 version
  download _WinMan_ v1.4.1
* Microsoft .NET Framework 4.6 or higher

## Quick Introduction

Currently, a setup program is missing, so just extract the ZIP file to a location of your choice.
To start the graphical user interface of _WinMan_ run `WinManGui.exe`.

1. Record one or more _Display Configuration Patterns_

    Imagine you use a notebook sometimes only with the integrated display, and sometimes in a docking station with two connected monitors.
    With display configuration patterns, you can prepare different window layouts, targeting different monitor setups.

2. Record/create _Window Patterns_

    To detect whether a certain window is already opened or not, some properties like title, process name and window class are used.
    To restore a window as part of a window layout, additional information like a command string and command line arguments are configured.

3. Create _Layouts_

    A layout lists a number of window patterns and specifies where a matching window should be positioned and whether it should be restored or not, if no open window matches the pattern.
    Every layout is targeting a specific display configuration.
    The window position includes the screen, the virtual desktop, and the position in pixel or percent.

    Some layouts can be marked as default layouts. Default layouts are applied if no specific layout is selected.

4. Apply _Layouts_

    You can apply layouts via the GUI (graphical user interface) of _WinMan_ `WinManGui.exe`.
    But it is more practical, to create shortcuts which are calling the CLI (command line interface) of _WinMan_ `winman.exe`.

    E.g. `winman.exe --layouts "My Layout"`

    _WinMan_ is looking for a layout with the given name, which is targeting the current display configuration.
    If it finds one or more matching layouts it applies them.
    If a layout with the same name exists for every display configuration, it can allways be applied and the fitting layout for the current display configuration is selected.

5. Kill _Layouts_ (since version 1.7.0)

    To close all windows, which are part of a layout, the appropriate button in the GUI could be used.
    But as with applying, the CLI is a good way too.

    E.g. `winman.exe --layouts "My Layout" --kill`

## Screenshots

![Display Configurations](screenshots/display-configurations.png)

![Window Patterns](screenshots/window-patterns.png)

![Layouts](screenshots/layouts.png)

## CLI Usage

To automate applying or killing window layouts in a shell script (CMD/PowerShell), the command line tool `winman.exe` can be used.

```
Mastersign WinMan
-----------------
WinMan Library Version: 1.9.0
WinMan CLI Version: 1.9.0

Usage: winman [<workspace file>] [<options>]*

If the workspace file is not specified, the default workspace file is used.
  %USERPROFILE%\winman_workspace.json

If no option is used, the default layouts are targeted.

Options:

  -h, --help, -?, /?
      Does print this help text. Ignores all other options.

  -v, --version
      Prints version information. Ignores all other options.

  -svd, --switch-virtual-desktop <no>
      Switch to the specified virtual desktop before applying the workspace.

  -l, --layouts <layout-name>*
      Target a specific set of layouts when applying the workspace.

  -d, --default-layouts
      Target the default layouts when applying the workspace.

  -K, --kill
      Instead of restoring windows, close matching windows.
```

## License

This project is published under the MIT license.
