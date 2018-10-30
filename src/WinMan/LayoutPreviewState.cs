using System;
using System.Drawing;

namespace Mastersign.WinMan.Gui
{
    class LayoutPreviewState
    {
        public ScreenPattern ScreenUnderCursor { get; set; }

        public bool ForceRaster { get; set; }

        public LayoutPreviewRaster Raster { get; set; }

        public Point? From { get; set; }
        public Point? To { get; set; }
    }
}
