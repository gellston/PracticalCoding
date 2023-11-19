using OpenCvSharp;
using System;
using System.Data;
using System.Threading;
using System.Windows;
using System.Windows.Media.Imaging;

namespace Model
{
    public class CameraModel
    {
        #region Private Property
        private VideoCapture capture = null;
        #endregion

        #region Constructor
        public CameraModel(int id) { 
        
            this.UsbID = id;


        }
        #endregion

        #region Property
        public int UsbID
        {
            private set;
            get;
        }

        public string Name { get; set; } = "";
        #endregion

        #region Function
        public void Open()
        {
            try
            {
                this.capture = new VideoCapture(this.UsbID);
               
            }
            catch (Exception ex)
            {
                throw new Exception(ex.Message, ex);
            }


        }

        public WriteableBitmap Grab()
        {
            try
            {
                using (Mat image = new Mat()) // Frame image buffer
                {
                    capture.Read(image); // same as cvQueryFrame
                    if (image.Empty())
                        throw new NullReferenceException("Invalid cv image");

                  

                   return OpenCvSharp.WpfExtensions.WriteableBitmapConverter.ToWriteableBitmap(image);
                }
            }
            catch(Exception ex)
            {
                throw new Exception(ex.Message, ex );
            }

        }

        public void Close()
        {
            if (this.capture != null)
                this.capture.Dispose();


            this.capture = null;
        }
        #endregion


    }
}
