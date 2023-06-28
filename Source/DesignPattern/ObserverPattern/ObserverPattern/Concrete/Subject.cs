using ObserverPattern.Interface;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ObserverPattern.Concrete
{
    public class Subject : ISubject
    {

        #region Private Property

        List<IObserver> observers = new List<IObserver>();
        private int _state = 0;
        #endregion


        #region Function
        public void Attach(IObserver observer)
        {
            this.observers.Add(observer);
        }

        public void Detach(IObserver observer)
        {
            this.observers.Remove(observer);
        }

        public void Notify()
        {
           foreach(var observer in this.observers)
            {
                observer.Update(this);
            }
        }

        public void BusinessLogic1()
        {

            this.SetState(1);
            this.Notify();
            
        }

        public void BusinessLogic2()
        {
            this.SetState(2);
            this.Notify();
        }

        public int Status()
        {
            return _state;
        }

        public void SetState(int state)
        {
            this._state = state;
        }
        #endregion
    }
}
