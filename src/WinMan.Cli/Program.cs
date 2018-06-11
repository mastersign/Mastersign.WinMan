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
                    startInfo.IncludeDefaultLayouts);
            }
            return success ? 0 : -1;
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
            Console.WriteLine("  -svd, --switch-virtual-desktop <no>");
            Console.WriteLine("      Switch to the specified virtual desktop before applying the workspace.");
            Console.WriteLine();
            Console.WriteLine("  -l, --layouts <layout-name>*");
            Console.WriteLine("      Target a specific set of layouts when applying the workspace.");
            Console.WriteLine();
            Console.WriteLine("  -d, --default-layouts");
            Console.WriteLine("      Target the default layouts when applying the workspace.");
        }

        private static bool SwitchVirtualDesktop(int targetVirtualDesktop)
        {
            var vd = VirtualDesktopHelper.GetVirtualDesktop(targetVirtualDesktop - 1);
            if (vd == null)
            {
                Console.Error.WriteLine($"Could not find the virtual desktop {targetVirtualDesktop}.");
                return false;
            }
            try
            {
                vd.Switch();
            }
            catch (Exception e)
            {
#if DEBUG
                Console.Error.WriteLine(e);
#else
                Console.Error.WriteLine(e.Message);
#endif
                return false;
            }
            return true;
        }

        private static bool ApplyWorkspace(string workspaceFile, bool specificLayouts, string[] layoutNames, bool includeDefaultLayout)
        {
            if (!File.Exists(workspaceFile))
            {
                Console.Error.WriteLine($"The workspace file '{workspaceFile}' does not exist.");
                return false;
            }
            var core = new Core();
            core.LoadWorkspaceFromFile(workspaceFile);
            if (core.Workspace == null)
            {
                Console.Error.WriteLine($"Failed to load the workspace file '{workspaceFile}'.");
                return false;
            }
            Core.DefaultCore = core;

            var matchingConfigurations = new List<string>(
                core.Workspace.ConfigurationPatterns
                    .Where(cp => cp.Matches)
                    .Select(cp => cp.Name));
            foreach (var n in matchingConfigurations) PrintVerbose("- {0}", n);
            bool IsMatch(Layout l) => matchingConfigurations.Contains(l.Configuration);
            if (!specificLayouts)
            {
                core.ApplyWorkspace();
                return true;
            }
            else
            {
                var result = true;
                var layouts = new List<Layout>();
                if (includeDefaultLayout)
                {
                    foreach (var layout in core.Workspace.DefaultLayouts.Where(IsMatch))
                    {
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
                        Console.Error.WriteLine($"Could not find layout '{layoutName}'.");
                        result = false;
                    }
                }
                foreach (var layout in layouts)
                {
                    if (!layout.Apply(core.Workspace))
                    {
                        result = false;
                    }
                }
                return result;
            }
        }

    }
}
