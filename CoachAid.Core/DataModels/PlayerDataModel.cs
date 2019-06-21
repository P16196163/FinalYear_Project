using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CoachAid.Core
{
    /// <summary>
    /// Data model for a player's basic details
    /// </summary>
    public class PlayerDataModel
    {
        /// <summary>
        /// The unique Id for a player
        /// </summary>
        public string Id { get; set; }

        /// <summary>
        /// The player's first name(s)
        /// </summary>
        public string FirstName { get; set; }

        /// <summary>
        /// The player's last name
        /// </summary>
        public string LastName { get; set; }

        /// <summary>
        /// The player's full name
        /// </summary>
        public string FullName => FirstName + " " + LastName;

        /// <summary>
        /// The player's Nationality
        /// </summary>
        public string Nationality { get; set; }

        /// <summary>
        /// The player's primary position
        /// </summary>
        public Position Position { get; set; }

        /// <summary>
        /// The player's age
        /// </summary>
        public int Age { get; set; }

        /// <summary>
        /// The player's Height
        /// </summary>
        public double Height { get; set; }

        /// <summary>
        /// The player's Weight
        /// </summary>
        public double Weight { get; set; }

    }
}
