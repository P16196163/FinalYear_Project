using System.Threading.Tasks;
using System.Windows;
using System.Windows.Controls.Primitives;
using System.Windows.Input;

namespace CoachAid.Core
{
    /// <summary>
    /// The view model for the top menu
    /// </summary>
    public class SideMenuViewModel : BaseViewModel
    {
        #region Singleton

        public static SideMenuViewModel Instance => new SideMenuViewModel();

        #endregion


        #region commands

        public ICommand ExitHomeCommand { get; set; }
        public ICommand NewMatchCommand{ get; set; }
        public ICommand PreviousMatchesCommand { get; set; }
        public ICommand DBSelectionCommand { get; set; }

        #endregion

        #region Constructor

        public SideMenuViewModel()
        {
            // Create Commands

            ExitHomeCommand = new RelayCommand(async () => await ExitHome());
            NewMatchCommand = new RelayCommand(async () => await NewMatch());
            PreviousMatchesCommand = new RelayCommand(async () => await PreviousMatches());
            DBSelectionCommand = new RelayCommand(async () => await DBSelection());

        }

        public async Task NewMatch()
        {
            if (IoC.Get<ApplicationViewModel>().SideMenuVisible != false)
                IoC.Get<ApplicationViewModel>().SideMenuVisible = false;

            if (IoC.Get<ApplicationViewModel>().TopMenuVisible != false)
                IoC.Get<ApplicationViewModel>().TopMenuVisible = false;

            IoC.Get<ApplicationViewModel>().CurrentPage = ApplicationPage.Match;

            await Task.Delay(2000);
        }

        public async Task PreviousMatches()
        {
            IoC.Get<ApplicationViewModel>().CurrentPage = ApplicationPage.PreviousMatch;

            await Task.Delay(2000);
        }

        public async Task ExitHome()
        {
            MessageBoxResult result = MessageBox.Show("Exit to Main Menu", "CoachAid", MessageBoxButton.OKCancel, MessageBoxImage.Question);

            switch (result)
            {
                case MessageBoxResult.OK:
                    if (IoC.Get<ApplicationViewModel>().SideMenuVisible != false)
                        IoC.Get<ApplicationViewModel>().SideMenuVisible = false;

                    if (IoC.Get<ApplicationViewModel>().TopMenuVisible != false)
                        IoC.Get<ApplicationViewModel>().TopMenuVisible = false;

                    IoC.Get<ApplicationViewModel>().CurrentPage = ApplicationPage.Welcome;

                    await Task.Delay(2000);
                    break;

                case MessageBoxResult.Cancel:
                    break;
            }

            
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
