using IService;
using Microsoft.Extensions.DependencyInjection;
using Model;
using Service;
using System;
using System.Collections.Generic;
using System.Configuration;
using System.Data;
using System.Linq;
using System.Runtime.CompilerServices;
using System.Threading.Tasks;
using System.Windows;
using ViewModel;
using WPFMVVMToolkitExample2.ViewModels;

namespace WPFMVVMToolkitExample2
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


            //ViewModel
            services.AddTransient<CameraViewModel>();
            services.AddSingleton<MainWindowViewModel>();

            //Service
            services.AddSingleton<ICameraService, CameraService>();


            //Converter
            services.AddTransient<Func<CameraModel, CameraViewModel>>((serviceProvider) =>
            {
                return (model) =>
                {
                    var vm = serviceProvider.GetService<CameraViewModel>();
                    vm.Model = model;
                    return vm;
                };
            });

            services.AddTransient<Func<List<CameraModel>, List<CameraViewModel>>>((serviceProvider) =>
            {
                return (models) =>
                {
                    var converter = serviceProvider.GetService<Func<CameraModel, CameraViewModel>>();
                    return models.Select(model => converter(model)).ToList();
                };
            });

            return services.BuildServiceProvider();
        }


        
      
    }

}
