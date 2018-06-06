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
        public const int RESTORE_CHECK_INTERVAL_MS = 500;
        public const int WAIT_FOR_RESTORE_MS = 20000;

        public int GetVirtualDesktop(Layout layout)
            => OverrideVirtualDesktop ? VirtualDesktop : layout.DefaultVirtualDesktop;

        public bool Apply(Workspace workspace, Layout layout)
        {
            var windowPattern = workspace.FindWindowPattern(Window);
            if (windowPattern == null) return false;
            var configurationPattern = workspace.FindConfigurationPattern(layout.Configuration);
            if (configurationPattern == null) return false;
            var screen = configurationPattern.FindScreenPattern(Screen)?.Discover();
            if (screen == null) return false;
            var virtualDesktop = VirtualDesktopHelper.GetVirtualDesktop(GetVirtualDesktop(layout) - 1);
            if (virtualDesktop == null) return false;

            var windowWrappers = windowPattern.Discover();
            if (windowWrappers.Length > 0)
            {
                Array.ForEach(windowWrappers, w => Apply(w, screen, virtualDesktop, workspace.Options));
                return true;
            }
            else if (Restore && !string.IsNullOrWhiteSpace(windowPattern.Command))
            {
                if (TryRestoreWindow(windowPattern, ref windowWrappers))
                {
                    Array.ForEach(windowWrappers, w => Apply(w, screen, virtualDesktop, workspace.Options));
                    return true;
                }
                else return false;
            }
            else return true;
        }

        public bool RecordPosition(Workspace workspace, Layout layout)
        {
            var windowPattern = workspace.FindWindowPattern(Window);
            if (windowPattern == null) return false;
            var configurationPattern = workspace.FindConfigurationPattern(layout.Configuration);
            if (configurationPattern == null) return false;

            var windowWrappers = windowPattern.Discover();
            if (windowWrappers.Length > 0)
            {
                RecordPosition(configurationPattern, windowWrappers[0], workspace.Options, layout);
                return true;
            }
            return false;
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

        private static WindowState ShowCommandAsWindowState(ShowWindowCommands showCommand)
        {
            switch (showCommand)
            {
                case ShowWindowCommands.Hide:
                case ShowWindowCommands.Minimize:
                case ShowWindowCommands.ShowMinimized:
                case ShowWindowCommands.ShowMinNoActive:
                case ShowWindowCommands.ForceMinimize:
                    return WindowState.Minimized;
                case ShowWindowCommands.ShowMaximized:
                    return WindowState.Maximized;
                default:
                    return WindowState.Normal;
            }
        }

        public void Apply(WindowWrapper w, Screen screen, VirtualDesktop virtualDesktop, Options options)
        {
            var targetBounds = CalculateTargetBounds(screen.WorkingArea);
            var newX = targetBounds.X + (screen.Bounds.X - screen.WorkingArea.X);
            var newY = targetBounds.Y + (screen.Bounds.Y - screen.WorkingArea.Y);
            targetBounds = new Rect(newX, newY, targetBounds.Width, targetBounds.Height);
            if (CompensateOsMargin)
            {
                targetBounds = targetBounds.Expand(options.OsWindowMargin);
            }
            w.ShowCommand = ShowWindowCommands.ShowNoActivate;
            virtualDesktop.MoveWindowHere(w.Handle);
            w.NormalPosition = new RECT(targetBounds);
            w.ShowCommand = WindowStateAsShowWindowCommand();
        }

        public void RecordPosition(ConfigurationPattern configurationPattern, WindowWrapper w, Options options, Layout layout)
        {
            var vd = w.VirtualDesktop;
            var recordedVirtualDesktop = VirtualDesktopHelper.GetVirtualDesktopNumber(vd.Id) + 1;
            if (recordedVirtualDesktop == layout.DefaultVirtualDesktop)
            {
                VirtualDesktop = 1;
                OverrideVirtualDesktop = false;
            }
            else
            {
                VirtualDesktop = recordedVirtualDesktop;
                OverrideVirtualDesktop = false;
            }

            WindowState = ShowCommandAsWindowState(w.ShowCommand);

            var screen = configurationPattern.Screens.FirstOrDefault(s => s.DeviceName == w.Screen.DeviceName);
            Screen = screen.Name;
            var screenBounds = screen.Bounds;

            var p = w.NormalPosition;
            LeftUnit = ScreenUnit.Pixel;
            LeftInvert = false;
            Left = p.Left - screenBounds.Left;
            TopUnit = ScreenUnit.Pixel;
            TopInvert = false;
            Top = p.Top - screenBounds.Top;
            RightUnit = ScreenUnit.Pixel;
            RightInvert = false;
            Right = p.Right - screenBounds.Left;
            BottomUnit = ScreenUnit.Pixel;
            BottomInvert = false;
            Bottom = p.Bottom - screenBounds.Top;
        }

        public override string ToString() => Window;

        public WindowAction Clone() => (WindowAction)MemberwiseClone();
    }
}
