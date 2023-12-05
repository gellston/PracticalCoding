using Prism.Ioc;
using Prism.Unity;
using PrismExplorer.Support.UI.Units;
using PrismExplorer.View;
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
            return new MainWindowView();
        }

        protected override void RegisterTypes(IContainerRegistry containerRegistry)
        {
            

        }
    }
}
