using Microsoft.Extensions.DependencyInjection;
using WPFDependencyInjectionExample.Model;

namespace WPFDependencyInjectionExample
{
    internal class Program
    {
        static void Main(string[] args)
        {




            /////////////////////////////////
            // 서비스 등록
            var services = new ServiceCollection();
            services.AddSingleton<A>();
            services.AddSingleton<B>();
            var iocContainer = services.BuildServiceProvider();
            // 서비스 등록



            // 객체 생성
            var b = iocContainer.GetService<B>();


            System.Diagnostics.Debug.WriteLine("test");

        }
    }
}