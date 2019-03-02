using System.Windows;
using System.Windows.Input;
using CoachAid.Core;

namespace CoachAid
{
    /// <summary>
    /// The view model for the custom flat window
    /// </summary>
    public class WindowViewModel : BaseViewModel { 

        #region Member
        private Window mWindow;

        /// <summary>
        /// The margin around the window to allow for drop shadow
        /// </summary>
        private int mOuterMarginSize = 10;

        /// <summary>
        /// Radiud of the edges of the window
        /// </summary>
        private int mWindowRadius = 0;

        #endregion

        #region Public Properties

        public double WindowMinimumWidth { get; set; } = 1000;
        public double WindowMinimumHeight { get; set; } = 600;

        /// <summary>
        /// The size of the resize border around the window
        /// </summary>
        public int ResizeBorder { get; set; } = 1;

        /// <summary>
        /// The size of the resize border around the window including outer margin
        /// </summary>
        public Thickness ResizeBorderThickness { get { return new Thickness(ResizeBorder + OuterMarginSize); } }

        /// <summary>
        /// The padding of inner content of the main window
        /// </summary>
        public Thickness InnerContentPadding { get { return new Thickness(0); } }

        /// <summary>
        /// The size of the resize border around the window
        /// </summary>
        public int OuterMarginSize
        {
            get
            {
                return mWindow.WindowState == WindowState.Maximized ? 0 : mOuterMarginSize;
            }
            set
            {
                mOuterMarginSize = value;

            }
        }

        public Thickness OuterMarginSizeThickness { get { return new Thickness(OuterMarginSize); } }

        /// <summary>
        /// The radius of the edges of the window
        /// </summary>
        public int WindowRadius
        {
            get
            {
                return mWindow.WindowState == WindowState.Maximized ? 0 : mWindowRadius;
            }
            set
            {
                mWindowRadius = value;
            }
        }

        /// <summary>
        /// The radius of the edges of the window
        /// </summary>
        public CornerRadius WindowCornerRadius { get { return new CornerRadius(WindowRadius); } }

        /// <summary>
        /// The height of title bar/caption of window
        /// </summary>
        public int TitleHeight { get; set; } = 42;

        public GridLength TitleHeightGridLength { get { return new GridLength(TitleHeight + ResizeBorder); } }

        

        #endregion

        #region Commands

        /// <summary>
        /// Command to minimize window
        /// </summary>
        public ICommand MinimizeCommand { get; set; }

        /// <summary>
        /// Command to maximize window
        /// </summary>
        public ICommand MaximizeCommand { get; set; }

        /// <summary>
        /// Command to close window
        /// </summary>
        public ICommand CloseCommand { get; set; }

        /// <summary>
        /// Command to open system menu
        /// </summary>
        public ICommand MenuCommand { get; set; }

        #endregion

        #region Constructor 

        public WindowViewModel(Window window)
        {
            mWindow = window;

            mWindow.StateChanged += (sender, e) =>
                {
                    OnPropertyChanged(nameof(ResizeBorderThickness));
                    OnPropertyChanged(nameof(OuterMarginSize));
                    OnPropertyChanged(nameof(OuterMarginSizeThickness));
                    OnPropertyChanged(nameof(WindowRadius));
                    OnPropertyChanged(nameof(WindowCornerRadius));
                };

            //Create Commands

            MinimizeCommand = new RelayCommand(() => mWindow.WindowState = WindowState.Minimized);
            MaximizeCommand = new RelayCommand(() => mWindow.WindowState ^= WindowState.Maximized);
            CloseCommand = new RelayCommand(() => mWindow.Close());
            MenuCommand = new RelayCommand(() => SystemCommands.ShowSystemMenu(mWindow, GetMousePosition()));
        }

        #endregion

        #region private helpers

        /// <summary>
        /// gets current mouse position on screen
        /// </summary>
        /// <returns></returns>
        private Point GetMousePosition()
        {
            var position = Mouse.GetPosition(mWindow);
            return new Point(position.X + mWindow.Left, position.Y + mWindow.Top);
        }

        #endregion
    }
}
