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
    public partial class StringForm : Form
    {
        public StringForm()
        {
            InitializeComponent();
        }

        public static string AskForString(IWin32Window owner, string title, string defValue = null)
        {
            var dlg = new StringForm { Text = title };
            dlg.txtValue.Text = defValue;
            return dlg.ShowDialog(owner) == DialogResult.OK
                ? dlg.txtValue.Text
                : null;
        }

        private void StringForm_Activated(object sender, EventArgs e)
        {
            txtValue.SelectAll();
        }

        private void btnCancel_Click(object sender, EventArgs e)
        {
            DialogResult = DialogResult.Cancel;
            Close();
        }

        private void btnOK_Click(object sender, EventArgs e)
        {
            DialogResult = DialogResult.OK;
            Close();
        }
    }
}
