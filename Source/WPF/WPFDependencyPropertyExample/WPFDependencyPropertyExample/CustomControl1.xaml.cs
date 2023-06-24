using System;
using System.Collections.Generic;
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

namespace WPFDependencyPropertyExample
{
    /// <summary>
    /// CustomControl1.xaml에 대한 상호 작용 논리
    /// </summary>
    public partial class CustomControl1 : UserControl
    {
        public CustomControl1()
        {
            InitializeComponent();
        }


        public static readonly DependencyProperty HeadLineProperty = DependencyProperty.Register("HeadLine", typeof(string), typeof(CustomControl1), new PropertyMetadata("test", OnHeadLineChanged));
        private static void OnHeadLineChanged(DependencyObject o, DependencyPropertyChangedEventArgs e){
            try
            {
 
                System.Diagnostics.Debug.WriteLine("value = " + e.NewValue);
               
            }catch(Exception ex)
            {
                System.Diagnostics.Debug.WriteLine(ex.ToString());  
            }
        }

        public string HeadLine
        {
            get
            {
                return (string)GetValue(HeadLineProperty);
            }
            set
            {
                SetValue(HeadLineProperty, value);
            }
        }
    }
}
