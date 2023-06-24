using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace WPFDataTriggerExample
{
    public class Student : INotifyPropertyChanged
    {

        #region Private Property
        private string _Name = "";
        private int _Age = 0;
        private bool _Bad = false;
        #endregion

        #region Event
        public event PropertyChangedEventHandler? PropertyChanged;

        public void OnRaisePropertyChanged(string propertyName)
        {
            if(this.PropertyChanged != null)
                this.PropertyChanged.Invoke(this, new PropertyChangedEventArgs(propertyName));
        }
        #endregion

        #region Constructor
        public Student()
        {

        }


        #endregion

        #region Public Property

        public string Name
        {
            get => _Name;
            set
            {
                _Name = value;
                OnRaisePropertyChanged(nameof(Name));
            }
        }

        public bool Bad
        {
            get => _Bad;
            set
            {
                _Bad = value;
                OnRaisePropertyChanged(nameof(Bad));
            }
        }

        public int Age
        {
            get => _Age;
            set
            {
                _Age = value;
                OnRaisePropertyChanged(nameof(Age));
            }
        }
        #endregion
    }
}
