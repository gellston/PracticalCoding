using System;
using System.Threading.Tasks;
using System.Windows.Media.Imaging;

namespace Camera.Interface
{
    public interface ICameraService
    {

        public Task<WriteableBitmap> GrabAsync();
        void Open(int id);
        void Close();
        bool IsOpen { get; }
    }
}
