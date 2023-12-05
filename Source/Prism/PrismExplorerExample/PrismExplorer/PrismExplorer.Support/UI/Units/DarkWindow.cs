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

        public static DependencyProperty CloseCommandProperty = DependencyProperty.Register("CloseCommand", typeof(ICommand), typeof(DarkWindow), new PropertyMetadata(null));
        #endregion

        #region Property
        public ICommand CloseCommand
        {
            get => (ICommand)GetValue(CloseCommandProperty);
            set => SetValue(CloseCommandProperty, value);
        }

        #endregion


        #region Private Function
        private void WindowClose()
        {
            if(this.CloseCommand == null)
            {
                this.Close();
            }
            else
            {
                this.CloseCommand.Execute(this);
            }
            
        }
        #endregion

        #region Event Handler
        public override void OnApplyTemplate()
        {
            if(GetTemplateChild("PART_CloseButton") is CloseButton btn)
            {
                btn.Click += (s, o) =>
                {
                    this.WindowClose();
                };
            }

            if(GetTemplateChild("PART_MinButton") is MinimizeButton minbtn)
            {
                minbtn.Click += (s, o) =>
                {

                    this.WindowState = WindowState.Minimized;
                };
            }

            if(GetTemplateChild("PART_MaxButton") is MaximizeButton maxbtn)
            {
                maxbtn.Click += (s, o) =>
                {
                    this.WindowState = this.WindowState != WindowState.Maximized ? WindowState.Maximized : WindowState.Normal;
                };
            }
        }
        #endregion
    }
}
