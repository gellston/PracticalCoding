using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace WPFBindingExample
{
    public class Person : INotifyPropertyChanged
    {

        #region Private Property
        public event PropertyChangedEventHandler? PropertyChanged;

        private string _Name = "";
        private int _Age = 0;
        #endregion

        #region Functions
        public void OnPropertyChanged(string propertyName)
        {
            if (PropertyChanged != null)
                PropertyChanged(this, new PropertyChangedEventArgs(propertyName));
        }
        #endregion


        #region Public Property
        public string Name
        {
            get => _Name;
            set
            {
                _Name = value;  
                OnPropertyChanged(nameof(Name));
            }
        }
        public int Age
        {
            get => _Age;
            set
            {
                _Age = value;
                OnPropertyChanged(nameof(Age));
            }
        }

        #endregion



    }
}
