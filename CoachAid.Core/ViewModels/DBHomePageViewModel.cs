﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Input;

namespace CoachAid.Core
{
    public class DBHomePageViewModel : BaseViewModel
    {

        public ICommand RemoveMenuCommand { get; set; }

        public DBHomePageViewModel()
        {
            RemoveMenuCommand = new RelayCommand(async () => await RemoveMenu());

        }

        public async Task RemoveMenu()
        {
            if (IoC.Get<ApplicationViewModel>().SideMenuVisible != false && IoC.Get<ApplicationViewModel>().TopMenuVisible != false)
            {
                IoC.Get<ApplicationViewModel>().SideMenuVisible = false;
                IoC.Get<ApplicationViewModel>().TopMenuVisible = false;
            }
            else
            {
                IoC.Get<ApplicationViewModel>().SideMenuVisible = true;
                IoC.Get<ApplicationViewModel>().TopMenuVisible = true;
            }

            await Task.Delay(500);
        }
    }
}
