using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
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
                var processMainModule = window.Process?.MainModule?.FileName;
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

        public static WindowPattern FromWindow(WindowWrapper w)
            => new WindowPattern()
                {
                    TitlePattern = w.Title,
                    WindowClassPattern = w.WindowClass,
                    ProcessFileName = w.Process?.MainModule?.FileName,
                    Command = w.Process?.StartInfo?.FileName,
                    CommandArgs = w.Process?.StartInfo?.Arguments,
                    WorkingDir = w.Process?.StartInfo?.WorkingDirectory
                };

        public override string ToString() => Name;
    }
}
