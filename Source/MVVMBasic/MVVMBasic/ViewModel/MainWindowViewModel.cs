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

        private string _Text = "";
        public string Text
        {
            get
            {
                return _Text;
            }
            set
            {
                //_Text = value;
                SetProperty(ref _Text, value);
            }
        }

        private bool _check = false;
        public ICommand HitTestCommand
        {
            get => new RelayCommand(() =>
            {
                _check = !_check;
                if (_check == true)
                    this.Text = "check!!";
                else
                    this.Text = "non check!!";
            });
        }

    }
}
