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
            var startMode = StartMode.ApplyWorkspace;
            var workspaceFile = Core.DefaultWorkspaceFilePath;
            var layoutNames = new List<string>();
            var includeDefaultLayouts = false;

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
                else if (arg == "-d" || arg == "--default-layouts")
                {
                    includeDefaultLayouts = true;
                }
                else if (arg == "-l" || arg == "--layouts")
                {
                    i++;
                    for (; i < argv.Length && !argv[i].StartsWith("-"); i++)
                    {
                        layoutNames.Add(argv[i]);
                    }
                    i--;
                }
            }

            return new StartInfo(startMode, workspaceFile, 
                layoutNames.ToArray(), includeDefaultLayouts);
        }
    }
}
