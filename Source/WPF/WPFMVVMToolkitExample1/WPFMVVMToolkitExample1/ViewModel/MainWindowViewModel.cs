using CommunityToolkit.Mvvm.ComponentModel;
using CommunityToolkit.Mvvm.Input;
using Microsoft.Extensions.DependencyInjection;
using System;
using System.Collections.Generic;
using System.Collections.ObjectModel;
using System.Linq;
using System.Security.Cryptography;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Input;
using WPFMVVMToolkitExample1.Model;
using WPFMVVMToolkitExample1.Service;

namespace WPFMVVMToolkitExample1.ViewModel
{
    public partial class MainWindowViewModel : ObservableObject
    {

        #region Private Property
        private readonly ImageManagerService imageManagerService;

        #endregion

        #region Constructor
        public MainWindowViewModel(ImageManagerService _imageManagerService) {

            this.imageManagerService = _imageManagerService;

        }
        #endregion


        #region Property
        [ObservableProperty]
        public ObservableCollection<ImageViewModel> _ImageVMCollection = new ObservableCollection<ImageViewModel>();
        #endregion


        #region Command
        [RelayCommand]
        public void OpenImage()
        {
            try
            {

                var images = imageManagerService.LoadImages("C://Github//test");

                //////////////////
                /////////////////////
                /////////////////////
                /////////////////////
                /////////////////////
                List<ImageViewModel> imageViewModels = new List<ImageViewModel>();
                foreach (var image in images)
                {
                    var imageViewModel = App.Current.Services.GetService<ImageViewModel>();
                    imageViewModel.Model = image;
                    imageViewModels.Add(imageViewModel);
                }
                //////////////////
                /////////////////////
                /////////////////////
                /////////////////////
                /////////////////////


                this.ImageVMCollection = new ObservableCollection<ImageViewModel>(imageViewModels);

            }
            catch (Exception ex)
            {
                System.Diagnostics.Debug.WriteLine(ex.Message);
            }
        }

        [RelayCommand]
        public void Clear()
        {
            try
            {
                this.ImageVMCollection.Clear();

            }
            catch (Exception ex)
            {
                System.Diagnostics.Debug.WriteLine(ex.Message);
            }

        }


        #endregion

    }
}
