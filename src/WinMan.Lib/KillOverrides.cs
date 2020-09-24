using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Mastersign.WinMan
{
    public class KillOverrides
    {
        public static readonly KillOverrides None = new KillOverrides();

        public StringReplacement[] StringReplacements { get; }

        public KillOverrides(StringReplacement[] stringReplacements)
        {
            StringReplacements = stringReplacements;
        }

        private KillOverrides()
        {
            StringReplacements = Array.Empty<StringReplacement>();
        }
    }
}
