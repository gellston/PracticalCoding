using System.Text;
using System.Windows;
using System.Windows.Controls;
using System.Windows.Data;
using System.Windows.Documents;
using System.Windows.Input;
using System.Windows.Media;
using System.Windows.Media.Imaging;
using System.Windows.Navigation;
using System.Windows.Shapes;

namespace PrismExplorer.Resource.Control
{

    #region Enum
    public enum IconType
    {
        None,
        Close,
        Maximize,
        Minimize
    }
    #endregion


    public class KooIcon : ContentControl
    {

        #region Dependency Property
        public static DependencyProperty IconProperty = DependencyProperty.Register("Icon", typeof(IconType), typeof(KooIcon), new PropertyMetadata(IconType.None, IconPropertyChanged));
        public static DependencyProperty DataProperty = DependencyProperty.Register("Data", typeof(Geometry), typeof(KooIcon), new PropertyMetadata(null));
        public static DependencyProperty FillProperty = DependencyProperty.Register("Fill", typeof(Brush), typeof(KooIcon), new PropertyMetadata(Brushes.Black));
        #endregion


        #region Property
        public IconType Icon
        {
            get => (IconType)GetValue(IconProperty);
            set => SetValue(IconProperty, value);
        }


        public Geometry Data
        {
            get => (Geometry)GetValue(DataProperty);
            set => SetValue(DataProperty, value);   
        }

        public Brush Fill
        {
            get => (Brush)GetValue(FillProperty);   
            set => SetValue(FillProperty, value);   
        }

        #endregion

        #region Event Handler
        private static void IconPropertyChanged(DependencyObject d, DependencyPropertyChangedEventArgs e)
        {
            KooIcon bongIcon = (KooIcon)d;
            string geometryData = Design.Geometies.GeometryConverter.GetData(bongIcon.Icon.ToString());

            bongIcon.Data = Geometry.Parse(geometryData);
          
        }
        #endregion


        #region Function
        public override void OnApplyTemplate()
        {
            base.OnApplyTemplate();
        }
        #endregion

        #region Static Constructor
        static KooIcon()
        {
            DefaultStyleKeyProperty.OverrideMetadata(typeof(KooIcon), new FrameworkPropertyMetadata(typeof(KooIcon)));
        }
        #endregion
    }
}