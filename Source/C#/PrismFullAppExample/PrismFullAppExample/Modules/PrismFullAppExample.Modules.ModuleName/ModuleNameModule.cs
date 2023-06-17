using Prism.Ioc;
using Prism.Modularity;
using Prism.Regions;
using PrismFullAppExample.Core;
using PrismFullAppExample.Modules.ModuleName.Views;

namespace PrismFullAppExample.Modules.ModuleName
{
    public class ModuleNameModule : IModule
    {
        private readonly IRegionManager _regionManager;

        public ModuleNameModule(IRegionManager regionManager)
        {
            _regionManager = regionManager;
        }

        public void OnInitialized(IContainerProvider containerProvider)
        {
            _regionManager.RequestNavigate("ContentRegion", "ViewA");
        }

        public void RegisterTypes(IContainerRegistry containerRegistry)
        {
            containerRegistry.RegisterForNavigation<ViewA>();
        }
    }
}