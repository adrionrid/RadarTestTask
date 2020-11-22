using System;
using System.Collections.Generic;
using System.Drawing;
using System.Drawing.Drawing2D;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace RadarTestTask.GraphObjects
{
    public class Renderer
    {
        private Graphics _graphics;
        public Graphics Graphics => _graphics;
        private Bitmap _bitmap;
        private PictureBox _pictureBox;
        private PointF mousePosition;
        public PointF MousePosition => mousePosition;

        private float currentScale = 1f;
        public float Scale { get => currentScale; private set => currentScale = Math.Max(scaleMin, value); }
        private static float scaleMin = 1f;
        public float ScaleCoef = 10000f;
        private float imageOffsetX;
        private float imageOffsetY;

        private List<IGraphObject> _graphObjects;

        public Renderer(PictureBox pictureBox)
        {
            _pictureBox = pictureBox;
            _bitmap = new Bitmap(pictureBox.Width - pictureBox.Padding.Horizontal, pictureBox.Height - pictureBox.Padding.Vertical);
            _graphics = Graphics.FromImage(_bitmap);
            _graphics.SmoothingMode = SmoothingMode.HighQuality;
            _graphics.Clear(_pictureBox.BackColor);
            ResetTransform();
            _pictureBox.MouseMove += (s, e) =>
                mousePosition = new PointF((pictureBox.Height - imageOffsetX - e.Y) / (_graphics.DpiY / 25.4f * 1000f) / Scale * ScaleCoef, (-imageOffsetY + e.X) / (_graphics.DpiX / 25.4f * 1000f) / Scale * ScaleCoef);

            _graphObjects = new List<IGraphObject>();
        }
        public void AddGraphObjects(IEnumerable<IGraphObject> graphObjects)
        {
            _graphObjects.AddRange(graphObjects);
        }
        public void Render()
        {
            _graphics.Clear(_pictureBox.BackColor);
            foreach (var g in _graphObjects)
            {
                g.Draw(this);
            }
            _pictureBox.Image = _bitmap;
        }

        public void Clear()
        {
            _graphObjects.Clear();
            _graphObjects.TrimExcess();
            _graphics.Clear(_pictureBox.BackColor);
        }

        private void ResetTransform()
        {
            _graphics.ResetTransform();
            _graphics.RotateTransform(-90f);
            _graphics.TranslateTransform(-_pictureBox.Height, 0);
            ScaleToMeters();
        }
        private void ScaleToMeters()
        {
            _graphics.ScaleTransform(_graphics.DpiX / 25.4f * 1000f, _graphics.DpiY / 25.4f * 1000f);
        }
        private void ApplyScale(float scale)
        {
            if (scale == 0)
                return;

            ResetTransform();
            ResetOffset();
            scale = Math.Abs(scale);
            _graphics.ScaleTransform(scale, scale);
            Render();
        }
        public void Zoom(float delta)
        {
            Scale += delta;
            ApplyScale(Scale / ScaleCoef);
        }
        public void ZoomOnAll()
        {
            var bounds = _graphObjects.Bounds();
            var max = (float)Math.Round(Math.Max(bounds.Width, bounds.Height));
            ApplyScale(max / ScaleCoef);
            Scale = max;
        }

        public void MoveImage(float x, float y, float sensivity = 1f)
        {
            imageOffsetX += x;
            imageOffsetY -= y;
            _graphics.TranslateTransform(x / (_graphics.DpiX / 25.4f * 1000f) / Scale * ScaleCoef * sensivity, -y / (_graphics.DpiY / 25.4f * 1000f) / Scale * ScaleCoef * sensivity);
            Render();
        }

        private void ResetOffset()
        {
            imageOffsetX = 0;
            imageOffsetY = 0;
        }

        public bool TryGetGraphObject(out IGraphObject hit)
        {
            hit = null;
            foreach (var g in _graphObjects)
            {
                if (g.Path.IsVisible(MousePosition))
                {
                    hit = g;
                    return true;
                }
            }
            return false;
        }
    }
}
