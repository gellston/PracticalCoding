using Microsoft.Toolkit.Mvvm.ComponentModel;
using Microsoft.Toolkit.Mvvm.Input;
using System;
using System.Collections.Generic;
using System.Collections.ObjectModel;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Input;
using System.Windows.Media.Imaging;
using VisionAlgorithmExample1.Model;
using VisionAlgorithmExample1.Service;

namespace VisionAlgorithmExample1.ViewModel
{
    public class MainWindowViewModel : ObservableObject
    {

        private readonly VisionAlgorithmService algorithmService;


        //CI Consturctor Injection
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


        public OpenCvSharp.Mat OpencvSharpImage = null;



        private ImageFile _SelectedImageFile = null;
        public ImageFile SelectedImageFile
        {
            get => _SelectedImageFile;
            set
            {
                var imageFile = value as ImageFile;

                try
                {
                    OpenCvSharp.Mat image = new OpenCvSharp.Mat(imageFile.FilePath);
                    this.OpencvSharpImage = image;
                    this.CurrentImage = OpenCvSharp.WpfExtensions.WriteableBitmapConverter.ToWriteableBitmap(image);
                }
                catch(Exception ex)
                {
                    System.Diagnostics.Debug.WriteLine(ex.Message);
                    System.Diagnostics.Debug.WriteLine(ex.StackTrace);
                }
                

                SetProperty(ref _SelectedImageFile, value);
            }
        }


        private WriteableBitmap _CurrentImage = null;
        public WriteableBitmap CurrentImage
        {
            get => _CurrentImage;
            set => SetProperty(ref _CurrentImage, value);
        }


        private WriteableBitmap _ResultImage = null;
        public WriteableBitmap ResultImage
        {
            get => _ResultImage;
            set => SetProperty(ref _ResultImage, value);
        }



        public ICommand OpenImageFileCommand
        {
            get => new RelayCommand(() =>
            {
                try
                {
                    var path = Helper.DialogHelper.OpenFolder();
                    this.ImageFileCollection = this.algorithmService.LoadImageFiles(path);
                }
                catch (Exception ex)
                {
                    System.Diagnostics.Debug.WriteLine(ex.Message);
                }

            });
        }

        public ICommand FilterTestCommand
        {
            get => new RelayCommand(() =>
            {
                try
                {

                    OpenCvSharp.Mat resultImage = new OpenCvSharp.Mat();
                    OpenCvSharp.Mat grayImage = new OpenCvSharp.Mat();
        
                    OpenCvSharp.Cv2.CvtColor(this.OpencvSharpImage, grayImage, OpenCvSharp.ColorConversionCodes. BGR2GRAY );

             

                    CliAlgorithm.Algorithm algo = new CliAlgorithm.Algorithm();
                    algo.Threshold(grayImage.Data, grayImage.Width, grayImage.Height, 128);


                    this.ResultImage = OpenCvSharp.WpfExtensions.WriteableBitmapConverter.ToWriteableBitmap(grayImage);


                }catch (Exception ex)
                {
                    System.Diagnostics.Debug.WriteLine(ex.Message);
                }

            });
        }
    }
}
