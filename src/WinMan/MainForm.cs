using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Mastersign.WinMan
{
    public partial class MainForm : Form
    {
        public MainForm()
        {
            InitializeComponent();
        }

        private ListViewItem ListViewItemFromWindow(WindowWrapper w)
        {
            var item = new ListViewItem(new string[]
                    {
                        w.Title,
                        w.Handle.ToString(),
                        w.WindowClass,
                        w.ShowCommand.ToString(),
                        w.NormalPosition.ToString(),
                        w.Screen.DeviceName,
                        w.VirtualDesktop?.Id.ToString(),
                        w.Process.MainModule.FileName,
                    });
            item.Tag = w;
            return item;
        }

        private void btnListTopWindows_Click(object sender, EventArgs e)
        {
            var windows = WindowWrapper.AllWindows()
                .Where(w => w.IsVisible && w.VirtualDesktop != null)
                .Select(ListViewItemFromWindow)
                .ToArray();
            listWindows.Items.Clear();
            listWindows.Items.AddRange(windows);
        }

        private WindowWrapper SelectedWindow
        {
            get
            {
                if (listWindows.SelectedItems.Count == 0) return null;
                return listWindows.SelectedItems[0].Tag as WindowWrapper;
            }
        }

        private void btnMax_Click(object sender, EventArgs e)
        {
            var w = SelectedWindow;
            if (w == null) return;
            w.ShowCommand = ShowWindowCommands.ShowMaximized;
        }
    }
}
