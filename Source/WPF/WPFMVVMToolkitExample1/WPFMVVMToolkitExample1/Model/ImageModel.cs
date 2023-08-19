using System;
using System.Collections.Generic;
using System.Linq;
using System.Security.RightsManagement;
using System.Text;
using System.Threading.Tasks;

namespace WPFMVVMToolkitExample1.Model
{
    public class ImageModel
    {
        #region Constructor
        public ImageModel()
        {

        }
        #endregion

        #region Property
        public string Name { get; set; } = "";
        public string Path { get; set; } = "";  
        #endregion
    }
}
