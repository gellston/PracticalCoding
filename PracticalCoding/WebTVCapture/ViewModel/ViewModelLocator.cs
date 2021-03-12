using System;
using System.Collections.Generic;
using System.Text;
using GalaSoft.MvvmLight;
using GalaSoft.MvvmLight.Ioc;

namespace WebTVCapture.ViewModel
{
    public class ViewModelLocator
    {

        public ViewModelLocator()
        {
            SimpleIoc.Default.Register<MainWindowViewModel>();



        }

        public MainWindowViewModel MainWindowViewModel
        {
            get
            {
                return SimpleIoc.Default.GetInstance<MainWindowViewModel>();
            }
        }
    }
}
