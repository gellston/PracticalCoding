using Microsoft.Toolkit.Mvvm.ComponentModel;
using Microsoft.Toolkit.Mvvm.Input;
using MVVMBasic.Service;
using System;
using System.Collections.Generic;
using System.Collections.ObjectModel;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Input;

namespace MVVMBasic.ViewModel
{
    public class MainWindowViewModel : ObservableObject
    {

        private readonly TextFileManager textFileManager;


        public MainWindowViewModel(TextFileManager _textFileManager)
        {
            this.textFileManager = _textFileManager;
        }

        public ICommand OpenFolderCommand
        {
            get => new RelayCommand(() =>
            {

                try
                {
                    var folderPath = Helper.DialogHelper.OpenFolder();

                    this.TextFileCollection = this.textFileManager.TextFilesReader(folderPath);

                }catch (Exception ex)
                {

                }
            });
        }


        private ObservableCollection<Model.TextFile> _TextFileCollection = null;
        public ObservableCollection<Model.TextFile> TextFileCollection
        {
            get => _TextFileCollection;
            set => SetProperty(ref _TextFileCollection, value); 
        }


        private Model.TextFile _SelectedTextFile = null;
        public Model.TextFile SelectedTextFile
        {
            get => _SelectedTextFile;
            set
            {

                if(value != null)
                {

                    var content = File.ReadAllText(value.FilePath, Encoding.UTF8);
                    this.CurrentText = content; 
                }

                SetProperty(ref _SelectedTextFile, value);
            }
        }

        private string _CurrentText = "";
        public string CurrentText
        {
            get => _CurrentText;
            set => SetProperty(ref _CurrentText, value);    
        }
    }
}
