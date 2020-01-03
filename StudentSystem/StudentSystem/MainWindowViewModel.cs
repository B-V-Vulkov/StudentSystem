namespace StudentSystem
{
    using System.Windows;
    using Prism.Commands;

    public class MainWindowViewModel
    {
        #region Declarations

        private Window window;

        private DelegateCommand minimizedCommand;

        private DelegateCommand maximizedCommand;

        private DelegateCommand closeCommand;

        #endregion

        #region Initializations

        public MainWindowViewModel(Window window)
        {
            this.window = window;

            this.window.MaxHeight = SystemParameters.MaximizedPrimaryScreenHeight;
            this.window.MaxWidth = SystemParameters.MaximizedPrimaryScreenWidth;
        }

        #endregion

        #region Properties

        public DelegateCommand MinimizedCommand
        {
            get
            {
                if (this.minimizedCommand == null)
                {
                    this.minimizedCommand = new DelegateCommand(MinimizedWindow);
                }

                return this.minimizedCommand;
            }
        }

        public DelegateCommand MaximizedCommand
        {
            get
            {
                if (this.maximizedCommand == null)
                {
                    this.maximizedCommand = new DelegateCommand(MaximizedWindow);
                }

                return this.maximizedCommand;
            }
        }

        public DelegateCommand CloseCommand
        {
            get
            {
                if (this.closeCommand == null)
                {
                    this.closeCommand = new DelegateCommand(CloseWindow);
                }

                return this.closeCommand;
            }
        }

        #endregion

        #region Methods

        private void MinimizedWindow()
        {
            this.window.WindowState = WindowState.Minimized;
        }

        private void MaximizedWindow()
        {
            this.window.WindowState = WindowState.Maximized;
        }

        private void CloseWindow()
        {
            this.window.Close();
        }

        #endregion
    }
}
