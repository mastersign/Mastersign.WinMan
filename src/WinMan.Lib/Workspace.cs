using Newtonsoft.Json;
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

        [JsonIgnore]
        public Layout[] DefaultLayouts => Layouts.Where(l => l.DefaultLayout).ToArray();

        public void Apply()
        {
            foreach (var layout in DefaultLayouts)
            {
                layout.Apply(this);
            }
        }

        public void Upgrade()
        {
            if (Options == null) Options = Options.Default();
        }

        public void UpdateConfigurationReferences(string oldName, string newName)
        {
            if (oldName == null || newName == null) return;
            foreach (var layout in Layouts)
            {
                if (layout.Configuration == oldName) layout.Configuration = newName;
            }
        }

        public void UpdateScreenPatternReferences(string configuration, string oldName, string newName)
        {
            if (configuration == null || oldName == null || newName == null) return;
            foreach (var layout in Layouts)
            {
                if (layout.Configuration == configuration)
                {
                    foreach (var windowAction in layout.Windows)
                    {
                        if (windowAction.Screen == oldName) windowAction.Screen = newName;
                    }
                }
            }
        }

        public void UpdateWindowPatternReferences(string oldName, string newName)
        {
            if (oldName == null || newName == null) return;
            foreach (var layout in Layouts)
            {
                foreach (var windowAction in layout.Windows)
                {
                    if (windowAction.Window == oldName) windowAction.Window = newName;
                }
            }
        }
    }
}
