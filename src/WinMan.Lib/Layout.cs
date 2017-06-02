using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using WindowsDesktop;

namespace Mastersign.WinMan
{
    partial class Layout
    {
        public bool IsMatch(Workspace workspace, Screen[] screens, int virtualDesktopCount)
        {
            var configurationPattern = workspace.FindConfigurationPattern(Configuration);
            if (configurationPattern == null) return false;
            return configurationPattern.IsMatch(screens, virtualDesktopCount);
        }

        public bool Apply(Workspace workspace)
        {
            var screens = Screen.AllScreens;
            var vdCount = VirtualDesktop.GetDesktops().Length;
            if (!IsMatch(workspace, screens, vdCount)) return false;
            return Windows.All(wa => wa.Apply(workspace, this));
        }

        public override string ToString() => Name + " - " + Configuration;
    }
}
