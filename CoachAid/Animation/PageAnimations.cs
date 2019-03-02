using System.Threading.Tasks;
using System.Windows;
using System.Windows.Controls;
using System.Windows.Media.Animation;

namespace CoachAid
{
    /// <summary>
    /// Helpers to animate pages in specific ways
    /// </summary>
    public static class PageAnimations
    {
        /// <summary>
        /// Slides a page in from the right
        /// </summary>
        /// <param name="page">The page to animate</param>
        /// <param name="seconds">The time the animation will take</param>
        /// <returns></returns>
        public static async Task SlideInAndFadeInFromRight(this Page page, float seconds, bool KeepMargin = true)
        {
            //Create Storyboard
            var sb = new Storyboard();

            //Add slide from right animations
            sb.AddSlideFromRight(seconds, page.WindowWidth, KeepMargin: KeepMargin);

            //Add fade in animation
            sb.AddFadeIn(seconds);

            // Start animating
            sb.Begin(page);

            // Make page visible
            page.Visibility = Visibility.Visible;

            // Wait for it to finish
            await Task.Delay((int)(seconds * 1000));
        }

        /// <summary>
        /// Slides a page out to the left
        /// </summary>
        /// <param name="page">The page to animate</param>
        /// <param name="seconds">The time the animation will take</param>
        /// <returns></returns>
        public static async Task SlideOutAndFadeOutToLeft(this Page page, float seconds, bool KeepMargin = true)
        {
            //Create Storyboard
            var sb = new Storyboard();

            //Add slide from right animations
            sb.AddSlideToLeft(seconds, page.WindowWidth, KeepMargin: KeepMargin);

            //Add fade in animation
            sb.AddFadeOut(seconds);

            // Start animating
            sb.Begin(page);

            // Make page visible
            page.Visibility = Visibility.Visible;

            // Wait for it to finish
            await Task.Delay((int)(seconds * 1000));
        }

    }
}
