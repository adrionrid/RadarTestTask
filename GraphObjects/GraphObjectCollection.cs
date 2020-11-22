using System;
using System.Collections.Generic;
using System.Drawing;
using System.Drawing.Drawing2D;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace RadarTestTask.GraphObjects
{
    public static class GraphObjectCollection
    {
        public static RectangleF Bounds(this IEnumerable<IGraphObject> graphObjects)
        {
            using (var path = new GraphicsPath())
            {
                foreach (var g in graphObjects)
                {
                    path.AddPath(g.Path, false);
                }
                return path.GetBounds();
            }
        }
    }
}
