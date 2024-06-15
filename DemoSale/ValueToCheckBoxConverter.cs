using System;
using System.Globalization;
using System.Windows.Data;

namespace DemoSale
{
    public class ValueToCheckBoxConverter : IValueConverter
    {

        public object Convert(object value, Type targetType, object parameter, CultureInfo culture)
        {
            int howMuch = (int)value;
            int checkBoxValue = System.Convert.ToInt32(parameter);

            return howMuch >= checkBoxValue;
        }

        public object ConvertBack(object value, Type targetType, object parameter, CultureInfo culture)
        {
            return new object();
        }
    }
}
