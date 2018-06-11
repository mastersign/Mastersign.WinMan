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

        public string[] TargetLayouts { get; }

        public bool IncludeDefaultLayouts { get; }

        public StartInfo(
            StartMode startMode, 
            string workspaceFile,
            string[] targetLayouts, 
            bool includeDefaultLayouts,
            int targetVirtualDesktop)
        {
            StartMode = startMode;
            WorkspaceFile = workspaceFile;
            TargetLayouts = targetLayouts;
            IncludeDefaultLayouts = includeDefaultLayouts;
            TargetVirtualDesktop = targetVirtualDesktop;
        }

        public bool IsTargetingSpecificLayouts => TargetLayouts != null && TargetLayouts.Length > 0;
    }
}
