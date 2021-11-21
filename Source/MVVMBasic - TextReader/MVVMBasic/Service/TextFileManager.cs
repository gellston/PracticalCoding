using MVVMBasic.Model;
using System;
using System.Collections.Generic;
using System.Collections.ObjectModel;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MVVMBasic.Service
{
    public class TextFileManager
    {

        public TextFileManager()
        {

        }

        public ObservableCollection<TextFile> TextFilesReader(string _path)
        {
            ObservableCollection<TextFile> collection = new ObservableCollection<TextFile>();

            var files = Helper.FileSystemHelper.GetFiles(_path, "*.txt");


            foreach (var file in files)
            {
                var textfileModel = new TextFile()
                {
                    FileName = Path.GetFileName(file),
                    FilePath = file
                };
                collection.Add(textfileModel);
            }


            return collection;
        }
    }
}
