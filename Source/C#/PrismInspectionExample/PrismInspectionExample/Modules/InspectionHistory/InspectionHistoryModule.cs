using InspectionHistory.Views;
using Prism.Ioc;
using Prism.Modularity;
using Prism.Regions;

namespace InspectionHistory
{
    public class InspectionHistoryModule : IModule
    {
        public void OnInitialized(IContainerProvider containerProvider)
        {
            //var regionManager = containerProvider.Resolve<IRegionManager>();
            //regionManager.RegisterViewWithRegion("Main", typeof(InspectionHistoryView));
        }

        public void RegisterTypes(IContainerRegistry containerRegistry)
        {
            containerRegistry.RegisterForNavigation<InspectionHistoryView>();
        }
    }
}