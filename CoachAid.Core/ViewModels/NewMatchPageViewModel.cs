using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Input;

namespace CoachAid.Core
{
    public class NewMatchPageViewModel : BaseViewModel
    {

        public ICommand ConfirmCommand { get; set; }
        public ICommand CancelCommand { get; set; }

        public NewMatchPageViewModel()
        {
            ConfirmCommand = new RelayCommand(async () => await ConfirmMatch());
            CancelCommand = new RelayCommand(async () => await Cancel());

        }

        public async Task ConfirmMatch()
        {
            if (IoC.Get<ApplicationViewModel>().TopMenuVisible != true)
                IoC.Get<ApplicationViewModel>().TopMenuVisible = true;

            if (IoC.Get<ApplicationViewModel>().SideMenuVisible != true)
                IoC.Get<ApplicationViewModel>().SideMenuVisible = true;

            IoC.Get<ApplicationViewModel>().CurrentPage = ApplicationPage.DBHome;

            await Task.Delay(500);
        }

        public async Task Cancel()
        {
            if (IoC.Get<ApplicationViewModel>().TopMenuVisible != true)
                IoC.Get<ApplicationViewModel>().TopMenuVisible = true;

            if (IoC.Get<ApplicationViewModel>().SideMenuVisible != true)
                IoC.Get<ApplicationViewModel>().SideMenuVisible = true;

            IoC.Get<ApplicationViewModel>().CurrentPage = ApplicationPage.DBHome;

            await Task.Delay(500);
        }
    }
}
