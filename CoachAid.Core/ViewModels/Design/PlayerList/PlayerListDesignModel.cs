using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CoachAid.Core
{
    public class PlayerListDesignModel : PlayerListViewModel
    {

        #region Singleton

        /// <summary>
        /// A single instance of the design model
        /// </summary>
        public static PlayerListDesignModel Instance => new PlayerListDesignModel();

        #endregion


        #region Constructor

        /// <summary>
        /// Default constructor
        /// </summary>
        public PlayerListDesignModel()
        {
            Items = new List<PlayerListItemViewModel>
            {
                new PlayerListItemViewModel
                {

                    Name = "Luke Jones",
                    Age = 23,
                    Position = Position.Lock,
                    Nationality = "WAL",
                    Height = 193,
                    Weight = 107,
                    AvgRating = 8.43,

                },
                new PlayerListItemViewModel
                {

                    Name = "Jeff Tracy",
                    Age = 33,
                    Position = Position.FlyHalf,
                    Nationality = "USA",
                    Height = 178,
                    Weight = 84,
                    AvgRating = 8.83,

                },
                new PlayerListItemViewModel
                {

                    Name = "Tim Vine",
                    Age = 23,
                    Position = Position.NumberEight,
                    Nationality = "ENG",
                    Height = 180,
                    Weight = 101,
                    AvgRating = 6.43,

                },
                new PlayerListItemViewModel
                {

                    Name = "Lennox Lewis",
                    Age = 17,
                    Position = Position.Prop,
                    Nationality = "CAN",
                    Height = 188,
                    Weight = 117,
                    AvgRating = 5.43,

                },
                new PlayerListItemViewModel
                {

                    Name = "Bronson Missouri",
                    Age = 23,
                    Position = Position.Wing,
                    Nationality = "USA",
                    Height = 176,
                    Weight = 77,
                    AvgRating = 6.54,

                },
                new PlayerListItemViewModel
                {

                    Name = "Albert Plunge",
                    Age = 23,
                    Position = Position.Centre,
                    Nationality = "NZL",
                    Height = 190,
                    Weight = 102,
                    AvgRating = 9.43,

                }
            };


        }

        #endregion
    }
}
