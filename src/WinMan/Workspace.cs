using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Mastersign.WinMan
{
    partial class Workspace
    {
        public WindowPattern FindWindowPattern(string windowPatternName)
            => WindowPatterns.FirstOrDefault(p => p.Name == windowPatternName);

        public Layout FindLayout(string layoutName)
            => Layouts.FirstOrDefault(l => l.Name == layoutName);

        public ScreenPattern FindScreenPattern(string screenPatternName)
            => Layouts
            .Select(l => l.FindScreenPattern(screenPatternName))
            .FirstOrDefault(s => s != null);

        public void Apply()
        {
            Layouts.Where(l => l.DefaultLayout).All(l => l.Apply(this));
        }
    }
}
