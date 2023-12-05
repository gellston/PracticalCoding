using System;
using System.Collections.Generic;
using System.Linq;
using System.Runtime.CompilerServices;
using System.Text;
using System.Threading.Tasks;

namespace PrismExplorer.Resource.Design.Geometies
{
    internal class GeometryConverter
    {
        public static string GetData([CallerMemberName] string name = null)
        {
            return GeometryContainer._items[name].Data;
        }
    }
}
