using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using WindowsDesktop;

namespace Mastersign.WinMan
{
    public static class VirtualDesktopHelper
    {
        public static void LoadVirtualDesktops() => VirtualDesktop.GetDesktops();

        public static int GetVirtualDesktopNumber(Guid id)
        {
            var desktops = VirtualDesktop.GetDesktops();
            for (int i = 0; i < desktops.Length; i++)
            {
                if (desktops[i].Id == id) return i;
            }
            return -1;
        }

        public static VirtualDesktop GetVirtualDesktop(int no)
        {
            var desktops = VirtualDesktop.GetDesktops();
            return no >= 0 && no < desktops.Length ? desktops[no] : null;
        }
    }
}
