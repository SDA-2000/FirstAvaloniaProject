using Avalonia.Data.Converters;
using System;
using Avalonia.Media;

namespace GetStartedApp.Converters;

public class ToggleButtonConverter : IValueConverter
{
    public object Convert(object value, Type targetType, object parameter, System.Globalization.CultureInfo culture)
    {
        if (value is bool isOpen && isOpen)
        {
            return "M0,0 L10,10 L20,0 Z";
        }
        else
        {
            return "M0,10 L10,0 L20,10 Z";
        }
    }

    public object ConvertBack(object value, Type targetType, object parameter, System.Globalization.CultureInfo culture)
    {
        throw new NotImplementedException();
    }
}