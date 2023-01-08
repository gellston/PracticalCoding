using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace WPFMVVMExample1.Model
{
    public class TextFileModel :  ModelBase
    {

        #region Private Property
        private string _FileName = "";
        private string _FilePath = "";

        #endregion


        #region Constructor
        public TextFileModel() {
        
        
        }
        #endregion

        #region Public Property
        public string FileName
        {
            get => _FileName;
            set
            {
                _FileName = value;
                this.OnPropertyChanged(nameof(FileName));
            }
        }

        public string FilePath
        {
            get => _FilePath;
            set
            {
                _FilePath = value;
                this.OnPropertyChanged(nameof(FilePath));
            }
        }
        #endregion



    }
}
