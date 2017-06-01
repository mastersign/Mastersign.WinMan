using System;
using System.Collections.Generic;
using System.Drawing;
using System.Drawing.Drawing2D;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Mastersign.WinMan
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

        private void TransformToConfiguration(Graphics g, Size s, ConfigurationPattern c)
        {
            g.TranslateTransform(s.Width * 0.5f, s.Height * 0.5f);

            var screens = c.Screens;
            var outerBounds = screens[0].Bounds;
            for (int i = 1; i < screens.Count; i++)
            {
                outerBounds = Rectangle.Union(outerBounds, screens[i].Bounds);
            }
            outerBounds.Inflate(OuterMargin, OuterMargin);

            var factor = Math.Min(
                (float)s.Width / (float)outerBounds.Width,
                (float)s.Height / (float)outerBounds.Height);
            g.ScaleTransform(factor, factor);

            g.TranslateTransform(-outerBounds.Left - outerBounds.Width * 0.5f, -outerBounds.Top - outerBounds.Height * 0.5f);
        }

        private void TransformToScreen(Graphics g, ScreenPattern s)
        {
            var outerBounds = s.Bounds;
            var innerBounds = outerBounds;
            innerBounds.Inflate(-ScreenBorderStrength, -ScreenBorderStrength);
            g.TranslateTransform(innerBounds.Left, innerBounds.Top);
            var sx = (float)innerBounds.Width / (float)outerBounds.Width;
            var sy = (float)innerBounds.Height / (float)outerBounds.Height;
            g.ScaleTransform(sx, sy);
        }

        private void PaintScreen(Graphics g, ScreenPattern s, bool selected)
        {
            var r = s.Bounds;
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

            var transformOld = g.Transform;
            TransformToConfiguration(g, s, c);

            PaintScreens(g, c, selectedScreen);

            g.Transform = transformOld;
        }

        private void PaintWindowAction(Graphics g, ConfigurationPattern c, WindowAction a, bool selected = false)
        {
            var screen = c.FindScreenPattern(a.Screen);
            if (screen == null) return;

            var transformOld = g.Transform;
            TransformToScreen(g, screen);

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

            g.Transform = transformOld;
        }

        public void PaintWindowAction(Graphics g, Size s, Workspace w, Layout l, WindowAction a)
        {
            var c = w.FindConfigurationPattern(l.Configuration);
            if (c == null || c.Screens.Count == 0) return;

            g.Clear(BackgroundColor);

            g.SmoothingMode = SmoothingMode.HighQuality;

            var transformOld = g.Transform;
            TransformToConfiguration(g, s, c);

            PaintScreens(g, c);
            PaintWindowAction(g, c, a);

            g.Transform = transformOld;
        }

        public void PaintWindowActions(Graphics g, Size s, Workspace w, Layout l, WindowAction selectedWindowAction)
        {
            var c = w.FindConfigurationPattern(l.Configuration);
            if (c == null || c.Screens.Count == 0) return;

            g.Clear(BackgroundColor);

            g.SmoothingMode = SmoothingMode.HighQuality;

            var transformOld = g.Transform;
            TransformToConfiguration(g, s, c);

            PaintScreens(g, c);
            foreach (var a in l.Windows)
            {
                if (a == selectedWindowAction) continue;
                if (a.VirtualDesktop != selectedWindowAction.VirtualDesktop) continue;
                PaintWindowAction(g, c, a, false);
            }
            PaintWindowAction(g, c, selectedWindowAction, true);

            g.Transform = transformOld;
        }
    }
}
