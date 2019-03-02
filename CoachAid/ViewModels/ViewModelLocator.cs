using CoachAid.Core;

namespace CoachAid
{
    /// <summary>
    /// Locates view models from the IoC for use in binding in Xaml files
    /// </summary>
    public class ViewModelLocator
    {

        #region Public Properties

        /// <summary>
        /// A singleton instance of the ViewModelLocator
        /// </summary>
        public static ViewModelLocator Instance { get; private set; } = new ViewModelLocator();

        /// <summary>
        /// ApplicationViewModel
        /// </summary>
        public static ApplicationViewModel ApplicationViewModel => IoC.Get<ApplicationViewModel>();

        #endregion
    }
}
