using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ObserverPattern.Interface
{
    public interface IObserver
    {
        public void Update(ISubject state);
    }
}
