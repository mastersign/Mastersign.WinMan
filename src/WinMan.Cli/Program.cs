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
            switch (startInfo.StartMode)
            {
                case StartMode.Help:
                    PrintHelp();
                    return 0;
                case StartMode.VersionInfo:
                    PrintVersionInfo();
                    return 0;
                case StartMode.ApplyWorkspace:
                    return ApplyWorkspace(startInfo.WorkspaceFile,
                       startInfo.IsTargetingSpecificLayouts,
                       startInfo.TargetLayouts,
                       startInfo.IncludeDefaultLayouts);
                default:
                    return -1;
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
            Console.WriteLine("Options:");
            Console.WriteLine();
            Console.WriteLine("  -h, --help, -?, /?");
            Console.WriteLine("      Does print this help text. Ignores all other options.");
            Console.WriteLine();
            Console.WriteLine("  -v, --version");
            Console.WriteLine("      Prints version information. Ignores all other options.");
            Console.WriteLine();
            Console.WriteLine("  -l, --layouts <layout-name>*");
            Console.WriteLine("      Target a specific set of layouts when applying the workspace.");
            Console.WriteLine();
            Console.WriteLine("  -d, --default-layouts");
            Console.WriteLine("      Include the default layouts when targeting specific layouts.");
            Console.WriteLine("      Is ignored without the --layouts option.");
        }

        private static int ApplyWorkspace(string workspaceFile, bool specificLayouts, string[] layoutNames, bool includeDefaultLayout)
        {
            if (!File.Exists(workspaceFile))
            {
                Console.Error.WriteLine($"The workspace file '{workspaceFile}' does not exist.");
                return -1;
            }
            var core = new Core();
            core.LoadWorkspaceFromFile(workspaceFile);
            if (core.Workspace == null)
            {
                Console.Error.WriteLine($"Failed to load the workspace file '{workspaceFile}'.");
                return -1;
            }
            if (!specificLayouts)
            {
                core.ApplyWorkspace();
                return 0;
            }
            else
            {
                var result = 0;
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
                        result = 1;
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
                        result = 2;
                    }
                }
                return result;
            }
        }

    }
}
