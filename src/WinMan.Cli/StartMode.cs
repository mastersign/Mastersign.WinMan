using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Mastersign.WinMan
{
    [Flags]
    enum StartMode
    {
        None = 0,
        Help = 1,
        VersionInfo = 2,
        ApplyWorkspace = 4,
        SwitchVirtualDesktop = 8,
    }
}
