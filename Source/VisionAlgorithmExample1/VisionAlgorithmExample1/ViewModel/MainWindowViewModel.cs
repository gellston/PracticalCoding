using Microsoft.Toolkit.Mvvm.ComponentModel;
using Microsoft.Toolkit.Mvvm.Input;
using System;
using System.Collections.Generic;
using System.Collections.ObjectModel;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Input;
using VisionAlgorithmExample1.Model;
using VisionAlgorithmExample1.Service;

namespace VisionAlgorithmExample1.ViewModel
{
    public class MainWindowViewModel : ObservableObject
    {

        private readonly VisionAlgorithmService algorithmService;

        public MainWindowViewModel(VisionAlgorithmService _algorithmService)
        {
            this.algorithmService = _algorithmService;
        }



        private ObservableCollection<ImageFile> _ImageFileCollection = null;
        public ObservableCollection<ImageFile> ImageFileCollection
        {
            get => _ImageFileCollection;
            set => SetProperty(ref _ImageFileCollection, value);    
        }



        public ICommand OpenImageFile
        {
            get => new RelayCommand(() =>
            {
                try
                {
                    var path = Helper.DialogHelper.OpenFolder();
                    ImageFileCollection = this.algorithmService.LoadImageFiles(path);
                }
                catch (Exception ex)
                {
                    System.Diagnostics.Debug.WriteLine(ex.Message);
                }

            });
        }
    }
}
