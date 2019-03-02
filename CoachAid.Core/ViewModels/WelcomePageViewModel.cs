using System;
using System.IO;
using System.Threading.Tasks;
using System.Windows.Input;

namespace CoachAid.Core
{
    public class WelcomePageViewModel : BaseViewModel
    {

        #region Commands

        public ICommand NewDBCommand { get; set; }
        public ICommand LoadDBCommand { get; set; }
        public ICommand OptionsCommand { get; set; }

        #endregion

        #region Constructor

        public WelcomePageViewModel()
        {
            // Create Commands

            NewDBCommand = new RelayCommand(async () => await NewDB());
            LoadDBCommand = new RelayCommand(async () => await LoadDB());
            OptionsCommand = new RelayCommand(async () => await Options());

        }

        public async Task Options()
        {
            IoC.Get<ApplicationViewModel>().CurrentPage = ApplicationPage.Options;

            await Task.Delay(2000);
        }

        public async Task LoadDB()
        {
            await Task.Delay(2000);
        }

        public async Task NewDB()
        {
            IoC.Get<ApplicationViewModel>().CurrentPage = ApplicationPage.DBHome;

            IoC.Get<ApplicationViewModel>().TopMenuVisible = true;

            IoC.Get<ApplicationViewModel>().SideMenuVisible = true;

            await Task.Delay(2000);
        }


        #endregion

    }
}
