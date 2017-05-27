using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Mastersign.WinMan
{
    partial class Layout
    {
        public ScreenPattern FindScreenPattern(string screenPatternName)
            => Configurations.Select(c => c.FindScreenPattern(screenPatternName))
                .FirstOrDefault(s => s != null && s.Name == screenPatternName);

        public override string ToString() => Name;
    }
}
