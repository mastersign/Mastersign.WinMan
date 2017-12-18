using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.Drawing;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading;
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
        public const int RESTORE_CHECK_INTERVAL_MS = 500;
        public const int WAIT_FOR_RESTORE_MS = 20000;

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
                Array.ForEach(windowWrappers, w => Apply(w, screen, virtualDesktop));
                return true;
            }
            else if (Restore && !string.IsNullOrWhiteSpace(windowPattern.Command))
            {
                if (TryRestoreWindow(windowPattern, ref windowWrappers))
                {
                    Array.ForEach(windowWrappers, w => Apply(w, screen, virtualDesktop));
                    return true;
                }
                else return false;
            }
            else return true;
        }

        private bool TryRestoreWindow(WindowPattern windowPattern, ref WindowWrapper[] windowWrappers)
        {
            try
            {
                var startInfo = new ProcessStartInfo("cmd", 
                    $"/C START \"WinMan Starter - {windowPattern.Name}\" \"{windowPattern.Command}\" {windowPattern.CommandArgs}");
                startInfo.UseShellExecute = false;
                startInfo.WindowStyle = ProcessWindowStyle.Hidden;
                if (!string.IsNullOrWhiteSpace(windowPattern.WorkingDir) &&
                    Directory.Exists(windowPattern.WorkingDir))
                {
                    startInfo.WorkingDirectory = windowPattern.WorkingDir;
                }
                var p = Process.Start(startInfo);
                var tCancel = DateTime.Now + new TimeSpan(0, 0, 0, 0, WAIT_FOR_RESTORE_MS);
                do
                {
                    Thread.Sleep(RESTORE_CHECK_INTERVAL_MS);
                    Application.DoEvents();
                    WindowWrapper.ClearCaches();
                    windowWrappers = windowPattern.Discover();
                } while (windowWrappers.Length == 0 && DateTime.Now < tCancel);
                return windowWrappers.Length > 0;
            }
            catch (Exception)
            {
                return false;
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

        public Rect CalculateTargetBounds(Rect screenBounds)
        {
            var left = ResolveValue(screenBounds.Left, screenBounds.Width, Left, LeftUnit, LeftInvert);
            var top = ResolveValue(screenBounds.Top, screenBounds.Height, Top, TopUnit, TopInvert);
            var right = ResolveValue(screenBounds.Left, screenBounds.Width, Right, RightUnit, RightInvert);
            var bottom = ResolveValue(screenBounds.Top, screenBounds.Height, Bottom, BottomUnit, BottomInvert);
            var targetBounds = new Rect(left, top, right - left, bottom - top);
            return targetBounds;
        }

        private ShowWindowCommands WindowStateAsShowWindowCommand()
        {
            switch (WindowState)
            {
                case WindowState.Minimized:
                    return ShowWindowCommands.ShowMinNoActive;
                case WindowState.Normal:
                    return ShowWindowCommands.ShowNA;
                case WindowState.Maximized:
                    return ShowWindowCommands.Maximize;
                default:
                    throw new NotSupportedException();
            }
        }

        public void Apply(WindowWrapper w, Screen screen, VirtualDesktop virtualDesktop)
        {
            var targetBounds = CalculateTargetBounds(screen.WorkingArea);
            var newX = targetBounds.X + (screen.Bounds.X - screen.WorkingArea.X);
            var newY = targetBounds.Y + (screen.Bounds.Y - screen.WorkingArea.Y);
            targetBounds = new Rect(newX, newY, targetBounds.Width, targetBounds.Height);
            if (CompensateOsMargin)
            {
                targetBounds = new Rect(
                    targetBounds.Left - OS_MARGIN_LEFT,
                    targetBounds.Top - OS_MARGIN_TOP,
                    targetBounds.Width + OS_MARGIN_LEFT + OS_MARGIN_RIGHT,
                    targetBounds.Height + OS_MARGIN_TOP + OS_MARGIN_BOTTOM);
            }
            w.ShowCommand = ShowWindowCommands.ShowNoActivate;
            virtualDesktop.MoveWindowHere(w.Handle);
            w.NormalPosition = new RECT(targetBounds);
            w.ShowCommand = WindowStateAsShowWindowCommand();
        }

        public override string ToString() => Window;
    }
}
