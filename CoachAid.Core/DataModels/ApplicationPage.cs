namespace CoachAid.Core
{
    /// <summary>
    /// A page of the application
    /// </summary>
    public enum  ApplicationPage
    {
        /// <summary>
        /// The initial welcome page
        /// </summary>
        Welcome = 0,

        /// <summary>
        /// The options page
        /// </summary>
        Options = 1,

        /// <summary>
        /// The homepage for a team/db
        /// </summary>
        DBHome = 2,

        /// <summary>
        /// The page featuring a list of all team players
        /// </summary>
        DBPLayers = 3,

        /// <summary>
        /// The page featuring the stats for the team
        /// </summary>
        DBStats = 4,

        /// <summary>
        /// The page showing the best possible team selection
        /// </summary>
        DBSelection = 5,

        /// <summary>
        /// The page for a player
        /// </summary>
        Player = 6,

        /// <summary>
        /// The page to add stats for a New Match
        /// </summary>
        Match = 7,

        /// <summary>
        /// The page to view old Matches
        /// </summary>
        PreviousMatch = 8,
    }
}
