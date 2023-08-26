using CommunityToolkit.Mvvm.ComponentModel;
using CommunityToolkit.Mvvm.Input;
using Microsoft.Extensions.DependencyInjection;
using Microsoft.WindowsAPICodePack.Dialogs;
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
        private readonly Func<List<ImageModel>, List<ImageViewModel>> imageModel2VMConverter;
        #endregion

        #region Constructor
        public MainWindowViewModel(ImageManagerService _imageManagerService,
                                   Func<List<ImageModel>, List<ImageViewModel>> _imageModel2VMConverter) {

            this.imageManagerService = _imageManagerService;
            this.imageModel2VMConverter = _imageModel2VMConverter;

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

                CommonOpenFileDialog dialog = new CommonOpenFileDialog();
                dialog.IsFolderPicker = true;
                var result = dialog.ShowDialog();
                if (result != CommonFileDialogResult.Ok)
                    return;


                var images = imageManagerService.LoadImages(dialog.FileName);
                var viewModels = imageModel2VMConverter(images);


                this.ImageVMCollection = new ObservableCollection<ImageViewModel>(viewModels);

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
