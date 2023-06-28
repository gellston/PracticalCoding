using ObserverPattern.Interface;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Reflection;
using System.Text;
using System.Threading.Tasks;

namespace ObserverPattern.Concrete
{
    public class AObserver : IObserver
    {


        public void Update(ISubject model)
        {
            var _model = model as Subject;
            System.Console.WriteLine("AObserver = " + _model.Status());
        }

    }
}
