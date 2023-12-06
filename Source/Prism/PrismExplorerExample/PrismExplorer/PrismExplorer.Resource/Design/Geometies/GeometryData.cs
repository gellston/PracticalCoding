using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PrismExplorer.Resource.Design.Geometies
{
    public class GeometryData
    {
        public static string Close => GeometryConverter.GetData();
        public static string Minimize => GeometryConverter.GetData();
        public static string Maximize => GeometryConverter.GetData();
        public static string Restore => GeometryConverter.GetData();
    }
}
