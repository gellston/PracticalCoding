using Microsoft.Toolkit.Mvvm.ComponentModel;
using Microsoft.Toolkit.Mvvm.Input;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Input;

namespace MVVMBasic.ViewModel
{
    public class AViewModel : ObservableObject
    {
        public AViewModel()
        {

        }

        public ICommand TestStringCommand
        {
            get => new RelayCommand(() =>
            {
                this.TestString = "!!!!!!!!!!!!";
            });
        }


        private string _TestString = "?????????";
        public string TestString
        {
            get => _TestString;
            set => SetProperty(ref _TestString, value);
        }
    }
}
