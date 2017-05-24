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

        private void btnListTopWindows_Click(object sender, EventArgs e)
        {
            listBox1.Items.Clear();
            listBox1.Items.AddRange(WindowWrapper.AllWindows()
                .Where(w => w.IsVisible && w.Title.Length > 0)
                .Select(w => w.Title + " " + w.Process.MainModule.FileName)
                .ToArray());
        }
    }
}
