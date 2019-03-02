using System;
using System.Windows;
using System.Windows.Media.Animation;

namespace CoachAid
{
    public static class StoryboardHelpers
    {
        /// <summary>
        /// Add a slide from right animation to storyboard
        /// </summary>
        /// <param name="storyboard">The storyboard to add the animation to</param>
        /// <param name="seconds">The time the animation will take</param>
        /// <param name="offset">The distance to the right to start from</param>
        /// <param name="decelerationRatio">The rate of deceleration</param>
        /// <param name="KeepMargin">Whether to keep margin after animation</param>
        public static void AddSlideFromRight(this Storyboard storyboard, float seconds, double offset, float decelerationRatio = 0.9f, bool KeepMargin = true)
        {
            //Create the margin animate from right
            var animation = new ThicknessAnimation
            {
                Duration = new Duration(TimeSpan.FromSeconds(seconds)),
                From = new Thickness(KeepMargin ? offset : 0, 0, -offset, 0),
                To = new Thickness(0),
                DecelerationRatio = decelerationRatio
            };

            // Set the target property name
            Storyboard.SetTargetProperty(animation, new PropertyPath("Margin"));

            // Add this to storyboard
            storyboard.Children.Add(animation);
        }

        /// <summary>
        /// Add a slide from left animation to storyboard
        /// </summary>
        /// <param name="storyboard">The storyboard to add the animation to</param>
        /// <param name="seconds">The time the animation will take</param>
        /// <param name="offset">The distance to the left to start from</param>
        /// <param name="decelerationRatio">The rate of deceleration</param>
        /// <param name="KeepMargin">Whether to keep margin after animation</param>
        public static void AddSlideFromLeft(this Storyboard storyboard, float seconds, double offset, float decelerationRatio = 0.9f, bool KeepMargin = true)
        {
            //Create the margin animate from right
            var animation = new ThicknessAnimation
            {
                Duration = new Duration(TimeSpan.FromSeconds(seconds)),
                From = new Thickness(-offset, 0, KeepMargin ? offset : 0, 0),
                To = new Thickness(0),
                DecelerationRatio = decelerationRatio
            };

            // Set the target property name
            Storyboard.SetTargetProperty(animation, new PropertyPath("Margin"));

            // Add this to storyboard
            storyboard.Children.Add(animation);
        }

        /// <summary>
        /// Add a slide from top animation to storyboard
        /// </summary>
        /// <param name="storyboard">The storyboard to add the animation to</param>
        /// <param name="seconds">The time the animation will take</param>
        /// <param name="offset">The distance from the top to start from</param>
        /// <param name="decelerationRatio">The rate of deceleration</param>
        /// <param name="KeepMargin">Whether to keep margin after animation</param>
        public static void AddSlideFromTop(this Storyboard storyboard, float seconds, double offset, float decelerationRatio = 0.9f, bool KeepMargin = true)
        {
            //Create the margin animate from top
            var animation = new ThicknessAnimation
            {
                Duration = new Duration(TimeSpan.FromSeconds(seconds)),
                From = new Thickness(0, KeepMargin ? 0 : -offset, 0, offset),
                To = new Thickness(0),
                DecelerationRatio = decelerationRatio
            };

            // Set the target property name
            Storyboard.SetTargetProperty(animation, new PropertyPath("Margin"));

            // Add this to storyboard
            storyboard.Children.Add(animation);
        }

        /// <summary>
        /// Adds a fade in animation to storyboard
        /// </summary>
        /// <param name="storyboard">The storyboard to add the animation to</param>
        /// <param name="seconds">The time the animation will take</param>
        /// <param name="offset">The distance to the right to start from</param>
        /// <param name="decelerationRatio">The rate of deceleration</param>
        public static void AddFadeIn(this Storyboard storyboard, float seconds)
        {
            //Create the fade in
            var animation = new DoubleAnimation
            {
                Duration = new Duration(TimeSpan.FromSeconds(seconds)),
                From = 0,
                To = 1, 
            };

            // Set the target property name
            Storyboard.SetTargetProperty(animation, new PropertyPath("Opacity"));

            // Add this to storyboard
            storyboard.Children.Add(animation);
        }

