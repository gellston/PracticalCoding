using About.Views;
using Prism.Ioc;
using Prism.Modularity;
using Prism.Regions;

namespace About
{
    public class AboutModule : IModule
    {
        public void OnInitialized(IContainerProvider containerProvider)
        {

        }

        public void RegisterTypes(IContainerRegistry containerRegistry)
        {
            containerRegistry.RegisterForNavigation<AboutView>();
        }
    }
}