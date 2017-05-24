using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Mastersign.WinMan
{
    class WindowWrapper
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

        private WindowWrapper(IntPtr hWnd)
        {
            Handle = hWnd;
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

        public bool IsValid => WinApi.IsWindow(Handle);

        public bool IsVisible => WinApi.IsWindowVisible(Handle);

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
            return Title;
        }
    }
}
