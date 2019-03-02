using System;
using System.Diagnostics;
using System.Globalization;
using CoachAid.Core;

namespace CoachAid
{
    /// <summary>
    /// Converts the <see cref="ApplicationPage"/> to actual view/page
    /// </summary>
    public class ApplicationPageValueConverter : BaseValueConverter<ApplicationPageValueConverter>
    {
        public override object Convert(object value, Type targetType, object parameter, CultureInfo culture)
        {
            //FInd appropriate page
            switch ((ApplicationPage)value)
            {
                case ApplicationPage.Welcome:
                    return new WelcomePage();

                case ApplicationPage.Options:
                    return new OptionsPage();

                case ApplicationPage.DBHome:
                    return new DBHomePage();

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
