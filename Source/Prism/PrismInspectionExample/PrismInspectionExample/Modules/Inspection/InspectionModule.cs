using Inspection.Interface;
using Inspection.Service;
using Inspection.Views;
using Prism.Ioc;
using Prism.Modularity;
using Prism.Regions;

namespace Inspection
{
    public class InspectionModule : IModule
    {
        public void OnInitialized(IContainerProvider containerProvider)
        {
            var regionManager = containerProvider.Resolve<IRegionManager>();
            regionManager.RequestNavigate("Main", "InspectionView");
        }

        public void RegisterTypes(IContainerRegistry containerRegistry)
        {
            containerRegistry.RegisterForNavigation<InspectionView>();
            containerRegistry.RegisterSingleton<ICameraService, CameraService>();
        }
    }
}