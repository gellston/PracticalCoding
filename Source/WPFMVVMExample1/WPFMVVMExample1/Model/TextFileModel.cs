using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace WPFMVVMExample1.Model
{
    public class TextFileModel : ModelBase
    {

        #region PrivateProperty
        private string _FileName = "";
        private string _FilePath = "";
        #endregion

        #region Constructor
        public TextFileModel()
        {

        }
        #endregion


        #region Public Property
        public string FileName
        {
            get => _FileName;
            set
            {
                _FileName = value;
                OnPropertyChanged("FileName");
            }
        }

        public string FilePath
        {
            get => _FilePath;
            set
            {
                _FilePath = value;
                OnPropertyChanged("FilePath");
            }
        }
        #endregion
    }
}
