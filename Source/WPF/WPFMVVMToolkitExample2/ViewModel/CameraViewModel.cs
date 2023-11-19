using CommunityToolkit.Mvvm.ComponentModel;
using CommunityToolkit.Mvvm.Input;
using Model;
using System;
using System.Threading;
using System.Threading.Tasks;
using System.Windows.Media.Imaging;

namespace ViewModel
{
    public partial class CameraViewModel : ObservableObject
    {

        #region Constructor
        public CameraViewModel()
        {

        }
        #endregion

        #region Property
        [ObservableProperty]
        private CameraModel _Model = null;


        [ObservableProperty]
        private int _UsbID = 0;

        [ObservableProperty]
        private string _Name = "";

        [ObservableProperty]
        private WriteableBitmap _CurrentFrame = null;
        #endregion


        #region Event Handler
        partial void OnModelChanged(CameraModel model)
        {
            this.UsbID = model.UsbID;
            this.Name = model.Name;
        }
        #endregion

        #region Command

        [RelayCommand]
        private void OpenCamera()
        {
            try
            {

                this.Model.Open();

            }catch (Exception ex)
            {
                System.Diagnostics.Debug.WriteLine(ex.Message);

            }

        }

        [RelayCommand]
        private void CloseCamera()
        {
            try
            {
                this.Model.Close();
            }
            catch (Exception ex)
            {
                System.Diagnostics.Debug.WriteLine(ex.Message);

            }

        }



        [RelayCommand]
        private void Capture()
        {
            try
            {
                var image = this.Model.Grab();
                this.CurrentFrame = image;
            }catch(Exception ex)
            {
                System.Diagnostics.Debug.WriteLine(ex.Message);
            }
        }


        [RelayCommand]
        private async Task Continue(CancellationToken token)
        {
            try
            {
                await Task.Run(async () =>
                {
                    while (!token.IsCancellationRequested)
                    {

                        var currentFrame = this.Model.Grab();
                        currentFrame.Freeze();
                        this.CurrentFrame = currentFrame;
                        await Task.Delay(33);
                    }

                });
            }
            catch (Exception ex)
            {
                System.Diagnostics.Debug.WriteLine(ex.Message);
            }
        }


        [RelayCommand]
        private void Stop()
        {
            try
            {
                this.continueCommand.Cancel();
            }catch(Exception ex)
            {
                System.Diagnostics.Debug.WriteLine(ex.Message);
            }
        }
        #endregion

    }
}
