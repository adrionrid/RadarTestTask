using System;
using System.Collections.Generic;
using System.Drawing;
using System.Globalization;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace RadarTestTask.GraphObjects
{
    public static class GraphObject
    {
        private static Dictionary<string, Func<IGraphObject>> types = new Dictionary<string, Func<IGraphObject>>{
            {"тчк", () => new Point()},
            {"окр", () => new Circle()},
            {"лин", () => new Line()},
            {"прям", () => new Rectangle()}
        };
        public static IReadOnlyDictionary<string, Func<IGraphObject>> Types => types;
        private static Dictionary<Type, string> typeNames = new Dictionary<Type, string>{
            {typeof(Line), "Линия"},
            {typeof(Point), "Точка"},
            {typeof(Circle), "Круг"},
            {typeof(Rectangle), "Прямоугольник"},
        };
        public static IReadOnlyDictionary<Type, string> TypeNames => typeNames;

        public static IGraphObject GetGraphObject(string type)
        {
            var t = type.ToLower();
            if (types.ContainsKey(t))
            {
                return types[t].Invoke();
            }

            throw new ArgumentOutOfRangeException("GraphObject type not found.");
        }
        public static string GetGraphObjectInfo(IGraphObject graphObject)
        {
            var sb = new StringBuilder();
            sb.AppendLine($"Тип: {graphObject.TypeName}");
            sb.AppendLine($"Цвета: ");
            foreach (var item in graphObject.Colors)
            {
                sb.AppendLine($"    {item}");
            }
            sb.AppendLine($"Вершины: ");
            foreach (var item in graphObject.Vertices)
            {
                sb.AppendLine($"    {item}");
            }
            return sb.ToString();
        }
    }
}
