using Newtonsoft.Json;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Mastersign.WinMan
{
    [JsonConverter(typeof(ByStringJsonConverter))]
    partial class Margin
    {
        public int Vertical => Top + Bottom;
        public int Horizontal => Left + Right;

        public Margin(string value)
        {
            if (string.IsNullOrEmpty(value)) throw new ArgumentException("Invalid string representation for the margin.", nameof(value));
            var parts = value.Split(',');
            if (parts.Length != 4) throw new ArgumentException("Invalid string representation for the margin.", nameof(value));
            _left = int.Parse(parts[0]);
            _top = int.Parse(parts[1]);
            _right = int.Parse(parts[2]);
            _bottom = int.Parse(parts[3]);
        }

        public override string ToString() => $"{Left}, {Top}, {Right}, {Bottom}";

        public static implicit operator string(Margin m) => m.ToString();
        public static implicit operator Margin(string value) => new Margin(value);
    }
}
