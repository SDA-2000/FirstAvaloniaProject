using Avalonia.Data.Converters;
using System;

namespace GetStartedApp.Converters;

public class ToggleButtonIconConverter : IValueConverter
{
    public object Convert(object value, Type targetType, object parameter, System.Globalization.CultureInfo culture)
    {
        if (value is bool isOpen && isOpen)
        {
            return "M31.726,14.915c-0.602-0.089-1.237,0.09-1.703,0.552L0.592,44.677c-0.785,0.776-0.789,2.044-0.011,2.827 c0.364,0.367,0.834,0.563,1.312,0.589c0.545,0.028,1.098-0.164,1.515-0.579l28.3-28.085L59.796,47.73 c0.364,0.367,0.835,0.563,1.312,0.589c0.544,0.029,1.098-0.164,1.516-0.578c0.784-0.777,0.789-2.045,0.011-2.827L33.425,15.48 C32.962,15.014,32.329,14.829,31.726,14.915z";
        }
        else
        {
            return "m121.3,34.6c-1.6-1.6-4.2-1.6-5.8,0l-51,51.1-51.1-51.1c-1.6-1.6-4.2-1.6-5.8,0-1.6,1.6-1.6,4.2 0,5.8l53.9,53.9c0.8,0.8 1.8,1.2 2.9,1.2 1,0 2.1-0.4 2.9-1.2l53.9-53.9c1.7-1.6 1.7-4.2 0.1-5.8z";
        }
    }

    public object ConvertBack(object value, Type targetType, object parameter, System.Globalization.CultureInfo culture)
    {
        throw new NotImplementedException();
    }
}