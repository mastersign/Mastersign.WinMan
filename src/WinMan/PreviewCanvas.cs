using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Drawing;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Mastersign.WinMan
{
    public partial class PreviewCanvas : UserControl
    {
        public PreviewCanvas()
        {
            InitializeComponent();
            SetStyle(ControlStyles.AllPaintingInWmPaint, true);
            SetStyle(ControlStyles.UserPaint, true);
            SetStyle(ControlStyles.Opaque, true);
            SetStyle(ControlStyles.OptimizedDoubleBuffer, true);
        }

        protected override void OnPaintBackground(PaintEventArgs e)
        {
            // nothing
        }
    }
}
