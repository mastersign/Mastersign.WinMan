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

        public ConfigurationPattern FindConfigurationPattern(string configurationPatternName)
            => ConfigurationPatterns.FirstOrDefault(p => p.Name == configurationPatternName);

        public Layout FindLayout(string layoutName)
            => Layouts.FirstOrDefault(l => l.Name == layoutName);

        public Layout[] DefaultLayouts => Layouts.Where(l => l.DefaultLayout).ToArray();

        public void Apply()
        {
            foreach (var layout in DefaultLayouts)
            {
                layout.Apply(this);
            }
        }
    }
}
