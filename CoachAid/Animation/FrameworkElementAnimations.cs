using System.Threading.Tasks;
using System.Windows;
using System.Windows.Media.Animation;

namespace CoachAid
{
    /// <summary>
    /// Helpers to animate framework elemnts in specific ways
    /// </summary>
    public static class FrameworkElementAnimations
    {
        /// <summary>
        /// Slides an element in from the right
        /// </summary>
        /// <param name="page">The element to animate</param>
        /// <param name="seconds">The time the animation will take</param>
        /// <param name="KeepMargin">Whether to keep margin after animation</param>
        /// <returns></returns>
        public static async Task SlideInAndFadeInFromRight(this FrameworkElement element, float seconds, bool KeepMargin = true)
        {
            //Create Storyboard
            var sb = new Storyboard();

            //Add slide from right animations
            sb.AddSlideFromRight(seconds, element.ActualWidth, KeepMargin: KeepMargin);

            //Add fade in animation
            sb.AddFadeIn(seconds);

            // Start animating
            sb.Begin(element);

            // Make page visible
            element.Visibility = Visibility.Visible;

            // Wait for it to finish
            await Task.Delay((int)(seconds * 1000));
        }

        /// <summary>
        /// Slides an element in from the Left
        /// </summary>
        /// <param name="page">The element to animate</param>
        /// <param name="seconds">The time the animation will take</param>
        /// <param name="KeepMargin">Whether to keep margin after animation</param>
        /// <returns></returns>
        public static async Task SlideInAndFadeInFromLeft(this FrameworkElement element, float seconds = 0.3f, bool KeepMargin = true)
        {
            //Create Storyboard
            var sb = new Storyboard();

            await Task.Delay(500);
            //Add slide from right animations
            sb.AddSlideFromLeft(seconds, element.ActualWidth, KeepMargin: KeepMargin);

            //Add fade in animation
            sb.AddFadeIn(seconds);

            // Start animating
            sb.Begin(element);

            // Make page visible
            element.Visibility = Visibility.Visible;

            // Wait for it to finish
            await Task.Delay((int)(seconds * 1000));
        }

        /// <summary>
        /// Slides an element in from the top
        /// </summary>
        /// <param name="page">The element to animate</param>
        /// <param name="seconds">The time the animation will take</param>
        /// <param name="KeepMargin">Whether to keep margin after animation</param>
        /// <returns></returns>
        public static async Task SlideInAndFadeInFromTop(this FrameworkElement element, float seconds, bool KeepMargin = true)
        {

            await Task.Delay(60);

            //Create Storyboard
            var sb = new Storyboard();

            //Add slide from right animations
            sb.AddSlideFromTop(seconds, element.ActualHeight, KeepMargin: KeepMargin);

            //Add fade in animation
            sb.AddFadeIn(seconds);

            // Start animating
            sb.Begin(element);

            // Make page visible
            element.Visibility = Visibility.Visible;

            // Wait for it to finish
            await Task.Delay((int)(seconds * 1000));
        }

        /// <summary>
        /// Slides an element out to the left
        /// </summary>
        /// <param name="element">The element to animate</param>
        /// <param name="seconds">The time the animation will take</param>
        /// <param name="KeepMargin">Whether to keep margin after animation</param>
        /// <returns></returns>
        public static async Task SlideOutAndFadeOutToLeft(this FrameworkElement element, float seconds = 0.3f, bool KeepMargin = true)
        {
            
            //Create Storyboard
            var sb = new Storyboard();

            await Task.Delay((int)(seconds * 80));

            //Add slide from right animations
            sb.AddSlideToLeft(seconds, element.ActualWidth, KeepMargin: KeepMargin);

            //Add fade in animation
            sb.AddFadeOut(seconds);

            // Start animating
            sb.Begin(element);

            // Make page visible
            element.Visibility = Visibility.Visible;

            // Wait for it to finish
            await Task.Delay((int)(seconds * 1000));
        }

        /// <summary>
        /// Slides an element in to the top
        /// </summary>
        /// <param name="page">The element to animate</param>
        /// <param name="seconds">The time the animation will take</param>
        /// <param name="KeepMargin">Whether to keep margin after animation</param>
        /// <returns></returns>
        public static async Task SlideOutAndFadeOutToTop(this FrameworkElement element, float seconds, bool KeepMargin = true)
        {
            //Create Storyboard
            var sb = new Storyboard();

            //Add slide from right animations
            sb.AddSlideToTop(seconds, element.ActualWidth, KeepMargin: KeepMargin);

            //Add fade in animation
            sb.AddFadeIn(seconds);

            // Start animating
            sb.Begin(element);

            // Make page visible
            element.Visibility = Visibility.Visible;

            // Wait for it to finish
            await Task.Delay((int)(seconds * 1000));
        }

    }
}
