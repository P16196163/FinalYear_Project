using System.Windows;

namespace CoachAid
{
    /// <summary>
    /// A base class to run any animation method when a boolean is set to true
    /// </summary>
    /// <typeparam name="Parent"></typeparam>
    public abstract class AnimateBaseProperty<Parent> : BaseAttachedProperties<Parent, bool>
        where Parent : BaseAttachedProperties<Parent, bool>, new()
    {

        #region Public Properties

        /// <summary>
        /// A flag indicating if it is the first time this property has been loaded
        /// </summary>
        public bool FirstLoad { get; set; } = true;

        #endregion

        public override void OnValueUpdated(DependencyObject sender, object value)
        {
            // Get framework element
            if (!(sender is FrameworkElement element))
                return;
            
            // Don't fire if the value doesnt changed
            if (sender.GetValue(ValueProperty) == value && !FirstLoad)
                return;

            // On first load...
            if (FirstLoad)
            {
                //Create a single self-unhookable event
                // for the elements Loaded event
                RoutedEventHandler onLoaded = null;
                onLoaded = (ss, ee) =>
                {
                    // Unhook ourselves
                    element.Loaded -= onLoaded;

                    // Do desired animation
                    DoAnimation(element, (bool)value);

                    //No longer in firstload
                    FirstLoad = false;
                };

                // Hook into the loaded event of the element
                element.Loaded += onLoaded;

            }
            else DoAnimation(element, (bool)value);
        }

        /// <summary>
        /// The animation that is fired when the value changes
        /// </summary>
        /// <param name="element">The element</param>
        /// <param name="value">The value</param>
        public virtual void DoAnimation(FrameworkElement element, bool value) { }
    }

    /// <summary>
    /// Animates a framework element sliding it in from left on show
    /// and sliding out to left on hide
    /// </summary>
    public class AnimateSlideInFromTopProperty : AnimateBaseProperty<AnimateSlideInFromTopProperty>
    {

        public override async void DoAnimation(FrameworkElement element, bool value)
        {
            if (value)
                await element.SlideInAndFadeInFromTop(FirstLoad ? 0.5f : 0.5f, KeepMargin: false);
            else
                //Animate out
                await element.SlideOutAndFadeOutToTop(FirstLoad ? 0 : 20.2f, KeepMargin: false);
        }

    }

    public class AnimateSlideInFromLeftProperty : AnimateBaseProperty<AnimateSlideInFromLeftProperty>
    {

        public override async void DoAnimation(FrameworkElement element, bool value)
        {
            if (value)
                await element.SlideInAndFadeInFromLeft(FirstLoad ? 0 : 1f, KeepMargin: false);
            else
                //Animate out
                await element.SlideOutAndFadeOutToLeft(FirstLoad ? 0 : 0.5f, KeepMargin: false);
        }

    }

}
