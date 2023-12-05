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

    public class DarkWindow : Window
    {
        #region Static Constructor
        static DarkWindow()
        {
            DefaultStyleKeyProperty.OverrideMetadata(typeof(DarkWindow), new FrameworkPropertyMetadata(typeof(DarkWindow)));
        }
        #endregion

        #region Dependency Property

        #endregion


        #region Private Function
        private void WindowClose()
        {
            
        }
        #endregion

        public override void OnApplyTemplate()
        {
            if(GetTemplateChild("PART_CloseButton") is CloseButton btn)
            {
                btn.Click += (s, o) =>
                {
                   
                }
            }
        }
    }
}
