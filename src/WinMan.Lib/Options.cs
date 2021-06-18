using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Mastersign.WinMan
{
    partial class Options
    {
        public static readonly int DEFAULT_RESTORATION_TIMEOUT = 30;

        public static Options Default() => new Options
        {
            RestorationTimeout = DEFAULT_RESTORATION_TIMEOUT,
        };
    }
}
