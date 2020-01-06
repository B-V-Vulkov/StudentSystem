namespace StudentSystem
{
    using System;
    using System.Windows;
    using Prism.Commands;

    using Common;

    public class MainWindowViewModel
    {
        #region Declarations

        private Window window;

        private DelegateCommand<string> changeWindowStateCommand;

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

        public DelegateCommand<string> ChangeWindowStateCommand
        {
            get
            {
                if (this.changeWindowStateCommand == null)
                {
                    this.changeWindowStateCommand = new DelegateCommand<string>(ChangeWindowState);
                }

                return this.changeWindowStateCommand;
            }
        }

        #endregion

        #region Methods

        private void ChangeWindowState(string command)
        {
            if (command == WindowCommand.Minimize.ToString())
            {
                this.window.WindowState = WindowState.Minimized;
            }
            else if (command == WindowCommand.Maximize.ToString())
            {
                if (this.window.WindowState == WindowState.Maximized)
                {
                    this.window.WindowState = WindowState.Normal;
                }
                else
                {
                    this.window.WindowState = WindowState.Maximized;
                }
            }
            else if (command == WindowCommand.Close.ToString())
            {
                this.window.Close();
            }
            else
            {
                throw new InvalidOperationException(ExceptionMessage.INVALID_WINDOW_COMMAND_EXCEPTION);
            }
        }

        #endregion
    }
}
