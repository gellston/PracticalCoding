using System;
using System.Collections.Generic;
using System.Collections.ObjectModel;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using VisionAlgorithmExample1.Model;

namespace VisionAlgorithmExample1.Service
{
    public class VisionAlgorithmService
    {

        public VisionAlgorithmService()
        {

        }


        public ObservableCollection<ImageFile> LoadImageFiles(string path)
        {


            var files = Directory.GetFiles(path, "*.*", SearchOption.AllDirectories)
                        .Where(path => path.ToUpper().EndsWith(".JPG") || path.EndsWith(".BMP") || path.EndsWith(".JPEG"));
                                    

            ObservableCollection<ImageFile> temp = new ObservableCollection<ImageFile>();
            foreach(var file in files)
            {
                temp.Add(new ImageFile()
                {
                    FileName = Path.GetFileName(file),
                    FilePath = file
                });
            }

            return temp;
        }
    }
}
