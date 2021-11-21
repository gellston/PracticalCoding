using Microsoft.Toolkit.Mvvm.ComponentModel;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MVVMBasic.Model
{
    public class TextFile : ObservableObject
    {

        public TextFile()
        {

        }

        private string _FileName = "";

        public string FileName
        {
            get => _FileName;
            set => SetProperty(ref _FileName, value);   
        }

        private string _FilePath = "";

        public string FilePath
        {
            get => _FilePath;
            set => SetProperty(ref _FilePath, value);
        }
    }
}
