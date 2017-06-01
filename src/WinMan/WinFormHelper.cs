using System;
using System.Collections.Generic;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Mastersign.WinMan
{
    public static class WinFormHelper
    {
        public static readonly IDictionary<Type, Font> Fonts = new Dictionary<Type, Font>();

        public static readonly IList<Type> ContainerTypes = new List<Type>();

        static WinFormHelper()
        {
            Fonts[typeof(GroupBox)] = SystemFonts.SmallCaptionFont;
            Fonts[typeof(TabControl)] = SystemFonts.SmallCaptionFont;
            Fonts[typeof(Label)] = SystemFonts.MessageBoxFont;
            Fonts[typeof(Button)] = SystemFonts.MessageBoxFont;
            Fonts[typeof(CheckBox)] = SystemFonts.MessageBoxFont;
            Fonts[typeof(TextBox)] = SystemFonts.IconTitleFont;
            Fonts[typeof(NumericUpDown)] = SystemFonts.IconTitleFont;
            Fonts[typeof(DomainUpDown)] = SystemFonts.IconTitleFont;
            Fonts[typeof(ComboBox)] = SystemFonts.IconTitleFont;
            Fonts[typeof(DateTimePicker)] = SystemFonts.IconTitleFont;
            Fonts[typeof(MonthCalendar)] = SystemFonts.IconTitleFont;
            Fonts[typeof(ListBox)] = SystemFonts.IconTitleFont;
            Fonts[typeof(DataGrid)] = SystemFonts.IconTitleFont;
            Fonts[typeof(DataGridView)] = SystemFonts.IconTitleFont;
            Fonts[typeof(ListView)] = SystemFonts.IconTitleFont;
            Fonts[typeof(TreeView)] = SystemFonts.IconTitleFont;
        }

        public static void ApplyFixes(Control c)
        {
            if (c == null) return;
            if (Fonts.TryGetValue(c.GetType(), out Font fastHit))
            {
                c.Font = fastHit;
            }
            else
            {
                foreach (var kvp in Fonts)
                {
                    if (c.GetType().IsInstanceOfType(kvp.Key))
                    {
                        c.Font = kvp.Value;
                    }
                }
            }
            if (c.HasChildren)
            {
                foreach (Control child in c.Controls)
                {
                    ApplyFixes(child);
                }
            }
            if (c is TabControl)
            {
                foreach (Control page in ((TabControl)c).TabPages)
                {
                    ApplyFixes(page);
                }
            }
            if (c is SplitContainer)
            {
                ApplyFixes(((SplitContainer)c).Panel1);
                ApplyFixes(((SplitContainer)c).Panel2);
            }
        }
    }
}
