using System;
using System.Collections.Generic;
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
using WPFDataTemplateExample.Model;

namespace WPFDataTemplateExample
{
    /// <summary>
    /// Interaction logic for MainWindow.xaml
    /// </summary>
    public partial class MainWindow : Window
    {
        public MainWindow()
        {

           
            InitializeComponent();

        }

        private bool _toggle = false;
        private void tesetButton_Click(object sender, RoutedEventArgs e)
        {

            _toggle = !_toggle;

            if (_toggle)
            {
                this.contentPresenter.Content = new Student()
                {
                    Name = "BongHoe Koko",
                    Age = 25
                };
            }
            else
            {
                this.contentPresenter.Content = new Teacher()
                {
                    Name = "BongHoe Koko",
                    Age = 25,
                    ClassName = "Math"
                };

            }
            

        }
    }
}
