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


        private ObservableObject _CurrentViewModel = null;
        public ObservableObject CurrentViewModel
        {
            get => _CurrentViewModel;
            set => SetProperty(ref _CurrentViewModel, value);
        }

        public ICommand AMenuCommand
        {
            get => new RelayCommand<ObservableObject>((viewModel) =>
            {
                this.CurrentViewModel = viewModel;
            });
        }
        public ICommand BMenuCommand
        {
            get => new RelayCommand<ObservableObject>((viewModel) =>
            {
                this.CurrentViewModel = viewModel;
            });
        }
        public ICommand CMenuCommand
        {
            get => new RelayCommand<ObservableObject>((viewModel) =>
            {
                this.CurrentViewModel = viewModel;
            });
        }
        public ICommand DMenuCommand
        {
            get => new RelayCommand<ObservableObject>((viewModel) =>
            {
                this.CurrentViewModel = viewModel;
            });
        }
    }
}
