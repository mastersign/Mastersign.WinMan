using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Mastersign.WinMan.Cli
{
    static class ArgumentParser
    {
        public static StartInfo ParseArgs(string[] argv)
        {
            var startMode = StartMode.None;
            var workspaceFile = Core.DefaultWorkspaceFilePath;
            var verbose = false;
            var waitForInteractionWhenError = false;
            var layoutNames = new List<string>();
            var includeDefaultLayouts = false;
            var virtualDesktopOverride = (int?)null;
            var targetVirtualDesktop = 0;
            var stringReplacements = new List<StringReplacement>();

            for (var i = 0; i < argv.Length; i++)
            {
                var arg = argv[i];
                if (arg == "-h" || arg == "--help" || arg == "-?" || arg == "/?")
                {
                    startMode = StartMode.Help;
                    break;
                }
                if (arg == "-v" || arg == "--version")
                {
                    startMode = StartMode.VersionInfo;
                    break;
                }
                if (arg == "-V" || arg == "--verbose")
                {
                    verbose = true;
                }
                else if (arg == "-w" || arg == "--wait-on-error")
                {
                    waitForInteractionWhenError = true;
                }
                else if (arg == "-K" || arg == "--kill")
                {
                    startMode |= StartMode.Kill;
                }
                else if (arg == "-d" || arg == "--default-layouts")
                {
                    startMode |= StartMode.ApplyWorkspace;
                    includeDefaultLayouts = true;
                }
                else if (arg == "-l" || arg == "--layout" || arg == "--layouts")
                {
                    i++;
                    for (; i < argv.Length && !argv[i].StartsWith("-"); i++)
                    {
                        startMode |= StartMode.ApplyWorkspace;
                        layoutNames.Add(argv[i]);
                    }
                    i--;
                }
                else if (arg == "-o" || arg == "-ovd" || arg == "--override-virtual-desktop")
                {
                    i++;
                    if (i < argv.Length && !argv[i].StartsWith("-"))
                    {
                        if (int.TryParse(argv[i], out int vdOverrideValue))
                        {
                            virtualDesktopOverride = vdOverrideValue;
                        }
                    }
                }
                else if (arg == "-s" || arg == "-svd" || arg == "--switch-virtual-desktop")
                {
                    i++;
                    if (i < argv.Length && !argv[i].StartsWith("-"))
                    {
                        if (int.TryParse(argv[i], out targetVirtualDesktop))
                        {
                            startMode |= StartMode.SwitchVirtualDesktop;
                        }
                    }
                }
                else if (arg == "-r" || arg == "--replace")
                {
                    if (i + 2 < argv.Length)
                    {
                        stringReplacements.Add(new StringReplacement(argv[i + 1], argv[i + 2]));
                        i += 2;
                    }
                    else
                    {
                        i = argv.Length;
                    }
                }
                else
                {
                    workspaceFile = arg;
                }
            }

            if (startMode == StartMode.None)
            {
                startMode = StartMode.ApplyWorkspace;
            }

            return new StartInfo(
                startMode,
                workspaceFile,
                verbose,
                waitForInteractionWhenError,
                layoutNames.ToArray(),
                includeDefaultLayouts,
                virtualDesktopOverride,
                targetVirtualDesktop,
                stringReplacements.ToArray());
        }
    }
}
