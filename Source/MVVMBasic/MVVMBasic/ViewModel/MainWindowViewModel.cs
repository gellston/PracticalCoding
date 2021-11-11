using Microsoft.Toolkit.Mvvm.ComponentModel;
using Microsoft.Toolkit.Mvvm.Input;
using MVVMBasic.Service;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Input;

namespace MVVMBasic.ViewModel
{
    public class MainWindowViewModel : ObservableObject
    {

        private readonly Service1 service1;

        public MainWindowViewModel(Service1 _service1)
        {
            this.service1 = _service1;
        }


        private string _Test = "TEST!!!!";
        public string Test
        {
            get
            {
                return _Test;
            }
            set
            {
                SetProperty(ref _Test, value);
            }
        }

        public ICommand TestCommand
        {
            get => new RelayCommand(() =>
            {
                this.Test = this.service1.InputTest("test");
                
            });
        }
    }
}
