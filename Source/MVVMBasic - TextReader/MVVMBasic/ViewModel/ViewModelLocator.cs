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
            System.Console.WriteLine("Test");
        }

        public MainWindowViewModel MainWindowViewModel
        {
            get => App.Current.Services.GetService<MainWindowViewModel>();
        }
    }
}
