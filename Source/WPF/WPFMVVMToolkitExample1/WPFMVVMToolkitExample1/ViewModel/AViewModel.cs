using CommunityToolkit.Mvvm.ComponentModel;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace WPFMVVMToolkitExample1.ViewModel
{
    public class AViewModel : ObservableObject
    {

        #region Constructor
        public AViewModel() {


            System.Console.WriteLine("test");
        }
        #endregion


        #region Property
        public ImageViewModel ImageViewModel1 { get; set; } = null;
        public ImageViewModel ImageViewModel2 { get; set; } = null;
        #endregion
    }
}
