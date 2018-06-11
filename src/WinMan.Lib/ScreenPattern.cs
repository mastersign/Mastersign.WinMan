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
                && (!RespectPosition || (Bounds.X == screen.Bounds.X && Bounds.Y == screen.Bounds.Y))
                && (!RespectSize || (Bounds.Width == screen.Bounds.Width && Bounds.Height == screen.Bounds.Height));
        
        public static ScreenPattern FromScreen(Screen screen)
            => new ScreenPattern()
                {
                    Name = screen.DeviceName,
                    DeviceName = screen.DeviceName,
                    Bounds = screen.Bounds
                };

        public Screen Discover() => Screen.AllScreens.FirstOrDefault(s => IsMatch(s));

        public override string ToString() => Name;
    }
}
