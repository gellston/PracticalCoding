using System;
using System.Collections.Generic;
using System.Collections.ObjectModel;
using System.Linq;
using System.Security.Policy;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Input;
using WPFUserManagementExample.Util;

namespace WPFUserManagementExample.ViewModel
{
    public class MainWindowViewModel : ViewModelBase
    {
        #region Private Property
        private DateTime _CurrentAddDateTime = DateTime.Now;
        private DateTime _CurrentUpdateDateTime = DateTime.Now;

        private string _CurrentSurName = "";
        private string _CurrentFirstName = "";

        private ObservableCollection<UserViewModel> _UserViewModelCollection = new ObservableCollection<UserViewModel>();
        private UserViewModel _CurrentUserViewModel = null;
        #endregion

        #region Constrcutor
        public MainWindowViewModel() { 
        
        }
        #endregion


        #region Public Property
        public string CurrentSurName
        {
            get => _CurrentSurName;
            set
            {
                _CurrentSurName = value;
                OnPropertyChanged(nameof(CurrentSurName));
            }
        }

        public string CurrentFirstName
        {
            get => _CurrentFirstName;
            set
            {
                _CurrentFirstName = value;
                OnPropertyChanged(nameof(CurrentFirstName));
            }
        }

        public DateTime CurrentAddDateTime
        {
            get => _CurrentAddDateTime;
            set
            {
                _CurrentAddDateTime= value;
                OnPropertyChanged(nameof(CurrentAddDateTime));
            }
        }

        public DateTime CurrentUpdateDateTime
        {
            get => _CurrentUpdateDateTime;
            set
            {
                _CurrentUpdateDateTime = value;

                OnPropertyChanged(nameof(CurrentUpdateDateTime));
            }
        }

        public UserViewModel CurrentUserViewModel
        {
            get => _CurrentUserViewModel;
            set
            {
                _CurrentUserViewModel = value;
                OnPropertyChanged(nameof(CurrentUserViewModel));
                
                if(_CurrentUserViewModel != null)
                {
                    this.CurrentSurName = _CurrentUserViewModel.SurName;
                    this.CurrentFirstName = _CurrentUserViewModel.FirstName;
                    this.CurrentAddDateTime = _CurrentUserViewModel.AddDateTime;
                    this.CurrentUpdateDateTime = _CurrentUserViewModel.UpdateDateTime;
                }

            }
        }
        #endregion


        #region Collection
        public ObservableCollection<UserViewModel> UserViewModelCollection
        {
            get => _UserViewModelCollection;
            set
            {
                _UserViewModelCollection = value;
                OnPropertyChanged(nameof(UserViewModelCollection));
            }
        }
        #endregion


        #region Command
        public ICommand AddUserCommand
        {
            get => new RelayCommand((args) =>
            {
                try
                {

                    this.UserViewModelCollection.Add(new UserViewModel()
                    {
                        SurName = "",
                        FirstName = ""
                    });

                }catch(Exception ex)
                {
                    System.Diagnostics.Debug.WriteLine(ex.ToString());
                }

            });
        }


        public ICommand ModifyUserCommand
        {
            get => new RelayCommand((args) =>
            {
                if (this.CurrentUserViewModel == null)
                    return;

                this.CurrentUserViewModel.SurName = this.CurrentSurName;
                this.CurrentUserViewModel.FirstName = this.CurrentFirstName;
                this.CurrentUserViewModel.UpdateDateTime = DateTime.Now;
            });
        }

        public ICommand RemoveUserCommand
        {
            get => new RelayCommand((args) =>
            {
                if (this.CurrentUserViewModel == null)
                    return;

                this.UserViewModelCollection.Remove(this.CurrentUserViewModel);
            });
        }

        #endregion
    }
}
