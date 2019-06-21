using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CoachAid.Core
{
    public class SelectionListItemViewModel : BaseViewModel
    {
        /// <summary>
        /// The Name of selected player
        /// </summary>
        public string Name { get; set; }

        /// <summary>
        /// The number of the player/postion for selection
        /// </summary>
        public string Number { get; set; }

        /// <summary>
        /// The position for selection
        /// </summary>
        public Position Position { get; set; }

        /// <summary>
        /// The average match rating of the selected player
        /// </summary>
        public double AvgRating { get; set; }
        
    }
}
