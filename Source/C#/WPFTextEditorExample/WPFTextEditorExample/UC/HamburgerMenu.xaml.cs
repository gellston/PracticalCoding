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

namespace WPFTextEditorExample.UC
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

        public static readonly DependencyProperty IsOpenProperty = DependencyProperty.Register("IsOpen", typeof(bool), typeof(HamburgerMenu), new PropertyMetadata(false));
        public bool IsOpen
        {
            get => (bool)GetValue(IsOpenProperty);
            set => SetValue(IsOpenProperty, value);
        }





        public static readonly DependencyProperty LeftMenuContentProperty = DependencyProperty.Register("LeftMenuContent", typeof(object), typeof(HamburgerMenu));
        public object LeftMenuContent
        {
            get => (object)GetValue(LeftMenuContentProperty);
            set => SetValue(LeftMenuContentProperty, value);
        }


        public static readonly DependencyProperty MainContentProperty = DependencyProperty.Register("MainContent", typeof(object), typeof(HamburgerMenu));
        public object MainContent
        {
            get => (object)GetValue(MainContentProperty);
            set => SetValue(MainContentProperty, value);
        }

    }
}
