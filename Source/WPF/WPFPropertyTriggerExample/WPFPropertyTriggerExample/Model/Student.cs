using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace WPFPropertyTriggerExample.Model
{
    public class Student : Person, INotifyPropertyChanged
    {


        #region Private Property
        private bool _Bad = false;
        private double _Score = 0;

        #endregion



        #region Constructor
        public Student() { }
        #endregion



        #region Public Property

        public double Score
        {
            get => _Score;
            set
            {

                _Score = value;

                OnPropertyChanged(nameof(Score));
            }
        }

        public bool Bad
        {
            get => _Bad;
            set
            {
                _Bad = value;
                OnPropertyChanged(nameof(Bad));
            }
        }
        #endregion


        #region Event
        public event PropertyChangedEventHandler? PropertyChanged;

        #endregion

        #region Function
        public void OnPropertyChanged(string propertyName)
        {
            if (this.PropertyChanged != null)
                this.PropertyChanged(this, new PropertyChangedEventArgs(propertyName));
        }
        #endregion


    }
}
