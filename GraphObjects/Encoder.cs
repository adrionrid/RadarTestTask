using System;
using System.Collections.Generic;
using System.Collections.ObjectModel;
using System.Drawing;
using System.IO;
using System.Linq;
using System.Text;
using System.Text.RegularExpressions;
using System.Threading.Tasks;

namespace RadarTestTask.GraphObjects
{
    public static class Encoder
    {
        public static List<IGraphObject> Decode(string data)
        {
            var list = new List<IGraphObject>();
            using (var sr = new StringReader(data))
            {
                string stringObject;

                while ((stringObject = sr.ReadLine()) != null)
                {
                    var attributes = Split(stringObject);
                    var type = GraphObject.GetGraphObject(attributes[0]);
                    var graphObject = type.Create(stringObject);
                    list.Add(graphObject);
                }
            }
            return list;
        }

        public static string ReadFile(string fileName)
        {
            using (var sr = new StreamReader(fileName, Encoding.GetEncoding(1251)))
            {
                return sr.ReadToEnd();
            }
        }
        internal static string[] Split(string data)
        {
            var pattern = @"\s+";
            return Regex.Split(data, pattern, RegexOptions.IgnoreCase);
        }
    }
}
