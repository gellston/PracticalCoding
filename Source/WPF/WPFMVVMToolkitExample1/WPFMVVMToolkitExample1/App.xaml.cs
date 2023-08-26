using Microsoft.Extensions.DependencyInjection;
using System;
using System.Collections.Generic;
using System.Configuration;
using System.Data;
using System.Linq;
using System.Threading.Tasks;
using System.Windows;
using WPFMVVMToolkitExample1.Model;
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

            //ViewModel
            services.AddSingleton<MainWindowViewModel>();
            services.AddTransient<ImageViewModel>();
            services.AddTransient<Func<List<ImageModel>, List<ImageViewModel>>>((serviceProvider) =>
            {

                Func<List<ImageModel>, List<ImageViewModel>> converter = (models)=>{

                    List<ImageViewModel> viewModels = new List<ImageViewModel>();

                    foreach (var model in models)
                    {
                        //컨버터 중간 과정 
                        var imageViewModel = serviceProvider.GetService<ImageViewModel>();
                        imageViewModel.Model = model;
                        viewModels.Add(imageViewModel);
                    }
                    return viewModels;
                };
  
                return converter;
            });


            //Service
            services.AddSingleton<ImageManagerService>();
 
            return services.BuildServiceProvider();
        }
    }
}
