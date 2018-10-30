using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.Drawing;
using System.Linq;

namespace Mastersign.WinMan.Gui
{
    public class LayoutPreviewRaster
    {
        public double[] X { get; }

        public double[] Y { get; }

        public LayoutPreviewRaster(RasterPartitioning pX, RasterPartitioning pY)
        {
            X = _partitionings[pX];
            Y = _partitionings[pY];
        }

        private static double GR = (3.0 - Math.Sqrt(5)) / 2.0;

        private static Dictionary<RasterPartitioning, double[]> _partitionings = new Dictionary<RasterPartitioning, double[]>
        {
            {RasterPartitioning.Golden, new [] { 0.0, GR, 1.0 - GR, 1.0 } },
            {RasterPartitioning.Even4, Even(4) },
            {RasterPartitioning.Even5, Even(5) },
            {RasterPartitioning.Even6, Even(6) },
            {RasterPartitioning.Even7, Even(7) },
            {RasterPartitioning.Even8, Even(8) },
            {RasterPartitioning.Even10, Even(10) },
            {RasterPartitioning.Even12, Even(12) },
        };

        private static double[] Even(int n) 
            => Enumerable.Range(0, n + 1).Select(v => 1.0 / n * v).ToArray();

        public static LayoutPreviewRaster Default => new LayoutPreviewRaster(RasterPartitioning.Even6, RasterPartitioning.Even4);

        internal Point GetPartition(float x, float y)
        {
            int px = 0;
            int py = 0;
            for (int i = 0; i < X.Length; i++) { if (x >= X[i]) px = i; }
            for (int i = 0; i < Y.Length; i++) { if (y >= Y[i]) py = i; }
            return new Point(px, py);
        }
    }

    public enum RasterPartitioning
    {
        Golden,
        Even4,
        Even5,
        Even6,
        Even7,
        Even8,
        Even10,
        Even12,
    }
}
