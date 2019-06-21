using CoachAid.Core;

namespace CoachAid
{
    /// <summary>
    /// Interaction logic for DBPlayersPage.xaml
    /// </summary>
    public partial class DBPlayersPage : BasePage<DBPlayersViewModel>
    {
        public DBPlayersPage()
        {
            InitializeComponent();
        }

        private void AddPlayer_Click(object sender, System.Windows.RoutedEventArgs e)
        {
            AddPlayerWindow addPlayerWindow = new AddPlayerWindow();

            addPlayerWindow.Show();
        }
    }
}
