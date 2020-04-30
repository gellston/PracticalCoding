using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Linq;
using System.Runtime.CompilerServices;
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

namespace PracticalCoding2
{
    /// <summary>
    /// Interaction logic for MainWindow.xaml
    /// </summary>
    public partial class MainWindow : Window, INotifyPropertyChanged
    {


        public event PropertyChangedEventHandler PropertyChanged;
        protected void NotifyPropertyChanged([CallerMemberName] string name = null)
        {
            var handler = PropertyChanged;
            if (handler != null)
            {
                handler(this, new PropertyChangedEventArgs(name));
            }
        }



        public MainWindow()
        {
            InitializeComponent();
            this.DataContext = this;


            this.TestString = "test!!!!!";
        }



        private string _TestString = "";
        public string TestString
        {
            get
            {
                return _TestString;
            }

            set
            {
                _TestString = value;
                NotifyPropertyChanged("TestString");
            }
        }


        private bool _IsChecked = false;
        public bool IsChecked
        {
            get
            {
                return _IsChecked;
            }

            set
            {
                _IsChecked = value;
                NotifyPropertyChanged("IsChecked");
            }
        }

        private int _CurrentProgressValue = 0;
        public int CurrentProgressValue
        {
            get
            {
                return _CurrentProgressValue;
            }

            set
            {
                _CurrentProgressValue = value;
                NotifyPropertyChanged("CurrentProgressValue");
            }
        }

        private void Button_Click(object sender, RoutedEventArgs e)
        {
            this.TestString = "test??????";
            this.CurrentProgressValue = 50;

        }
    }
}
