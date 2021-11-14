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

        }



        public ICommand OpenMenuCommand
        {
            get => new RelayCommand(() =>
            {
                this.MenuOpen = !this.MenuOpen;
            });
        }
        
        //C# Property!!!!!!!!!!!!!
        private bool _MenuOpen = false;
        public bool MenuOpen
        {
            get => _MenuOpen;
            set => SetProperty(ref _MenuOpen, value);
        }

    }
}
