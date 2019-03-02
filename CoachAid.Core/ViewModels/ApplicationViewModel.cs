namespace CoachAid.Core
{
    /// <summary>
    /// The applicataion state as a view model
    /// </summary>
    public class ApplicationViewModel : BaseViewModel
    {
        /// <summary>
        /// The current page of the application
        /// </summary>
        public ApplicationPage CurrentPage { get; set; } = ApplicationPage.Welcome;

        /// <summary>
        /// True if side menu should be visible
        /// </summary>
        public bool SideMenuVisible { get; set; } = false;

        /// <summary>
        /// True if top menu should be visible
        /// </summary>
        public bool TopMenuVisible { get; set; } = false;

    }
}
