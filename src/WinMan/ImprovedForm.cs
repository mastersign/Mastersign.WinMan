using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Mastersign.WinMan
{
    public class ImprovedForm : Form
    {
        protected override void OnLoad(EventArgs e)
        {
            base.OnLoad(e);
            WinFormHelper.ApplyFixes(this);
        }

        #region ToolBar Focus Fix

        private bool handleFirstClickOnActivated = false;

        protected override void OnActivated(EventArgs e)
        {
            base.OnActivated(e);
            if (this.handleFirstClickOnActivated)
            {
                var cursorPosition = Cursor.Position;
                var clientPoint = this.PointToClient(cursorPosition);
                var child = this.GetChildAtPoint(clientPoint);
                while (this.handleFirstClickOnActivated && child != null)
                {
                    var toolStrip = child as ToolStrip;
                    if (toolStrip != null)
                    {
                        this.handleFirstClickOnActivated = false;
                        clientPoint = toolStrip.PointToClient(cursorPosition);
                        foreach (var item in toolStrip.Items)
                        {
                            var toolStripItem = item as ToolStripItem;
                            if (toolStripItem != null && toolStripItem.Bounds.Contains(clientPoint))
                            {
                                var tsMenuItem = item as ToolStripMenuItem;
                                if (tsMenuItem != null)
                                {
                                    tsMenuItem.ShowDropDown();
                                }
                                else
                                {
                                    toolStripItem.PerformClick();
                                }
                                break;
                            }
                        }
                    }
                    else
                    {
                        child = child.GetChildAtPoint(clientPoint);
                    }
                }
                this.handleFirstClickOnActivated = false;
            }
        }

        protected override void WndProc(ref Message m)
        {
            const int WM_ACTIVATE = 0x0006;
            const int WA_CLICKACTIVE = 0x0002;
            if (m.Msg == WM_ACTIVATE && Low16(m.WParam) == WA_CLICKACTIVE)
            {
                handleFirstClickOnActivated = true;
            }
            base.WndProc(ref m);
        }

        private static int GetIntUnchecked(IntPtr value) => IntPtr.Size == 8 ? unchecked((int)value.ToInt64()) : value.ToInt32();

        private static int Low16(IntPtr value) => unchecked((short)GetIntUnchecked(value));

        private static int High16(IntPtr value) => unchecked((short)(((uint)GetIntUnchecked(value)) >> 16));

        #endregion
    }
}
