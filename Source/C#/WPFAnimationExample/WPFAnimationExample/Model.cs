using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace WPFAnimationExample
{
    public class Model : INotifyPropertyChanged
    {
        public event PropertyChangedEventHandler? PropertyChanged;

        #region Private Property
        private bool _IsChecked = false;
        #endregion

        #region Public Property
        public bool IsChecked
        {
            get => _IsChecked;
            set
            {
                _IsChecked = value;
                OnRaisePropertyChanged(nameof(IsChecked));
            }
  
        }
        #endregion

        #region Function
        public void OnRaisePropertyChanged(string name = "")
        {
            if(PropertyChanged != null)
            {
                PropertyChanged(this, new PropertyChangedEventArgs(name));
            }
        }
        #endregion
    }
}
