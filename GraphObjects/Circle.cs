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
    public class Circle : IGraphObject
    {
        public PointF Center { get; private set; }
        public float Radius { get; private set; }
        public float BorderWidth { get; private set; }
        public Color BorderColor { get; private set; }
        public Color FillColor { get; private set; } = Color.Transparent;
        private GraphicsPath path;
        public GraphicsPath Path => path;
        public string TypeName => GraphObject.TypeNames[typeof(Circle)];
        public Color[] Colors => new Color[] { BorderColor, FillColor };
        public PointF[] Vertices => new PointF[] { Center };
        public Circle()
        {

        }

        /// <summary>
        /// ОКР x y радиус толщина_линии цвет_границы [цвет заливки]
        /// </summary>
        /// <param name="data"></param>
        /// <returns></returns>
        public IGraphObject Create(string data)
        {
            var attr = Encoder.Split(data);
            var count = attr.Count();
            if (count < 6 || count > 7)
            {
                throw new ArgumentOutOfRangeException("Не корректный формат данных");
            }
            Center = new PointF(float.Parse(attr[1], CultureInfo.InvariantCulture), float.Parse(attr[2], CultureInfo.InvariantCulture));
            Radius = float.Parse(attr[3], CultureInfo.InvariantCulture);
            BorderWidth = float.Parse(attr[4], CultureInfo.InvariantCulture);
            BorderColor = Color.FromArgb(255, Color.FromArgb(int.Parse(attr[5])));
            if (count > 6)
            {
                FillColor = Color.FromArgb(255, Color.FromArgb(int.Parse(attr[6])));
            }

            path = new GraphicsPath();
            path.AddEllipse(new RectangleF(Center.X - Radius, Center.Y - Radius, Radius * 2, Radius * 2));
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
