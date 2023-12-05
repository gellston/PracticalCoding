using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Reflection;
using System.Text;
using System.Text.Json;
using System.Threading.Tasks;
using YamlDotNet.Serialization;
using Newtonsoft.Json;

namespace PrismExplorer.Resource.Design.Geometies
{
    public class GeometryContainer
    {
        static GeometryContainer()
        {
            Build();
        }

        internal static GeometryRoot _data;
        internal static Dictionary<string, GeometryItem> _items;

        private static void Build()
        {
            Assembly assembly = Assembly.GetExecutingAssembly();
            var resourceName = "PrismExplorer.Resource.Properties.Resources.geometries.yaml";

            var names = Assembly.GetExecutingAssembly().GetManifestResourceNames();

            using (var stream = assembly.GetManifestResourceStream(resourceName))
            using(var reader = new StreamReader(stream))
            {
                StringReader r = new StringReader(reader.ReadToEnd());  
                Deserializer deserializer = new Deserializer();
                object yamlObject = deserializer.Deserialize<object>(r);

                Newtonsoft.Json.JsonSerializer js = new Newtonsoft.Json.JsonSerializer();
                StringWriter w = new StringWriter();
                js.Serialize(w, yamlObject);

                string jsonText = w.ToString();

                _data = JsonConvert.DeserializeObject<GeometryRoot>(jsonText);
                _items = new Dictionary<string, GeometryItem>();

                foreach(var item in _data.Items) {
                    _items.Add(item.Name, item);
                }
            }

        }
    }
}
