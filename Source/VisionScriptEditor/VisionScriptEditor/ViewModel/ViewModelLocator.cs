using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Microsoft.Extensions.DependencyInjection;

namespace VisionScriptEditor.ViewModel
{
    public class ViewModelLocator
    {

        public ViewModelLocator()
        {
            System.Diagnostics.Debug.WriteLine("test");
        }

        public MainWindowViewModel MainWindowViewModel
        {
            get
            {
                return App.Current.Services.GetService<MainWindowViewModel>();
            }
        }
    }
}
