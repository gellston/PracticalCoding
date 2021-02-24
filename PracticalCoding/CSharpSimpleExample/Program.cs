using System;
using System.IO;
using System.Threading;
using System.Threading.Tasks;
using System.Xml.Serialization;

namespace CSharpSimpleExample
{
    class Program
    {
        static void Main(string[] args)
        {
            //XML Serialization 파일 출력 
            using (StreamWriter wr = new StreamWriter(@"d:\Test.xml"))
            {
                var model = new Model()
                {
                    Property1 = "test!!!",
                    Property2 = 1
                };
                XmlSerializer xs = new XmlSerializer(typeof(Model));
                xs.Serialize(wr, model);
            }

            //XML DeSerialization 파일 리딩 
            using (var reader = new StreamReader(@"d:\Test.xml"))
            {
                XmlSerializer xs = new XmlSerializer(typeof(Model));
                Model model = (Model)xs.Deserialize(reader);
            }

        }
    }
}
