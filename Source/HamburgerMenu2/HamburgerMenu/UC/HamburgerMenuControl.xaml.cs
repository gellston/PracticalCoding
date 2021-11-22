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

namespace HamburgerMenu.UC
{
    /// <summary>
    /// HamburgerMenu.xaml에 대한 상호 작용 논리
    /// </summary>
    public partial class HamburgerMenuControl : UserControl
    {
        public HamburgerMenuControl()
        {

            InitializeComponent();
        }



        public static readonly DependencyProperty IsMenuOpenProperty = DependencyProperty.Register("IsMenuOpen", typeof(bool), typeof(HamburgerMenuControl),  new PropertyMetadata(false));
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



        public static readonly DependencyProperty MenuContentProperty = DependencyProperty.Register("MenuContent", typeof(object), typeof(HamburgerMenuControl));
        public object MenuContent
        {
            get
            {
                return (object)GetValue(MenuContentProperty);
            }

            set
            {
                SetValue(MenuContentProperty, value);
            }
        }

        public static readonly DependencyProperty MenuNameProperty = DependencyProperty.Register("MenuName", typeof(string), typeof(HamburgerMenuControl));
        public string MenuName
        {
            get
            {
                return (string)GetValue(MenuContentProperty);
            }

            set
            {
                SetValue(MenuContentProperty, value);
            }
        }

        private void OpenButton_Click(object sender, RoutedEventArgs e)
        {

            this.IsMenuOpen = !this.IsMenuOpen;

        }
    }
}
