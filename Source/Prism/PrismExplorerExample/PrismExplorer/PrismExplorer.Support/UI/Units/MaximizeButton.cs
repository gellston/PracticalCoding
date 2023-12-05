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

namespace PrismExplorer.Support.UI.Units
{
    
    public class MaximizeButton : Button
    {

        #region Dependency Property
        public static DependencyProperty IsMaximizedProperty = DependencyProperty.Register("IsMaximized", typeof(bool), typeof(MaximizeButton), new PropertyMetadata(false));
        #endregion

        #region Property
        public bool IsMaximized
        {
            get => (bool)GetValue(IsMaximizedProperty);
            set=> SetValue(IsMaximizedProperty, value);
        }
        #endregion

        #region Static Constructor
        static MaximizeButton()
        {
            DefaultStyleKeyProperty.OverrideMetadata(typeof(MaximizeButton), new FrameworkPropertyMetadata(typeof(MaximizeButton)));
        }
        #endregion
    }
}
