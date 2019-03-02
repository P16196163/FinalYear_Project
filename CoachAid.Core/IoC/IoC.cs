using Ninject;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CoachAid.Core
{
    /// <summary>
    /// The IoC container for our application
    /// </summary>
    public static class IoC
    {
        #region Public Properties
        /// <summary>
        /// The kernel for IoC container
        /// </summary>
        public static IKernel Kernel { get; private set; } = new StandardKernel();

        #endregion

        #region Construction

        /// <summary>
        /// Gets a service from the IoC container
        /// </summary>
        /// <typeparam name="T"></typeparam>
        /// <returns></returns>
        public static T Get<T>()
        {
            return Kernel.Get<T>();
        }

        /// <summary>
        /// Sets up the IoC container, binds all information required and is ready for use
        /// NOTE: must be called as soon as your application starts up to ensure all
        /// services can be found
        /// </summary>
        public static void Setup()
        {
            // Bind all required view models
            BindViewModels();
        }

        private static void BindViewModels()
        {
            // Bind to a single instance of ApplicationViewModel
            Kernel.Bind<ApplicationViewModel>().ToConstant(new ApplicationViewModel());
        }

        #endregion

    }
}
