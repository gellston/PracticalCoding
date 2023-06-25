using Camera.Interface;
using OpenCvSharp;
using OpenCvSharp.WpfExtensions;
using System;
using System.Threading.Tasks;
using System.Windows.Media.Imaging;

namespace Camera.Service
{
    public class CameraService : ICameraService
    {

        #region Private Property
        private bool _IsOpen = false;
        private VideoCapture cap = null;
        #endregion


        #region Public Property

        public bool IsOpen
        {
            get => _IsOpen;
        }


        #endregion

        #region Functions
        public void Close()
        {
            if(_IsOpen == false || this.cap == null)
            {
                throw new Exception("Its not open yet");
            }

            try
            {
                this.cap.Dispose();
                this.cap = null;
            }
            catch (Exception ex)
            {
                this._IsOpen = false;
                throw ex;
            }
            finally
            {
                this._IsOpen = false;
            }



        }

        public async Task<WriteableBitmap> GrabAsync()
        {
            if (_IsOpen == false)
            {
                throw new Exception("Its not open yet");
            }

            return await Task.Run<WriteableBitmap>(() =>
            {

                using (Mat image = new Mat())
                {
                    this.cap.Read(image);
                    var wbImage = image.ToWriteableBitmap();
                    wbImage.Freeze();
                    return wbImage;
                }
                
            });
        }

        public void Open(int id)
        {
            if (_IsOpen == true)
            {
                throw new Exception("Its already open");
            }

            try
            {
                if (this.cap != null)
                {
                    this.cap.Dispose();
                    this.cap = null;
                }

                this.cap = VideoCapture.FromCamera(id);
                this.cap.FrameWidth = 640;
                this.cap.FrameHeight = 480;
                this._IsOpen = true;
            }
            catch(Exception ex)
            {
                this._IsOpen = false;
                throw ex;
            }

       
        }

        #endregion
    }
}
