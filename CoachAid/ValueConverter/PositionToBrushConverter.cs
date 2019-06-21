using System;
using System.Diagnostics;
using System.Globalization;
using System.Windows.Media;
using CoachAid.Core;

namespace CoachAid
{
    /// <summary>
    /// Converts the <see cref="Position"/> to actual background colour
    /// </summary>
    public class PositionToBrushConverter : BaseValueConverter<PositionToBrushConverter>
    {
        public override object Convert(object value, Type targetType, object parameter, CultureInfo culture)
        {
            // Set colour based on position groups
            switch ((Position)value)
            {
                // Front Row
                case Position.Prop:
                    return (SolidColorBrush)(new BrushConverter().ConvertFrom("#e595de"));
                case Position.Hooker:
                    return (SolidColorBrush)(new BrushConverter().ConvertFrom("#e595de"));
                
                // Second Row
                case Position.Lock:
                    return (SolidColorBrush)(new BrushConverter().ConvertFrom("#f79240"));

                // Back Row
                case Position.Flanker:
                    return (SolidColorBrush)(new BrushConverter().ConvertFrom("#f23737"));
                case Position.NumberEight:
                    return (SolidColorBrush)(new BrushConverter().ConvertFrom("#f23737"));

                // Half Backs
                case Position.ScrumHalf:
                    return (SolidColorBrush)(new BrushConverter().ConvertFrom("#c04cff"));
                case Position.FlyHalf:
                    return (SolidColorBrush)(new BrushConverter().ConvertFrom("#c04cff"));

                // Inside Backs
                case Position.Centre:
                    return (SolidColorBrush)(new BrushConverter().ConvertFrom("#5bebff"));
 
                // Back Three
                case Position.Wing:
                    return (SolidColorBrush)(new BrushConverter().ConvertFrom("#5bff5d"));
                case Position.FullBack:
                    return (SolidColorBrush)(new BrushConverter().ConvertFrom("#5bff5d"));

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
