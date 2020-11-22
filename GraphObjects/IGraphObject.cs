using System;
using System.Collections.Generic;
using System.Drawing;
using System.Drawing.Drawing2D;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace RadarTestTask.GraphObjects
{
    public interface IGraphObject
    {
        IGraphObject Create(string data);
        void Edit();
        void Draw(Renderer renderer);
        string GetData();
        GraphicsPath Path { get; }
        string TypeName { get; }
        Color[] Colors { get; }
        PointF[] Vertices { get; }
    }
}
