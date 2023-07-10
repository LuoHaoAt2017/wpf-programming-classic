using System;
using System.Collections.Generic;
using System.Globalization;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Data;

namespace Chapter17ControlTemplate.Converter
{
	public class PriceToBackgroundConverter : IValueConverter
	{
		public object Convert(object value, Type targetType, object parameter, CultureInfo culture)
		{
			decimal valueDecimal = (decimal)value;
			if (valueDecimal < 1500)
			{
				return "red";
			}
			else if(valueDecimal < 4500)
			{
				return "green";
			}
            else
            {
				return "blue";
			}
        }

		public object ConvertBack(object value, Type targetType, object parameter, CultureInfo culture)
		{
			throw new NotImplementedException();
		}
	}
}
