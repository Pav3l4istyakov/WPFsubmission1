using System;
using System.Collections.Generic;
using System.Globalization;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Data;

namespace WPFsubmission1
{
    public class DateToColorConverter : IValueConverter
    {
        public object Convert(object value, Type targetType, object parameter, CultureInfo culture)
        {
            if (value is DateTime date)
            {
                DateTime today = DateTime.Today;
                switch (parameter as string)
                {
                    case "Past":
                        return date < today;
                    case "Today":
                        return date == today;
                    case "Tomorrow":
                        return date == today.AddDays(1);
                    case "Future":
                        return date > today.AddDays(1);
                    default:
                        return false;
                }
            }
            return false;
        }

        public object ConvertBack(object value, Type targetType, object parameter, CultureInfo culture)
        {
            throw new NotImplementedException();
        }
    }
}