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

        #region Private Property
        private MaximizeButton maximizeButton;
        #endregion

        #region Static Constructor
        static DarkWindow()
        {
            DefaultStyleKeyProperty.OverrideMetadata(typeof(DarkWindow), new FrameworkPropertyMetadata(typeof(DarkWindow)));
        }

        public DarkWindow()
        {

            this.StateChanged += (s, o) =>
            {
                maximizeButton.IsMaximized = this.WindowState == WindowState.Maximized;
            };
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


        private void Bar_MouseDown(object sender, MouseButtonEventArgs e)
        {
            if(e.LeftButton == MouseButtonState.Pressed)
            {
                this.DragMove();
            }
        }

        private void Bar_PreviewMouseLeftButtonDown(object sender, MouseButtonEventArgs e)
        {
            if (e.ClickCount == 2)
            {
                this.WindowState = this.WindowState != WindowState.Maximized ? WindowState.Maximized : WindowState.Normal;
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
                maximizeButton = maxbtn;
                maxbtn.Click += (s, o) =>
                {
                    
                    this.WindowState = maximizeButton.IsMaximized == false ? WindowState.Maximized : WindowState.Normal;
                };
            }

            if(GetTemplateChild("PART_Bar") is Border bar)
            {
                bar.MouseDown += Bar_MouseDown;
                bar.PreviewMouseLeftButtonDown += Bar_PreviewMouseLeftButtonDown;
            }

            maximizeButton.IsMaximized = this.WindowState == WindowState.Maximized;
        }





        #endregion
    }
}
