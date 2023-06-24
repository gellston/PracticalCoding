using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace WPFUserManagementExample.ViewModel
{
    public class UserViewModel : ViewModelBase
    {


        #region Private Property
        private DateTime _AddDateTime = DateTime.Now;
        private DateTime _UpdateDateTime = DateTime.Now;

        private string _SurName = "";
        private string _FirstName = "";
        #endregion

        #region Constructor
        public UserViewModel()
        {

        }
        #endregion

        #region Property
        public string SurName
        {
            get => _SurName;
            set
            {
                _SurName = value;
                OnPropertyChanged(nameof(SurName));
            }
        }

        public string FirstName
        {
            get => _FirstName;
            set
            {
                _FirstName = value;
                OnPropertyChanged(nameof(FirstName));
            }
        }

        public DateTime AddDateTime
        {
            get => _AddDateTime;
            set
            {
                _AddDateTime = value;
                OnPropertyChanged(nameof(AddDateTime));
            }
        }

        public DateTime UpdateDateTime
        {
            get => _UpdateDateTime;
            set
            {
                _UpdateDateTime = value;

                OnPropertyChanged(nameof(UpdateDateTime));
            }
        }
        #endregion
    }
}
