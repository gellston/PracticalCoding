using System;
using System.Collections.Generic;
using System.Collections.ObjectModel;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows;
using System.Windows.Controls;
using System.Windows.Data;
using System.Windows.Documents;
using System.Windows.Input;
using System.Windows.Media;
using System.Windows.Media.Imaging;
using System.Windows.Navigation;
using System.Windows.Shapes;
using WPFPropertyTriggerExample.Model;

namespace WPFPropertyTriggerExample
{
    /// <summary>
    /// Interaction logic for MainWindow.xaml
    /// </summary>
    public partial class MainWindow : Window
    {
        public MainWindow()
        {



            this.PersonCollection.Add(new Student()
            {
                Name = "BongHoe Koo",
                Score = 90 ,
                Bad = true
            });

            this.PersonCollection.Add(new Student()
            {
                Name = "SungKun",
                Score = 90,
                Bad = false
            });


            this.PersonCollection.Add(new Teacher()
            {
                Name = "BongHoe Koo",
                ClassName = "Math",
               
            });


            this.PersonCollection.Add(new Teacher()
            {
                Name = "BongHoe Koo",
                ClassName = "Music"
            });



            InitializeComponent();

        }


        private ObservableCollection<Person> _PersonCollection = null;
        public ObservableCollection<Person> PersonCollection
        {
            get
            {
                _PersonCollection ??= new ObservableCollection<Person>();
                return _PersonCollection;
            }
        }

        private void Button_Click(object sender, RoutedEventArgs e)
        {

            var student = this.PersonCollection[0] as Student;
            student.Bad = !student.Bad;
        }
    }
}