        /// <summary>
        /// Adds a fade out animation to storyboard
        /// </summary>
        /// <param name="storyboard">The storyboard to add the animation to</param>
        /// <param name="seconds">The time the animation will take</param>
        public static void AddFadeOut(this Storyboard storyboard, float seconds)
        {
            //Create the fade in
            var animation = new DoubleAnimation
            {
                Duration = new Duration(TimeSpan.FromSeconds(seconds)),
                From = 1,
                To = 0,
            };

            // Set the target property name
            Storyboard.SetTargetProperty(animation, new PropertyPath("Opacity"));

            // Add this to storyboard
            storyboard.Children.Add(animation);
        }

        /// <summary>
        /// Add a slide to left animation to storyboard
        /// </summary>
        /// <param name="storyboard">The storyboard to add the animation to</param>
        /// <param name="seconds">The time the animation will take</param>
        /// <param name="offset">The distance to the left to end at</param>
        /// <param name="decelerationRatio">The rate of deceleration</param>
        /// <param name="KeepMargin">Whether to keep margin after animation</param>
        public static void AddSlideToLeft(this Storyboard storyboard, float seconds, double offset, float decelerationRatio = 0.9f, bool KeepMargin = true)
        {
            //Create the margin animate to left
            var animation = new ThicknessAnimation
            {
                Duration = new Duration(TimeSpan.FromSeconds(seconds)),
                From = new Thickness(0),
                To = new Thickness(-offset, 0, KeepMargin ? offset : 0, 0),
                DecelerationRatio = decelerationRatio
            };

            // Set the target property name
            Storyboard.SetTargetProperty(animation, new PropertyPath("Margin"));

            // Add this to storyboard
            storyboard.Children.Add(animation);
        }

        /// <summary>
        /// Add a slide to right animation to storyboard
        /// </summary>
        /// <param name="storyboard">The storyboard to add the animation to</param>
        /// <param name="seconds">The time the animation will take</param>
        /// <param name="offset">The distance to the right to end at</param>
        /// <param name="decelerationRatio">The rate of deceleration</param>
        /// <param name="KeepMargin">Whether to keep margin after animation</param>
        public static void AddSlideToRight(this Storyboard storyboard, float seconds, double offset, float decelerationRatio = 0.9f, bool KeepMargin = true)
        {
            //Create the margin animate from right
            var animation = new ThicknessAnimation
            {
                Duration = new Duration(TimeSpan.FromSeconds(seconds)),
                From = new Thickness(0),
                To = new Thickness(KeepMargin ? offset : 0, 0, -offset, 0),
                DecelerationRatio = decelerationRatio
            };

            // Set the target property name
            Storyboard.SetTargetProperty(animation, new PropertyPath("Margin"));

            // Add this to storyboard
            storyboard.Children.Add(animation);
        }

        /// <summary>
        /// Add a slide to top animation to storyboard
        /// </summary>
        /// <param name="storyboard">The storyboard to add the animation to</param>
        /// <param name="seconds">The time the animation will take</param>
        /// <param name="offset">The distance to the top to end at</param>
        /// <param name="decelerationRatio">The rate of deceleration</param>
        /// <param name="KeepMargin">Whether to keep margin after animation</param>
        public static void AddSlideToTop(this Storyboard storyboard, float seconds, double offset, float decelerationRatio = 0.9f, bool KeepMargin = true)
        {
            //Create the margin animate to top
            var animation = new ThicknessAnimation
            {
                Duration = new Duration(TimeSpan.FromSeconds(seconds)),
                From = new Thickness(0),
                To = new Thickness(0, -offset, 0, offset),
                DecelerationRatio = decelerationRatio
            };

            // Set the target property name
            Storyboard.SetTargetProperty(animation, new PropertyPath("Margin"));

            // Add this to storyboard
            storyboard.Children.Add(animation);
        }

    }
}
