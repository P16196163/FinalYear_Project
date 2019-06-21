using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CoachAid.Core
{
    public class PlayerListItemDesignModel : PlayerListItemViewModel
    {

        #region Singleton

        /// <summary>
        /// A single instance of the design model
        /// </summary>
        public static PlayerListItemDesignModel Instance => new PlayerListItemDesignModel();

        #endregion


        #region Constructor

        /// <summary>
        /// Default constructor
        /// </summary>
        public PlayerListItemDesignModel()
        {
            Name = "Luke Jones";
            Age = 23;
            Position = Position.Lock;
            Nationality = "WAL";
            Height = 193;
            Weight = 107;
            AvgRating = 8.43;

        }

        #endregion
    }
}
