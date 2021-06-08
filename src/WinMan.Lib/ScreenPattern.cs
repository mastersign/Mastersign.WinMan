using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Mastersign.WinMan
{
    partial class ScreenPattern
    {
        public void Initialize()
        {
            BoundsChanged += BoundsChangedHandler;
            BoundsChanged += MatchesInvalidatedHandler;
            RespectPositionChanged += MatchesInvalidatedHandler;
            RespectSizeChanged += MatchesInvalidatedHandler;
        }

        public event EventHandler MatchesChanged;

        private void MatchesInvalidatedHandler(object sender, EventArgs e)
        {
            MatchesChanged?.Invoke(this, EventArgs.Empty);
            OnPropertyChanged(nameof(Matches));
        }

        public bool IsMatch(Screen screen)
            => (string.IsNullOrWhiteSpace(DeviceName) || string.Equals(DeviceName, screen.DeviceName))
                && (!RespectPosition || (Bounds.X == screen.Bounds.X && Bounds.Y == screen.Bounds.Y))
                && (!RespectSize || (Bounds.Width == screen.Bounds.Width && Bounds.Height == screen.Bounds.Height));

        public bool Matches => Screen.AllScreens.Any(IsMatch);
        
        public static ScreenPattern FromScreen(Screen screen)
            => new ScreenPattern
                {
                    Name = screen.DeviceName,
                    DeviceName = screen.DeviceName,
                    Bounds = screen.Bounds
                };

        public Screen Discover() => Screen.AllScreens.FirstOrDefault(IsMatch);

        public override string ToString() => Name;

        #region Bounds Properties

        public int Left
        {
            get => Bounds.Left;
            set => Bounds = new Rect(value, Bounds.Y, Bounds.Width, Bounds.Height);
        }

        public int Top
        {
            get => Bounds.Top;
            set => Bounds = new Rect(Bounds.X, value, Bounds.Width, Bounds.Height);
        }

        public int Width
        {
            get => Bounds.Width;
            set => Bounds = new Rect(Bounds.X, Bounds.Y, value, Bounds.Height);
        }

        public int Height
        {
            get => Bounds.Height;
            set => Bounds = new Rect(Bounds.X, Bounds.Y, Bounds.Width, value);
        }

        public event EventHandler LeftChanged;
        public event EventHandler TopChanged;
        public event EventHandler WidthChanged;
        public event EventHandler HeightChanged;

        private void BoundsChangedHandler(object sender, EventArgs e)
        {
            LeftChanged?.Invoke(sender, e);
            TopChanged?.Invoke(sender, e);
            WidthChanged?.Invoke(sender, e);
            HeightChanged?.Invoke(sender, e);
        }

        #endregion
    }
}
