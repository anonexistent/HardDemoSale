using DemoSale.Data;
using DemoSale.DataBaseCore;
using System;
using System.Collections.Generic;
using System.Globalization;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Data;

namespace DemoSale
{
    public class TechnicalMaintenanceConverter : IValueConverter
    {
        public object Convert(object value, Type targetType, object parameter, CultureInfo culture)
        {
            var temp = (WarrantyRecord)value;
            if (!string.IsNullOrEmpty(temp.warContract.engTecWorker))
            {
                return temp.warContract.technicalMaintenance.ToString();
            }
            else
            {
                return "Новый!";
            }
        }

        public object ConvertBack(object value, Type targetType, object parameter, CultureInfo culture)
        {
            throw new NotImplementedException();
        }
    }
}
