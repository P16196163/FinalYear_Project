using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CoachAid.Core
{
    public class SelectionListDesignModel : SelectionListViewModel
    {

        #region Singleton

        /// <summary>
        /// A single instance of the design model
        /// </summary>
        public static SelectionListDesignModel Instance => new SelectionListDesignModel();

        #endregion


        #region Constructor

        /// <summary>
        /// Default constructor
        /// </summary>
        public SelectionListDesignModel()
        {
            Starting15 = new List<SelectionListItemViewModel>
            {
                new SelectionListItemViewModel
                {
                    Number = "1",
                    Position = Position.Prop,
                    Name = "Bill Bailey",
                    AvgRating = 5.86,
                },

                new SelectionListItemViewModel
                {
                    Number = "2",
                    Position = Position.Hooker,
                    Name = "Derek Trotter",
                    AvgRating = 5.04,
                },

                new SelectionListItemViewModel
                {
                    Number = "3",
                    Position = Position.Prop,
                    Name = "Lennox Lewis",
                    AvgRating = 5.12,
                },

                new SelectionListItemViewModel
                {
                    Number = "4",
                    Position = Position.Lock,
                    Name = "Luke Jones",
                    AvgRating = 5.45,
                },

                new SelectionListItemViewModel
                {
                    Number = "5",
                    Position = Position.Lock,
                    Name = "Tiny Tim",
                    AvgRating = 5.54,
                },

                new SelectionListItemViewModel
                {
                    Number = "6",
                    Position = Position.Flanker,
                    Name = "Big Tim",
                    AvgRating = 5.54,
                },

                new SelectionListItemViewModel
                {
                    Number = "7",
                    Position = Position.Flanker,
                    Name = "Turnover Tim",
                    AvgRating = 5.54,
                },

                new SelectionListItemViewModel
                {
                    Number = "8",
                    Position = Position.NumberEight,
                    Name = "Trucking Tim",
                    AvgRating = 5.54,
                },

                new SelectionListItemViewModel
                {
                    Number = "9",
                    Position = Position.ScrumHalf,
                    Name = "Boris Yelsin",
                    AvgRating = 5.54,
                },

                new SelectionListItemViewModel
                {
                    Number = "10",
                    Position = Position.FlyHalf,
                    Name = "Andy Goode",
                    AvgRating = 5.54,
                },

                new SelectionListItemViewModel
                {
                    Number = "11",
                    Position = Position.Wing,
                    Name = "Tom Bosley",
                    AvgRating = 5.54,
                },

                new SelectionListItemViewModel
                {
                    Number = "12",
                    Position = Position.Centre,
                    Name = "Andy Williams",
                    AvgRating = 5.54,
                },

                new SelectionListItemViewModel
                {
                    Number = "13",
                    Position = Position.Centre,
                    Name = "Albert Plunge",
                    AvgRating = 5.54,
                },

                new SelectionListItemViewModel
                {
                    Number = "14",
                    Position = Position.Wing,
                    Name = "Speedy Gonzales",
                    AvgRating = 5.54,
                },

                new SelectionListItemViewModel
                {
                    Number = "15",
                    Position = Position.FullBack,
                    Name = "Steely Dan",
                    AvgRating = 5.54,
                },
            };

            Substitutes = new List<SelectionListItemViewModel>
            {
                new SelectionListItemViewModel
                {
                    Number = "16",
                    Position = Position.Prop,
                    Name = "Fat Tim",
                    AvgRating = 5.54,
                },
                new SelectionListItemViewModel
                {
                    Number = "17",
                    Position = Position.Hooker,
                    Name = "Duke Nukem",
                    AvgRating = 5.54,
                },
                new SelectionListItemViewModel
                {
                    Number = "18",
                    Position = Position.Lock,
                    Name = "Rodney Trotter",
                    AvgRating = 5.54,
                },
                new SelectionListItemViewModel
                {
                    Number = "19",
                    Position = Position.Flanker,
                    Name = "Booker T",
                    AvgRating = 5.54,
                },
                new SelectionListItemViewModel
                {
                    Number = "20",
                    Position = Position.ScrumHalf,
                    Name = "Matt Dawson",
                    AvgRating = 5.54,
                },
                new SelectionListItemViewModel
                {
                    Number = "21",
                    Position = Position.Centre,
                    Name = "Fidel Castro",
                    AvgRating = 5.54,
                },
                new SelectionListItemViewModel
                {
                    Number = "22",
                    Position = Position.Wing,
                    Name = "Regular Gonzales",
                    AvgRating = 5.54,
                },
            };


        }

        #endregion
    }
}
