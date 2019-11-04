using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Mastersign.WinMan
{
    class StartInfo
    {
        public StartMode StartMode { get; }

        public string WorkspaceFile { get; }

        public bool Verbose { get; }

        public bool WaitForInteractionWhenError { get; }

        public string[] TargetLayouts { get; }

        public bool IncludeDefaultLayouts { get; }

        public int TargetVirtualDesktop { get; }

        public StringReplacement[] StringReplacements { get; }

        public StartInfo(
            StartMode startMode, 
            string workspaceFile,
            bool verbose,
            bool waitForInteractionWhenError,
            string[] targetLayouts, 
            bool includeDefaultLayouts,
            int targetVirtualDesktop,
            StringReplacement[] stringReplacements
            )
        {
            StartMode = startMode;
            WorkspaceFile = workspaceFile;
            Verbose = verbose;
            WaitForInteractionWhenError = waitForInteractionWhenError;
            TargetLayouts = targetLayouts;
            IncludeDefaultLayouts = includeDefaultLayouts;
            TargetVirtualDesktop = targetVirtualDesktop;
            StringReplacements = stringReplacements;
        }

        public bool IsTargetingSpecificLayouts => TargetLayouts != null && TargetLayouts.Length > 0;
    }
}
