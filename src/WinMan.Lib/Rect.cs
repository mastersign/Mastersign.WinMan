using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Drawing;
using Newtonsoft.Json;

namespace Mastersign.WinMan
{
    [JsonConverter(typeof(ByStringJsonConverter))]
    partial class Rect
    {
        public int Left => X;
        public int Top => Y;
        public int Right => X + Width;
        public int Bottom => Y + Height;

        public Rect(string value)
        {
            if (string.IsNullOrEmpty(value)) throw new ArgumentException("Invalid string representation for the rectangle.", nameof(value));
            var parts = value.Split(',');
            if (parts.Length != 4) throw new ArgumentException("Invalid string representation for the rectangle.", nameof(value));
            _x = int.Parse(parts[0]);
            _y = int.Parse(parts[1]);
            _width = int.Parse(parts[2]);
            _height = int.Parse(parts[3]);
        }

        public override string ToString() => $"{X}, {Y}, {Width}, {Height}";

        public Rect Expand(Margin m) => new Rect(X - m.Left, Y - m.Top, Width + m.Left + m.Right, Height + m.Top + m.Bottom);
        public Rect Shrink(Margin m) => new Rect(X + m.Left, Y + m.Top, Width - m.Left - m.Right, Height - m.Top - m.Bottom);

        public static implicit operator Rectangle(Rect r) => new Rectangle(r.X, r.Y, r.Width, r.Height);
        public static implicit operator Rect(Rectangle r) => new Rect(r.X, r.Y, r.Width, r.Height);

        public static implicit operator string(Rect r) => r.ToString();
        public static implicit operator Rect(string value) => new Rect(value);
    }
}
