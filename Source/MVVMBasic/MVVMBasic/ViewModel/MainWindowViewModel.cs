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
    public class MainWindowViewModel : ObservableObject
    {

        public MainWindowViewModel()
        {
            System.Console.WriteLine("test");
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

        private bool _isCheck = false;
        public ICommand TestCommand
        {
            get => new RelayCommand(() =>
            {

                _isCheck = !_isCheck;

                if (_isCheck)
                {
                    this.Test = "!!!!!!!!!!!!!!!!!!!!!!";
                }
                else
                {
                    this.Test = "AAAA";
                }
            });
        }
    }
}
