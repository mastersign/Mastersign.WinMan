using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Mastersign.WinMan
{
    partial class Options
    {
        public static readonly Margin DEFAULT_OS_WINDOW_MARGIN = new Margin(6, 0, 7, 8);

        public static Options Default() => new Options
        {
            OsWindowMargin = DEFAULT_OS_WINDOW_MARGIN
        };
    }
}
