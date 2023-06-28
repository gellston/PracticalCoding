using StrategyPattern.Interface;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace StrategyPattern.Concrete
{
    public class Context
    {

        #region Private Property
        private IStrategy strategy;
        #endregion

        #region Constructor
        public Context(IStrategy _strategy)
        {
            this.strategy = _strategy;
        }
        #endregion

        #region Function
        public void Run(string test)
        {
            this.strategy.Run(test);
        }

        public void SetStrategy(IStrategy _strategy)
        {
            this.strategy= _strategy;
        }
        #endregion
    }
}
