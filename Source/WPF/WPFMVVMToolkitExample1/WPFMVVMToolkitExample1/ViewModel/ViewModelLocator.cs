using Microsoft.Extensions.DependencyInjection;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace WPFMVVMToolkitExample1.ViewModel
{
    public class ViewModelLocator
    {


        public MainWindowViewModel MainWindowViewModel
        {
            get => App.Current.Services.GetService<MainWindowViewModel>();
        }
    }
}
