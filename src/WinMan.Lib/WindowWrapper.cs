﻿using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using WindowsDesktop;

namespace Mastersign.WinMan
{
    public class WindowWrapper
    {
        private static readonly Dictionary<IntPtr, WindowWrapper> _instances = new Dictionary<IntPtr, WindowWrapper>();

        public static WindowWrapper ForHandle(IntPtr hWnd)
        {
            if (!_instances.TryGetValue(hWnd, out WindowWrapper wrapper))
            {
                wrapper = new WindowWrapper(hWnd);
                _instances[hWnd] = wrapper;
            }
            return wrapper;
        }

        public static WindowWrapper Find(string windowClass, string windowName)
        {
            var hWnd = WinApi.FindWindow(windowClass, windowName);
            return hWnd != IntPtr.Zero ? ForHandle(hWnd) : null;
        }

        public static void ClearCaches()
        {
            var handles = _instances.Keys.ToArray();
            foreach (var hWnd in handles)
            {
                if (!WinApi.IsWindow(hWnd))
                {
                    _instances.Remove(hWnd);
                }
                else
                {
                    _instances[hWnd].ClearCache();
                }
            }
        }

        public static WindowWrapper[] AllWindows()
        {
            List<IntPtr> result = new List<IntPtr>();
            WinApi.EnumWindows((hWnd, lParam) =>
            {
                if (WinApi.IsWindowVisible(hWnd) && VirtualDesktop.FromHwnd(hWnd) != null)
                {
                    result.Add(hWnd);
                }
                return true;
            }, IntPtr.Zero);
            return result.Select(ForHandle).ToArray();
        }

        public IntPtr Handle { get; private set; }
        private WindowWrapper(IntPtr hWnd)
        {
            Handle = hWnd;
            ClearCache();
        }

        public void ClearCache()
        {
            _titleLoaded = false;
            _windowClassLoaded = false;
            _placementLoaded = false;
            _virtualDesktopLoaded = false;
            _screenLoaded = false;
            _processLoaded = false;
        }

        public bool IsValid => WinApi.IsWindow(Handle);

        public bool IsVisible => WinApi.IsWindowVisible(Handle);

        private string _title;
        private bool _titleLoaded;

        private string ReadTitle()
        {
            // Get the size of the string required to hold the window title. 
            var size = WinApi.SendMessage((int)Handle, WinApi.WM_GETTEXTLENGTH, 0, 0).ToInt32();

            // If the return is 0, there is no title. 
            if (size > 0)
            {
                var title = new StringBuilder(size + 1);
                WinApi.SendMessage(Handle, WinApi.WM_GETTEXT, title.Capacity, title);
                return title.ToString();
            }
            else
            {
                return string.Empty;
            }
        }

        public string Title
        {
            get
            {
                if (!_titleLoaded)
                {
                    _title = ReadTitle();
                    _titleLoaded = true;
                }
                return _title;
            }
        }

        private string _windowClass;
        private bool _windowClassLoaded;

        private string ReadWindowClass()
        {
            var sb = new StringBuilder(256);
            WinApi.GetClassName(Handle, sb, sb.Capacity);
            return sb.ToString();
        }

        public string WindowClass
        {
            get
            {
                if (!_windowClassLoaded)
                {
                    _windowClass = ReadWindowClass();
                    _windowClassLoaded = true;
                }
                return _windowClass;
            }
        }

        private WINDOWPLACEMENT _placement = WINDOWPLACEMENT.Default;
        private bool _placementLoaded;

        private void ReadPlacement()
        {
            WinApi.GetWindowPlacement(Handle, ref _placement);
            _placementLoaded = true;
        }

        private void WritePlacement()
        {
            WinApi.SetWindowPlacement(Handle, ref _placement);
        }

        public RECT NormalPosition
        {
            get
            {
                if (!_placementLoaded)
                {
                    ReadPlacement();
                }
                return _placement.NormalPosition;
            }
            set
            {
                ReadPlacement();
                _placement.NormalPosition = value;
                WritePlacement();
            }
        }

        public ShowWindowCommands ShowCommand
        {
            get
            {
                if (!_placementLoaded)
                {
                    ReadPlacement();
                }
                return _placement.ShowCmd;
            }
            set
            {
                ReadPlacement();
                _placement.ShowCmd = value;
                WritePlacement();
            }
        }

        public void SetPlacement(RECT normalPosition, ShowWindowCommands showCmd)
        {
            ReadPlacement();
            _placement.NormalPosition = normalPosition;
            _placement.ShowCmd = showCmd;
            WritePlacement();
        }

        private VirtualDesktop _virtualDesktop;
        private bool _virtualDesktopLoaded;

        public VirtualDesktop VirtualDesktop
        {
            get
            {
                if (!_virtualDesktopLoaded)
                {
                    _virtualDesktop = VirtualDesktop.FromHwnd(Handle);
                    _virtualDesktopLoaded = true;
                }
                return _virtualDesktop;
            }
        }

        private Screen _screen;
        private bool _screenLoaded;

        public Screen Screen
        {
            get
            {
                if (!_screenLoaded)
                {
                    _screen = Screen.FromHandle(Handle);
                    _screenLoaded = true;
                }
                return _screen;
            }
        }

        private Process _process;
        private bool _processLoaded;

        public Process Process
        {
            get
            {
                if (!_processLoaded)
                {
                    WinApi.GetWindowThreadProcessId(Handle, out uint pId);
                    _process = Process.GetProcessById((int)pId);
                    _processLoaded = true;
                }
                return _process;
            }
        }

        public string ProcessFileName
        {
            get
            {
                try
                {
                    return Process?.MainModule?.FileName;
                }
                catch (Exception)
                {
                    return null;
                }
            }
        }

        public List<WindowWrapper> GetChildWindows()
        {
            List<IntPtr> result = new List<IntPtr>();
            WinApi.EnumChildWindows(Handle, (hWnd, lParam) =>
            {
                result.Add(hWnd);
                return true;
            }, IntPtr.Zero);
            return result.Select(ForHandle).ToList();
        }

        public override string ToString()
        {
            return $"{Title} [{Handle}] {ShowCommand} ({Path.GetFileName(Process.MainModule.FileName)}) ";
        }
    }
}