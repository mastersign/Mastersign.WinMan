using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Mastersign.WinMan
{
    partial class ScreenPattern
    {
        public bool IsMatch(Screen screen)
            => (DeviceName == null || string.Equals(DeviceName, screen.DeviceName))
                && Bounds == screen.Bounds;
        
        public static ScreenPattern FromScreen(Screen screen)
            => new ScreenPattern()
                {
                    Name = screen.DeviceName,
                    DeviceName = screen.DeviceName,
                    Bounds = screen.Bounds
                };

        public override string ToString() => DeviceName;
    }
}
