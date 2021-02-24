using System;
using System.Collections.Generic;
using System.Text;

namespace CSharpSimpleExample
{
    public class Model
    {
        public Model()
        {

        }

 
        public string Property1 {
            get;set;
        }

        public int Property2
        {
            get; set;
        }

        public List<string> Property3
        {
            get
            {
                var list = new List<string>();
                for (int index = 0; index < 10; index++)
                    list.Add("value = " + index);
                return list;
            }
        }
    }
}
