using System;
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
        private static readonly Dictionary<IntPtr, WindowWrapper> instances = new Dictionary<IntPtr, WindowWrapper>();

        public static WindowWrapper ForHandle(IntPtr hWnd)
        {
            if (!instances.TryGetValue(hWnd, out WindowWrapper wrapper))
            {
                wrapper = new WindowWrapper(hWnd);
                instances[hWnd] = wrapper;
            }
            return wrapper;
        }

        public static WindowWrapper Find(string windowClass, string windowName)
        {
            var hWnd = WinApi.FindWindow(windowClass, windowName);
            return hWnd != IntPtr.Zero ? ForHandle(hWnd) : null;
        }

        public static List<WindowWrapper> AllWindows()
        {
            List<IntPtr> result = new List<IntPtr>();
            WinApi.EnumWindows((hWnd, lParam) =>
            {
                result.Add(hWnd);
                return true;
            }, IntPtr.Zero);
            return result.Select(ForHandle).ToList();
        }

        public IntPtr Handle { get; private set; }

        private WINDOWPLACEMENT placement = WINDOWPLACEMENT.Default;

        private WindowWrapper(IntPtr hWnd)
        {
            Handle = hWnd;
        }

        private void ReadPlacement()
        {
            WinApi.GetWindowPlacement(Handle, ref placement);
        }

        private void WritePlacement()
        {
            WinApi.SetWindowPlacement(Handle, ref placement);
        }

        public string Title
        {
            get
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
        }

        public string WindowClass
        {
            get
            {
                var sb = new StringBuilder(256);
                WinApi.GetClassName(Handle, sb, sb.Capacity);
                return sb.ToString();
            }
        }

        public bool IsValid => WinApi.IsWindow(Handle);

        public bool IsVisible => WinApi.IsWindowVisible(Handle);

        public RECT NormalPosition
        {
            get
            {
                ReadPlacement();
                return placement.NormalPosition;
            }
            set
            {
                ReadPlacement();
                placement.NormalPosition = value;
                WritePlacement();
            }
        }

        public ShowWindowCommands ShowCommand
        {
            get
            {
                ReadPlacement();
                return placement.ShowCmd;
            }
            set
            {
                ReadPlacement();
                placement.ShowCmd = value;
                WritePlacement();
            }
        }

        public void SetPlacement(RECT normalPosition, ShowWindowCommands showCmd)
        {
            ReadPlacement();
            placement.NormalPosition = normalPosition;
            placement.ShowCmd = showCmd;
            WritePlacement();
        }

        public VirtualDesktop VirtualDesktop => VirtualDesktop.FromHwnd(Handle);

        public Screen Screen=> System.Windows.Forms.Screen.FromHandle(Handle);

        public Process Process
        {
            get
            {
                WinApi.GetWindowThreadProcessId(Handle, out uint pId);
                return Process.GetProcessById((int)pId);
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
