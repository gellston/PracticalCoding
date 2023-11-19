using Microsoft.Extensions.DependencyInjection;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace WPFMVVMToolkitExample2.ViewModels
{
    public class ViewModelLocator
    {

        #region Property
        public MainWindowViewModel MainWindowViewModel
        {
            get => App.Current.Services.GetService<MainWindowViewModel>();
        }

        #endregion
    }
}
