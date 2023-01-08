using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace WPFMVVMExample1.ViewModel
{
    public class ViewModelBase : INotifyPropertyChanged
    {
        #region Private Property
        public event PropertyChangedEventHandler? PropertyChanged;
        #endregion

        #region Constructor
        public ViewModelBase() { 
        
        }
        #endregion

        #region Function
        protected void OnPropertyChanged(string propertyName)
        {
            if (PropertyChanged != null)
            {
                PropertyChanged(this, new PropertyChangedEventArgs(propertyName));
            }
        }
        #endregion
    }
}
