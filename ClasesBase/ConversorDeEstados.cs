using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Globalization;
using System.Windows.Data;
using System.Windows.Media;
using System.Drawing;

namespace ClasesBase
{
    public class ConversorDeEstados : IValueConverter
    {
        public object Convert(object value, Type targetType, object parameter, CultureInfo culture)
        {
            int duracion = (int)value;

            if (duracion == 0)
            {
                return new SolidColorBrush(Colors.Green);
            }
            else if (duracion > 0 && duracion <= 30)
            {
                return new SolidColorBrush(Colors.LightCoral);
            }
            else if (duracion > 30 && duracion <= 60)
            {
                return new SolidColorBrush(Colors.Coral);
            }
            else
            {
                return new SolidColorBrush(Colors.DarkRed);
            }
        }

        public object ConvertBack(object value, Type targetType, object parameter, CultureInfo culture)
        {
            throw new NotImplementedException();
        }
    }
}
