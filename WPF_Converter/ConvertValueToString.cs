using System;
using System.Collections.Generic;
using System.Globalization;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Data;

namespace WPF_Converter
{
    public class ConvertValueToString : IValueConverter
    {
        public object Convert(object value, Type targetType, object parameter, CultureInfo culture)
        {
            int number = System.Convert.ToInt32(value);
            string res = "";
            switch (number)
            {
                case 0:
                    res = "zero";
                    break;
                case 1:
                    res = "one";
                    break;
                case 2:
                    res = "two";
                    break;
                case 3:
                    res = "three";
                    break;
                case 4:
                    res = "four";
                    break;
            }
            return res;
       }

        public object ConvertBack(object value, Type targetType, object parameter, CultureInfo culture)
        {
            string str = value.ToString();
            int res =0;
            switch (str)
            {
                case "zero":
                    res = 0;
                    break;
                case "one":
                    res = 1;
                    break;
                case "two":
                    res = 2;
                    break;
                case "three":
                    res = 3;
                    break;
                case "four":
                    res = 4;
                    break;
            }
            return res;
        }
    }
}
