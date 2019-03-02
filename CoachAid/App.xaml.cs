using System.Windows;
using CoachAid.Core;

namespace CoachAid
{
    /// <summary>
    /// Interaction logic for App.xaml
    /// </summary>
    public partial class App : Application
    {

        /// <summary>
        /// Custom startup so we load IoC immediately before anything else
        /// </summary>
        /// <param name="e"></param>
        protected override void OnStartup(StartupEventArgs e)
        {
            // Base application does what it needs
            base.OnStartup(e);

            // Setup IoC
            IoC.Setup();

            // Show the main window
            Current.MainWindow = new MainWindow();
            Current.MainWindow.Show();

        }

    }
}
