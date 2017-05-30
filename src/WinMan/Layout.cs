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
        public ScreenPattern FindScreenPattern(string screenPatternName)
            => Configurations.Select(c => c.FindScreenPattern(screenPatternName))
                .FirstOrDefault(s => s != null && s.Name == screenPatternName);

        public bool IsMatch(Screen[] screens, int virtualDesktopCount)
            => Configurations.Any(c => c.IsMatch(screens, virtualDesktopCount));

        public bool Apply(Workspace workspace)
        {
            var screens = Screen.AllScreens;
            var vdCount = VirtualDesktop.GetDesktops().Length;
            if (!IsMatch(screens, vdCount)) return false;
            return Windows.All(wa => wa.Apply(workspace, this));
        }

        public override string ToString() => Name;
    }
}
