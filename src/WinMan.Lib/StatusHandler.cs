using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Mastersign.WinMan
{
    public delegate void StatusHandler(StatusLevel level, string message);

    public enum StatusLevel
    {
        Info,
        Error,
    }
}
