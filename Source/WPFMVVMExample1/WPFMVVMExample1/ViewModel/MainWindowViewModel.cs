using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Input;
using WPFMVVMExample1.Command;

namespace WPFMVVMExample1.ViewModel
{
    public class MainWindowViewModel : ViewModelBase
    {

        #region Private Property
       
        #endregion

        #region Contrsuctor
        public MainWindowViewModel() { 
        


        
        }
        #endregion


        #region Collection

        #endregion

        #region Command
        public ICommand LoadCommand
        {
            get => new RelayCommand<object>((objecct) =>
            {

            });
        }

        public ICommand SaveCommand
        {
            get => new RelayCommand<object>((objecct) =>
            {

            });
        }
        #endregion


    }
}
