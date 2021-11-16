using Microsoft.Toolkit.Mvvm.ComponentModel;
using Microsoft.Toolkit.Mvvm.Input;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Input;

namespace MVVMBasic.Model
{
    public class Student : ObservableObject
    {

        public Student()
        {

        }

        private string _Name = "";
        public string Name
        {
            get => _Name;
            set => SetProperty(ref _Name, value);   
        }



        private int _Age = 0;
        public int Age
        {
            get => _Age;
            set => SetProperty(ref _Age, value);
        }

        public ICommand HitTestCommand
        {
            get => new RelayCommand(() =>
            {
                System.Diagnostics.Debug.WriteLine("test");
            });
        }
    }
}
