using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Reflection;
using System.Text;
using System.Threading.Tasks;

namespace Mastersign.WinMan.Cli
{
    class Program
    {
        [STAThread]
        static int Main(string[] argv)
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
                    layouts.AddRange(core.Workspace.DefaultLayouts);
                }
                foreach (var layoutName in layoutNames)
                {
                    var layout = core.Workspace.FindLayout(layoutName);
                    if (layout == null)
                    {
                        Console.Error.WriteLine($"Could not find layout '{layoutName}'.");
                        result = false;
                    }
                    else if (!layouts.Contains(layout))
                    {
                        layouts.Add(layout);
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
