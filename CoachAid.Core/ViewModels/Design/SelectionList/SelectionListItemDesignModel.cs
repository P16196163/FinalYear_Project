using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CoachAid.Core
{
    public class SelectionListItemDesignModel : SelectionListItemViewModel
    {

        #region Singleton

        /// <summary>
        /// A single instance of the design model
        /// </summary>
        public static SelectionListItemDesignModel Instance => new SelectionListItemDesignModel();

        #endregion


        #region Constructor

        /// <summary>
        /// Default constructor
        /// </summary>
        public SelectionListItemDesignModel()
        {
            Number = "4";
            Position = Position.Lock;
            Name = "Luke Jones";
            AvgRating = 8.43;

        }

        #endregion
    }
}
