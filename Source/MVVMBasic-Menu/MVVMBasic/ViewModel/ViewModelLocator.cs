using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Microsoft.Extensions.DependencyInjection;

namespace MVVMBasic.ViewModel
{
    public class ViewModelLocator
    {

        public ViewModelLocator()
        {
        }

        public MainWindowViewModel MainWindowViewModel
        {
            get => App.Current.Services.GetService<MainWindowViewModel>();
        }

        public AViewModel AViewModel
        {
            get => App.Current.Services.GetService<AViewModel>();
        }

        public BViewModel BViewModel
        {
            get => App.Current.Services.GetService<BViewModel>();
        }

        public CViewModel CViewModel
        {
            get => App.Current.Services.GetService<CViewModel>();
        }

        public DViewModel DViewModel
        {
            get => App.Current.Services.GetService<DViewModel>();
        }

    }
}
