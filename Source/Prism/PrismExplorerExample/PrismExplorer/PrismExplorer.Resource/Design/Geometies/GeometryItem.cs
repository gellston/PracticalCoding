using Newtonsoft.Json;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PrismExplorer.Resource.Design.Geometies
{
    internal class GeometryItem
    {
        [JsonProperty("name")]
        public string Name { get; set; }

        [JsonProperty("data")]
        public string Data { get; set; }
    }
}
