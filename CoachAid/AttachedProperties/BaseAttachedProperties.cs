using System;
using System.Windows;

namespace CoachAid
{
    /// <summary>
    /// Base Attached property to replace vanilla WPF property
    /// </summary>
    /// <typeparam name="Parent">The parent class to be the attached property</typeparam>
    /// <typeparam name="Property">Type of the attached property</typeparam>
    public abstract class BaseAttachedProperties<Parent, Property>
        where Parent : BaseAttachedProperties<Parent, Property>,new()
    {
        #region Public Properties

        /// <summary>
        /// A singleton instance of parent class
        /// </summary>
        public static Parent Instance { get; private set; } = new Parent();

        #endregion

        #region Attached Property Definitions 

        /// <summary>
        /// The attached property for this class
        /// </summary>
        public static readonly DependencyProperty ValueProperty =
            DependencyProperty.RegisterAttached("Value", 
                typeof(Property), 
                typeof(BaseAttachedProperties<Parent, Property>), 
                new UIPropertyMetadata(
                    default(Property),
                    new PropertyChangedCallback(OnValuePropertyChanged),
                    new CoerceValueCallback(OnValuePropertyUpdated)
                    ));

        /// <summary>
        /// The callback event when the <see cref="ValueProperty"/> is changed, even if it is the same vlaue
        /// </summary>
        /// <param name="d">The UI element that had it's property changed</param>
        /// <param name="e">The arguementd for the event</param>
        private static object OnValuePropertyUpdated(DependencyObject d, object value)
        {
            //call parent function
            Instance.OnValueUpdated(d, value);

            //call event listeners
            Instance.ValueUpdated(d, value);

            return value;

        }

        /// <summary>
        /// The callback event when the <see cref="ValueProperty"/> is changed
        /// </summary>
        /// <param name="d">The UI element that had it's property changed</param>
        /// <param name="e">The arguementd for the event</param>
        private static void OnValuePropertyChanged(DependencyObject d, DependencyPropertyChangedEventArgs e)
        {
            //call parent function
            Instance.OnValueChanged(d, e);

            //call event listeners
            Instance.ValueChanged(d, e);
        }

        /// <summary>
        /// Gets attached property
        /// </summary>
        /// <param name="d">Element to get property from</param>
        /// <returns></returns>
        public static Property GetValue(DependencyObject d) => (Property)d.GetValue(ValueProperty);

        /// <summary>
        /// Sets the attached property
        /// </summary>
        /// <param name="d">Element to get property from</param>
        /// <param name="value">Value to set property to</param>
        public static void SetValue(DependencyObject d, Property value) => d.SetValue(ValueProperty, value);

        #endregion

        #region Public Events

        /// <summary>
        /// Fired when value changes
        /// </summary>
        public event Action<DependencyObject, DependencyPropertyChangedEventArgs> ValueChanged = (sender, e) => { };

        /// <summary>
        /// Fired when value changes, even when value is the same
        /// </summary>
        public event Action<DependencyObject, object> ValueUpdated = (sender, value) => { };

        #endregion

        #region Event Methods

        /// <summary>
        /// The method that is called when any attached property of this type is changed
        /// </summary>
        /// <param name="sender">UI element that this property was changed for</param>
        /// <param name="e">arguments for this event</param>
        public virtual void OnValueChanged(DependencyObject sender, DependencyPropertyChangedEventArgs e) { }

        /// <summary>
        /// The method that is called when any attached property of this type is changed, even if the valueis the same
        /// </summary>
        /// <param name="sender">UI element that this property was changed for</param>
        /// <param name="e">arguments for this event</param>
        public virtual void OnValueUpdated(DependencyObject sender, object value) { }

        #endregion
    }
}
