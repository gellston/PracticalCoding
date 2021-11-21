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

namespace CustomHamburgerMenu.UC
{
    /// <summary>
    /// HamburgerMenu.xaml에 대한 상호 작용 논리
    /// </summary>
    public partial class HamburgerMenu : UserControl
    {
        public HamburgerMenu()
        {
            InitializeComponent();

        }


        public static readonly DependencyProperty MainContentProperty = DependencyProperty.Register("MainContent", typeof(object), typeof(HamburgerMenu));
        public object MainContent
        {
            get
            {
                return (object)GetValue(MainContentProperty);
            }

            set
            {
                SetValue(MainContentProperty, value);
            }
        }

        public static readonly DependencyProperty LeftContentProperty = DependencyProperty.Register("LeftContent", typeof(object), typeof(HamburgerMenu));
        public object LeftContent
        {
            get
            {
                return (object)GetValue(LeftContentProperty);
            }

            set
            {
                SetValue(LeftContentProperty, value);
            }
        }


        public static readonly DependencyProperty IsMenuOpenProperty = DependencyProperty.Register("IsMenuOpen", typeof(bool), typeof(HamburgerMenu));
        public bool IsMenuOpen
        {
            get
            {
                return (bool)GetValue(IsMenuOpenProperty);
            }

            set
            {
                SetValue(IsMenuOpenProperty, value);
            }
        }


        public static readonly DependencyProperty MenuWidthProperty = DependencyProperty.Register("MenuWidth", typeof(double), typeof(HamburgerMenu), new PropertyMetadata(0.0));
        public double MenuWidth
        {
            get
            {
                return (double)GetValue(MenuWidthProperty);
            }

            set
            {
                SetValue(MenuWidthProperty, value);
            }
        }


       
    }
}
