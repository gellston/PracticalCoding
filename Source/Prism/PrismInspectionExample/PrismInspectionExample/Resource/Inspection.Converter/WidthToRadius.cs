using System;
using System.Globalization;
using System.Windows.Data;

namespace Inspection.Converter
{
    public class WidthToRadius : IValueConverter
    {
        public object Convert(object value, Type targetType, object parameter, CultureInfo culture)
        {
            var width = (double)value;

            return width / 2;
        }

        public object ConvertBack(object value, Type targetType, object parameter, CultureInfo culture)
        {
            throw new NotImplementedException();
        }
    }
}
