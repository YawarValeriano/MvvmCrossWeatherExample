using System;
using MvvmCross.Converters;
using System.Globalization;

namespace Core.Converters
{
	public class StringUrlValueConverter : MvxValueConverter<string, string>
    {
        protected override string Convert(string value, Type targetType, object parameter, CultureInfo culture)
        {
            return $"https://openweathermap.org/img/wn/{value}@4x.png";
        }

    }
}

