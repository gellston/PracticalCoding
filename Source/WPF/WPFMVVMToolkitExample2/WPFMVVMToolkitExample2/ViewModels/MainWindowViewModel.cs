using CommunityToolkit.Mvvm.ComponentModel;
using CommunityToolkit.Mvvm.Input;
using IService;
using Microsoft.Extensions.DependencyInjection;
using Model;
using System;
using System.Collections.Generic;
using System.Collections.ObjectModel;
using System.Linq;
using System.Runtime.CompilerServices;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Input;
using ViewModel;

namespace WPFMVVMToolkitExample2.ViewModels
{
    public partial class MainWindowViewModel : ObservableObject
    {
        #region Private Property
        private readonly ICameraService cameraService;

        private Func<CameraModel, CameraViewModel> cameraVMConverter;
        #endregion


        #region Constructor
        public MainWindowViewModel(ICameraService _cameraService,
                                   Func<CameraModel, CameraViewModel> _cameraVMConverter) {

            this.cameraService = _cameraService;
            this.cameraVMConverter = _cameraVMConverter;
        }
        #endregion


        #region Property

        [ObservableProperty]
        public CameraViewModel _CurrentCameraViewModel = null;

        [ObservableProperty]
        private ObservableCollection<CameraViewModel> _CameraViewModelCollection = new ObservableCollection<CameraViewModel>();
        #endregion

        #region Collection

        #endregion

        #region Command
        [RelayCommand]
        private void CreateCamera()
        {
            try
            {
                var currentTimeStamp = DateTime.Now.ToString("yyyy-MM-dd HH:mm:ss:fff");
                var cameraModel = this.cameraService.CreateCamera(currentTimeStamp, 0);
                var vm = this.cameraVMConverter(cameraModel);
                this.CameraViewModelCollection.Add(vm);


            }catch(Exception ex)
            {
                System.Diagnostics.Debug.WriteLine(ex.Message);
            }
        }


        [RelayCommand]
        private void RemoveCamera()
        {
            try
            {
                if (this.CurrentCameraViewModel == null) return;


                this.CameraViewModelCollection.Remove(this.CurrentCameraViewModel);
            }
            catch (Exception ex)
            {
                System.Diagnostics.Debug.WriteLine(ex.Message);
            }
        }

        #endregion

        #region Event Handler

        #endregion

    }
}
