using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Reflection;
using System.Runtime.InteropServices;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Mastersign.WinMan
{
    internal static class Program
    {
        private static Core _core;

        /// <summary>
        /// Main entry point for the application.
        /// </summary>
        [STAThread]
        private static void Main(string[] argv)
        {
            string workspaceFile = null;
            if (argv.Length == 1 && File.Exists(argv[0]))
            {
                workspaceFile = argv[0];
            }

            _core = new Core();
            _core.LoadWorkspaceFromFile(workspaceFile);
            _core.ReloadWindows();
            Core.DefaultCore = _core;
            Application.EnableVisualStyles();
            Application.SetCompatibleTextRenderingDefault(false);
            Application.Run(new MainForm());
        }
    }
}
