using System;
using System.Collections.Generic;
using System.Linq;
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
            _core = new Core();
            _core.LoadWorkspaceFromFile();
            _core.ReloadWindows();

            Application.EnableVisualStyles();
            Application.SetCompatibleTextRenderingDefault(false);
            Application.Run(new MainForm());

            _core.WriteWorkspaceToFile();
        }
    }
}
