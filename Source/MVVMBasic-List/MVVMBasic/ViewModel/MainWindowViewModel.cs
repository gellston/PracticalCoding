using Microsoft.Toolkit.Mvvm.ComponentModel;
using Microsoft.Toolkit.Mvvm.Input;
using MVVMBasic.Model;
using System;
using System.Collections.Generic;
using System.Collections.ObjectModel;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Input;

namespace MVVMBasic.ViewModel
{
    public class MainWindowViewModel : ObservableObject
    {


        public MainWindowViewModel()
        {


           
        }
        

        private ObservableCollection<Student> _StudentCollection = null;
        public ObservableCollection<Student> StudentCollection
        {
            get
            {
                _StudentCollection ??= new ObservableCollection<Student>();
                return _StudentCollection;
            }
        }


        private Student _SelectedStudent = null;
        public Student SelectedStudent
        {
            set => SetProperty(ref _SelectedStudent, value);
            get => _SelectedStudent;
        }


        public ICommand SelectionChangedCommand
        {
            get => new RelayCommand<object>((items) =>
             {

                 try
                 {
                     var commandArray = (items as ObservableCollection<object>).Cast<Student>().ToList();



                     System.Diagnostics.Debug.WriteLine("test");
                 }
                 catch(Exception ex)
                 {
                     System.Diagnostics.Debug.WriteLine(ex.Message);
                 }
             });
        }


        public ICommand CreateStudentCommand
        {
            get => new RelayCommand(() =>
            {

                var student = new Student()
                {
                    Name = "test",
                    Age = 15
                };

                this.StudentCollection.Add(student);

            });
        }

    }
}
