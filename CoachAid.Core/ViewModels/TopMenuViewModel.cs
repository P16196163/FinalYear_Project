using System.Threading.Tasks;
using System.Windows.Input;

namespace CoachAid.Core
{
    /// <summary>
    /// The view model for the top menu
    /// </summary>
    public class TopMenuViewModel : BaseViewModel
    {
        #region Singleton

        public static TopMenuViewModel Instance => new TopMenuViewModel();

        #endregion


        #region commands

        public ICommand DBHomeCommand { get; set; }
        public ICommand DBPlayersCommand { get; set; }
        public ICommand DBStatsCommand { get; set; }
        public ICommand DBSelectionCommand { get; set; }

        #endregion

        #region Constructor

        public TopMenuViewModel()
        {
            // Create Commands

            DBHomeCommand = new RelayCommand(async () => await DBHome());
            DBPlayersCommand = new RelayCommand(async () => await DBPlayers());
            DBStatsCommand = new RelayCommand(async () => await DBStats());
            DBSelectionCommand = new RelayCommand(async () => await DBSelection());

        }

        public async Task DBPlayers()
        {
            if (IoC.Get<ApplicationViewModel>().SideMenuVisible != true)
                IoC.Get<ApplicationViewModel>().SideMenuVisible = true;

            IoC.Get<ApplicationViewModel>().CurrentPage = ApplicationPage.DBPLayers;

            await Task.Delay(2000);
        }

        public async Task DBStats()
        {
            if (IoC.Get<ApplicationViewModel>().SideMenuVisible != true)
                IoC.Get<ApplicationViewModel>().SideMenuVisible = true;

            IoC.Get<ApplicationViewModel>().CurrentPage = ApplicationPage.DBStats;

            await Task.Delay(2000);
        }

        public async Task DBHome()
        {
            if (IoC.Get<ApplicationViewModel>().SideMenuVisible != true)
                IoC.Get<ApplicationViewModel>().SideMenuVisible = true;

            IoC.Get<ApplicationViewModel>().CurrentPage = ApplicationPage.DBHome;

            await Task.Delay(2000);
        }

        public async Task DBSelection()
        {
            if (IoC.Get<ApplicationViewModel>().SideMenuVisible != true)
                IoC.Get<ApplicationViewModel>().SideMenuVisible = true;

            IoC.Get<ApplicationViewModel>().CurrentPage = ApplicationPage.DBSelection;

            await Task.Delay(2000);
        }

        #endregion

    }
}
