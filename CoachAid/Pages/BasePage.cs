using System.Threading.Tasks;
using System.Windows.Controls;
using CoachAid.Core;

namespace CoachAid
{
    /// <summary>
    /// A base page to give all pages a base functionality
    /// </summary>
    public class BasePage<VM> : Page
        where VM : BaseViewModel, new()
    {

        #region Private Members

        private VM mViewModel;

        #endregion

        #region Public Properties

        /// <summary>
        /// View Model associated with this page
        /// </summary>
        public VM ViewModel
        {
            get { return mViewModel; }
            set
            {
                //If nothing has changed, return
                if (mViewModel == value)
                    return;

                // Update the value
                mViewModel = value;

                // Set data context for this page
                DataContext = mViewModel;

            }
        }

        /// <summary>
        /// The animation to play when page is first loaded
        /// </summary>
        public PageAnimation PageLoadAnimation { get; set; } = PageAnimation.SlideAndFadeInFromRight;

        /// <summary>
        /// The animation to play when page is unloaded
        /// </summary>
        public PageAnimation PageUnloadAnimation { get; set; } = PageAnimation.SlideAndFadeOutToLeft;

        /// <summary>
        /// The time any slide takes to complete
        /// </summary>
        public float SlideSeconds { get; set; } = 0.8f;

        #endregion

        #region Default Constructor

        public BasePage()
        {
            //Listen out for page loading
            Loaded += BasePage_Loaded;

            ViewModel = new VM();
        }

        #endregion

        #region Animation Load / Unload

        /// <summary>
        /// Once the page is loaded, perform any required animation
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private async void BasePage_Loaded(object sender, System.Windows.RoutedEventArgs e)
        {
            //Animate the page in
            await AnimateIn();
        }

        public async Task AnimateIn()
        {
            // Make sure we have something to do
            if (PageLoadAnimation == PageAnimation.None)
                return;

            switch (PageLoadAnimation)
            {
                case PageAnimation.SlideAndFadeInFromRight:


                    // Start the animation
                    await this.SlideInAndFadeInFromRight(SlideSeconds);
                 
                    break;
            }
        }

        /// <summary>
        /// Animates the page out
        /// </summary>
        /// <returns></returns>
        public async Task AnimateOut()
        {
            // Make sure we have something to do
            if (PageUnloadAnimation == PageAnimation.None)
                return;

            switch (PageUnloadAnimation)
            {
                case PageAnimation.SlideAndFadeOutToLeft:

                    // Start the animation
                    await this.SlideOutAndFadeOutToLeft(SlideSeconds);

                    break;
            }
        }

        #endregion

    }
}
