using System;
using System.Collections.Generic;
using System.Linq;
using System.Runtime.InteropServices;
using System.Text;
using System.Threading.Tasks;

namespace Mastersign.WinMan
{
    static class WinApi
    {
        public const int WM_GETTEXT = 0x000D;
        public const int WM_GETTEXTLENGTH = 0x000E;
        
        [DllImport("user32.dll", SetLastError = true, CharSet = CharSet.Auto)]
        public static extern int RegisterWindowMessage(string lpString);

        [DllImport("user32.dll", EntryPoint = "SendMessage", CharSet = CharSet.Auto)]
        public static extern bool SendMessage(IntPtr hWnd, uint Msg, int wParam, StringBuilder lParam);

        [DllImport("user32.dll", SetLastError = true)]
        public static extern IntPtr SendMessage(int hWnd, int Msg, int wparam, int lparam);

        [DllImport("user32.dll", SetLastError = true)]
        public static extern IntPtr FindWindow(string lpClassName, string lpWindowName);

        [DllImport("user32.dll")]
        [return: MarshalAs(UnmanagedType.Bool)]
        public static extern bool EnumWindows(EnumWindowsProc lpEnumFunc, IntPtr lParam);

        [DllImport("user32.dll")]
        [return: MarshalAs(UnmanagedType.Bool)]
        private static extern bool EnumWindowStations(EnumWindowStationsDelegate lpEnumFunc, IntPtr lParam);

        [DllImport("user32.dll")]
        [return: MarshalAs(UnmanagedType.Bool)]
        public static extern bool EnumChildWindows(IntPtr hwndParent, EnumWindowsProc lpEnumFunc, IntPtr lParam);

        [DllImport("user32.dll")]
        [return: MarshalAs(UnmanagedType.Bool)]
        public static extern bool IsWindow(IntPtr hWnd);

        [DllImport("user32.dll")]
        [return: MarshalAs(UnmanagedType.Bool)]
        public static extern bool IsWindowVisible(IntPtr hWnd);

        [DllImport("user32.dll", SetLastError = true)]
        public static extern uint GetWindowThreadProcessId(IntPtr hWnd, out uint lpdwProcessId);

        public delegate bool EnumWindowsProc(IntPtr hWnd, IntPtr lParam);

        private delegate bool EnumWindowStationsDelegate(string windowsStation, IntPtr lParam);

        //private static bool EnumWindowStationsCallback(string windowStation, IntPtr lParam)
        //{
        //    GCHandle gch = GCHandle.FromIntPtr(lParam);
        //    IList<string> list = gch.Target as List<string>;

        //    if (null == list)
        //    {
        //        return (false);
        //    }

        //    list.Add(windowStation);

        //    return (true);
        //}

        //static void Main()
        //{
        //    IList<string> list = new List<string>();
        //    GCHandle gch = GCHandle.Alloc(list);
        //    EnumWindowStationsDelegate childProc = new EnumWindowStationsDelegate(EnumWindowStationsCallback);

        //    EnumWindowStations(childProc, GCHandle.ToIntPtr(gch));

        //    foreach (string a in list)
        //    {
        //        Console.WriteLine(a);
        //    }

        //    Console.ReadKey();
        //}
    }
}
