﻿using System;
using System.Collections.Generic;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Mastersign.WinMan
{
    partial class WindowAction
    {
        public void Apply(Workspace workspace, Layout layout)
        {
            var windowPattern = workspace.FindWindowPattern(Window);
            if (windowPattern == null) return;
            var screen = layout.FindScreenPattern(Screen)?.Discover();
            if (screen == null) return;
            Array.ForEach(
                windowPattern.Discover(),
                w => Apply(w, screen));
        }

        private int ResolveValue(int reference, int range, int value, ScreenUnit unit)
        {
            switch (unit)
            {
                case ScreenUnit.Pixel:
                    return reference + value;
                case ScreenUnit.Percent:
                    return reference + (int)Math.Round((value / 100.0) * range);
                default:
                    throw new NotSupportedException();
            }
        }

        public void Apply(WindowWrapper w, Screen screen)
        {
            var screenR = screen.WorkingArea;
            var left = ResolveValue(screenR.Left, screenR.Width, Left, LeftUnit);
            var top = ResolveValue(screenR.Top, screenR.Height, Top, TopUnit);
            var right = ResolveValue(screenR.Left, screenR.Width, Right, RightUnit);
            var bottom = ResolveValue(screenR.Top, screenR.Height, Bottom, BottomUnit);
            var targetBounds = screenR;
            switch (Positioning)
            {
                case Positioning.Free:
                    targetBounds = new Rectangle(left, top, right - left, bottom - top);
                    break;
                case Positioning.DockLeft:
                    break;
                case Positioning.DockRight:
                    break;
                case Positioning.DockTop:
                    break;
                case Positioning.DockBottom:
                    break;
                case Positioning.DockHeight:
                    break;
                case Positioning.DockWidth:
                    break;
                case Positioning.DockTopLeft:
                    break;
                case Positioning.DockTopRight:
                    break;
                case Positioning.DockBottomLeft:
                    break;
                case Positioning.DockBottomRight:
                    break;
                default:
                    break;
            }
            w.NormalPosition = new RECT(targetBounds);
        }

        public override string ToString() => Window;
    }
}
