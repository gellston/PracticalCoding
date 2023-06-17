using Prism.Ioc;
using Prism.Modularity;
using PrismFullAppExample.Modules.ModuleName;
using PrismFullAppExample.Services;
using PrismFullAppExample.Services.Interfaces;
using PrismFullAppExample.Views;
using System.Windows;

namespace PrismFullAppExample
{
    /// <summary>
    /// Interaction logic for App.xaml
    /// </summary>
    public partial class App
    {
        protected override Window CreateShell()
        {
            return Container.Resolve<MainWindow>();
        }

        protected override void RegisterTypes(IContainerRegistry containerRegistry)
        {
            containerRegistry.RegisterSingleton<IMessageService, MessageService>();
        }

        protected override void ConfigureModuleCatalog(IModuleCatalog moduleCatalog)
        {
            moduleCatalog.AddModule<ModuleNameModule>();
        }
    }
}
