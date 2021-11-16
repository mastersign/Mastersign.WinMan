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
    partial class ConfigurationPattern
    {
        public bool IsMatch(Screen[] screens, int virtualDesktopCount)
            => screens.Length >= Screens.Count &&
               (!RespectScreenCount || screens.Length == Screens.Count) &&
               Screens.All(p => screens.Any(p.IsMatch)) &&
               (!RespectVirtualDesktopCount || VirtualDesktopCount == virtualDesktopCount);

        public bool Matches => IsMatch(Screen.AllScreens, VirtualDesktop.GetDesktops().Length);

        public static ConfigurationPattern FromConfiguration(Screen[] screens, int virtualDesktopCount)
            => new ConfigurationPattern()
                {
                    VirtualDesktopCount = virtualDesktopCount,
                    RespectVirtualDesktopCount = true,
                    Screens = new BindingList<ScreenPattern>(screens.Select(ScreenPattern.FromScreen).ToList()),
                };

        public ScreenPattern FindScreenPattern(string screenPatternName)
            => Screens.FirstOrDefault(s => s.Name == screenPatternName);

        public override string ToString() => Name;
    }
}
