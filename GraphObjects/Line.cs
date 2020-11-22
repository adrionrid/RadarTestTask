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
    public class Line : IGraphObject
    {
        public PointF Start { get; private set; }
        public PointF End { get; private set; }
        public float Width { get; private set; }
        public Color Color { get; private set; }
        private GraphicsPath path;
        public GraphicsPath Path => path;
        public string TypeName => GraphObject.TypeNames[typeof(Line)];
        public Color[] Colors => new Color[] { Color };
        public PointF[] Vertices => new PointF[] { Start, End };
        public Line()
        {

        }
        /// <summary>
        /// ЛИН x y x1 y1 толщина_линии цвет_линии
        /// </summary>
        /// <param name="data"></param>
        /// <returns></returns>
        public IGraphObject Create(string data)
        {
            var attr = Encoder.Split(data);
            if (attr.Count() != 7)
            {
                throw new ArgumentOutOfRangeException("Не корректный формат данных");
            }

            Start = new PointF(float.Parse(attr[1], CultureInfo.InvariantCulture), float.Parse(attr[2], CultureInfo.InvariantCulture));
            End = new PointF(float.Parse(attr[3], CultureInfo.InvariantCulture), float.Parse(attr[4], CultureInfo.InvariantCulture));
            Width = float.Parse(attr[5]);
            Color = Color.FromArgb(255, Color.FromArgb(int.Parse(attr[6])));

            path = new GraphicsPath();
            path.AddLine(Start, End);
            return this;
        }

        public void Draw(Renderer renderer)
        {
            using (var pen = new Pen(Color, Width))
            {
                renderer.Graphics.DrawPath(pen, path);
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
