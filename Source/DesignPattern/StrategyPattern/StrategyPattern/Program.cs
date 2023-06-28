using StrategyPattern.Concrete;

namespace StrategyPattern
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Hello, World!");

            var a = new AStrategy();
            var b = new BStrategy();    
            var c = new CStrategy();

            var context = new Context(a);


            context.Run("test");
            context.SetStrategy(b);
            context.Run("test");
            context.SetStrategy(c);
            context.Run("test");

        }
    }
}