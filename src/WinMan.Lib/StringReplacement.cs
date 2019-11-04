using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Mastersign.WinMan
{
    public class StringReplacement
    {
        public string Pattern { get; }

        public string Replacement { get; }

        public StringReplacement(string pattern, string replacement)
        {
            Pattern = pattern;
            Replacement = replacement;
        }
    }
}
