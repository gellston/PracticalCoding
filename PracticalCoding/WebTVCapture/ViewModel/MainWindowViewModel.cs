using GalaSoft.MvvmLight;
using GalaSoft.MvvmLight.Command;
using Microsoft.Win32;
using Microsoft.WindowsAPICodePack.Dialogs;
using System;
using System.Collections.Generic;
using System.Collections.ObjectModel;
using System.IO;
using System.Linq;
using System.Text;
using System.Windows.Input;
using WebTVCapture.Model;
using File = WebTVCapture.Model.File;

namespace WebTVCapture.ViewModel
{
    public class MainWindowViewModel : ViewModelBase
    {
        public MainWindowViewModel()
        {
            System.Console.WriteLine("test");
        }



        private ObservableCollection<File> _LogFilesCollection = null;
        public ObservableCollection<File> LogFilesCollection
        {
            get
            {
                _LogFilesCollection ??= new ObservableCollection<File>();
                return _LogFilesCollection;
            }
        }

        public ICommand LoadLogFileCommand
        {
            get => new RelayCommand(() =>
            {

                CommonOpenFileDialog dialog = new CommonOpenFileDialog();

                dialog.IsFolderPicker = true; 
                if (dialog.ShowDialog() == CommonFileDialogResult.Ok)
                {
                    var path = dialog.FileName;
                    var files = Directory.GetFiles(path, "*.jpg", SearchOption.AllDirectories);

                    foreach (var file in files)
                    {
                        this.LogFilesCollection.Add(new File()
                        {
                            FileName = Path.GetFileNameWithoutExtension(file),
                            FilePath = file
                        });
                    }

                }
  
            });
        }

    }
}
