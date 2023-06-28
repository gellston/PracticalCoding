using ObserverPattern.Concrete;

namespace ObserverPattern
{
    internal class Program
    {
        static void Main(string[] args)
        {

            var subject = new Subject();

            var a = new AObserver();
            var b = new BObserver();    

            subject.Attach(a);
            subject.Attach(b);


            subject.BusinessLogic1();
            subject.BusinessLogic2();
            subject.Detach(a);

            subject.BusinessLogic1();
            subject.BusinessLogic2();
        }
    }
}