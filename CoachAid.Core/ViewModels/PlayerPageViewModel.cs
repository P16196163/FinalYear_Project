using System;
using System.Collections.Generic;

namespace CoachAid.Core
{
    /// <summary>
    /// The view model for the player page
    /// </summary>
    public class PlayerPageViewModel : BaseViewModel
    {
        public static PlayerDataModel Player = new PlayerDataModel()
        {
            FirstName = "Rodney",
            LastName = "Trotter",
            Nationality = "English",
            Position = Position.Lock,
            Age = 21,
            Height = 196,
            Weight = 108,
        };

        public string Name => Player.FullName;
        public string Nationality => Player.Nationality;
        public Position Position => Player.Position;
        public string Age => Player.Age.ToString();
        public string Height => Player.Height.ToString() + "cm";
        public string Weight => Player.Weight.ToString() + "kg";

        public double AvgRating { get; set; } = 7.44565745556;
        public string Avg => AvgRating.ToString("F");

        public double LastMatchRating { get; set; } = 8.9923874875;
        public string LastMatch => LastMatchRating.ToString("F");

        public List<SeasonStats> seasonStats { get; set; }
        public List<MatchStats> matchStats { get; set; }

        public class SeasonStats
        {
            public int GP { get; set; }
            public int Tries { get; set; }
            public int Pens { get; set; }
            public int DGs { get; set; }
            public int Pts => (Tries * 5) + ((Pens + DGs) * 3);
            public double TklAtt { get; set; }
            public double TklCmp { get; set; }
            public string TklPct => (TklAtt == 0 ? 0 : (TklCmp / TklAtt) * 100).ToString("F");

        }

        public class MatchStats
        {
            public string Opponent { get; set; }
            public DateTime Date { get; set; }
            public int MinsPld { get; set; }
            public int Tries { get; set; }
            public int Pens { get; set; }
            public int DGs { get; set; }
            public int Pts => (Tries * 5) + ((Pens + DGs) * 3);
            public double TklAtt { get; set; }
            public double TklCmp { get; set; }
            public string TklPct => (TklAtt == 0 ? 0 : (TklCmp / TklAtt) * 100).ToString("F");

        }

        public PlayerPageViewModel()
        {
            seasonStats = new List<SeasonStats>
            {
                new SeasonStats
                {
                    GP = 12,
                    Tries = 2,
                    Pens = 8,
                    DGs = 1,
                    TklAtt = 56,
                    TklCmp = 41
                }
            };

            matchStats = new List<MatchStats>
            {
                new MatchStats
                {
                    Opponent = "Aston University",
                    Date = new DateTime(2019, 3, 13),
                    MinsPld = 80,
                    Tries = 2,
                    Pens = 8,
                    DGs = 1,
                    TklAtt = 56,
                    TklCmp = 41
                },
                new MatchStats
                {
                    Opponent = "University of Leicester",
                    Date = new DateTime(2019, 3, 6),
                    MinsPld = 80,
                    Tries = 2,
                    Pens = 8,
                    DGs = 1,
                    TklAtt = 56,
                    TklCmp = 41
                },
                new MatchStats
                {
                    Opponent = "Aston University",
                    Date = new DateTime(2019, 2, 28),
                    MinsPld = 80,
                    Tries = 2,
                    Pens = 8,
                    DGs = 1,
                    TklAtt = 56,
                    TklCmp = 41
                },
            };

        }
    }
}
