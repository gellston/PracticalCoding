using System;
using System.Collections.Generic;
using System.Collections.ObjectModel;
using System.ComponentModel;
using System.Diagnostics.Metrics;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Data;
using System.Windows.Documents;
using System.Windows.Input;
using System.Windows.Markup;

namespace WPFBindingExample
{
    public class BindingObject : INotifyPropertyChanged
    {

        #region Private Property
        public event PropertyChangedEventHandler? PropertyChanged;
        private string _Temp = "";
        private ListCollectionView _ListBoxItemCollection = null;
        private ListCollectionView _ListViewItemCollection = null;
        private ListCollectionView _GridViewItemCollection = null;

        #endregion

        #region Constructor
        public BindingObject()
        {

            var people = new List<Person>();
            people.Add(new Person()
            {
                Name = "BongHoe Koo",
                Age = 33
            });
            people.Add(new Person()
            {
                Name = "BongHoe Koo",
                Age = 33
            });
            people.Add(new Person()
            {
                Name = "BongHoe Koo",
                Age = 33
            });

            this.ListViewItemCollection = new ListCollectionView(people);
            this.ListBoxItemCollection = new ListCollectionView(people);
            this.GridViewItemCollection = new ListCollectionView(people);


        }
        #endregion

        #region Public Property
        public string Temp
        {
            get => _Temp;
            set
            {
                _Temp = value;
                OnPropertyChanged(nameof(Temp));
            }
        }
        #endregion

        #region Functions
        public void OnPropertyChanged(string propertyName)
        {
            if (PropertyChanged != null)
                PropertyChanged(this, new PropertyChangedEventArgs(propertyName));
        }
        #endregion

        #region Collection
        public ListCollectionView ListBoxItemCollection
        {
            get => _ListBoxItemCollection;
            set
            {
                _ListBoxItemCollection = value;
                OnPropertyChanged(nameof(ListBoxItemCollection));
            }
        }

        public ListCollectionView ListViewItemCollection
        {
            get => _ListViewItemCollection;
            set
            {
                _ListViewItemCollection = value;
                OnPropertyChanged(nameof(ListViewItemCollection));
            }
        }


        public ListCollectionView GridViewItemCollection
        {
            get => _GridViewItemCollection;
            set
            {
                _GridViewItemCollection = value;
                OnPropertyChanged(nameof(GridViewItemCollection));
            }
        }


        #endregion

        #region Command

        public ICommand TestCommand
        {
            get => new RelayCommand((arg) =>
            {
                var view = CollectionViewSource.GetDefaultView(this.ListViewItemCollection) as ListCollectionView;
                view.MoveCurrentToFirst();
                if (view != null)
                {
                    while (view.CurrentPosition != view.Count)
                    {
                        var person = view.CurrentItem as Person;
                        person.Name = "Steve!";
                        view.MoveCurrentToNext();
                    }
                }
            });
        }
        #endregion





    }
}
