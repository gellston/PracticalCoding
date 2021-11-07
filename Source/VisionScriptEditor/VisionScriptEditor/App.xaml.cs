using Microsoft.Extensions.DependencyInjection;
using Microsoft.Toolkit.Mvvm.DependencyInjection;
using System;
using System.Collections.Generic;
using System.Configuration;
using System.Data;
using System.Linq;
using System.Windows;
using VisionScriptEditor.Service;
using VisionScriptEditor.ViewModel;

namespace VisionScriptEditor
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
        protected override void OnStartup(StartupEventArgs e)
        {
            
            ActiproSoftware.Products.ActiproLicenseManager.RegisterLicense("hyvision system", "WPF211-6PW5H-108N4-0W3L4-0KCG");
            base.OnStartup(e);
        }


        public new static App Current => (App)Application.Current;

        // ViewModel, 서비스, 모델이 담길 그릇. 
        public IServiceProvider Services { get; }


        // ViewModel, 서비스, 모델 등록 함수
        private static IServiceProvider ConfigureServices()
        {


            var services = new ServiceCollection();
            // 코드 등록 부분


            // Service
            services.AddSingleton<ScriptManageService>();
            services.AddSingleton<ConfigService>();


            // ViewModel
            services.AddSingleton<MainWindowViewModel>();

            return services.BuildServiceProvider();
        }

    }
}
