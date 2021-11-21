using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MVVMBasic.Helper
{
    public class FileSystemHelper
    {

        public static void CopyFiles(string _sourcePath, string _targetPath, string pattern)
        {
            try
            {
                var files = Directory.GetFiles(_sourcePath, pattern);
                foreach (var file in files)
                {
                    File.Copy(file, _targetPath + Path.GetFileName(file), true);
                }
            }
            catch (Exception e)
            {
                throw e;
            }
        }


        public static void CopyFile(string _source, string _path)
        {

            try
            {
                File.Copy(_source, _path, true);
            }
            catch (Exception e)
            {
                throw e;
            }

        }


        public static string[] GetFiles(string _path, string _pattern)
        {
            try
            {
                string path = _path;
                string searchPatterns = _pattern;
                string[] files = searchPatterns
                                      .Split('|')
                                      .SelectMany(searchPattern => Directory.GetFiles(path, searchPattern)).ToArray();

                return files;
            }
            catch (Exception e)
            {
                throw e;
            }
        }

        public static void DeleteFiles(string _path)
        {
            try
            {
                System.IO.DirectoryInfo di = new DirectoryInfo(_path);
                foreach (FileInfo file in di.GetFiles())
                {
                    file.Delete();
                }
                foreach (DirectoryInfo dir in di.GetDirectories())
                {
                    dir.Delete(true);
                }
            }
            catch (Exception e)
            {
                throw e;
            }
        }

        
    }
}
