using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Reflection;
using System.Text;
using System.Threading.Tasks;

namespace Mastersign.WinMan.Cli
{
    internal class Program
    {
        [STAThread]
        private static int Main(string[] argv)
        {
            var startInfo = ArgumentParser.ParseArgs(argv);
            var success = true;
            _verbose = startInfo.Verbose;
            if (startInfo.StartMode.HasFlag(StartMode.Help))
            {
                PrintHelp();
            }
            if (startInfo.StartMode.HasFlag(StartMode.VersionInfo))
            {
                PrintVersionInfo();
            }
            if (startInfo.StartMode.HasFlag(StartMode.SwitchVirtualDesktop))
            {
                success = success && SwitchVirtualDesktop(startInfo.TargetVirtualDesktop);
            }
            if (startInfo.StartMode.HasFlag(StartMode.ApplyWorkspace))
            {
                success = success && ApplyWorkspace(startInfo.WorkspaceFile,
                    startInfo.IsTargetingSpecificLayouts,
                    startInfo.TargetLayouts,
                    startInfo.IncludeDefaultLayouts,
                    startInfo.StringReplacements,
                    startInfo.VirtualDesktopOverride,
                    startInfo.StartMode.HasFlag(StartMode.Kill));
            }
            if (_errorCnt > 0 && startInfo.WaitForInteractionWhenError)
            {
                Console.Write("Press any key to continue...");
                Console.ReadKey();
                Console.WriteLine();
            }
            return success ? 0 : -1;
        }

        private static bool _verbose;

        private static void PrintVerbose(string format, params object[] args)
        {
            if (!_verbose) return;
            Console.WriteLine(format, args);
        }

        private static int _errorCnt;

        private static void PrintError(string format, params object[] args)
        {
            _errorCnt++;
            var colorBackup = Console.ForegroundColor;
            Console.ForegroundColor = ConsoleColor.Red;
            Console.Error.WriteLine(format, args);
            Console.ForegroundColor = colorBackup;
        }

        private static void PrintStatus(StatusLevel level, string message)
        {
            switch (level)
            {
                case StatusLevel.Info:
                    PrintVerbose("    " + message);
                    break;
                case StatusLevel.Error:
                    PrintError("    " + message);
                    break;
            }
        }

        private static void PrintVersionInfo()
        {
            var libVersion = typeof(Core).Assembly.GetName().Version.ToString(3);
            var cliVersion = Assembly.GetExecutingAssembly().GetName().Version.ToString(3);
            Console.WriteLine("Mastersign WinMan");
            Console.WriteLine("-----------------");
            Console.WriteLine("WinMan Library Version: " + libVersion);
            Console.WriteLine("WinMan CLI Version: " + cliVersion);
        }

        private static void PrintHelp()
        {
            PrintVersionInfo();
            Console.WriteLine();
            Console.WriteLine("Usage: winman [<workspace file>] [<options>]*");
            Console.WriteLine();
            Console.WriteLine("If the workspace file is not specified, the default workspace file is used.");
            Console.WriteLine("  " + Core.DefaultWorkspaceFilePath);
            Console.WriteLine();
            Console.WriteLine("If no option is used, the default layouts are targeted.");
            Console.WriteLine();
            Console.WriteLine("Options:");
            Console.WriteLine();
            Console.WriteLine("  -h, --help, -?, /?");
            Console.WriteLine("      Does print this help text. Ignores all other options.");
            Console.WriteLine();
            Console.WriteLine("  -v, --version");
            Console.WriteLine("      Prints version information. Ignores all other options.");
            Console.WriteLine();
            Console.WriteLine("  -V, --verbose");
            Console.WriteLine("      Print progress messages.");
            Console.WriteLine();
            Console.WriteLine("  -w, --wait-on-error");
            Console.WriteLine("      Prompts for pressing a key before exit, if an error occured.");
            Console.WriteLine();
            Console.WriteLine("  -s, -svd, --switch-virtual-desktop <no>");
            Console.WriteLine("      Switch to the specified virtual desktop before applying the workspace.");
            Console.WriteLine();
            Console.WriteLine("  -o, -ovd, --override-virtual-desktop <no>");
            Console.WriteLine("      Overrides the virtual desktop of all targeted layouts.");
            Console.WriteLine();
            Console.WriteLine("  -l, --layouts <layout-name>*");
            Console.WriteLine("      Target a specific set of layouts when applying the workspace.");
            Console.WriteLine();
            Console.WriteLine("  -d, --default-layouts");
            Console.WriteLine("      Target the default layouts when applying the workspace.");
            Console.WriteLine();
            Console.WriteLine("  -r, --replace <search> <replacement>");
            Console.WriteLine("      Replace a string in the properties of window patterns.");
            Console.WriteLine("      This option can be used multiple times.");
            Console.WriteLine();
            Console.WriteLine("  -K, --kill");
            Console.WriteLine("      Instead of restoring windows, close matching windows.");
        }

