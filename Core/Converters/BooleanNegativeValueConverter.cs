using System;
using MvvmCross.Converters;
using System.Globalization;

namespace Core.Converters
{
	public class BooleanNegativeValueConverter : MvxValueConverter<bool, bool>
    {
        protected override bool Convert(bool value, Type targetType, object parameter, CultureInfo culture)
        {
            return !value;
        }

    }
}

