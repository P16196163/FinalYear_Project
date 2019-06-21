using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CoachAid.Core
{
    /// <summary>
    /// A view model for the overall Player list
    /// </summary>
    public class PlayerListViewModel : BaseViewModel
    {
        /// <summary>
        /// The player list items for the list
        /// </summary>
        public List<PlayerListItemViewModel> Items { get; set; }

    }
}
