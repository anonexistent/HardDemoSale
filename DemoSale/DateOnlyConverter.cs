using System;
using System.Globalization;
using System.Windows.Data;

namespace DemoSale
{
    public class DateOnlyConverter : IValueConverter
    {
        public object Convert(object value, Type targetType, object parameter, CultureInfo culture)
        {
            if (value is DateOnly dateOnly)
            {
                return dateOnly.ToDateTime(TimeOnly.MinValue); // Преобразуем DateOnly в DateTime
            }
            return null;
        }

        public object ConvertBack(object value, Type targetType, object parameter, CultureInfo culture)
        {
            if (value is DateTime dateTime)
            {
                return DateOnly.FromDateTime(dateTime); // Преобразуем DateTime в DateOnly
            }
            return null;
        }
    }
}
