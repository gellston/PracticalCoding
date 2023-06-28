using ObserverPattern.Interface;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ObserverPattern.Concrete
{
    public class BObserver : IObserver
    {


        public void Update(ISubject model)
        {
            var _model = model as Subject;
            System.Console.WriteLine("BObserver = " + _model.Status());
        }

    }
}
