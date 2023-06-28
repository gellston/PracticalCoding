using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using StrategyPattern.Interface;

namespace StrategyPattern.Concrete
{
    public class AStrategy : IStrategy
    {
        public void Run(string test)
        {
            Console.WriteLine("A Strategy = " + test);
        }
    }
}
