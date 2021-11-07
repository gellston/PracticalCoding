using Microsoft.Toolkit.Mvvm.ComponentModel;
using System;
using System.Collections.Generic;
using System.Collections.ObjectModel;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace VisionScriptEditor.Service
{
    public class ScriptManageService
    {

        private readonly ConfigService configService;
        private readonly HV.V1.VScript interpreter;

        public ScriptManageService(ConfigService _configService)
        {
            this.configService = _configService;



            HV.V1.VScript.InitV8StartupData(this.configService.CurrentApplicationPath);
            HV.V1.VScript.InitV8Platform();
            if (HV.V1.VScript.InitV8Engine() == false)
            {
                throw new Exception("V8 engine init failed");
            }
            HV.V1.VScript.SetV8Flag("--use_strict");
            HV.V1.VScript.SetV8Flag("--max_old_space_size=8192");
            HV.V1.VScript.SetV8Flag("--expose_gc");

            this.interpreter = new HV.V1.VScript();

        }


        public void Run(string _content)
        {
            try
            {
                this.interpreter.RunScript(_content);

                this.GlobalObjectcollection.Clear();

                foreach (KeyValuePair<string, HV.V1.Object> keyValue in this.interpreter.GlobalObjects)
                {
                    this.GlobalObjectcollection.Add(keyValue.Value);

                }

            }
            catch(HV.V1.ScriptError e)
            {
                throw e;
            }
        }

        private ObservableCollection<HV.V1.Object> _GlobalObjectCollection = null;
        public ObservableCollection<HV.V1.Object> GlobalObjectcollection
        {
            get
            {
                _GlobalObjectCollection ??= new ObservableCollection<HV.V1.Object>();
                return _GlobalObjectCollection;
            }
        }
    }
}
