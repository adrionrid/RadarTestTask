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
    public class Point : IGraphObject
    {
        public PointF Position { get; private set; }
        public Color Color { get; private set; }

        private static float radius = 0.0005f;
        private GraphicsPath path;
        public GraphicsPath Path => path;
        public string TypeName => GraphObject.TypeNames[typeof(Point)];
        public Color[] Colors => new Color[] { Color };
        public PointF[] Vertices => new PointF[] { Position };
        public Point()
        {

        }

        /// <summary>
        /// ТЧК x y цвет
        /// </summary>
        /// <param name="data"></param>
        /// <returns></returns>
        public IGraphObject Create(string data)
        {
            var attr = Encoder.Split(data);
            if (attr.Count() != 4)
            {
                throw new ArgumentOutOfRangeException("Не корректный формат данных");
            }
            Position = new PointF(float.Parse(attr[1], CultureInfo.InvariantCulture), float.Parse(attr[2], CultureInfo.InvariantCulture));
            Color = Color.FromArgb(255, Color.FromArgb(int.Parse(attr[3])));

            path = new GraphicsPath();
            path.AddEllipse(new RectangleF(Position.X - radius, Position.Y - radius, radius * 2, radius * 2));
            return this;
        }

        public void Draw(Renderer renderer)
        {
            var r = radius * renderer.ScaleCoef / renderer.Scale;
            path.Reset();
            path.AddEllipse(new RectangleF(Position.X - r, Position.Y - r, r * 2, r * 2));

            using (var brush = new SolidBrush(Color))
            {
                renderer.Graphics.FillPath(brush, path);
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
