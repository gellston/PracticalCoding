using Prism.Commands;
using Prism.Mvvm;
using Prism.Regions;
using System;
using System.Windows.Input;

namespace PrismInspectionExample.ViewModels
{
    public class MainWindowViewModel : BindableBase
    {

        #region Private  Property
        private readonly IRegionManager regionManager;
        #endregion


        #region Constructor
        public MainWindowViewModel(IRegionManager _regionManager)
        {
            this.regionManager = _regionManager;
        }
        #endregion

        public ICommand MainMenuChangedCommand
        {
            get => new DelegateCommand<string>((name) =>
            {
                try
                {
                    this.regionManager.RequestNavigate("Main", name);
                }catch(Exception e)
                {
                    System.Diagnostics.Debug.WriteLine(e.Message);
                }
            });
        }

      
    }
}
