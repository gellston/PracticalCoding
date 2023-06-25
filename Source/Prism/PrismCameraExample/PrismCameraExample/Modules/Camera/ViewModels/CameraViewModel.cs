using Camera.Interface;
using Prism.Commands;
using Prism.Mvvm;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows;
using System.Windows.Input;
using System.Windows.Media.Imaging;

namespace Camera.ViewModels
{
    public class CameraViewModel : BindableBase
    {

        #region Private Property
        private readonly ICameraService cameraService;
        private volatile bool _IsLoop = false;
        private bool _IsPlaying = false;
        private WriteableBitmap _CurrentFrame = null;
        #endregion

        #region Constructor
        public CameraViewModel(ICameraService _cameraService)
        {

            this.cameraService = _cameraService;
        }
        #endregion

        #region Public Property
        public WriteableBitmap CurrentFrame
        {
            get => _CurrentFrame;
            set => SetProperty(ref _CurrentFrame, value);
        }

        public bool IsPlaying
        {
            get => _IsPlaying;
            set => SetProperty(ref _IsPlaying, value);
        }
        #endregion

        #region Command
        public ICommand OpenCameraCommand
        {
            get => new DelegateCommand(() =>
            {
                try
                {
                    if (this.IsPlaying == true)
                        return;


                    this.cameraService.Open(0);
                }catch(Exception ex)
                {
                    System.Diagnostics.Debug.WriteLine(ex.Message);
                }
            });
        }

        public ICommand CloseCameraCommand
        {
            get => new DelegateCommand(() =>
            {
                try
                {
                    if (this.IsPlaying == true)
                        return;


                    this.cameraService.Close();

                }
                catch (Exception ex)
                {
                    System.Diagnostics.Debug.WriteLine(ex.Message);
                }
            });
        }


        public ICommand LiveCommand
        {
            get => new DelegateCommand(async() =>
            {
                try
                {

                    if (this.IsPlaying == true)
                        return;


                    this.IsPlaying = true;
                    Task.Run(async () =>
                    {
                        this._IsLoop = true;
                        while (this._IsLoop == true)
                        {
                            
                            var image = await this.cameraService.GrabAsync();
                            Application.Current.Dispatcher.Invoke(() =>
                            {
                                this.CurrentFrame = image;

                            });
                            await Task.Delay(33);
                        }
                        this.IsPlaying = false;
                    });
           
                }
                catch (Exception ex)
                {
                    System.Diagnostics.Debug.WriteLine(ex.Message);
                    this.IsPlaying = false;
                }
            });
        }

        public ICommand GrabCommand
        {
            get => new DelegateCommand(async () =>
            {
                try
                {
                    if (this.IsPlaying == true)
                        return;


                    this.CurrentFrame = await this.cameraService.GrabAsync();

                }
                catch (Exception ex)
                {
                    System.Diagnostics.Debug.WriteLine(ex.Message);
                }
            });
        }


        public ICommand StopCommand
        {
            get => new DelegateCommand(() =>
            {
                try
                {
                    
                    this._IsLoop = false;
                }
                catch (Exception ex)
                {
                    System.Diagnostics.Debug.WriteLine(ex.Message);
                }
            });
        }
        #endregion
    }
}
