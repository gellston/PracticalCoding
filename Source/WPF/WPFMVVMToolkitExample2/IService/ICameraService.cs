using Model;
using System;

namespace IService
{
    public interface ICameraService
    {
        public CameraModel CreateCamera(string name, int usbID);
    }
}
