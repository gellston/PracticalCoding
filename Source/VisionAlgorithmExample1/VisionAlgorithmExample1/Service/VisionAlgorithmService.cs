﻿using System;
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
                                 .Where(filePath => filePath.ToUpper().EndsWith(".JPG") || filePath.ToUpper().EndsWith(".BMP") || filePath.ToUpper().EndsWith(".JPEG"))
                                 .ToArray();


            ObservableCollection<ImageFile> temp = new ObservableCollection<ImageFile>();
            foreach(var file in files)
            {
                temp.Add(new ImageFile()
                {
                    FilePath = file,
                    FileName = Path.GetFileName(file),
                });
            }
            return temp;
        }
    }
}
