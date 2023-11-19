using IService;
using Model;
using System;

namespace Service
{
    public class CameraService : ICameraService
    {
        #region Constructor
        public CameraService() { 
        
        }
        #endregion

        #region Function
        public CameraModel CreateCamera(string name, int usbID)
        {

            try
            {

                var model = new CameraModel(usbID);
                model.Name = name;

                return model;

            }catch(Exception ex)
            {

                throw ex;
            }

        }
        #endregion
    }
}
