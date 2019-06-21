using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Input;

namespace CoachAid.Core
{
    public class DBPlayersViewModel : BaseViewModel
    {
        public ICommand PlayerPageCommand { get; set; }

        public DBPlayersViewModel()
        {
            PlayerPageCommand = new RelayCommand(async () => await Player());
        }

        public async Task Player()
        {
            IoC.Get<ApplicationViewModel>().CurrentPage = ApplicationPage.Player;

            await Task.Delay(200);
        }
    }
}
