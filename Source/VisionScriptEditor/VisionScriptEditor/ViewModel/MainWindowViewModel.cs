using Microsoft.Toolkit.Mvvm.ComponentModel;
using Microsoft.Toolkit.Mvvm.Input;
using System;
using System.Collections.Generic;
using System.Collections.ObjectModel;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Input;
using VisionScriptEditor.Service;

namespace VisionScriptEditor.ViewModel
{
    public class MainWindowViewModel : ObservableObject
    {
        private readonly ScriptManageService scriptManageService;

        public MainWindowViewModel(ScriptManageService _scriptManageService)
        {
            this.scriptManageService = _scriptManageService;


            this.GlobalObjectCollection = this.scriptManageService.GlobalObjectcollection;

        }


        private ObservableCollection<HV.V1.Object> _GlobalObjectCollection = null;
        public ObservableCollection<HV.V1.Object> GlobalObjectCollection
        {
            get => _GlobalObjectCollection;
            set => _GlobalObjectCollection = value;
        }


        private string _ScriptContent = "";
        public string ScriptContent
        {
            get => _ScriptContent;
            set => SetProperty(ref _ScriptContent, value);
        }

       
        public ICommand OpenFolderCommand
        {
            get => new RelayCommand(() =>
            {
                try
                {
                    var folderPath = Helper.DialogHelper.OpenFolder();
                    
                }catch(Exception e)
                {
                    Helper.DialogHelper.ShowToastErrorMessage("폴더 열기 실패", "폴더 열기에 실패 했습니다.");
                }
            });
        }


        public ICommand RunScriptCommand
        {
            get => new RelayCommand(() =>
            {
                try
                {
                    this.scriptManageService.Run(this.ScriptContent);
                }catch(HV.V1.ScriptError e)
                {
                    Helper.DialogHelper.ShowToastErrorMessage("Script error", e.Message);

                }
            });
        }
    }
}
