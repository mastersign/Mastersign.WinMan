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
    static class Program
    {
        private static Core _core;

        public static Core Core => _core;

        /// <summary>
        /// Der Haupteinstiegspunkt für die Anwendung.
        /// </summary>
        [STAThread]
        static void Main(string[] argv)
        {
            string workspaceFile = null;
            if (argv.Length == 1 && File.Exists(argv[0]))
            {
                workspaceFile = argv[0];
            }

            _core = new Core();
            _core.LoadWorkspaceFromFile(workspaceFile);
            _core.ReloadWindows();
            Application.EnableVisualStyles();
            Application.SetCompatibleTextRenderingDefault(false);
            Application.Run(new MainForm());

            if (_core.WorkspaceFileName == null && File.Exists(Core.DefaultWorkspaceFilePath))
            {
                _core.ShowSaveWorkspaceFileDialog(null, "Save Workspace...");
            }
            else
            {
                _core.WriteWorkspaceToFile();
            }
        }
    }
}
