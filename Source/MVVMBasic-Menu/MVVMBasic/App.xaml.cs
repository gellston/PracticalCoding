using Microsoft.Extensions.DependencyInjection;
using MVVMBasic.ViewModel;
using System;
using System.Collections.Generic;
using System.Configuration;
using System.Data;
using System.Linq;
using System.Threading.Tasks;
using System.Windows;

namespace MVVMBasic
{
    /// <summary>
    /// Interaction logic for App.xaml
    /// </summary>
    public partial class App : Application
    {

        public App()
        {
            this.Services = ConfigureServices();
            this.InitializeComponent();


            
        }

        public new static App Current => (App)Application.Current;


        public IServiceProvider Services { get; }/// <summary>
        /// 
        /// </summary>
        /// <returns></returns>


        private static IServiceProvider ConfigureServices()
        {
            var services = new ServiceCollection();

            services.AddSingleton<MainWindowViewModel>();
            
            services.AddSingleton<AViewModel>();
            services.AddSingleton<BViewModel>();
            services.AddSingleton<CViewModel>();
            services.AddSingleton<DViewModel>();

            return services.BuildServiceProvider(); // IOC 컨테이너 리턴 
        }
    }
}
