﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Mastersign.WinMan
{
    class StartInfo
    {
        public StartMode StartMode { get; private set; }

        public string WorkspaceFile { get; private set; }

        public string[] TargetLayouts { get; private set; }

        public bool IncludeDefaultLayouts { get; private set; }

        public StartInfo(StartMode startMode, string workspaceFile,
            string[] targetLayouts, bool includeDefaultLayouts)
        {
            StartMode = startMode;
            WorkspaceFile = workspaceFile;
            TargetLayouts = targetLayouts;
            IncludeDefaultLayouts = includeDefaultLayouts;
        }

        public bool IsTargetingSpecificLayouts => TargetLayouts != null && TargetLayouts.Length > 0;
    }
}