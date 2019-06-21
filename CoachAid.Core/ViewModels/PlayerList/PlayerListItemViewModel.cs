using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CoachAid.Core
{
    public class PlayerListItemViewModel : BaseViewModel
    {
        /// <summary>
        /// The Full Name of this player
        /// </summary>
        public string Name { get; set; }

        /// <summary>
        /// This player's age
        /// </summary>
        public int Age { get; set; }

        /// <summary>
        /// The nationality of this player
        /// </summary>
        public string Nationality { get; set; }

        /// <summary>
        /// This player's position
        /// </summary>
        public Position Position { get; set; }

        /// <summary>
        /// This player's average match rating
        /// </summary>
        public double AvgRating { get; set; }

        /// <summary>
        /// This player's height
        /// </summary>
        public double Height { get; set; }

        /// <summary>
        /// This player's weight
        /// </summary>
        public double Weight { get; set; }

        public string HeightToString => $"{Height}cm";

        public string WeightToString => $"{Weight}kg"; 
       
    }
}
