using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.IO;
using System.Linq;
using System.Runtime.CompilerServices;
using System.Text;
using System.Threading.Tasks;
using WPFMVVMToolkitExample1.Model;

namespace WPFMVVMToolkitExample1.Service
{
    public class ImageManagerService
    {
        #region Constructor
        public ImageManagerService() { 
        
        }
        #endregion


        #region Function
        public List<ImageModel> LoadImages(string path)
        {
            try
            {
                List<ImageModel> images = new List<ImageModel>();
                var files = Directory.GetFiles(path, "*.jpg");
                foreach (var file in files)
                {
                    var model = new ImageModel()
                    {
                        Name = Path.GetFileName(file),
                        Path = file
                    };
                    images.Add(model);
                }
                return images;
            }
            catch(Exception e)
            {
                System.Diagnostics.Debug.WriteLine(e.Message);
                throw e;
            }
        }
        #endregion
    }
}
