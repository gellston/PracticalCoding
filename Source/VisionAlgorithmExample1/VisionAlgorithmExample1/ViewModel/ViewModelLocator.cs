using Microsoft.Extensions.DependencyInjection;
using Microsoft.Toolkit.Mvvm.ComponentModel;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace VisionAlgorithmExample1.ViewModel
{
    public class ViewModelLocator
    {
        


        

        public ViewModelLocator()
        {

        }


        public ObservableObject MainWindowViewModel
        {
            get=> App.Current.Services.GetService<MainWindowViewModel>();

        }

    }
}
