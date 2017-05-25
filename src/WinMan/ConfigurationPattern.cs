using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Mastersign.WinMan
{
    partial class ConfigurationPattern
    {
        public bool IsMatch(Screen[] screens, int virtualDesktopCount)
            => Screens.All(p => screens.Any(s => p.IsMatch(s)))
                && (!RespectVirtualDesktopCount || VirtualDesktopCount == virtualDesktopCount);

        public static ConfigurationPattern FromConfiguration(Screen[] screens, int virtualDesktopCount)
            => new ConfigurationPattern()
                {
                    VirtualDesktopCount = virtualDesktopCount,
                    RespectVirtualDesktopCount = true,
                    Screens = screens.Select(ScreenPattern.FromScreen).ToList()
                };
    }
}
