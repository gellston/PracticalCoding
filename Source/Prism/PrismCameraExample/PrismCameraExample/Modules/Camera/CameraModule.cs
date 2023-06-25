using Camera.Interface;
using Camera.Service;
using Camera.Views;
using Prism.Ioc;
using Prism.Modularity;
using Prism.Regions;

namespace Camera
{
    public class CameraModule : IModule
    {
        public void OnInitialized(IContainerProvider containerProvider)
        {
            var regionManager = containerProvider.Resolve<IRegionManager>();
            regionManager.RequestNavigate("Main", "CameraView");
        }

        public void RegisterTypes(IContainerRegistry containerRegistry)
        {
            containerRegistry.RegisterForNavigation<CameraView>();
            containerRegistry.RegisterSingleton<ICameraService, CameraService>();
        }
    }
}