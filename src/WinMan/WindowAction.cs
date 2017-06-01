using System;
using System.Collections.Generic;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using WindowsDesktop;

namespace Mastersign.WinMan
{
    partial class WindowAction
    {
        public const int OS_MARGIN_LEFT = 8;
        public const int OS_MARGIN_TOP = 0;
        public const int OS_MARGIN_RIGHT = 8;
        public const int OS_MARGIN_BOTTOM = 8;

        public bool Apply(Workspace workspace, Layout layout)
        {
            var windowPattern = workspace.FindWindowPattern(Window);
            if (windowPattern == null) return false;
            var configurationPattern = workspace.FindConfigurationPattern(layout.Configuration);
            if (configurationPattern == null) return false;
            var screen = configurationPattern.FindScreenPattern(Screen)?.Discover();
            if (screen == null) return false;
            var virtualDesktop = VirtualDesktopHelper.GetVirtualDesktop(VirtualDesktop - 1);
            if (virtualDesktop == null) return false;

            var windowWrappers = windowPattern.Discover();
            if (windowWrappers.Length > 0)
            {
                Array.ForEach(
                    windowPattern.Discover(),
                    w => Apply(w, screen, virtualDesktop));
                return true;
            }
            else if (Restore)
            {
                // TODO restore window
                return false;
            }
            else
            {
                return true;
            }
        }

        private int ResolveValue(int reference, int range, int value, ScreenUnit unit, bool invert)
        {
            switch (unit)
            {
                case ScreenUnit.Pixel:
                    return !invert
                        ? reference + value
                        : reference + range - value;
                case ScreenUnit.Percent:
                    return !invert
                        ? reference + (int)Math.Round((value / 100.0) * range)
                        : reference + range - (int)Math.Round((value / 100.0) * range);
                default:
                    throw new NotSupportedException();
            }
        }

        public Rectangle CalculateTargetBounds(Rectangle screenBounds)
        {
            var left = ResolveValue(screenBounds.Left, screenBounds.Width, Left, LeftUnit, LeftInvert);
            var top = ResolveValue(screenBounds.Top, screenBounds.Height, Top, TopUnit, TopInvert);
            var right = ResolveValue(screenBounds.Left, screenBounds.Width, Right, RightUnit, RightInvert);
            var bottom = ResolveValue(screenBounds.Top, screenBounds.Height, Bottom, BottomUnit, BottomInvert);
            var targetBounds = new Rectangle(left, top, right - left, bottom - top);
            return targetBounds;
        }

        public void Apply(WindowWrapper w, Screen screen, VirtualDesktop virtualDesktop)
        {
            var targetBounds = CalculateTargetBounds(screen.WorkingArea);
            if (CompensateOsMargin)
            {
                targetBounds = new Rectangle(
                    targetBounds.Left - OS_MARGIN_LEFT,
                    targetBounds.Top - OS_MARGIN_TOP,
                    targetBounds.Width + OS_MARGIN_LEFT + OS_MARGIN_RIGHT,
                    targetBounds.Height + OS_MARGIN_TOP + OS_MARGIN_BOTTOM);
            }
            w.NormalPosition = new RECT(targetBounds);
            virtualDesktop.MoveWindowHere(w.Handle);
        }

        public override string ToString() => Window;
    }
}
