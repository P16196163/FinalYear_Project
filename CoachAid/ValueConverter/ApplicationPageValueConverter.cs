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
            //Find appropriate page
            switch ((ApplicationPage)value)
            {
                case ApplicationPage.Welcome:
                    return new WelcomePage();

                case ApplicationPage.Options:
                    return new OptionsPage();

                case ApplicationPage.DBHome:
                    return new DBHomePage();

                case ApplicationPage.DBPLayers:
                    return new DBPlayersPage();

                case ApplicationPage.DBStats:
                    return new DBTeamStatsPage();

                case ApplicationPage.DBSelection:
                    return new DBSelectionPage();

                case ApplicationPage.Player:
                    return new PlayerPage();

                case ApplicationPage.Match:
                    return new NewMatchPage();

                case ApplicationPage.PreviousMatch:
                    return null;

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