        private static bool SwitchVirtualDesktop(int targetVirtualDesktop)
        {
            var vd = VirtualDesktopHelper.GetVirtualDesktop(targetVirtualDesktop - 1);
            if (vd == null)
            {
                PrintError($"Could not find the virtual desktop {targetVirtualDesktop}.");
                return false;
            }
            PrintVerbose("Switching to desktop {0}...", targetVirtualDesktop);
            try
            {
                vd.Switch();
            }
            catch (Exception e)
            {
#if DEBUG
                PrintError(e.ToString());
#else
                PrintError(e.Message);
#endif
                return false;
            }
            PrintVerbose("Finished successfully.");
            return true;
        }

        private static bool ApplyWorkspace(string workspaceFile,
            bool specificLayouts, string[] layoutNames, bool includeDefaultLayout,
            StringReplacement[] stringReplacements, int? virtualDesktopOverride,
            bool kill)
        {
            if (!File.Exists(workspaceFile))
            {
                PrintError($"The workspace file '{workspaceFile}' does not exist.");
                return false;
            }
            PrintVerbose("Loading workspace file:");
            PrintVerbose("- {0}", workspaceFile);
            var core = new Core();
            core.LoadWorkspaceFromFile(workspaceFile);
            if (core.Workspace == null)
            {
                PrintError($"Failed to load the workspace file '{workspaceFile}'.");
                return false;
            }
            Core.DefaultCore = core;

            PrintVerbose("Matching screen configurations:");
            // loading virtual desktops, fixes unmatched screen configuration
            VirtualDesktopHelper.LoadVirtualDesktops();
            var matchingConfigurations = new List<string>(
                core.Workspace.ConfigurationPatterns
                    .Where(cp => cp.Matches)
                    .Select(cp => cp.Name));
            foreach (var n in matchingConfigurations) PrintVerbose("- {0}", n);
            bool IsMatch(Layout l) => matchingConfigurations.Contains(l.Configuration);
            if (!specificLayouts)
            {
                PrintVerbose((kill ? "Killing" : "Applying") + " all default layouts:");
                foreach (var l in core.Workspace.DefaultLayouts.Where(IsMatch)) PrintVerbose("- {0}", l.Name);
                if (kill)
                    core.KillWorkspace(PrintStatus, new KillOverrides(stringReplacements));
                else
                {
                    if (virtualDesktopOverride.HasValue)
                        PrintVerbose("Overriding default virtual desktop: " + virtualDesktopOverride.Value);
                    core.ApplyWorkspace(PrintStatus, new ApplyOverrides(stringReplacements, virtualDesktopOverride));
                }
                PrintVerbose("Finished.");
                return true;
            }
            else
            {
                var result = true;
                var layouts = new List<Layout>();
                PrintVerbose("Selecting layouts:");
                if (includeDefaultLayout)
                {
                    foreach (var layout in core.Workspace.DefaultLayouts.Where(IsMatch))
                    {
                        PrintVerbose("- {0} (default)", layout.Name);
                        layouts.Add(layout);
                    }
                }
                foreach (var layoutName in layoutNames)
                {
                    var found = false;
                    foreach (var layout in core.Workspace.FindLayouts(layoutName))
                    {
                        found = true;
                        if (!IsMatch(layout)) continue;
                        if (!layouts.Contains(layout))
                        {
                            PrintVerbose("- {0}", layout.Name);
                            layouts.Add(layout);
                        }
                    }
                    if (!found)
                    {
                        PrintError($"Could not find layout '{layoutName}'.");
                        result = false;
                    }
                }
                PrintVerbose((kill ? "Killing" : "Applying") + " layouts:");
                foreach (var layout in layouts)
                {
                    PrintVerbose($"- {layout.Configuration}: {layout.Name}");
                    if (kill)
                    {
                        var cnt = layout.Kill(core.Workspace, PrintStatus, new KillOverrides(stringReplacements));
                        PrintVerbose($"    Closed windows: {cnt}");
                    }
                    else
                    {
                        if (!layout.Apply(core.Workspace, PrintStatus, new ApplyOverrides(stringReplacements, virtualDesktopOverride)))
                        {
                            PrintVerbose("    Failed");
                            result = false;
                        }
                        else
                        {
                            PrintVerbose("    Succeeded");
                        }
                    }
                }
                if (result) PrintVerbose("Finished successfully");
                return result;
            }
        }
    }
}
