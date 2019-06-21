using System;
using System.Diagnostics;
using System.Globalization;
using CoachAid.Core;

namespace CoachAid
{
    /// <summary>
    /// Converts a boolean value to height
    /// </summary>
    public class BooleanToHeightConverter : BaseValueConverter<BooleanToHeightConverter>
    {
        public override object Convert(object value, Type targetType, object parameter, CultureInfo culture)
        {
            switch ((bool)value)
            {
                case false:
                    return 0;

                case true:
                    return "Auto";

                default:
                    return null;

            }

        }

        public override object ConvertBack(object value, Type targetType, object parameter, CultureInfo culture)
        {
            throw new NotImplementedException();
        }
    }
}
