using PrismExplorer.Support.UI.Units;
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

namespace PrismExplorer.Views
{
    
    public class ExplorerWindowView : DarkWindow
    {
        #region Static Constructor
        static ExplorerWindowView()
        {
            DefaultStyleKeyProperty.OverrideMetadata(typeof(ExplorerWindowView), new FrameworkPropertyMetadata(typeof(ExplorerWindowView)));
        }
        #endregion
    }
}
