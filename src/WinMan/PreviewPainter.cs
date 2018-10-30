using System;
using System.Collections.Generic;
using System.Drawing;
using System.Drawing.Drawing2D;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Mastersign.WinMan.Gui
{
    class PreviewPainter
    {
        public PreviewPainter()
        {
            OuterMargin = 200; // Screen Pixel
            BackgroundColor = SystemColors.Window;
            ScreenBrush = SystemBrushes.Desktop;
            ScreenBorderBrush = SystemBrushes.WindowFrame;
            ScreenBorderStrength = 32; // Screen Pixel
            ScreenSelectedBrush = SystemBrushes.Highlight;
            WindowBrush = SystemBrushes.ButtonFace;
            WindowSelectedBrush = SystemBrushes.ButtonHighlight;
            WindowBorderBrush = SystemBrushes.ButtonShadow;
            WindowBorderStrength = 24; // Screen Pixel
            WindowTitleBarBrush = SystemBrushes.InactiveCaption;
            WindowTitleBarSelectedBrush = SystemBrushes.Highlight;
            WindowTitleBarHeight = 40; // Screen Pixel
            MinimizedWindowWidth = 360;
            MinimizedWindowHeight = WindowTitleBarHeight + WindowBorderStrength * 2;
            RasterWidth = 12; // Screen Pixel
            RasterBrush = new SolidBrush(Color.FromArgb(96, SystemColors.ControlDark));
            RasterSelectionBrush = new SolidBrush(Color.FromArgb(212, SystemColors.Highlight));
        }

        public int OuterMargin { get; set; }
        public Color BackgroundColor { get; set; }

        public Brush ScreenBrush { get; set; }
        public Brush ScreenBorderBrush { get; set; }
        public int ScreenBorderStrength { get; set; }
        public Brush ScreenSelectedBrush { get; set; }

        public Brush WindowBrush { get; set; }
        public Brush WindowSelectedBrush { get; set; }
        public Brush WindowBorderBrush { get; set; }
        public int WindowBorderStrength { get; set; }
        public Brush WindowTitleBarBrush { get; set; }
        public Brush WindowTitleBarSelectedBrush { get; set; }
        public int WindowTitleBarHeight { get; set; }
        public int MinimizedWindowWidth { get; set; }
        public int MinimizedWindowHeight { get; set; }

        public int RasterWidth { get; set; }
        public Brush RasterBrush { get; set; }
        public Brush RasterSelectionBrush { get; set; }

        private Matrix TransformToConfiguration(Matrix originalT, Size s, ConfigurationPattern c)
        {
            var t = originalT.Clone();

            t.Translate(s.Width * 0.5f, s.Height * 0.5f);

            var screens = c.Screens;
            Rectangle outerBounds = screens[0].Bounds;
            for (int i = 1; i < screens.Count; i++)
            {
                outerBounds = Rectangle.Union(outerBounds, screens[i].Bounds);
            }
            outerBounds.Inflate(OuterMargin, OuterMargin);

            var factor = Math.Min(
                (float)s.Width / (float)outerBounds.Width,
                (float)s.Height / (float)outerBounds.Height);
            t.Scale(factor, factor);

            t.Translate(-outerBounds.Left - outerBounds.Width * 0.5f, -outerBounds.Top - outerBounds.Height * 0.5f);
            
            return t;
        }

        private Matrix TransformToScreen(Matrix originalT, ScreenPattern s)
        {
            var t = originalT.Clone();

            var outerBounds = s.Bounds;
            Rectangle innerBounds = outerBounds;
            innerBounds.Inflate(-ScreenBorderStrength, -ScreenBorderStrength);
            t.Translate(innerBounds.Left, innerBounds.Top);
            var sx = (float)innerBounds.Width / (float)outerBounds.Width;
            var sy = (float)innerBounds.Height / (float)outerBounds.Height;
            t.Scale(sx, sy);

            return t;
        }

        public void TransformFromScreen(Size s, Workspace w, Layout l, Point p, out ScreenPattern screen, out Point screenPos)
        {
            var c = w.FindConfigurationPattern(l.Configuration);
            screen = null;
            screenPos = Point.Empty;
            if (c == null || c.Screens.Count == 0) return;
            var t = TransformToConfiguration(new Matrix(), s, c);
            if (!t.IsInvertible) return;
            t.Invert();
            var points = new Point[] { new Point(p.X, p.Y) };
            t.TransformPoints(points);
            var cPos = points[0];

            foreach (var scr in c.Screens)
            {
                var b = scr.Bounds;
                if (cPos.X >= b.Left && cPos.Y >= b.Top && cPos.X <= b.Right && cPos.Y <= b.Bottom)
                {
                    screen = scr;
                    screenPos = new Point(cPos.X - b.X, cPos.Y - b.Y);
                    return; // found screen
                }
            }
            // outside of screens
        }

        private void PaintScreen(Graphics g, ScreenPattern s, bool selected)
        {
            Rectangle r = s.Bounds;
            g.FillRectangle(ScreenBorderBrush, r);
            r.Inflate(-ScreenBorderStrength, -ScreenBorderStrength);
            g.FillRectangle(selected ? ScreenSelectedBrush : ScreenBrush, r);
        }

        private void PaintScreens(Graphics g, ConfigurationPattern c, ScreenPattern selectedScreen = null)
        {
            foreach (var screen in c.Screens)
            {
                PaintScreen(g, screen, screen == selectedScreen);
            }
        }

        public void PaintScreenConfiguration(Graphics g, Size s, ConfigurationPattern c, ScreenPattern selectedScreen = null)
        {
            if (c.Screens.Count == 0) return;

            g.Clear(BackgroundColor);

            g.SmoothingMode = SmoothingMode.HighQuality;

            var originalTransform = g.Transform;
            g.Transform = TransformToConfiguration(originalTransform, s, c);

            PaintScreens(g, c, selectedScreen);

            g.Transform = originalTransform;
        }

        private void PaintWindowAction(Graphics g, ConfigurationPattern c, WindowAction a, bool selected = false)
        {
            var screen = c.FindScreenPattern(a.Screen);
            if (screen == null) return;

            var originalTransform = g.Transform;
            g.Transform = TransformToScreen(originalTransform, screen);

            var screenBounds = screen.Bounds;
            Rectangle windowBounds;
            switch (a.WindowState)
            {
                case WindowState.Minimized:
                    windowBounds = new Rectangle(
                        screenBounds.Left,
                        screenBounds.Bottom - MinimizedWindowHeight,
                        MinimizedWindowWidth, MinimizedWindowHeight);
                    break;
                case WindowState.Normal:
                    windowBounds = a.CalculateTargetBounds(screenBounds);
                    break;
                case WindowState.Maximized:
                    windowBounds = screenBounds;
                    break;
                default:
                    throw new NotSupportedException();
            }
            windowBounds.Offset(-screenBounds.X, -screenBounds.Y);
            g.FillRectangle(WindowBorderBrush, windowBounds);
            windowBounds.Inflate(-WindowBorderStrength, -WindowBorderStrength);
            if (windowBounds.Height >= WindowTitleBarHeight * 2 + WindowBorderStrength)
            {
                g.FillRectangle(selected ? WindowTitleBarSelectedBrush : WindowTitleBarBrush,
                    windowBounds.Left, windowBounds.Top,
                    windowBounds.Width, WindowTitleBarHeight);
                g.FillRectangle(selected ? WindowSelectedBrush : WindowBrush,
                    windowBounds.Left, windowBounds.Top + WindowTitleBarHeight + WindowBorderStrength,
                    windowBounds.Width, windowBounds.Height - WindowTitleBarHeight - WindowBorderStrength);
            }
            else
            {
                g.FillRectangle(selected ? WindowTitleBarSelectedBrush : WindowTitleBarBrush,
                    windowBounds);
            }

            g.Transform = originalTransform;
        }

        public void PaintWindowAction(Graphics g, Size s, Workspace w, Layout l, WindowAction a)
        {
            var c = w.FindConfigurationPattern(l.Configuration);
            if (c == null || c.Screens.Count == 0) return;

            g.Clear(BackgroundColor);

            g.SmoothingMode = SmoothingMode.HighQuality;

            var originalTransform = g.Transform;
            g.Transform = TransformToConfiguration(originalTransform, s, c);

            PaintScreens(g, c);
            PaintWindowAction(g, c, a);

            g.Transform = originalTransform;
        }

        public void PaintWindowActions(Graphics g, Size s, Workspace w, Layout l, WindowAction selectedWindowAction)
        {
            var c = w.FindConfigurationPattern(l.Configuration);
            if (c == null || c.Screens.Count == 0) return;

            g.Clear(BackgroundColor);

            g.SmoothingMode = SmoothingMode.HighQuality;

            var originalTransform = g.Transform;
            g.Transform = TransformToConfiguration(originalTransform, s, c);

            PaintScreens(g, c);
            foreach (var a in l.Windows)
            {
                if (a == selectedWindowAction) continue;
                if (a.GetVirtualDesktop(l) != selectedWindowAction.GetVirtualDesktop(l)) continue;
                PaintWindowAction(g, c, a, false);
            }
            PaintWindowAction(g, c, selectedWindowAction, true);

            g.Transform = originalTransform;
        }

        public void PaintRaster(Graphics g, Size s, Workspace w, Layout l, LayoutPreviewRaster raster,
            ScreenPattern selectedScreen = null, Point? from = null, Point? to = null)
        {
            if (raster == null) throw new ArgumentNullException(nameof(raster));

            var c = w.FindConfigurationPattern(l.Configuration);
            if (c == null || c.Screens.Count == 0) return;

            g.SmoothingMode = SmoothingMode.HighQuality;

            var originalTransform = g.Transform;
            g.Transform = TransformToConfiguration(originalTransform, s, c);

            if (selectedScreen != null && to.HasValue)
            {
                if (!from.HasValue) from = to;
                var xA = Math.Min(from.Value.X, to.Value.X);
                var xB = Math.Max(from.Value.X, to.Value.X) + 1;
                var yA = Math.Min(from.Value.Y, to.Value.Y);
                var yB = Math.Max(from.Value.Y, to.Value.Y) + 1;
                var left = xA == 0
                    ? selectedScreen.Left + ScreenBorderStrength
                    : selectedScreen.Left + (int)(selectedScreen.Width * raster.X[xA]) + RasterWidth / 2;
                var top = yA == 0
                    ? selectedScreen.Top + ScreenBorderStrength
                    : selectedScreen.Top + (int)(selectedScreen.Height * raster.Y[yA]) + RasterWidth / 2;
                var right = xB >= raster.X.Length
                    ? selectedScreen.Left + selectedScreen.Width - ScreenBorderStrength
                    : selectedScreen.Left + (int)(selectedScreen.Width * raster.X[xB]) - RasterWidth / 2;
                var bottom = yB >= raster.Y.Length
                    ? selectedScreen.Top + selectedScreen.Height - ScreenBorderStrength
                    : selectedScreen.Top + (int)(selectedScreen.Height * raster.Y[yB]) - RasterWidth / 2;
                g.FillRectangle(RasterSelectionBrush, left, top, right - left, bottom - top);
            }

            foreach (var screen in c.Screens)
            {
                if (selectedScreen != null && screen != selectedScreen) continue;
                foreach (var x in raster.X.Skip(1))
                {
                    var r = new Rectangle(
                        screen.Left + (int)(x * screen.Width) - RasterWidth / 2,
                        screen.Top + ScreenBorderStrength,
                        RasterWidth,
                        screen.Height - ScreenBorderStrength * 2);
                    g.FillRectangle(RasterBrush, r);
                }
                foreach (var y in raster.Y.Skip(1))
                {
                    var r = new Rectangle(
                        screen.Left + ScreenBorderStrength,
                        screen.Top + (int)(y * screen.Height) - RasterWidth / 2,
                        screen.Width - ScreenBorderStrength * 2,
                        RasterWidth);
                    g.FillRectangle(RasterBrush, r);
                }
            }

            g.Transform = originalTransform;
        }
    }
}
