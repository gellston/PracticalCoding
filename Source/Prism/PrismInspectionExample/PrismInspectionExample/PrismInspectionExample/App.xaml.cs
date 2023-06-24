using Inspection;
using InspectionHistory;
using Prism.Ioc;
using Prism.Modularity;
using PrismInspectionExample.Views;
using System.Windows;

namespace PrismInspectionExample
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

        protected override void RegisterTypes(IContainerRegistry registry)
        {

        }

        protected override void ConfigureModuleCatalog(IModuleCatalog category)
        {
            category.AddModule<InspectionModule>();
            category.AddModule<InspectionHistoryModule>();

        }
    }
}
