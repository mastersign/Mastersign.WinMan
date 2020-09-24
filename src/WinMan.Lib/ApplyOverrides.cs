using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Mastersign.WinMan
{
    public class ApplyOverrides
    {
        public static readonly ApplyOverrides None = new ApplyOverrides();

        public StringReplacement[] StringReplacements { get; }

        public int? VirtualDesktopNo { get; }

        public ApplyOverrides(StringReplacement[] stringReplacements, int? layoutVirtualDesktopOverride)
        {
            StringReplacements = stringReplacements;
            VirtualDesktopNo = layoutVirtualDesktopOverride;
        }

        private ApplyOverrides()
        {
            StringReplacements = Array.Empty<StringReplacement>();
            VirtualDesktopNo = null;
        }
    }
}
