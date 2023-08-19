using Microsoft.Extensions.DependencyInjection;
using System;
using System.Collections.Generic;
using System.Configuration;
using System.Data;
using System.Linq;
using System.Threading.Tasks;
using System.Windows;
using WPFMVVMToolkitExample1.Service;
using WPFMVVMToolkitExample1.ViewModel;

namespace WPFMVVMToolkitExample1
{
    /// <summary>
    /// Interaction logic for App.xaml
    /// </summary>
    public partial class App : Application
    {

        public App()
        {
            Services = ConfigureServices();

            this.InitializeComponent();
        }

        /// <summary>
        /// Gets the current <see cref="App"/> instance in use
        /// </summary>
        public new static App Current => (App)Application.Current;

        /// <summary>
        /// Gets the <see cref="IServiceProvider"/> instance to resolve application services.
        /// </summary>
        public IServiceProvider Services { get; }

        /// <summary>
        /// Configures the services for the application.
        /// </summary>
        private static IServiceProvider ConfigureServices()
        {

            var services = new ServiceCollection();


            Action<int> callback = (id) =>
            {

            };

            callback(512);


            Func<int, bool> callbac2 = (id) =>
            {

                return false;
            };


            //ViewModel
            services.AddSingleton<MainWindowViewModel>();
            services.AddTransient<ImageViewModel>();




            //Service
            services.AddSingleton<ImageManagerService>();



            return services.BuildServiceProvider();
        }
    }
}
