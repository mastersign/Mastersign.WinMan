using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Drawing;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Mastersign.WinMan.Gui
{
    public partial class RasterChooser : UserControl
    {
        private CheckBox[] _xCbs;
        private CheckBox[] _yCbs;

        public RasterChooser()
        {
            InitializeComponent();
            InitializeCheckBoxes();
        }

        private void InitializeCheckBoxes()
        {
            var checkBoxes = tableLayoutPanel1.Controls.OfType<CheckBox>().ToList();
            foreach (var cb in checkBoxes)
            {
                cb.Tag = Enum.Parse(typeof(RasterPartitioning), (string)cb.Tag);
            }
            _xCbs = checkBoxes.Where(cb => cb.Name.EndsWith("X")).ToArray();
            _yCbs = checkBoxes.Where(cb => cb.Name.EndsWith("Y")).ToArray();
            UpdateCheckBoxes();
        }

        private LayoutPreviewRaster _raster;

        public event EventHandler RasterChangedHandler;

        public LayoutPreviewRaster Raster {
            get => _raster;
            private set
            {
                if (value == _raster) return;
                if (value != null && _raster != null && value.X == _raster.X && value.Y == _raster.Y) return;
                _raster = value;
                RasterChangedHandler?.Invoke(this, EventArgs.Empty);
            }
        }

        public void SetRaster(RasterPartitioning x, RasterPartitioning y)
        {
            if (_xPart == x && _yPart == y) return;
            _xPart = x;
            _yPart = y;
            UpdateRaster();
        }

        private RasterPartitioning _xPart;

        private RasterPartitioning XPartitioning
        {
            get => _xPart;
            set
            {
                if (_xPart == value) return;
                _xPart = value;
                UpdateRaster();
            }
        }

        private RasterPartitioning _yPart;

        private RasterPartitioning YPartitioning
        {
            get => _yPart;
            set
            {
                if (_yPart == value) return;
                _yPart = value;
                UpdateRaster();
            }
        }

        private void UpdateRaster()
        {
            if (_updating) return;
            _updating = true;
            UpdateCheckBoxes();
            Raster = new LayoutPreviewRaster(_xPart, _yPart);
            _updating = false;
        }

        private void UpdateCheckBoxes()
        {
            foreach (var cb in _xCbs) cb.Checked = _xPart == (RasterPartitioning)cb.Tag;
            foreach (var cb in _yCbs) cb.Checked = _yPart == (RasterPartitioning)cb.Tag;
        }

        private bool _updating;

        private void CheckBoxXHandler(object sender, EventArgs e)
        {
            if (_updating) return;
            var cb = (CheckBox)sender;
            XPartitioning = (RasterPartitioning)cb.Tag;
        }

        private void CheckBoxYHandler(object sender, EventArgs e)
        {
            if (_updating) return;
            var cb = (CheckBox)sender;
            YPartitioning = (RasterPartitioning)cb.Tag;
        }
    }
}
