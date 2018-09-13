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
        private static string NormalizePath(string path)
            => path.Replace(Path.AltDirectorySeparatorChar, Path.DirectorySeparatorChar);

        public bool ClassicApp
        {
            get => !ModernApp;
            set => ModernApp = !value;
        }

        public bool IsMatch(WindowWrapper window)
        {
            if (ModernApp) return window.AppId == AppId;
            if (!StringMatching.IsMatch(TitlePattern, TitlePatternType, TitleIgnoreCase, window.Title)) return false;
            if (!StringMatching.IsMatch(WindowClassPattern, WindowClassPatternType, WindowClassIgnoreCase, window.WindowClass)) return false;

            if (!string.IsNullOrWhiteSpace(ProcessFileName))
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

        public int MatchingWindows => Core.DefaultCore.WindowWrappers.Where(IsMatch).Count();

        private static void GetCommandArgs(string commandLine, out string command, out string commandArgs)
        {
            command = null;
            commandArgs = null;
            if (commandLine == null) return;
            commandArgs = string.Empty;
            var respectSpace = true;
            for (var i = 0; i < commandLine.Length; i++)
            {
                if (commandLine[i] == '"') respectSpace = !respectSpace;
                if (commandLine[i] == ' ' && respectSpace)
                {
                    command = commandLine.Substring(0, i).Replace("\"", "");
                    if (commandLine.Length > i)
                    {
                        commandArgs = commandLine.Substring(i + 1).TrimStart(' ');
                    }
                    return;
                }
            }
            command = commandLine.Trim('"');
        }

        public static WindowPattern FromWindow(WindowWrapper w)
        {
            if (w.IsModernAppWindow)
            {
                return new WindowPattern()
                {
                    ModernApp = true,
                    AppId = w.AppId,
                    WorkingDir = w.Process?.StartInfo?.WorkingDirectory,
                };
            }
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
                ModernApp = false,
                TitlePattern = w.Title,
                WindowClassPattern = w.WindowClass,
                ProcessFileName = w.Process?.MainModule?.FileName,
                Command = command,
                CommandArgs = commandArgs,
                WorkingDir = w.Process?.StartInfo?.WorkingDirectory
            };
        }

        public bool IsRestorable => !string.IsNullOrWhiteSpace(Command) ||
                                    ModernApp && !string.IsNullOrWhiteSpace(AppId);

        public WindowWrapper[] Discover() => WindowWrapper.AllWindows().Where(IsMatch).ToArray();

        public override string ToString() => Name;

        public WindowPattern Clone() => (WindowPattern)MemberwiseClone();
    }
}
