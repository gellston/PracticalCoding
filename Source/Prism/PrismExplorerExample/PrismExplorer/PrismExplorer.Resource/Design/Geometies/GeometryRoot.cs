using Newtonsoft.Json;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PrismExplorer.Resource.Design.Geometies
{
    internal class GeometryRoot
    {
        [JsonProperty("geometries")]
        public List<GeometryItem> Items { get; set; }
    }
}
