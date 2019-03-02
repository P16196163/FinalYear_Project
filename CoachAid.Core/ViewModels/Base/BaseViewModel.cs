using System;
using System.ComponentModel;
using System.Linq.Expressions;
using System.Threading.Tasks;

namespace CoachAid.Core
{
    /// <summary>
    /// A base view model that fires Property Changed events as needed
    /// </summary>
    public class BaseViewModel : INotifyPropertyChanged
    {
        /// <summary>
        /// The event that is fired when any child property changes its value
        /// </summary>
        public event PropertyChangedEventHandler PropertyChanged = (sender, e) => {};

        /// <summary>
        /// Call this to fire a <see cref="PropertyChanged"/> event
        /// </summary>
        /// <param name="name"></param>
        public void OnPropertyChanged(string name)
        {
            PropertyChanged(this, new PropertyChangedEventArgs(name));
        }

        #region Command Helpers

        /// <summary>
        /// Runs a command if the flag is not set
        /// If the flag is true (indicating the function is already running) then the action is not run
        /// If the flag is false (indicating no running function) then the action is run
        /// Once the action is finished if it was run, the flag is reset to false
        /// </summary>
        /// <param name="updatingFlag">The boolean property flag defining if command is already running</param>
        /// <param name="action">The action to run if command is not already running</param>
        /// <returns></returns>
        protected async Task RunCommand(Expression<Func<bool>> updatingFlag, Func<Task> action)
        {
            //check if the flag property is true
            if (updatingFlag.GetPropertyValue())
                return;

            // Set the property flag to true to indicate we are running
            updatingFlag.SetPropertyValue(true);

            try
            {
                // Run the passed in action
                await action();
            }
            finally
            {
                // Set the property flag to false when finishied
                updatingFlag.SetPropertyValue(false);
            }
        }

        #endregion
    }


}
