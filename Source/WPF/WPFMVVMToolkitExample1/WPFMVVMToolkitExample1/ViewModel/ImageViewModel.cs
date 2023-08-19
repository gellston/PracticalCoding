using CommunityToolkit.Mvvm.ComponentModel;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Media.Imaging;
using WPFMVVMToolkitExample1.Model;

namespace WPFMVVMToolkitExample1.ViewModel
{
    public partial class ImageViewModel : ObservableObject
    {

        #region Constructor
        public ImageViewModel() { 
        
        }
        #endregion



        #region Property

        [ObservableProperty]
        public string _Name = "";

        [ObservableProperty]
        public string _Path = "";


        [ObservableProperty]
        public ImageModel _Model = null;

    
        public BitmapImage Image
        {
            get
            {
                var image = new BitmapImage(new Uri(this.Path));
                image.CacheOption = BitmapCacheOption.OnDemand;

                return image;
            }
        }

        #endregion

        #region Function

        partial void OnModelChanged(ImageModel value)
        {
            this.Name = value.Name;
            this.Path = value.Path;


            //var image = new BitmapImage(new Uri(this.Path));
            //image.CacheOption = BitmapCacheOption.OnDemand;
            //this.Image = image;


        }
        #endregion
    }
}
