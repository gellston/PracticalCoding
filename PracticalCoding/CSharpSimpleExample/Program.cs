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
            {
                while (true)
                {
                    HV.TestClass test = new HV.TestClass();
                    String CsharpString = "!!!!!";
                    test.SetString(CsharpString);

                    var result = test.GetString();

                    test = new HV.TestClass();

                    GC.Collect();
                    GC.WaitForPendingFinalizers();
                    GC.WaitForFullGCComplete();
                }
                
            }
            
            

        }


    }
}
