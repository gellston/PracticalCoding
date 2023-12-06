using Prism.Ioc;
using Prism.Modularity;
using Prism.Unity;
using PrismExplorer.Support.UI.Units;
using PrismExplorer.Views;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows;

namespace PrismExplorer
{
    internal class App : PrismApplication
    {
        protected override Window CreateShell()
        {
            return new ExplorerWindowView();
        }

        protected override void RegisterTypes(IContainerRegistry containerRegistry)
        {
            

        }

        protected override void ConfigureModuleCatalog(IModuleCatalog moduleCatalog)
        {
           // moduleCatalog.addmodule
        }
    }
}
