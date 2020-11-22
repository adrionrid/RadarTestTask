using System;
using System.Collections.Generic;
using System.Drawing;
using System.Drawing.Drawing2D;
using System.Globalization;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace RadarTestTask.GraphObjects
{
    public class Rectangle : IGraphObject
    {
        public PointF BottomLeft { get; private set; }
        public PointF TopRight { get; private set; }
        public float BorderWidth { get; private set; }
        public Color BorderColor { get; private set; }
        public Color FillColor { get; private set; } = Color.Transparent;
        private GraphicsPath path;
        public GraphicsPath Path => path;
        public string TypeName => GraphObject.TypeNames[typeof(Rectangle)];
        public Color[] Colors => new Color[] { BorderColor, FillColor };
        public PointF[] Vertices => new PointF[] { BottomLeft, TopRight, new PointF(BottomLeft.X, TopRight.Y), new PointF(TopRight.X, BottomLeft.Y) };
        public Rectangle()
        {
        }

        /// <summary>
        /// ПРЯМ x y x1 y1 толщина_линии цвет_границы [цвет заливки]
        /// </summary>
        /// <param name="data"></param>
        /// <returns></returns>
        public IGraphObject Create(string data)
        {
            var attr = Encoder.Split(data);
            var count = attr.Count();
            if (count < 7 || count > 8)
            {
                throw new ArgumentOutOfRangeException("Не корректный формат данных");
            }
            BottomLeft = new PointF(float.Parse(attr[1], CultureInfo.InvariantCulture), float.Parse(attr[2], CultureInfo.InvariantCulture));
            TopRight = new PointF(float.Parse(attr[3], CultureInfo.InvariantCulture), float.Parse(attr[4], CultureInfo.InvariantCulture));
            BorderWidth = float.Parse(attr[5], CultureInfo.InvariantCulture);
            BorderColor = Color.FromArgb(255, Color.FromArgb(int.Parse(attr[6])));
            if (count > 7)
            {
                FillColor = Color.FromArgb(255, Color.FromArgb(int.Parse(attr[7])));
            }

            path = new GraphicsPath();
            path.AddRectangle(new RectangleF(BottomLeft.X, BottomLeft.Y, TopRight.X - BottomLeft.X, TopRight.Y - BottomLeft.Y));
            return this;
        }

        public void Draw(Renderer renderer)
        {
            using (var pen = new Pen(BorderColor, BorderWidth))
            {
                renderer.Graphics.DrawPath(pen, path);
            }
            if (!FillColor.Equals(Color.Transparent))
            {
                using (var brush = new SolidBrush(FillColor))
                {
                    renderer.Graphics.FillPath(brush, path);
                }
            }
        }

        public void Edit()
        {
            throw new NotImplementedException();
        }

        public string GetData()
        {
            throw new NotImplementedException();
        }
    }
}
