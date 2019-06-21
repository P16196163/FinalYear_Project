using CoachAid.Core;

namespace CoachAid
{
    /// <summary>
    /// Interaction logic for WelcomePage.xaml
    /// </summary>
    public partial class WelcomePage : BasePage<WelcomePageViewModel>
    {
        public WelcomePage()
        {
            InitializeComponent();
        }

        private void NewDB_Click(object sender, System.Windows.RoutedEventArgs e)
        {
            NewTeamWindow NewTeam = new NewTeamWindow();

            NewTeam.Show();
        }
    }
}
