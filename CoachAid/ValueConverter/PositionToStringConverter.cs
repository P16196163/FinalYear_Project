using System;
using System.Diagnostics;
using System.Globalization;
using System.Windows.Media;
using CoachAid.Core;

namespace CoachAid
{
    /// <summary>
    /// Converts the <see cref="Position"/> to a string reflecting the position
    /// </summary>
    public class PositionToStringConverter : BaseValueConverter<PositionToStringConverter>
    {
        public override object Convert(object value, Type targetType, object parameter, CultureInfo culture)
        {
            // Set colour based on position groups
            switch ((Position)value)
            {
                // Front Row
                case Position.Prop:
                    return "Prop";
                case Position.Hooker:
                    return "Hooker";
                
                // Second Row
                case Position.Lock:
                    return "Lock";

                // Back Row
                case Position.Flanker:
                    return "Flanker";
                case Position.NumberEight:
                    return "No. 8";

                // Half Backs
                case Position.ScrumHalf:
                    return "Scrum Half";
                case Position.FlyHalf:
                    return "Fly Half";

                // Inside Backs
                case Position.Centre:
                    return "Centre";
 
                // Back Three
                case Position.Wing:
                    return "Wing";
                case Position.FullBack:
                    return "Fullback";

                default:
                    Debugger.Break();
                    return null;

            }

        }

        public override object ConvertBack(object value, Type targetType, object parameter, CultureInfo culture)
        {
            throw new NotImplementedException();
        }
    }
}
