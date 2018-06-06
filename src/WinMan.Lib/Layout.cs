using System;
using System.Collections.Generic;
using System.ComponentModel;
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
            if (!IsMatch(workspace, screens, vdCount))
            {
                return false;
            }
            var success = true;
            foreach (var windowAction in Windows)
            {
                if (!windowAction.Apply(workspace, this)) success = false;
            }
            return success;
        }

        public override string ToString() => $"{Configuration}: {Name}";

        public Layout Clone()
        {
            var result = (Layout)MemberwiseClone();
            result.Windows = new BindingList<WindowAction>(Windows.Select(wa => wa.Clone()).ToList());
            return result;
        }
    }
}
