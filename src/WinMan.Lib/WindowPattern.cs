using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Management;
using System.Text;
using System.Text.RegularExpressions;
using System.Threading.Tasks;

namespace Mastersign.WinMan
{
    partial class WindowPattern
    {
        private string NormalizePath(string path) => path.Replace(Path.AltDirectorySeparatorChar, Path.DirectorySeparatorChar);

        public bool IsMatch(WindowWrapper window)
        {
            if (!StringMatching.IsMatch(TitlePattern, TitlePatternType, TitleIgnoreCase, window.Title)) return false;
            if (!StringMatching.IsMatch(WindowClassPattern, WindowClassPatternType, WindowClassIgnoreCase, window.WindowClass)) return false;

            if (ProcessFileName != null)
            {
                var processPattern = NormalizePath(ProcessFileName);
                var processMainModule = window.ProcessFileName;
                if (processMainModule != null)
                {
                    processMainModule = NormalizePath(processMainModule);
                    if (Path.IsPathRooted(processPattern))
                    {
                        if (!processMainModule.Equals(processPattern, StringComparison.InvariantCultureIgnoreCase)) return false;
                    }
                    else
                    {
                        if (!processMainModule.EndsWith(processPattern, StringComparison.InvariantCultureIgnoreCase)) return false;
                    }
                }
            }
            return true;
        }

        private static void GetCommandArgs(string commandLine, out string command, out string commandArgs)
        {
            command = null;
            commandArgs = null;
            if (commandLine == null) return;
            var respectSpace = true;
            for (int i = 0; i < commandLine.Length; i++)
            {
                if (commandLine[i] == '"') respectSpace = !respectSpace;
                if (commandLine[i] == ' ' && respectSpace)
                {
                    command = commandLine.Substring(0, i - 1).Replace("\"", "");
                    commandArgs = commandLine.Substring(i + 1);
                    break;
                }
            }
        }

        public static WindowPattern FromWindow(WindowWrapper w)
        {
            var process = w.Process;
            string command = null;
            string commandArgs = null;
            if (process != null)
            {
                var wmiQuery = $"SELECT CommandLine FROM Win32_Process WHERE ProcessId={process.Id}";
                var objectSearcher = new ManagementObjectSearcher(wmiQuery);
                var results = objectSearcher.Get();
                try
                {
                    foreach (var o in results)
                    {
                        foreach (var p in o.Properties)
                        {
                            if (p.Name == "CommandLine")
                            {
                                GetCommandArgs(p.Value as string, out command, out commandArgs);
                            }
                        }
                        break;
                    }
                }
                finally
                {
                    results.Dispose();
                    objectSearcher.Dispose();
                }
            }

            return new WindowPattern()
            {
                TitlePattern = w.Title,
                WindowClassPattern = w.WindowClass,
                ProcessFileName = w.Process?.MainModule?.FileName,
                Command = command,
                CommandArgs = commandArgs,
                WorkingDir = w.Process?.StartInfo?.WorkingDirectory
            };
        }

        public WindowWrapper[] Discover() => WindowWrapper.AllWindows().Where(w => IsMatch(w)).ToArray();

        public override string ToString() => Name;
    }
}
