using System;
using System.Collections.Generic;
using System.Globalization;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Data;

namespace DataConverters
{
    class OpenConverter : IMultiValueConverter
    {
        public object Convert(object[] values, Type targetType, object parameter, CultureInfo culture)
        {
            int ClassSize = int.Parse(string.Format("{0}", values[0]));
            int NumEnrolled = int.Parse(string.Format("{0}", values[0]));
            if (ClassSize - NumEnrolled > 0)
            {
                return "True";
            }
            else
                return "False";
        }

        public object[] ConvertBack(object value, Type[] targetTypes, object parameter, CultureInfo culture)
        {
            throw new NotImplementedException();
        }
    }
}
