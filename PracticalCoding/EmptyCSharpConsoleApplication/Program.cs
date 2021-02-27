using System;

namespace EmptyCSharpConsoleApplication
{
    class Program
    {
        static void Main(string[] args)
        {
            while (true)
            {
                HV.TestClass test = new HV.TestClass();
                var list = test.GetData();

                test.SetString("!!!!!!");

                foreach (var element in list)
                {
                    System.Console.WriteLine("result = " + element);
                }

                GC.Collect();
           
            }
        }
    }
}
